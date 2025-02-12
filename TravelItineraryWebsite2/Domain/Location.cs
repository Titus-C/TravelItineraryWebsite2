using System.ComponentModel.DataAnnotations.Schema;

namespace TravelItineraryWebsite2.Domain
{
    public enum LocationType
    {
        None,
        Address,
        City,
        Region,
        Country
    }
    public class Location : BaseDomainModel
    {
        public string? Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? PlaceId { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public LocationType LocationType { get; set; }

        [ForeignKey(nameof(Itinerary))]
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
    }
}
