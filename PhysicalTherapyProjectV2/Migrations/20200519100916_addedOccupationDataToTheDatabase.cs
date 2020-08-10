using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class addedOccupationDataToTheDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Occupation",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(2715), "Studentas", null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(2744) },
                    { 2, null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3616), "Dėstytojas", null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3637) },
                    { 3, null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3664), "Kineziterapeutas", null, new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3679) }
                });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 825, DateTimeKind.Local).AddTicks(9626), new DateTime(2020, 5, 19, 13, 9, 15, 831, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 831, DateTimeKind.Local).AddTicks(9631), new DateTime(2020, 5, 19, 13, 9, 15, 831, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 834, DateTimeKind.Local).AddTicks(6007), new DateTime(2020, 5, 19, 13, 9, 15, 834, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1023), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1156), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1183), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1201), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(1210) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 854, DateTimeKind.Local).AddTicks(7266), new DateTime(2020, 5, 19, 11, 20, 52, 860, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 861, DateTimeKind.Local).AddTicks(883), new DateTime(2020, 5, 19, 11, 20, 52, 861, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 863, DateTimeKind.Local).AddTicks(7989), new DateTime(2020, 5, 19, 11, 20, 52, 863, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3325), new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3450), new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3471), new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3488), new DateTime(2020, 5, 19, 11, 20, 52, 864, DateTimeKind.Local).AddTicks(3494) });
        }
    }
}
