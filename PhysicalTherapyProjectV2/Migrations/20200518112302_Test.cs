using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 2, 187, DateTimeKind.Local).AddTicks(809), new DateTime(2020, 5, 18, 14, 23, 2, 191, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 2, 192, DateTimeKind.Local).AddTicks(1512), new DateTime(2020, 5, 18, 14, 23, 2, 192, DateTimeKind.Local).AddTicks(1546) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 12, 58, 47, 191, DateTimeKind.Local).AddTicks(5218), new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(7844), new DateTime(2020, 5, 18, 12, 58, 47, 195, DateTimeKind.Local).AddTicks(7887) });
        }
    }
}
