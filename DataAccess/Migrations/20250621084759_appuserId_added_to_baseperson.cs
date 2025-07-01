using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appuserId_added_to_baseperson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Teachers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Students",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "CustomerManagers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c1000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c2000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000001"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("d0000001-0000-0000-0000-000000000001"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000002"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("d0000001-0000-0000-0000-000000000002"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000003"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("d0000001-0000-0000-0000-000000000003"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000001"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000001"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000002"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000002"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000003"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000003"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000004"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000004"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000005"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000005"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000006"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000006"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000007"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000007"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000008"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000008"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000009"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000009"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000010"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000010"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000011"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000011"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000012"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000012"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000013"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000013"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000014"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000014"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000015"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("b0000001-0000-0000-0000-000000000015"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00001-0000-0000-0000-000000000001"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("c0000001-0000-0000-0000-000000000001"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00002-0000-0000-0000-000000000002"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("c0000001-0000-0000-0000-000000000002"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00003-0000-0000-0000-000000000003"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("c0000001-0000-0000-0000-000000000003"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00004-0000-0000-0000-000000000004"),
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { new Guid("c0000001-0000-0000-0000-000000000004"), new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7400) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CustomerManagers");

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
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 45, 40, 554, DateTimeKind.Local).AddTicks(4781));

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
    }
}
