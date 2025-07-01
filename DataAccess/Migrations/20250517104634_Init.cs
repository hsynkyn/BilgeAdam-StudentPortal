using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    TotalHour = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CourseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classrooms_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Exam1 = table.Column<double>(type: "double precision", nullable: true),
                    Exam2 = table.Column<double>(type: "double precision", nullable: true),
                    ProjectExam = table.Column<double>(type: "double precision", nullable: true),
                    ProjectPath = table.Column<string>(type: "text", nullable: true),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    RegisterPrice = table.Column<double>(type: "double precision", nullable: false),
                    ClassroomId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "TotalHour", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3346), null, "Yapay Zeka", 1, 120, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3367), null, "Web Programlama", 1, 100, null }
                });

            migrationBuilder.InsertData(
                table: "CustomerManagers",
                columns: new[] { "Id", "Birthdate", "CreatedDate", "DeletedDate", "Email", "FirstName", "HireDate", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e0000001-0000-0000-0000-000000000001"), new DateOnly(1990, 4, 15), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3917), null, "zeynep.yilmaz@example.com", "Zeynep", new DateOnly(2022, 1, 10), "Yılmaz", 1, null },
                    { new Guid("e0000001-0000-0000-0000-000000000002"), new DateOnly(1988, 9, 25), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3920), null, "burak.koc@example.com", "Burak", new DateOnly(2021, 11, 5), "Koç", 1, null },
                    { new Guid("e0000001-0000-0000-0000-000000000003"), new DateOnly(1992, 6, 30), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3922), null, "derya.ates@example.com", "Derya", new DateOnly(2023, 3, 1), "Ateş", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Birthdate", "CourseId", "CreatedDate", "DeletedDate", "Email", "FirstName", "HireDate", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("aaa00001-0000-0000-0000-000000000001"), new DateOnly(1985, 6, 10), new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3547), null, "ali@example.com", "Ali", new DateOnly(2020, 1, 1), "Yılmaz", 1, null },
                    { new Guid("aaa00002-0000-0000-0000-000000000002"), new DateOnly(1990, 3, 15), new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3559), null, "ayse@example.com", "Ayşe", new DateOnly(2021, 2, 10), "Demir", 1, null },
                    { new Guid("aaa00003-0000-0000-0000-000000000003"), new DateOnly(1980, 8, 22), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3563), null, "mehmet@example.com", "Mehmet", new DateOnly(2019, 9, 5), "Kaya", 1, null },
                    { new Guid("aaa00004-0000-0000-0000-000000000004"), new DateOnly(1992, 11, 30), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3565), null, "elif@example.com", "Elif", new DateOnly(2022, 5, 25), "Aydın", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "EndDate", "Name", "StartDate", "Status", "TeacherId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3709), null, "Yapay Zeka başlangıç sınıfı", new DateOnly(2025, 3, 1), "A Blok 101", new DateOnly(2024, 10, 1), 1, new Guid("aaa00001-0000-0000-0000-000000000001"), null },
                    { new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3715), null, "Web Programlama uzmanlık sınıfı", new DateOnly(2025, 2, 15), "B Blok 202", new DateOnly(2024, 9, 15), 1, new Guid("aaa00003-0000-0000-0000-000000000003"), null },
                    { new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3717), null, "Proje geliştirme ve mezuniyet sınıfı", new DateOnly(2025, 4, 30), "C Blok 303", new DateOnly(2024, 11, 1), 1, new Guid("aaa00002-0000-0000-0000-000000000002"), null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "ClassroomId", "CreatedDate", "DeletedDate", "Email", "Exam1", "Exam2", "FirstName", "ImagePath", "LastName", "ProjectExam", "ProjectName", "ProjectPath", "RegisterPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("dddddd00-0000-0000-0000-000000000001"), new DateOnly(2000, 5, 10), new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3786), null, "ahmet1@mail.com", 70.0, 80.0, "Ahmet", null, "Yıldız", 90.0, null, null, 1500.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000002"), new DateOnly(1999, 3, 15), new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3794), null, "busra2@mail.com", 60.0, 75.0, "Büşra", null, "Demir", 85.0, null, null, 1450.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000003"), new DateOnly(2001, 8, 20), new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3798), null, "can3@mail.com", 55.0, 65.0, "Can", null, "Kara", 75.0, null, null, 1350.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000004"), new DateOnly(2000, 11, 5), new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3802), null, "deniz4@mail.com", 45.0, 50.0, "Deniz", null, "Aydın", 70.0, null, null, 1400.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000005"), new DateOnly(2000, 6, 1), new Guid("c1000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3806), null, "emre5@mail.com", 85.0, 90.0, "Emre", null, "Aslan", 95.0, null, null, 1600.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000006"), new DateOnly(2000, 1, 10), new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3808), null, "fatma6@mail.com", 50.0, 55.0, "Fatma", null, "Çelik", 60.0, null, null, 1250.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000007"), new DateOnly(1999, 12, 15), new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3811), null, "gokhan7@mail.com", 65.0, 70.0, "Gökhan", null, "Şimşek", 75.0, null, null, 1300.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000008"), new DateOnly(2001, 2, 25), new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3814), null, "hale8@mail.com", 90.0, 95.0, "Hale", null, "Yalçın", 100.0, null, null, 1700.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000009"), new DateOnly(2000, 4, 3), new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3817), null, "ismail9@mail.com", 70.0, 65.0, "İsmail", null, "Öztürk", 80.0, null, null, 1500.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000010"), new DateOnly(2000, 9, 9), new Guid("c2000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3820), null, "jale10@mail.com", 60.0, 60.0, "Jale", null, "Bilgin", 65.0, null, null, 1400.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000011"), new DateOnly(2001, 5, 12), new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3822), null, "kaan11@mail.com", 80.0, 85.0, "Kaan", null, "Bozkurt", 75.0, null, null, 1550.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000012"), new DateOnly(2001, 1, 8), new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3825), null, "leyla12@mail.com", 55.0, 60.0, "Leyla", null, "Karaca", 70.0, null, null, 1350.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000013"), new DateOnly(2001, 7, 17), new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3828), null, "mert13@mail.com", 65.0, 50.0, "Mert", null, "Tunç", 60.0, null, null, 1250.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000014"), new DateOnly(2000, 6, 30), new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3830), null, "nazli14@mail.com", 75.0, 85.0, "Nazlı", null, "Kurt", 90.0, null, null, 1600.0, 1, null },
                    { new Guid("dddddd00-0000-0000-0000-000000000015"), new DateOnly(2001, 10, 10), new Guid("c3000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 13, 46, 34, 542, DateTimeKind.Local).AddTicks(3833), null, "onur15@mail.com", 90.0, 90.0, "Onur", null, "Yavuz", 85.0, null, null, 1650.0, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_TeacherId",
                table: "Classrooms",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerManagers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
