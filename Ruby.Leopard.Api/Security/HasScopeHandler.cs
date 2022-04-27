using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ruby.Leopard.Api.Sequirty
{
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirements>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            HasScopeRequirements requirement)
        {

            if (!context.User.HasClaim(c => c.Type == "scope" && c.Issuer == requirements.Issuer))
                return Task.CompletedTask;

            var scopes = context.User
                .FindFirst(c => c.Type == "scope" && c.Issuer == requirements.Issuer)    
                .Value.Split(' ');

            if (scopes.Any(s => s == requirement.Scope))
                context.Succeed(requirement);

            return Task.CompletedTask;        
        }
    }
}