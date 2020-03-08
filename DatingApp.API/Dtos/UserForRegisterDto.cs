using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [EmailAddress]
         public string Username { get; set; }
         [Required]
         [StringLength(50,MinimumLength = 4,ErrorMessage="You must specify password betwen 4 to 50 character")]
         public string Password { get; set; }
    }
}