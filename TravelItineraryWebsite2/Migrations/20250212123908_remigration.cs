using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelItineraryWebsite2.Migrations
{
    /// <inheritdoc />
    public partial class remigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserItineraries",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserItineraries", x => new { x.ApplicationUserId, x.ItineraryId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserItineraries_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserItineraries_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserItinerary",
                columns: table => new
                {
                    ItinerariesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserItinerary", x => new { x.ItinerariesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserItinerary_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserItinerary_Itinerary_ItinerariesId",
                        column: x => x.ItinerariesId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<double>(type: "float", nullable: true),
                    Lng = table.Column<double>(type: "float", nullable: true),
                    LocationType = table.Column<int>(type: "int", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItineraryDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItineraryId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    ArrivalTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    DepartureLocationId = table.Column<int>(type: "int", nullable: true),
                    ArrivalLocationId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItineraryDetail_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItineraryDetail_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItineraryDetail_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItineraryDetail_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "66872a47-cc8b-483a-bffd-4fe19ae17124", 0, "467697b3-1f05-48b1-96cf-8f394eb1105e", "tim@localhost.com", true, "Tim", "Cheng", false, null, "TIM@LOCALHOST.COM", "TIM@LOCALHOST.COM", "AQAAAAIAAYagAAAAENXqQ4BeiRX9QaO/0d37ABlfqkwBs7KqF18TARqgMDblmiy8lSji0Edp2KSGQYAOqA==", null, false, "ef1cc8c5-f56a-4022-90dd-2041156f7248", false, "tim@localhost.com" },
                    { "92fc0620-db8e-4623-bc6d-27dcded5f56f", 0, "349e9614-1da2-4b78-b815-8de34d84ac17", "titus@localhost.com", true, "Titus", "Cheng", false, null, "TITUS@LOCALHOST.COM", "TITUS@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGOOI7TCtPr7Gp95PI/5+e+i95S8iR5pMUv1bNcRrquGEwHlcoyJV2W/1dtvupUNkQ==", null, false, "2c032b6d-c374-4ae2-960b-00c960804891", false, "titus@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Itinerary",
                columns: new[] { "Id", "CreatedBy", "CreatedByName", "DateCreated", "DateUpdated", "Description", "EndDate", "Name", "StartDate", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, "92fc0620-db8e-4623-bc6d-27dcded5f56f", "Titus", new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(503), null, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hong Kong and Shenzhen Trip", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "92fc0620-db8e-4623-bc6d-27dcded5f56f", "Titus" },
                    { 2, "66872a47-cc8b-483a-bffd-4fe19ae17124", "Tim", new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(508), null, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osaka Trip", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "66872a47-cc8b-483a-bffd-4fe19ae17124", "Tim" },
                    { 3, "92fc0620-db8e-4623-bc6d-27dcded5f56f", "Titus", new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(513), null, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan Winter Trip", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "92fc0620-db8e-4623-bc6d-27dcded5f56f", "Titus" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserItineraries",
                columns: new[] { "ApplicationUserId", "ItineraryId" },
                values: new object[,]
                {
                    { "66872a47-cc8b-483a-bffd-4fe19ae17124", 1 },
                    { "66872a47-cc8b-483a-bffd-4fe19ae17124", 2 },
                    { "66872a47-cc8b-483a-bffd-4fe19ae17124", 3 },
                    { "92fc0620-db8e-4623-bc6d-27dcded5f56f", 1 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedByName", "DateCreated", "DateUpdated", "ItineraryId", "Lat", "Lng", "LocationType", "Name", "PlaceId", "UpdatedBy", "UpdatedByName" },
                values: new object[,]
                {
                    { 1, "Victoria Harbour", null, null, null, null, 1, 22.307445999999999, 114.16771, 1, "", "ChIJR3bnzBMBBDQRrodrPnMlcVg", null, null },
                    { 2, "Mitsushima Shin-uchi", null, null, null, null, 2, 34.733974000000003, 135.582807, 1, "", "ChIJTexD3aHhAGARNrzMqjfQG6Y", null, null },
                    { 3, "Shirakawa-go", null, null, null, null, 3, 36.257796999999997, 136.90619799999999, 2, "", "ChIJ5yW_trBx-F8R-AVYnbtRxcwY", null, null },
                    { 4, "Lau Sum Kee", null, null, null, null, 1, 22.331783000000001, 114.163192, 1, "", "ChIJvxd8mOcBBDQRSoZgKiql49A", null, null },
                    { 5, "Ying Kee", null, null, null, null, 1, 22.285088999999999, 114.142386, 1, "", "ChIJJzqTNYf_AzQRwKZRoDRERbw", null, null },
                    { 6, "Shinhotaka Ropeway", null, null, null, null, 3, 36.285792000000001, 137.57526200000001, 1, "", "ChIJLUAe875PHWARkR1e5ffwR9k", null, null },
                    { 7, "Unotake Kasu Udon", null, null, null, null, 2, 34.670552000000001, 135.499302, 1, "", "ChIJhfXfdxHnAGARxQbdzydTMTc", null, null },
                    { 8, "BEST WESTERN PLUS Hotel Hong Kong", null, null, null, null, 1, 22.287279999999999, 114.139121, 1, "", "ChIJewz8QYH_AzQRzRa9Gq-0NsE", null, null },
                    { 9, "Centrage Ark Ueshio", null, null, null, null, 2, 34.663462000000003, 135.51678999999999, 1, "", "ChIJCdMda1DnAGARSFh3OgTKhFk", null, null },
                    { 10, "Onyado Yuinosho", null, null, null, null, 3, 36.277239000000002, 136.902331, 1, "", "ChIJvXvOjU9x-F8RAWDVsroNuBg", null, null },
                    { 11, "Hong Kong International Airport", null, null, null, null, 1, 22.313473999999999, 113.91372800000001, 1, "", "ChIJncZGzPPiAzQRnjaSGIKQ9fk", null, null },
                    { 12, "Osaka Station", null, null, null, null, 2, 34.702485000000003, 135.49595099999999, 1, "", "ChIJC6fjlY3mAGARSshZ6CLIrhs", null, null },
                    { 13, "Hong Kong", null, null, null, null, 1, 22.319303999999999, 114.16936099999999, 2, "", "ChIJD5gyo-3iAzQRfMnq27qzivA", null, null },
                    { 14, "Osaka", null, null, null, null, 2, 34.693725000000001, 135.50225399999999, 2, "", "ChIJ4eIGNFXmAGAR5y9q5G7BW8U", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserItineraries_ItineraryId",
                table: "ApplicationUserItineraries",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserItinerary_UsersId",
                table: "ApplicationUserItinerary",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDetail_ArrivalLocationId",
                table: "ItineraryDetail",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDetail_DepartureLocationId",
                table: "ItineraryDetail",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDetail_ItineraryId",
                table: "ItineraryDetail",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDetail_LocationId",
                table: "ItineraryDetail",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ItineraryId",
                table: "Location",
                column: "ItineraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserItineraries");

            migrationBuilder.DropTable(
                name: "ApplicationUserItinerary");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ItineraryDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Itinerary");
        }
    }
}
