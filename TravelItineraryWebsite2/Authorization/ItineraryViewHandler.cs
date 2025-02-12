using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Authorization
{
    public class ItineraryViewHandler : AuthorizationHandler<ItineraryViewRequirement, Itinerary>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            ItineraryViewRequirement requirement,
            Itinerary itinerary)
        {
            // Get the current user's ID from the claims (assumes ClaimTypes.NameIdentifier is used)
            var userId = context.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                // If no user id found, do nothing.
                return Task.CompletedTask;
            }

            // Check if the user is the creator.
            if (itinerary.CreatedBy == userId)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            // Check if the user is among the users added to the itinerary.
            if (itinerary.Users.Any(u => u.Id == userId))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
