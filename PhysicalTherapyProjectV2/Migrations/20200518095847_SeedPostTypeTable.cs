using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class SeedPostTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, null, new DateTime(2020, 5, 18, 12, 58, 47, 191, DateTimeKind.Local).AddTicks(5218), "Article", null, new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 2, null, new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(7844), "Advertisment", null, new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(7887) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
