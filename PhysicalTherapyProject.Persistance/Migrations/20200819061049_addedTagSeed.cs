using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedTagSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "TagValue", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9363), "Mokymai", null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9375) },
                    { 2, null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9296), "Renginys", null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9328) },
                    { 4, null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9385), "Mokslas", null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(9394) },
                    { 1, null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(7968), "Naujienos", null, new DateTime(2020, 8, 19, 9, 10, 48, 504, DateTimeKind.Local).AddTicks(8004) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
