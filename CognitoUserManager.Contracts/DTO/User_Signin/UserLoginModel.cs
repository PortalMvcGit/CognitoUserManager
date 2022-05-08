using System.ComponentModel.DataAnnotations;

namespace CognitoUserManager.Contracts.DTO
{
    public class UserLoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}