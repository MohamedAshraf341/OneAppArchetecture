using ProjectName.Data.Entities;
using ProjectName.Data;
using Microsoft.AspNetCore.Identity;
using Serilog;
using ProjectName.Data.SeedData;

namespace ProjectName
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                Log.Information("Application Starting");
                var context = services.GetRequiredService<ApplicationDbContext>();
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await DefaultRoles.SeedAsync(roleManager);
                await DefaultUsers.SeedUserAsync(userManager);
                await DefaultUsers.SeedAdminAsync(userManager);
                Log.Information("Data is already seed");

            }
            catch (Exception ex)
            {

                Log.Fatal(ex, ex.Message);
            }
            finally
            {
                Log.CloseAndFlush();
            }

            try
            {
                host.Run();
            }
            catch (Exception ex)
            {

                Log.Fatal(ex, "The application failed to start!");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

}
