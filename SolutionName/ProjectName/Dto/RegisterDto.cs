using System.ComponentModel.DataAnnotations;

namespace ProjectName.Dto
{
    public class RegisterDto
    {
        public string Name { get; set; }


        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }
        [Required, StringLength(256)]
        public string Password { get; set; }
    }

}
