using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Configurations.Entities
{
    public class ApplicationUserItinerarySeed : IEntityTypeConfiguration<ApplicationUserItinerary>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserItinerary> builder)
        {
            builder.HasData(
                new ApplicationUserItinerary
                {
                    ApplicationUserId = "92fc0620-db8e-4623-bc6d-27dcded5f56f", // Titus
                    ItineraryId = 1
                },
                new ApplicationUserItinerary
                {
                    ApplicationUserId = "66872a47-cc8b-483a-bffd-4fe19ae17124", // Tim
                    ItineraryId = 1
                },
                new ApplicationUserItinerary
                {
                    ApplicationUserId = "66872a47-cc8b-483a-bffd-4fe19ae17124", // Tim
                    ItineraryId = 2
                },
                new ApplicationUserItinerary
                {
                    ApplicationUserId = "66872a47-cc8b-483a-bffd-4fe19ae17124", // Tim
                    ItineraryId = 3
                }
            );
        }
    }

}
