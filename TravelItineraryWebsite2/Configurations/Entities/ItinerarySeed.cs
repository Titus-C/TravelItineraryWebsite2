using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite2.Data;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Configurations.Entities
{
    public class ItinerarySeed : IEntityTypeConfiguration<Itinerary>
    {
        public void Configure(EntityTypeBuilder<Itinerary> builder)
        {
            builder.HasData(
                new Itinerary
                {
                    Id = 1,
                    Name = "Hong Kong and Shenzhen Trip",
                    StartDate = new DateTime(2025, 3, 6), // Example start date
                    EndDate = new DateTime(2025, 3, 11), // Example end date
                    CreatedBy = "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                    CreatedByName = "Titus",
                    UpdatedBy = "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                    UpdatedByName = "Titus",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                    //Users = new List<ApplicationUser> // Adding users to the itinerary directly
                    //{
                    //    new ApplicationUser { Id = "92fc0620-db8e-4623-bc6d-27dcded5f56f" }, // Titus
                    //}
                },
                new Itinerary
                {
                    Id = 2,
                    Name = "Osaka Trip",
                    StartDate = new DateTime(2025, 6, 14), // Example start date
                    EndDate = new DateTime(2025, 6, 21), // Example end date
                    CreatedBy = "66872a47-cc8b-483a-bffd-4fe19ae17124",
                    CreatedByName = "Tim",
                    UpdatedBy = "66872a47-cc8b-483a-bffd-4fe19ae17124",
                    UpdatedByName = "Tim",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                    //Users = new List<ApplicationUser> // Adding users to the itinerary directly
                    //{
                    //    new ApplicationUser { Id = "92fc0620-db8e-4623-bc6d-27dcded5f56f" }, // Titus
                    //    new ApplicationUser { Id = "66872a47-cc8b-483a-bffd-4fe19ae17124" }  // Tim
                    //}
                },
                new Itinerary
                {
                    Id = 3,
                    Name = "Japan Winter Trip",
                    StartDate = new DateTime(2025, 12, 15), // Example start date
                    EndDate = new DateTime(2025, 12, 25), // Example end date
                    CreatedBy = "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                    CreatedByName = "Titus",
                    UpdatedBy = "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                    UpdatedByName = "Titus",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                    //Users = new List<ApplicationUser> // Adding users to the itinerary directly
                    //{
                    //    new ApplicationUser { Id = "66872a47-cc8b-483a-bffd-4fe19ae17124" }  // Tim
                    //}
                }
            );

        }
    }
}
