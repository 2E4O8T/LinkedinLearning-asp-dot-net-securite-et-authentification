using Microsoft.AspNetCore.Identity;

namespace LinkedinLearning.Models
{
    public class Role : IdentityRole<int>
    {
        public static string[] Roles = new string[] { "Admin", "Visiteur", "Salarie", "Directeur" };
    }
}
