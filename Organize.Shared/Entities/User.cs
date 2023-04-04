
using System.ComponentModel.DataAnnotations;

namespace Organize.Shared.Entities
{
    public class User
    {
        [Required]
        [StringLength(15,ErrorMessage = "Username is too long!")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "The Password is required!")]
        public string Password { get; set; }
    }
} 