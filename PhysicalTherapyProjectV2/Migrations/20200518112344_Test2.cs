using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 672, DateTimeKind.Local).AddTicks(8847), new DateTime(2020, 5, 18, 14, 23, 43, 678, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 678, DateTimeKind.Local).AddTicks(7455), new DateTime(2020, 5, 18, 14, 23, 43, 678, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedBy", "CreatedOn", "PostTypeId", "PostUserId", "Title", "UpdatedBy", "UpdatedOn", "VideoLink", "isForAuthenticatedUser" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2020, 5, 18, 14, 23, 43, 681, DateTimeKind.Local).AddTicks(7970), 1, null, "What is Lorem Ipsum?", null, new DateTime(2020, 5, 18, 14, 23, 43, 681, DateTimeKind.Local).AddTicks(8104), null, false },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3284), 1, null, "1914 translation by H. Rackham", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3334), null, false },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3460), 1, null, "The standard Lorem Ipsum passage, used since the 1500s", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3470), null, false },
                    { 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3483), 1, null, "Where does it come from?", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3491), null, false },
                    { 5, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3509), 1, null, "Where can I get some?", null, new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3516), null, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

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
    }
}
