using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.UniqueIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodStuffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodClass = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStuffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetWeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoals", x => x.Id);
========
                    table.PrimaryKey("PK_Exercises", x => x.UniqueIdentifier);
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                });

            migrationBuilder.CreateTable(
                name: "WorkOuts",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LiveWeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FitFamerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOuts", x => x.UniqueIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitFamers",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    CurrentWeight = table.Column<double>(type: "float", nullable: false),
                    ExerciseExperienceLevel = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkOutId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkOutUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitFamers", x => x.UniqueIdentifier);
                    table.ForeignKey(
                        name: "FK_FitFamers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FitFamers_WorkOuts_WorkOutUniqueIdentifier",
                        column: x => x.WorkOutUniqueIdentifier,
                        principalTable: "WorkOuts",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOutExercises",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IntensityLevel = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    WorkOutId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkOutUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOutExercises", x => x.UniqueIdentifier);
                    table.ForeignKey(
                        name: "FK_WorkOutExercises_Exercises_ExerciseUniqueIdentifier",
                        column: x => x.ExerciseUniqueIdentifier,
                        principalTable: "Exercises",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOutExercises_WorkOuts_WorkOutUniqueIdentifier",
                        column: x => x.WorkOutUniqueIdentifier,
                        principalTable: "WorkOuts",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "MealPlanLogs",
                columns: table => new
                {
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealTime = table.Column<int>(type: "int", nullable: false),
                    FitFamerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
========
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    MealTime = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FitFamerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FitFamerUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlanLogs", x => x.UniqueIdentifier);
                    table.ForeignKey(
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                        name: "FK_MealPlanLogs_FitFamers_FitFamerId",
                        column: x => x.FitFamerId,
========
                        name: "FK_MealPlanLogs_FitFamers_FitFamerUniqueIdentifier",
                        column: x => x.FitFamerUniqueIdentifier,
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FitFamerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FitFamerUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AchievementId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AchievementUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => x.UniqueIdentifier);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievements_AchievementUniqueIdentifier",
                        column: x => x.AchievementUniqueIdentifier,
                        principalTable: "Achievements",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_FitFamers_FitFamerUniqueIdentifier",
                        column: x => x.FitFamerUniqueIdentifier,
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGoals",
                columns: table => new
                {
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetWeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ExpectedDailyCalorieIntake = table.Column<int>(type: "int", nullable: false),
                    ExpectedDailyCalorieBurnt = table.Column<int>(type: "int", nullable: false),
                    FitFamerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FitFamerUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoals", x => x.UniqueIdentifier);
                    table.ForeignKey(
                        name: "FK_UserGoals_FitFamers_FitFamerUniqueIdentifier",
                        column: x => x.FitFamerUniqueIdentifier,
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodStuffsWCalories",
                columns: table => new
                {
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodStuffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmtConsumed = table.Column<int>(type: "int", nullable: false),
                    MealLogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondaryId = table.Column<int>(type: "int", nullable: false),
========
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmtConsumed = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    FoodClass = table.Column<int>(type: "int", nullable: false),
                    FitFamerUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MealLogUniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                    table.PrimaryKey("PK_FoodStuffsWCalories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodStuffsWCalories_FoodStuffs_FoodStuffId",
                        column: x => x.FoodStuffId,
                        principalTable: "FoodStuffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodStuffsWCalories_MealPlanLogs_MealLogID",
                        column: x => x.MealLogID,
                        principalTable: "MealPlanLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
========
                    table.PrimaryKey("PK_FoodStuffs", x => x.UniqueIdentifier);
                    table.ForeignKey(
                        name: "FK_FoodStuffs_FitFamers_FitFamerUniqueIdentifier",
                        column: x => x.FitFamerUniqueIdentifier,
                        principalTable: "FitFamers",
                        principalColumn: "UniqueIdentifier");
                    table.ForeignKey(
                        name: "FK_FoodStuffs_MealPlanLogs_MealLogUniqueIdentifier",
                        column: x => x.MealLogUniqueIdentifier,
                        principalTable: "MealPlanLogs",
                        principalColumn: "UniqueIdentifier");
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                    { "1879eead-b342-4369-8aba-46198aa4600e", "6fa45f2d-6df2-47e0-bd81-d7b0beb67ae7", "FitFamer", "FITFAMER" },
                    { "868ffeb4-cb0a-4acf-8562-55e9e89fefcf", "d12963da-5f7f-4383-ab69-dfbac3a3056f", "Administrator", "ADMINISTRATOR" }
========
                    { "7607dbda-2c9e-4256-a65e-5f7f26169407", "e44bae40-4988-4d34-a652-a5ca25441a40", "Admin", "ADMIN" },
                    { "b5add0da-72bb-4220-a8a2-d02ff04ef629", "fe2fe752-4a1c-4c57-a24b-5d0a51d74aa9", "FitFamer", "FITFAMER" },
                    { "c704771d-e8f3-4500-8c99-91e27dac2189", "3f01fe12-f647-4785-b2fd-0393d6018dc7", "SuperAdmin", "SUPERADMIN" }
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AchievementFitFamer_FitFamersUniqueIdentifier",
                table: "AchievementFitFamer",
                column: "FitFamersUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseFitFamer_FitFamersUniqueIdentifier",
                table: "ExerciseFitFamer",
                column: "FitFamersUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_FitFamers_UserId",
                table: "FitFamers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FitFamers_WorkOutUniqueIdentifier",
                table: "FitFamers",
                column: "WorkOutUniqueIdentifier");

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:Fitness/Fitness.DAL/Migrations/20230410013533_CreatedDatabase.cs
                name: "IX_FoodStuffsWCalories_FoodStuffId",
                table: "FoodStuffsWCalories",
                column: "FoodStuffId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffsWCalories_MealLogID",
                table: "FoodStuffsWCalories",
                column: "MealLogID");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanLogs_FitFamerId",
                table: "MealPlanLogs",
                column: "FitFamerId");
========
                name: "IX_FoodStuffs_FitFamerUniqueIdentifier",
                table: "FoodStuffs",
                column: "FitFamerUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuffs_MealLogUniqueIdentifier",
                table: "FoodStuffs",
                column: "MealLogUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanLogs_FitFamerUniqueIdentifier",
                table: "MealPlanLogs",
                column: "FitFamerUniqueIdentifier");
>>>>>>>> 70d92aa1d895e7da1b52cd7ca1a93b7a5f57cd4c:Fitness/Fitness.DAL/Migrations/20230407213042_CreateDatabase.cs

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementUniqueIdentifier",
                table: "UserAchievements",
                column: "AchievementUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_FitFamerUniqueIdentifier",
                table: "UserAchievements",
                column: "FitFamerUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoals_FitFamerUniqueIdentifier",
                table: "UserGoals",
                column: "FitFamerUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercises_ExerciseUniqueIdentifier",
                table: "WorkOutExercises",
                column: "ExerciseUniqueIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercises_WorkOutUniqueIdentifier",
                table: "WorkOutExercises",
                column: "WorkOutUniqueIdentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AchievementFitFamer");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExerciseFitFamer");

            migrationBuilder.DropTable(
                name: "FoodStuffsWCalories");

            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "UserGoals");

            migrationBuilder.DropTable(
                name: "WorkOutExercises");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FoodStuffs");

            migrationBuilder.DropTable(
                name: "MealPlanLogs");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "FitFamers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WorkOuts");
        }
    }
}
