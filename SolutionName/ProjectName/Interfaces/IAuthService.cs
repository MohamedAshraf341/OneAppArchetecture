using ProjectName.Dto;

namespace ProjectName.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseAuthDto> RegisterAsync(RegisterDto model);
        Task<ResponseAuthDto> GetTokenAsync(LoginDto model);
        Task<string> AddRoleAsync(AddRoleDto model);
        Task<ResponseAuthDto> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
    }
}
