using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryWebsite2.Domain;

namespace TravelItineraryWebsite2.Configurations.Entities
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = 1,
                    Address = "Victoria Harbour",
                    PlaceId = "ChIJR3bnzBMBBDQRrodrPnMlcVg",
                    Lat = 22.307446,
                    Lng = 114.16771,
                    LocationType = LocationType.Address,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 2,
                    Address = "Mitsushima Shin-uchi",
                    PlaceId = "ChIJTexD3aHhAGARNrzMqjfQG6Y",
                    Lat = 34.733974,
                    Lng = 135.582807,
                    LocationType = LocationType.Address,
                    ItineraryId = 2
                },
                new Location
                {
                    Id = 3,
                    Address = "Shirakawa-go",
                    PlaceId = "ChIJ5yW_trBx-F8R-AVYnbtRxcwY",
                    Lat = 36.257797,
                    Lng = 136.906198,
                    LocationType = LocationType.City,
                    ItineraryId = 3
                },
                new Location
                {
                    Id = 4,
                    Address = "Lau Sum Kee",
                    PlaceId = "ChIJvxd8mOcBBDQRSoZgKiql49A",
                    Lat = 22.331783,
                    Lng = 114.163192,
                    LocationType = LocationType.Address,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 5,
                    Address = "Ying Kee",
                    PlaceId = "ChIJJzqTNYf_AzQRwKZRoDRERbw",
                    Lat = 22.285089,
                    Lng = 114.142386,
                    LocationType = LocationType.Address,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 6,
                    Address = "Shinhotaka Ropeway",
                    PlaceId = "ChIJLUAe875PHWARkR1e5ffwR9k",
                    Lat = 36.285792,
                    Lng = 137.575262,
                    LocationType = LocationType.Address,
                    ItineraryId = 3
                },
                new Location
                {
                    Id = 7,
                    Address = "Unotake Kasu Udon",
                    PlaceId = "ChIJhfXfdxHnAGARxQbdzydTMTc",
                    Lat = 34.670552,
                    Lng = 135.499302,
                    LocationType = LocationType.Address,
                    ItineraryId = 2
                },
                new Location
                {
                    Id = 8,
                    Address = "BEST WESTERN PLUS Hotel Hong Kong",
                    PlaceId = "ChIJewz8QYH_AzQRzRa9Gq-0NsE",
                    Lat = 22.28728,
                    Lng = 114.139121,
                    LocationType = LocationType.Address,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 9,
                    Address = "Centrage Ark Ueshio",
                    PlaceId = "ChIJCdMda1DnAGARSFh3OgTKhFk",
                    Lat = 34.663462,
                    Lng = 135.51679,
                    LocationType = LocationType.Address,
                    ItineraryId = 2
                },
                new Location
                {
                    Id = 10,
                    Address = "Onyado Yuinosho",
                    PlaceId = "ChIJvXvOjU9x-F8RAWDVsroNuBg",
                    Lat = 36.277239,
                    Lng = 136.902331,
                    LocationType = LocationType.Address,
                    ItineraryId = 3
                },
                new Location
                {
                    Id = 11,
                    Address = "Hong Kong International Airport",
                    PlaceId = "ChIJncZGzPPiAzQRnjaSGIKQ9fk",
                    Lat = 22.313474,
                    Lng = 113.913728,
                    LocationType = LocationType.Address,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 12,
                    Address = "Osaka Station",
                    PlaceId = "ChIJC6fjlY3mAGARSshZ6CLIrhs",
                    Lat = 34.702485,
                    Lng = 135.495951,
                    LocationType = LocationType.Address,
                    ItineraryId = 2
                },
                new Location
                {
                    Id = 13,
                    Address = "Hong Kong",
                    PlaceId = "ChIJD5gyo-3iAzQRfMnq27qzivA",
                    Lat = 22.319304,
                    Lng = 114.169361,
                    LocationType = LocationType.City,
                    ItineraryId = 1
                },
                new Location
                {
                    Id = 14,
                    Address = "Osaka",
                    PlaceId = "ChIJ4eIGNFXmAGAR5y9q5G7BW8U",
                    Lat = 34.693725,
                    Lng = 135.502254,
                    LocationType = LocationType.City,
                    ItineraryId = 2
                }
            );
        }
    }
}
