using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
        [Display(Name = "Votre rôle")]
        public int Age { get; set; }
        public string RoleSelected { get; set; }
        public List<SelectListItem> Roles { get; }
            = Role.Roles
                .Select ( role => new SelectListItem { Value = role, Text = role })
            .ToList ();
    }
}
