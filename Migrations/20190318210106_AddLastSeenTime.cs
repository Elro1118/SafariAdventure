using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafariAdventure.Migrations
{
    public partial class AddLastSeenTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastSeenTime",
                table: "SeenAnimals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSeenTime",
                table: "SeenAnimals");
        }
    }
}
