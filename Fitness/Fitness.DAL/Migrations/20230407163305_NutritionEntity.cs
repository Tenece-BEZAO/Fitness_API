using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NutritionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffName",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffName",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3645af8-6d01-4925-b0f6-972f9f062fc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e96cb6e5-bbdd-4769-a3ea-cb3e46f1ee8d");

            migrationBuilder.DropColumn(
                name: "FoodStuffName",
                table: "FoodStuffsWCalories");

            migrationBuilder.AddColumn<Guid>(
                name: "FoodStuffId",
                table: "FoodStuffsWCalories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodStuffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39bb11f0-de49-44ec-9447-97b3b819bf6a", "21252515-1390-4ad8-a763-bc6e17de8b91", "FitFamer", "FITFAMER" },
                    { "7c9fbccd-121f-443e-9d8c-cf9d721283a8", "93479ae9-d735-4e32-9594-81c21c05f393", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffId",
                table: "FoodStuffsWCalories",
                column: "FoodStuffId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                table: "FoodStuffsWCalories",
                column: "FoodStuffId",
                principalTable: "FoodStuffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropIndex(
                name: "IX_FoodStuffsWCalories_FoodStuffId",
                table: "FoodStuffsWCalories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39bb11f0-de49-44ec-9447-97b3b819bf6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9fbccd-121f-443e-9d8c-cf9d721283a8");

            migrationBuilder.DropColumn(
                name: "FoodStuffId",
                table: "FoodStuffsWCalories");

            migrationBuilder.AddColumn<string>(
                name: "FoodStuffName",
                table: "FoodStuffsWCalories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodStuffs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStuffs",
                table: "FoodStuffs",
                column: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3645af8-6d01-4925-b0f6-972f9f062fc2", "fcea8933-d5a5-4505-88a7-edc2098a200c", "FitFamer", "FITFAMER" },
                    { "e96cb6e5-bbdd-4769-a3ea-cb3e46f1ee8d", "ac38afc7-6376-42c2-8ab9-56c67b0e7b80", "Administrator", "ADMINISTRATOR" }
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
        }
    }
}
