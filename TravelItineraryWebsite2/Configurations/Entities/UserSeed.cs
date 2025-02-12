using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite2.Data;

namespace TravelItineraryWebsite2.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                    Email = "titus@localhost.com",
                    NormalizedEmail = "TITUS@LOCALHOST.COM",
                    FirstName = "Titus",
                    LastName = "Cheng",
                    UserName = "titus@localhost.com",
                    NormalizedUserName = "TITUS@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123#"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                },
                new ApplicationUser
                {
                    Id = "66872a47-cc8b-483a-bffd-4fe19ae17124",
                    Email = "tim@localhost.com",
                    NormalizedEmail = "TIM@LOCALHOST.COM",
                    FirstName = "Tim",
                    LastName = "Cheng",
                    UserName = "tim@localhost.com",
                    NormalizedUserName = "TIM@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123#"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                }
            );
        }
    }
}
