using LinkedinLearning.Requirements;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedinLearning.Handlers
{
    public class MinAgeHandler : AuthorizationHandler<MinAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinAgeRequirement requirement)
        {
            if (!context.User.HasClaim(claim => claim.Type == "Age"))
            {  
                return Task.CompletedTask; 
            }

            var age = int.Parse(context.User.Claims.First(claim => claim.Type == "Age").Value);

            if (age >= requirement.MinimumAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
