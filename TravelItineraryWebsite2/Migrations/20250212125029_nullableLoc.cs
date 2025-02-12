using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryWebsite2.Migrations
{
    /// <inheritdoc />
    public partial class nullableLoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66872a47-cc8b-483a-bffd-4fe19ae17124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c41b54e8-fe7b-4ac2-b358-175ab96fe557", "AQAAAAIAAYagAAAAEGVLNYgqYcJpuPtjKTVMLxxdO4GE8kvfp7cTVW6ZLaGjaNirns0kQ1oeNBux90vlhw==", "8ef04f1a-d54e-4514-a09a-6b3e759d0b6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a334a8d4-7d8e-4f71-93a8-82d305cf71a6", "AQAAAAIAAYagAAAAEGWpNBy1CJo63tFFg7o4t10iI2sMiEx62hEU86JTit2H5lUDlmHq0FjyiT3jUKylyA==", "b9a32f20-85ae-40bf-a616-9798f7c05adf" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4195), new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4207), new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4213), new DateTime(2025, 2, 12, 20, 50, 28, 59, DateTimeKind.Local).AddTicks(4214) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66872a47-cc8b-483a-bffd-4fe19ae17124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467697b3-1f05-48b1-96cf-8f394eb1105e", "AQAAAAIAAYagAAAAENXqQ4BeiRX9QaO/0d37ABlfqkwBs7KqF18TARqgMDblmiy8lSji0Edp2KSGQYAOqA==", "ef1cc8c5-f56a-4022-90dd-2041156f7248" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92fc0620-db8e-4623-bc6d-27dcded5f56f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "349e9614-1da2-4b78-b815-8de34d84ac17", "AQAAAAIAAYagAAAAEGOOI7TCtPr7Gp95PI/5+e+i95S8iR5pMUv1bNcRrquGEwHlcoyJV2W/1dtvupUNkQ==", "2c032b6d-c374-4ae2-960b-00c960804891" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 2, 12, 20, 39, 6, 738, DateTimeKind.Local).AddTicks(513) });
        }
    }
}
