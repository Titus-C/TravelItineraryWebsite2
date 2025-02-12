using TravelItineraryWebsite2.Data;

namespace TravelItineraryWebsite2.Domain
{
    public class ApplicationUserItinerary
    {
        //public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
    }

}
