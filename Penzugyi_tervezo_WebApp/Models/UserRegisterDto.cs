using System.ComponentModel.DataAnnotations;

namespace Penzugyi_tervezo_WebApp.Models
{
    public class UserRegisterDto
    {
        [Required]
        public string username { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string password { get; set; } = string.Empty;
    }
}
