using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class project_path_added_to_students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c1000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c2000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(939), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(947), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(950), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(953), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(956), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(960), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(963), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(966), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(969), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(972), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(976), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(979), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(982), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(985), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000015"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(988), "defaultProject.zip" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00002-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00003-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00004-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 21, 28, 541, DateTimeKind.Local).AddTicks(795));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "CustomerManagers",
                keyColumn: "Id",
                keyValue: new Guid("e0000001-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7802), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7815), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7819), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7823), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7827), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7830), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7833), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7836), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7842), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7845), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7849), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7852), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7855), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7858), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dddddd00-0000-0000-0000-000000000015"),
                columns: new[] { "CreatedDate", "ProjectPath" },
                values: new object[] { new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7862), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00001-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00002-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00003-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aaa00004-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 47, 58, 531, DateTimeKind.Local).AddTicks(7400));
        }
    }
}
