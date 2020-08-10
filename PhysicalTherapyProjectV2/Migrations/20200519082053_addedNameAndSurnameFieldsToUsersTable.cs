using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class addedNameAndSurnameFieldsToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 349, DateTimeKind.Local).AddTicks(6089), new DateTime(2020, 5, 19, 11, 18, 22, 355, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 356, DateTimeKind.Local).AddTicks(1774), new DateTime(2020, 5, 19, 11, 18, 22, 356, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 358, DateTimeKind.Local).AddTicks(7003), new DateTime(2020, 5, 19, 11, 18, 22, 358, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(1895), new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2017), new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2039), new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2051), new DateTime(2020, 5, 19, 11, 18, 22, 359, DateTimeKind.Local).AddTicks(2057) });
        }
    }
}
