using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedRolesForApplicationRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "922c23aa-e6eb-4f76-b802-4cafdbaba03e", "Administrator", null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1689), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(2028), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(2053), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 573, DateTimeKind.Local).AddTicks(3241), new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(8975), new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(9022), new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(9029), new DateTime(2020, 8, 18, 8, 31, 30, 575, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 576, DateTimeKind.Local).AddTicks(9354), new DateTime(2020, 8, 18, 8, 31, 30, 576, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1039), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1099), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1108), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1116), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1123), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1130), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1138), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1145), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1153), new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1156) });
        }
    }
}
