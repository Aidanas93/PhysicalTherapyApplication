using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedDataForTeamMembersV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedBy", "CreatedOn", "Date", "PostTypeId", "PostUserId", "Title", "UpdatedBy", "UpdatedOn", "isForAuthenticatedUser" },
                values: new object[,]
                {
                    { 9, "BRIGITA ZACHOVAJEVIENĖ – Kauno kr. pirmininkė 8 698 75901 brigitaz@medi.lt Pareigos: sekretorė", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1148), false },
                    { 10, "IEVA EGLĖ JAMONTAITĖ  Vilniaus kr.pirmininkė 8 682 45413 ieva.jamontaite@gmail.com Pareigos: LKTD narių narystės tvarkos priežiūra", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1153), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1156), false },
                    { 8, "DOVILĖ VALATKIENĖ –Klaipėdos <b>kr.pirmininkė<b> 861149101 dvalatkiene@yahoo.com klaipedosktd@gmail.com Pareigos: Klaipėdos krašto kineziterapeutų atstovavimas", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1138), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1141), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7094), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7426), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7448), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 92, DateTimeKind.Local).AddTicks(7679), new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4279), new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4327), new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4334), new DateTime(2020, 8, 18, 8, 27, 2, 95, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(4614), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6342), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6405), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6414), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6422), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6430), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6438), new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6441) });
        }
    }
}
