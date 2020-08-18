using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedTeamMemberToPostType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedOn", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8545), "Event", new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8591), "Advertisment", null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8595) },
                    { 4, null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8598), "TeamMember", null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8602) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(8467), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(9755), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(9825), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 960, DateTimeKind.Local).AddTicks(469), new DateTime(2020, 8, 17, 11, 24, 58, 965, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 965, DateTimeKind.Local).AddTicks(7862), "Advertisment", new DateTime(2020, 8, 17, 11, 24, 58, 965, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(370), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6791), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6902), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6915), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6926), new DateTime(2020, 8, 17, 11, 24, 58, 968, DateTimeKind.Local).AddTicks(6930) });
        }
    }
}
