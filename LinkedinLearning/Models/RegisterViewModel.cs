using System.ComponentModel.DataAnnotations;

namespace LinkedinLearning.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Adresse email")]
        public string Email { get; set; }
        [Display(Name = "Nom de famille")]
        public string FirstName { get; set; }
        [Display(Name = "Prénom")]
        public string LastName { get; set; }
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
