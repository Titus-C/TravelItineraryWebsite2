using Microsoft.AspNetCore.Identity;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Itinerary> Itineraries { get; } = new List<Itinerary>();
    }
}

