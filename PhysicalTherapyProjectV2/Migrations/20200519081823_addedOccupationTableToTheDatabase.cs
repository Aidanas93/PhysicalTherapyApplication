using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProjectV2.Migrations
{
    public partial class addedOccupationTableToTheDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OccupationId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OccupationId",
                table: "AspNetUsers",
                column: "OccupationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Occupation_OccupationId",
                table: "AspNetUsers",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Occupation_OccupationId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OccupationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OccupationId",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 681, DateTimeKind.Local).AddTicks(7970), new DateTime(2020, 5, 18, 14, 23, 43, 681, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3284), new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3460), new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3483), new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3509), new DateTime(2020, 5, 18, 14, 23, 43, 682, DateTimeKind.Local).AddTicks(3516) });
        }
    }
}
