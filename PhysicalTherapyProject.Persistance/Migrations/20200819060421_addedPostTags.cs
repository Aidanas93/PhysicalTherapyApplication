using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedPostTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TagValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4ccfe992-ab54-484b-b431-2f82b3a41ee9");

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(7384), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(8248), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(8286), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 820, DateTimeKind.Local).AddTicks(9282), new DateTime(2020, 8, 19, 9, 4, 20, 825, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2132), new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2201), new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2211), new DateTime(2020, 8, 19, 9, 4, 20, 826, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(1227), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(5968), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6062), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6075), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6085), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6095), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6107), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6116), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6126), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6136), new DateTime(2020, 8, 19, 9, 4, 20, 828, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Tags");

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
    }
}
