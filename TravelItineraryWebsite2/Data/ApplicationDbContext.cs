using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TravelItineraryWebsite2.Configurations.Entities;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Composite primary key for the join table
            builder.Entity<ApplicationUserItinerary>()
                .HasKey(ai => new { ai.ApplicationUserId, ai.ItineraryId });

            builder.ApplyConfiguration(new LocationSeed());
            builder.ApplyConfiguration(new ItinerarySeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new ApplicationUserItinerarySeed());
        }

        public DbSet<TravelItineraryWebsite2.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TravelItineraryWebsite2.Domain.ItineraryDetail> ItineraryDetail { get; set; } = default!;
        public DbSet<TravelItineraryWebsite2.Domain.Location> Location { get; set; } = default!;
        public DbSet<TravelItineraryWebsite2.Domain.ApplicationUserItinerary> ApplicationUserItineraries { get; set; } = default!;

    }
}
