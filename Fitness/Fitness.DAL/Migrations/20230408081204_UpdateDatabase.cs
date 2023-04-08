using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7607dbda-2c9e-4256-a65e-5f7f26169407");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5add0da-72bb-4220-a8a2-d02ff04ef629");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c704771d-e8f3-4500-8c99-91e27dac2189");

            migrationBuilder.DropColumn(
                name: "FitFamerId",
                table: "WorkOuts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f86c266-58c0-48e7-a38c-6edf39183523", "fe310517-ef6c-441c-b11e-38140657fb0b", "Admin", "ADMIN" },
                    { "aa2eff25-9f44-4892-99ea-ef05bdac4290", "98094185-0414-48d0-af85-d1bd9a8788d0", "SuperAdmin", "SUPERADMIN" },
                    { "d539a8dd-2132-4a0d-a4ac-4237d4afe929", "c188e339-e332-4144-a9d1-e541bb672eec", "FitFamer", "FITFAMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f86c266-58c0-48e7-a38c-6edf39183523");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa2eff25-9f44-4892-99ea-ef05bdac4290");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d539a8dd-2132-4a0d-a4ac-4237d4afe929");

            migrationBuilder.AddColumn<string>(
                name: "FitFamerId",
                table: "WorkOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7607dbda-2c9e-4256-a65e-5f7f26169407", "e44bae40-4988-4d34-a652-a5ca25441a40", "Admin", "ADMIN" },
                    { "b5add0da-72bb-4220-a8a2-d02ff04ef629", "fe2fe752-4a1c-4c57-a24b-5d0a51d74aa9", "FitFamer", "FITFAMER" },
                    { "c704771d-e8f3-4500-8c99-91e27dac2189", "3f01fe12-f647-4785-b2fd-0393d6018dc7", "SuperAdmin", "SUPERADMIN" }
                });
        }
    }
}
