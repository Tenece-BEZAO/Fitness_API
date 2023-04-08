using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffs_FoodStuffId",
                table: "MealFoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e9babf3-df22-4502-8a62-1582acb7aa68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82b1e9c1-850e-43bf-a7a3-fe417cab861b");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "MealPlanLogs");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "FoodStuffs");

            migrationBuilder.DropColumn(
                name: "FoodClass",
                table: "FoodStuffs");

            migrationBuilder.RenameColumn(
                name: "FoodStuffId",
                table: "MealFoodStuffs",
                newName: "FoodStuffWCaloriesId");

            migrationBuilder.RenameIndex(
                name: "IX_MealFoodStuffs_FoodStuffId",
                table: "MealFoodStuffs",
                newName: "IX_MealFoodStuffs_FoodStuffWCaloriesId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodStuffs",
                newName: "FoodStuffName");

            migrationBuilder.AddColumn<Guid>(
                name: "FoodStuffId",
                table: "FoodStuffs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "FoodStuff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodClass = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStuff", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c4973f9-4903-4401-9588-1093319e6ad5", "8becd0e4-05cb-43be-97dc-0b4d72fa2190", "FitFamer", "FITFAMER" },
                    { "a6eb103d-a70f-465f-8f47-09f5c95fd0c4", "6d369b9d-9e6a-425f-85e4-4df821203393", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffs_FoodStuffId",
                table: "FoodStuffs",
                column: "FoodStuffId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffs_FoodStuff_FoodStuffId",
                table: "FoodStuffs",
                column: "FoodStuffId",
                principalTable: "FoodStuff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffs_FoodStuffWCaloriesId",
                table: "MealFoodStuffs",
                column: "FoodStuffWCaloriesId",
                principalTable: "FoodStuffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffs_FoodStuff_FoodStuffId",
                table: "FoodStuffs");

            migrationBuilder.DropForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffs_FoodStuffWCaloriesId",
                table: "MealFoodStuffs");

            migrationBuilder.DropTable(
                name: "FoodStuff");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffs_FoodStuffId",
                table: "FoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4973f9-4903-4401-9588-1093319e6ad5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6eb103d-a70f-465f-8f47-09f5c95fd0c4");

            migrationBuilder.DropColumn(
                name: "FoodStuffId",
                table: "FoodStuffs");

            migrationBuilder.RenameColumn(
                name: "FoodStuffWCaloriesId",
                table: "MealFoodStuffs",
                newName: "FoodStuffId");

            migrationBuilder.RenameIndex(
                name: "IX_MealFoodStuffs_FoodStuffWCaloriesId",
                table: "MealFoodStuffs",
                newName: "IX_MealFoodStuffs_FoodStuffId");

            migrationBuilder.RenameColumn(
                name: "FoodStuffName",
                table: "FoodStuffs",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "MealPlanLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "FoodStuffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodClass",
                table: "FoodStuffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e9babf3-df22-4502-8a62-1582acb7aa68", "36128c48-4ba3-47e4-a3a2-b3eeb24436a1", "FitFamer", "FITFAMER" },
                    { "82b1e9c1-850e-43bf-a7a3-fe417cab861b", "483d7146-c7a1-42e1-986f-52736777b1ef", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffs_FoodStuffId",
                table: "MealFoodStuffs",
                column: "FoodStuffId",
                principalTable: "FoodStuffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
