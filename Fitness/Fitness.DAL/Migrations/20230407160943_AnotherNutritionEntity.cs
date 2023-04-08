using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AnotherNutritionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f29b2dc-50ee-4e89-bea8-87d288f33a5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c863ac44-3be5-4ca4-9d10-7828aa6ca2d4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MealPlanLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a60eaed-2af3-4177-9095-93fbbb9f002d", "4065f4db-d942-47df-87d4-fede6cf0a2d8", "Administrator", "ADMINISTRATOR" },
                    { "f8ed87b5-bb3e-4144-95f4-bc3b961703b2", "dcc951e8-e534-48d0-a9ce-d4615cdafd5d", "FitFamer", "FITFAMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a60eaed-2af3-4177-9095-93fbbb9f002d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8ed87b5-bb3e-4144-95f4-bc3b961703b2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MealPlanLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f29b2dc-50ee-4e89-bea8-87d288f33a5f", "e709c4c2-f92a-408a-8bdf-b909cbbb651a", "Administrator", "ADMINISTRATOR" },
                    { "c863ac44-3be5-4ca4-9d10-7828aa6ca2d4", "7baf0967-e855-4439-9e24-5ecc317903d0", "FitFamer", "FITFAMER" }
                });
        }
    }
}
