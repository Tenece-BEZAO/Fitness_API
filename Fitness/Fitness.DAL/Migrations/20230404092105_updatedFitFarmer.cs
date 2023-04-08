using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedFitFarmer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_FitFamers_FitFamerId",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffsWCalories_FitFamerId",
                table: "FoodStuffsWCalories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a37a6f-c74b-44f8-a94e-2e4f1191413c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a1264e-8ff9-4964-86e0-f9a4185d87cd");

            migrationBuilder.DropColumn(
                name: "FitFamerId",
                table: "FoodStuffsWCalories");

            migrationBuilder.AddColumn<Guid>(
                name: "FitFamerId",
                table: "MealPlanLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a26cee64-db2e-4695-9346-3e2618181207", "d9d0040b-d40e-43dd-a71d-d4472502748e", "Administrator", "ADMINISTRATOR" },
                    { "a81f460f-aaeb-4902-abd6-d295ab751277", "1e01695f-2f22-43aa-9078-8e78339e4a79", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanLogs_FitFamerId",
                table: "MealPlanLogs",
                column: "FitFamerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs");

            migrationBuilder.DropIndex(
                name: "IX_MealPlanLogs_FitFamerId",
                table: "MealPlanLogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26cee64-db2e-4695-9346-3e2618181207");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a81f460f-aaeb-4902-abd6-d295ab751277");

            migrationBuilder.DropColumn(
                name: "FitFamerId",
                table: "MealPlanLogs");

            migrationBuilder.AddColumn<Guid>(
                name: "FitFamerId",
                table: "FoodStuffsWCalories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61a37a6f-c74b-44f8-a94e-2e4f1191413c", "408998b3-1470-470b-a3b6-5cb6963b6407", "Administrator", "ADMINISTRATOR" },
                    { "c8a1264e-8ff9-4964-86e0-f9a4185d87cd", "9fee5481-578d-4468-a958-54bda3ac8e49", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffsWCalories_FitFamerId",
                table: "FoodStuffsWCalories",
                column: "FitFamerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffsWCalories_FitFamers_FitFamerId",
                table: "FoodStuffsWCalories",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "Id");
        }
    }
}
