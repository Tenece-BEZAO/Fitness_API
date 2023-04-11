using System;
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
            migrationBuilder.DropForeignKey(
                name: "FK_FitFamers_WorkOuts_WorkOutId",
                table: "FitFamers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_FitFamerUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_FitFamers_WorkOutId",
                table: "FitFamers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ee05a30-0a1b-4c6a-8439-4f4638ddfa86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95e6e27-07ea-4b29-80e3-e7e832557815");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0aaef0a-4e03-497d-8fc1-a7701106c361");

            migrationBuilder.DeleteData(
                table: "WorkOuts",
                keyColumn: "UniqueIdentifier",
                keyValue: new Guid("7039a48e-e803-4be3-9cfd-a061384a9a78"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "FitFamerUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.DropColumn(
                name: "WorkOutId",
                table: "FitFamers");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WorkOuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "WorkOuts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "FitFamerId",
                table: "UserAchievements",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "823b1e7f-72bf-45ff-9b2b-02839fa50e77", "1c781c1d-4dd5-46ad-9c82-155526ce410e", "Admin", "ADMIN" },
                    { "956ed2ed-27d1-4ce4-8456-076b91b9152a", "59d5c20c-fe1d-4474-b8a3-45553c5ed1d3", "FitFamer", "FITFAMER" },
                    { "ecaf48ee-9527-4dd4-9b93-cc2ca17757f6", "8b0b6d22-682e-499c-8c79-d8f45ee8e5a4", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOuts_UserId1",
                table: "WorkOuts",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_FitFamerId",
                table: "UserAchievements",
                column: "FitFamerId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOuts_AspNetUsers_UserId1",
                table: "WorkOuts",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOuts_AspNetUsers_UserId1",
                table: "WorkOuts");

            migrationBuilder.DropIndex(
                name: "IX_WorkOuts_UserId1",
                table: "WorkOuts");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_FitFamerId",
                table: "UserAchievements");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "823b1e7f-72bf-45ff-9b2b-02839fa50e77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "956ed2ed-27d1-4ce4-8456-076b91b9152a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecaf48ee-9527-4dd4-9b93-cc2ca17757f6");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "WorkOuts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WorkOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FitFamerId",
                table: "UserAchievements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "FitFamerUniqueIdentifier",
                table: "UserAchievements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkOutId",
                table: "FitFamers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ee05a30-0a1b-4c6a-8439-4f4638ddfa86", "04a1346a-0138-4d62-9eab-ded7cebae2e0", "SuperAdmin", "SUPERADMIN" },
                    { "d95e6e27-07ea-4b29-80e3-e7e832557815", "4ae5e39c-a872-4380-81f6-abc21b2f3c31", "Admin", "ADMIN" },
                    { "e0aaef0a-4e03-497d-8fc1-a7701106c361", "0bb8a17b-1007-4033-b7c8-c788e32fda47", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.InsertData(
                table: "WorkOuts",
                columns: new[] { "UniqueIdentifier", "CreatedAt", "Id", "LiveWeight", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7039a48e-e803-4be3-9cfd-a061384a9a78"), new DateTime(2023, 4, 11, 3, 30, 46, 706, DateTimeKind.Local).AddTicks(9037), 1, 0m, "Aerobics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_FitFamerUniqueIdentifier",
                table: "UserAchievements",
                column: "FitFamerUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_FitFamers_WorkOutId",
                table: "FitFamers",
                column: "WorkOutId");

            migrationBuilder.AddForeignKey(
                name: "FK_FitFamers_WorkOuts_WorkOutId",
                table: "FitFamers",
                column: "WorkOutId",
                principalTable: "WorkOuts",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerUniqueIdentifier",
                table: "UserAchievements",
                column: "FitFamerUniqueIdentifier",
                principalTable: "FitFamers",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
