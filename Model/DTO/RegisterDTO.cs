using System.ComponentModel.DataAnnotations;

namespace Model.DTO
{
    public class RegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{5,}$", ErrorMessage = "Password must be simple")]
        public string Password { get; set; }
        public string DisplayName { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Bio { get; set; }
    }
}