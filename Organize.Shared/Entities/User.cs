
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Organize.Shared.Enums;

namespace Organize.Shared.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(15,ErrorMessage = "Username is too long!")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "The Password is required!")]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public GenderTypeEnum Gender { get; set; }

        public ObservableCollection<BaseItem> UserItems { get; set; }

        public override string ToString()
        {
            var salutation = Gender == GenderTypeEnum.Male ? "Mr" : "Mrs";

            return $"{salutation}.{FirstName} {LastName}";
        }
    }
} 