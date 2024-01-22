using Microsoft.AspNetCore.Authorization;

namespace LinkedinLearning.Requirements
{
    public class MinAgeRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; private set; }
        public MinAgeRequirement (int minimumAge)
        {  
            MinimumAge = minimumAge; 
        }
    }
}
