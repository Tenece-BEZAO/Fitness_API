using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOutExercises_Exercises_ExerciseUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOutExercises_WorkOuts_WorkOutUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropTable(
                name: "AchievementFitFamer");

            migrationBuilder.DropTable(
                name: "ExerciseFitFamer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkOutExercises",
                table: "WorkOutExercises");

            migrationBuilder.DropIndex(
                name: "IX_WorkOutExercises_ExerciseUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropIndex(
                name: "IX_WorkOutExercises_WorkOutUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_AchievementUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_FitFamerId",
                table: "UserAchievements");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23ce25d7-f4c7-49fe-946c-63a4d25e71ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d898b7e-b9ac-4637-a4c8-9122b04ec740");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aff4c66f-76f7-4ab1-b754-a3f17645937d");

            migrationBuilder.DropColumn(
                name: "ExerciseUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropColumn(
                name: "WorkOutUniqueIdentifier",
                table: "WorkOutExercises");

            migrationBuilder.DropColumn(
                name: "AchievementUniqueIdentifier",
                table: "UserAchievements");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkOutId",
                table: "WorkOutExercises",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ExerciseId",
                table: "WorkOutExercises",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AchievementId",
                table: "UserAchievements",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkOutExercises",
                table: "WorkOutExercises",
                columns: new[] { "WorkOutId", "ExerciseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements",
                columns: new[] { "FitFamerId", "AchievementId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7bcf251b-3be4-49bb-bdf0-e0047f577716", "d8575301-98f7-480e-8a52-2fc0acdb3d58", "FitFamer", "FITFAMER" },
                    { "826178df-b2c2-432b-8419-95f296e27562", "1126f468-0094-45e0-af25-c6f3f61e6f68", "Admin", "ADMIN" },
                    { "aee5aabd-ff8c-43a8-b602-e01d8a173192", "9798dba4-069f-42fc-9b17-237927729401", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercises_ExerciseId",
                table: "WorkOutExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId",
                principalTable: "Achievements",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOutExercises_Exercises_ExerciseId",
                table: "WorkOutExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOutExercises_WorkOuts_WorkOutId",
                table: "WorkOutExercises",
                column: "WorkOutId",
                principalTable: "WorkOuts",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOutExercises_Exercises_ExerciseId",
                table: "WorkOutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOutExercises_WorkOuts_WorkOutId",
                table: "WorkOutExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkOutExercises",
                table: "WorkOutExercises");

            migrationBuilder.DropIndex(
                name: "IX_WorkOutExercises_ExerciseId",
                table: "WorkOutExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bcf251b-3be4-49bb-bdf0-e0047f577716");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826178df-b2c2-432b-8419-95f296e27562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aee5aabd-ff8c-43a8-b602-e01d8a173192");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseId",
                table: "WorkOutExercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "WorkOutId",
                table: "WorkOutExercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseUniqueIdentifier",
                table: "WorkOutExercises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkOutUniqueIdentifier",
                table: "WorkOutExercises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "AchievementId",
                table: "UserAchievements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "AchievementUniqueIdentifier",
                table: "UserAchievements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkOutExercises",
                table: "WorkOutExercises",
                column: "UniqueIdentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements",
                column: "UniqueIdentifier");

            migrationBuilder.CreateTable(
                name: "AchievementFitFamer",
                columns: table => new
                {
                    AchievementsUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FitFamersUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementFitFamer", x => new { x.AchievementsUniqueIdentifier, x.FitFamersUniqueIdentifier });
                    table.ForeignKey(
                        name: "FK_AchievementFitFamer_Achievements_AchievementsUniqueIdentifier",
                        column: x => x.AchievementsUniqueIdentifier,
                        principalTable: "Achievements",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AchievementFitFamer_FitFamers_FitFamersUniqueIdentifier",
                        column: x => x.FitFamersUniqueIdentifier,
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseFitFamer",
                columns: table => new
                {
                    ExercisesUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FitFamersUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseFitFamer", x => new { x.ExercisesUniqueIdentifier, x.FitFamersUniqueIdentifier });
                    table.ForeignKey(
                        name: "FK_ExerciseFitFamer_Exercises_ExercisesUniqueIdentifier",
                        column: x => x.ExercisesUniqueIdentifier,
                        principalTable: "Exercises",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseFitFamer_FitFamers_FitFamersUniqueIdentifier",
                        column: x => x.FitFamersUniqueIdentifier,
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23ce25d7-f4c7-49fe-946c-63a4d25e71ec", "8c3a00f4-25e2-4c3b-84ee-abd68c6c7fe7", "Admin", "ADMIN" },
                    { "8d898b7e-b9ac-4637-a4c8-9122b04ec740", "3ca10ef7-2211-46ba-8c1a-c5acb8b0bb99", "FitFamer", "FITFAMER" },
                    { "aff4c66f-76f7-4ab1-b754-a3f17645937d", "1f2204db-7391-4959-9b19-67a9bd9eb347", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercises_ExerciseUniqueIdentifier",
                table: "WorkOutExercises",
                column: "ExerciseUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercises_WorkOutUniqueIdentifier",
                table: "WorkOutExercises",
                column: "WorkOutUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementUniqueIdentifier",
                table: "UserAchievements",
                column: "AchievementUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_FitFamerId",
                table: "UserAchievements",
                column: "FitFamerId");

            migrationBuilder.CreateIndex(
                name: "IX_AchievementFitFamer_FitFamersUniqueIdentifier",
                table: "AchievementFitFamer",
                column: "FitFamersUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseFitFamer_FitFamersUniqueIdentifier",
                table: "ExerciseFitFamer",
                column: "FitFamersUniqueIdentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementUniqueIdentifier",
                table: "UserAchievements",
                column: "AchievementUniqueIdentifier",
                principalTable: "Achievements",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_FitFamers_FitFamerId",
                table: "UserAchievements",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOutExercises_Exercises_ExerciseUniqueIdentifier",
                table: "WorkOutExercises",
                column: "ExerciseUniqueIdentifier",
                principalTable: "Exercises",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOutExercises_WorkOuts_WorkOutUniqueIdentifier",
                table: "WorkOutExercises",
                column: "WorkOutUniqueIdentifier",
                principalTable: "WorkOuts",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
