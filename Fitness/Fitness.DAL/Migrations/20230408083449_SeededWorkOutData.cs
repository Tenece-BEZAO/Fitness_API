using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeededWorkOutData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FitFamers_WorkOuts_WorkOutUniqueIdentifier",
                table: "FitFamers");

            migrationBuilder.DropIndex(
                name: "IX_FitFamers_WorkOutUniqueIdentifier",
                table: "FitFamers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f86c266-58c0-48e7-a38c-6edf39183523");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa2eff25-9f44-4892-99ea-ef05bdac4290");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d539a8dd-2132-4a0d-a4ac-4237d4afe929");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "WorkOutUniqueIdentifier",
                table: "FitFamers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WorkOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkOutId",
                table: "FitFamers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6735d6aa-bda6-4500-b597-d83214fa23d6", "09b6f55a-b5eb-47fb-b3e0-01cf7fc2ac53", "Admin", "ADMIN" },
                    { "b4a3a67d-bc0d-486d-8a15-55e4e2593a16", "054993fa-e2f0-4622-ac62-4f92ed77fed6", "SuperAdmin", "SUPERADMIN" },
                    { "f85fd6b0-2bfc-4874-a474-9292331ac33f", "18722b3f-ca72-48b1-8be9-9e19c3c65203", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.InsertData(
                table: "WorkOuts",
                columns: new[] { "UniqueIdentifier", "CreatedAt", "Id", "LiveWeight", "Name", "UpdatedAt" },
                values: new object[] { new Guid("555a4943-81f5-4d79-86e5-f81111f839c5"), new DateTime(2023, 4, 8, 9, 34, 49, 265, DateTimeKind.Local).AddTicks(7880), 1, 0m, "Aerobics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FitFamers_WorkOuts_WorkOutId",
                table: "FitFamers");

            migrationBuilder.DropIndex(
                name: "IX_FitFamers_WorkOutId",
                table: "FitFamers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6735d6aa-bda6-4500-b597-d83214fa23d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4a3a67d-bc0d-486d-8a15-55e4e2593a16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85fd6b0-2bfc-4874-a474-9292331ac33f");

            migrationBuilder.DeleteData(
                table: "WorkOuts",
                keyColumn: "UniqueIdentifier",
                keyValue: new Guid("555a4943-81f5-4d79-86e5-f81111f839c5"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WorkOuts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WorkOuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "WorkOutId",
                table: "FitFamers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkOutUniqueIdentifier",
                table: "FitFamers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f86c266-58c0-48e7-a38c-6edf39183523", "fe310517-ef6c-441c-b11e-38140657fb0b", "Admin", "ADMIN" },
                    { "aa2eff25-9f44-4892-99ea-ef05bdac4290", "98094185-0414-48d0-af85-d1bd9a8788d0", "SuperAdmin", "SUPERADMIN" },
                    { "d539a8dd-2132-4a0d-a4ac-4237d4afe929", "c188e339-e332-4144-a9d1-e541bb672eec", "FitFamer", "FITFAMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FitFamers_WorkOutUniqueIdentifier",
                table: "FitFamers",
                column: "WorkOutUniqueIdentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_FitFamers_WorkOuts_WorkOutUniqueIdentifier",
                table: "FitFamers",
                column: "WorkOutUniqueIdentifier",
                principalTable: "WorkOuts",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
