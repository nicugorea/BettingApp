using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BettingAppWeb.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}