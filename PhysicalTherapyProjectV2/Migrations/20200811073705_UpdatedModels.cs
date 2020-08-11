using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(8985), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(9680), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(9712), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 906, DateTimeKind.Local).AddTicks(6903), new DateTime(2020, 8, 11, 10, 37, 4, 911, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 911, DateTimeKind.Local).AddTicks(7522), new DateTime(2020, 8, 11, 10, 37, 4, 911, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7844), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7932), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7943), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7951), new DateTime(2020, 8, 11, 10, 37, 4, 913, DateTimeKind.Local).AddTicks(7955) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(2715), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3616), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3664), new DateTime(2020, 5, 19, 13, 9, 15, 835, DateTimeKind.Local).AddTicks(3679) });

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
    }
}
