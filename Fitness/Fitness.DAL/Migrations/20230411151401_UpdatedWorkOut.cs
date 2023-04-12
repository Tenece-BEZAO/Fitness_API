using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedWorkOut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOuts_AspNetUsers_UserId1",
                table: "WorkOuts");

            migrationBuilder.DropIndex(
                name: "IX_WorkOuts_UserId1",
                table: "WorkOuts");

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
                name: "UserId",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "WorkOuts");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "WorkOuts",
                newName: "WorkOutDate");

            migrationBuilder.AddColumn<Guid>(
                name: "FitFamerId",
                table: "WorkOuts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_WorkOuts_FitFamerId",
                table: "WorkOuts",
                column: "FitFamerId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOuts_FitFamers_FitFamerId",
                table: "WorkOuts",
                column: "FitFamerId",
                principalTable: "FitFamers",
                principalColumn: "UniqueIdentifier",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOuts_FitFamers_FitFamerId",
                table: "WorkOuts");

            migrationBuilder.DropIndex(
                name: "IX_WorkOuts_FitFamerId",
                table: "WorkOuts");

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
                name: "FitFamerId",
                table: "WorkOuts");

            migrationBuilder.RenameColumn(
                name: "WorkOutDate",
                table: "WorkOuts",
                newName: "Date");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOuts_AspNetUsers_UserId1",
                table: "WorkOuts",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
