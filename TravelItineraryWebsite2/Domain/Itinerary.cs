using TravelItineraryWebsite2.Data;

namespace TravelItineraryWebsite2.Domain
{
    public class Itinerary : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        public ICollection<ItineraryDetail> Details { get; } = new List<ItineraryDetail>();

        // Method to add a user to the itinerary
        public void AddUser(ApplicationUser user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
            }
        }
    }
}
