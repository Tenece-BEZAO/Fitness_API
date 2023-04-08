using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixedUpNutritionEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs");

            migrationBuilder.DropTable(
                name: "MealFoodStuffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26cee64-db2e-4695-9346-3e2618181207");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a81f460f-aaeb-4902-abd6-d295ab751277");

            migrationBuilder.RenameColumn(
                name: "FoodStuffId",
                table: "FoodStuffsWCalories",
                newName: "MealLogID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffId",
                table: "FoodStuffsWCalories",
                newName: "IX_FoodStuffsWCalories_MealLogID");

            migrationBuilder.AlterColumn<Guid>(
                name: "FitFamerId",
                table: "MealPlanLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodStuffName",
                table: "FoodStuffsWCalories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodStuffs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs",
                column: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f29b2dc-50ee-4e89-bea8-87d288f33a5f", "e709c4c2-f92a-408a-8bdf-b909cbbb651a", "Administrator", "ADMINISTRATOR" },
                    { "c863ac44-3be5-4ca4-9d10-7828aa6ca2d4", "7baf0967-e855-4439-9e24-5ecc317903d0", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffName",
                table: "FoodStuffsWCalories",
                column: "FoodStuffName");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffName",
                table: "FoodStuffsWCalories",
                column: "FoodStuffName",
                principalTable: "FoodStuffs",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffsWCalories_MealPlanLogs_MealLogID",
                table: "FoodStuffsWCalories",
                column: "MealLogID",
                principalTable: "MealPlanLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffName",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_MealPlanLogs_MealLogID",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffName",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f29b2dc-50ee-4e89-bea8-87d288f33a5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c863ac44-3be5-4ca4-9d10-7828aa6ca2d4");

            migrationBuilder.RenameColumn(
                name: "MealLogID",
                table: "FoodStuffsWCalories",
                newName: "FoodStuffId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodStuffsWCalories_MealLogID",
                table: "FoodStuffsWCalories",
                newName: "IX_FoodStuffsWCalories_FoodStuffId");

            migrationBuilder.AlterColumn<Guid>(
                name: "FitFamerId",
                table: "MealPlanLogs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "FoodStuffName",
                table: "FoodStuffsWCalories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodStuffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MealFoodStuffs",
                columns: table => new
                {
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodStuffWCaloriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoodStuffs", x => new { x.MealId, x.FoodStuffWCaloriesId });
                    table.ForeignKey(
                        name: "FK_MealFoodStuffs_FoodStuffsWCalories_FoodStuffWCaloriesId",
                        column: x => x.FoodStuffWCaloriesId,
                        principalTable: "FoodStuffsWCalories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealFoodStuffs_MealPlanLogs_MealLogId",
                        column: x => x.MealLogId,
                        principalTable: "MealPlanLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a26cee64-db2e-4695-9346-3e2618181207", "d9d0040b-d40e-43dd-a71d-d4472502748e", "Administrator", "ADMINISTRATOR" },
                    { "a81f460f-aaeb-4902-abd6-d295ab751277", "1e01695f-2f22-43aa-9078-8e78339e4a79", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealFoodStuffs_FoodStuffWCaloriesId",
                table: "MealFoodStuffs",
                column: "FoodStuffWCaloriesId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoodStuffs_MealLogId",
                table: "MealFoodStuffs",
                column: "MealLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                table: "FoodStuffsWCalories",
                column: "FoodStuffId",
                principalTable: "FoodStuffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                table: "MealPlanLogs",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "Id");
        }
    }
}
