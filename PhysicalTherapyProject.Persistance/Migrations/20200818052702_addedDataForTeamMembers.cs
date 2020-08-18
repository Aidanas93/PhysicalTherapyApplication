using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedDataForTeamMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedBy", "CreatedOn", "Date", "PostTypeId", "PostUserId", "Title", "UpdatedBy", "UpdatedOn", "isForAuthenticatedUser" },
                values: new object[,]
                {
                    { 6, "Prezidentė: INESA RIMDEIKIENĖ 861112265 inesa.rimdeikiene@kaunoklinikos.lt Pareigos: draugijos valdybos ir narių atstovavimas, bendravimas su valstybinėmis institucijomis", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6430), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6433), false },
                    { 7, "RAIMUNDAS VENSKAITIS 862237888 raimundas.venskaitis@gmail.com Pareigos:  draugijos internetinio puslapio ir Facebook paskyros valdymas ir priežiūra", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6441), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1257), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1585), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1608), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 94, DateTimeKind.Local).AddTicks(2598), new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8545), new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8591), new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8598), new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 97, DateTimeKind.Local).AddTicks(8849), new DateTime(2020, 8, 18, 8, 8, 57, 97, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(646), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(710), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(718), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(726), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(729) });
        }
    }
}
