using Microsoft.AspNetCore.Identity;

namespace BackEnd.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public byte[]? Picture { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public DateTime? LastActive { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
