using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AnotherNutritionEntityurg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a60eaed-2af3-4177-9095-93fbbb9f002d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8ed87b5-bb3e-4144-95f4-bc3b961703b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3645af8-6d01-4925-b0f6-972f9f062fc2", "fcea8933-d5a5-4505-88a7-edc2098a200c", "FitFamer", "FITFAMER" },
                    { "e96cb6e5-bbdd-4769-a3ea-cb3e46f1ee8d", "ac38afc7-6376-42c2-8ab9-56c67b0e7b80", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3645af8-6d01-4925-b0f6-972f9f062fc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e96cb6e5-bbdd-4769-a3ea-cb3e46f1ee8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a60eaed-2af3-4177-9095-93fbbb9f002d", "4065f4db-d942-47df-87d4-fede6cf0a2d8", "Administrator", "ADMINISTRATOR" },
                    { "f8ed87b5-bb3e-4144-95f4-bc3b961703b2", "dcc951e8-e534-48d0-a9ce-d4615cdafd5d", "FitFamer", "FITFAMER" }
                });
        }
    }
}
