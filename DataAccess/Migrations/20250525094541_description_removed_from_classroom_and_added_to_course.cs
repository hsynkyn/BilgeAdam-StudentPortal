using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class description_removed_from_classroom_and_added_to_course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Classrooms");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c1000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c2000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4761), "Yapay Zeka Eğitimi" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4781), ".Net Core MVC" });

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00002-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00003-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00004-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4954));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Classrooms",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c1000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3709), "Yapay Zeka başlangıç sınıfı" });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c2000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3715), "Web Programlama uzmanlık sınıfı" });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3717), "Proje geliştirme ve mezuniyet sınıfı" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00002-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00003-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00004-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3565));
        }
    }
}
