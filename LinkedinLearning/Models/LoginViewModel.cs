using System.ComponentModel.DataAnnotations;

namespace LinkedinLearning.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required] 
        public string Password { get; set; }
    }
}
