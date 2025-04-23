using System.ComponentModel.DataAnnotations;

namespace Penzugyi_tervezo_WebApp.Models
{
    public class UserLoginDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
