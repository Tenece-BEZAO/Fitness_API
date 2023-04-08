using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffs_FitFamers_FitFamerId",
                table: "FoodStuffs");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffs_FoodStuff_FoodStuffId",
                table: "FoodStuffs");

            migrationBuilder.DropForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffs_FoodStuffWCaloriesId",
                table: "MealFoodStuffs");

            migrationBuilder.DropTable(
                name: "FoodStuff");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffs_FitFamerId",
                table: "FoodStuffs");

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
                name: "FitFamerId",
                table: "FoodStuffs");

            migrationBuilder.DropColumn(
                name: "FoodStuffId",
                table: "FoodStuffs");

            migrationBuilder.RenameColumn(
                name: "FoodStuffName",
                table: "FoodStuffs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AmtConsumed",
                table: "FoodStuffs",
                newName: "FoodClass");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "FoodStuffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodStuffsWCalories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodStuffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodStuffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmtConsumed = table.Column<int>(type: "int", nullable: false),
                    FitFamerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStuffsWCalories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodStuffsWCalories_FitFamers_FitFamerId",
                        column: x => x.FitFamerId,
                        principalTable: "FitFamers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                        column: x => x.FoodStuffId,
                        principalTable: "FoodStuffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffId",
                table: "FoodStuffsWCalories",
                column: "FoodStuffId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffsWCalories_FoodStuffWCaloriesId",
                table: "MealFoodStuffs",
                column: "FoodStuffWCaloriesId",
                principalTable: "FoodStuffsWCalories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealFoodStuffs_FoodStuffsWCalories_FoodStuffWCaloriesId",
                table: "MealFoodStuffs");

            migrationBuilder.DropTable(
                name: "FoodStuffsWCalories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a37a6f-c74b-44f8-a94e-2e4f1191413c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a1264e-8ff9-4964-86e0-f9a4185d87cd");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "FoodStuffs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodStuffs",
                newName: "FoodStuffName");

            migrationBuilder.RenameColumn(
                name: "FoodClass",
                table: "FoodStuffs",
                newName: "AmtConsumed");

            migrationBuilder.AddColumn<Guid>(
                name: "FitFamerId",
                table: "FoodStuffs",
                type: "uniqueidentifier",
                nullable: true);

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
                    Calories = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodClass = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_FoodStuffs_FitFamerId",
                table: "FoodStuffs",
                column: "FitFamerId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffs_FoodStuffId",
                table: "FoodStuffs",
                column: "FoodStuffId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffs_FitFamers_FitFamerId",
                table: "FoodStuffs",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "Id");

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
    }
}
