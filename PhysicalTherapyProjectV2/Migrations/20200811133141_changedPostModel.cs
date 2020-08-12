using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class changedPostModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoLink",
                table: "Posts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "VideoLink",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
