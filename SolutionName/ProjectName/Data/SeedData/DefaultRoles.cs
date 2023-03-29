using ProjectName.Const;
using Microsoft.AspNetCore.Identity;

namespace ProjectName.Data.SeedData
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManger)
        {
            if (!roleManger.Roles.Any())
            {
                await roleManger.CreateAsync(new IdentityRole(Roles.User.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }
        }
    }
}
