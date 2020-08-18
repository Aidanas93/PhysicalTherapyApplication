using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedNavigationalPropertyForImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d7d06b81-365c-4c58-a5b2-1165e776fdc4");

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1138), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1466), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1488), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 351, DateTimeKind.Local).AddTicks(1279), new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7884), new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7927), new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7935), new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 354, DateTimeKind.Local).AddTicks(8710), new DateTime(2020, 8, 18, 9, 59, 35, 354, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(462), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(527), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(536), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(545), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(552), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(560), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(567), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(575), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(582), new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(586) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "922c23aa-e6eb-4f76-b802-4cafdbaba03e");

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8449), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8753), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8775), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 687, DateTimeKind.Local).AddTicks(9964), new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5870), new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5915), new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5922), new DateTime(2020, 8, 18, 8, 38, 22, 690, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(6081), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7799), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7866), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7875), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7882), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7890), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7897), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7904), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7912), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7919), new DateTime(2020, 8, 18, 8, 38, 22, 691, DateTimeKind.Local).AddTicks(7922) });
        }
    }
}
