using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelItineraryWebsite2.Domain
{
    public enum DetailCategory
    {
        None = 0,
        Activity = 1,
        Accommodation = 2,
        Location = 3,
        Transport = 4
    }

    //[Owned]
    public class ItineraryDetail : BaseDomainModel
    {
        public string? Name { get; set; }

        [Required]
        [ForeignKey(nameof(Itinerary))]
        public int ItineraryId { get; set; }

        public Itinerary Itinerary { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime? EndDate {  get; set; } = DateTime.Now;
        public decimal? Cost { get; set; }
        public TimeSpan? Duration { get; set; } = TimeSpan.Zero;
        [NotMapped]
        public int? DurationHours
        {
            get => Duration?.Hours;
            set
            {
                if (value.HasValue)
                {
                    Duration = new TimeSpan(value.Value, Duration?.Minutes ?? 0, 0);
                }
            }
        }

        [NotMapped]
        public int? DurationMinutes
        {
            get => Duration?.Minutes;
            set
            {
                if (value.HasValue)
                {
                    Duration = new TimeSpan(Duration?.Hours ?? 0, value.Value, 0);
                }
            }
        }
        public TimeOnly? ArrivalTime { get; set; }
        [NotMapped]
        public DateTime? ComputedArrivalTime
        {
            get
            {
                // If a duration is provided, calculate arrival time; otherwise, return null.
                return Duration.HasValue && Duration.Value > TimeSpan.Zero
                       ? Date.Add(Duration.Value)
                       : (DateTime?)null;
            }
        }
        public DetailCategory Category { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Activity { get; set; }

        [ForeignKey(nameof(Location))]
        public int? LocationId { get; set; }
        public Location? Location { get; set; }

        // For transport details
        [ForeignKey(nameof(DepartureLocation))]
        public int? DepartureLocationId { get; set; }
        public Location? DepartureLocation { get; set; }

        [ForeignKey(nameof(ArrivalLocation))]
        public int? ArrivalLocationId { get; set; }
        public Location? ArrivalLocation { get; set; }
    }
}
