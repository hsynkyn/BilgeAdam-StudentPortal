using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.IdenetityMigrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Name", "NormalizedName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("99999999-0000-0000-0000-000000000001"), null, new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2536), null, "Admin", "ADMIN", 1, null },
                    { new Guid("99999999-0000-0000-0000-000000000002"), null, new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2550), null, "Student", "STUDENT", 1, null },
                    { new Guid("99999999-0000-0000-0000-000000000003"), null, new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2552), null, "Teacher", "TEACHER", 1, null },
                    { new Guid("99999999-0000-0000-0000-000000000004"), null, new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2554), null, "CustomerManager", "CUSTOMERMANAGER", 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("a0000001-0000-0000-0000-000000000001"), 0, new DateOnly(1990, 1, 1), "011971bc-b0ce-4f31-a233-7139229d301f", new DateTime(2025, 6, 1, 14, 16, 43, 976, DateTimeKind.Local).AddTicks(147), null, "admin@example.com", true, "Sistem", "Yöneticisi", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEAlWjzWQ58EfVEceyRAb1/f9US4NgbVUqMI4jJTDRejOb0BFmZ5Z2wZlIyYQnr6gDg==", null, false, "4446d85b-db4b-44d4-83a4-4ed5d2312a32", 1, false, null, "admin" },
                    { new Guid("b0000001-0000-0000-0000-000000000001"), 0, new DateOnly(2000, 5, 10), "1536e5fe-9d9d-4aff-ae2b-c7dcf13cb54a", new DateTime(2025, 6, 1, 14, 16, 44, 18, DateTimeKind.Local).AddTicks(496), null, "ahmet1@mail.com", true, "Ahmet", "Yıldız", false, null, "AHMET1@MAIL.COM", "AHMET1", "AQAAAAIAAYagAAAAEHcANyzDXx0Qk7e/vGcypMU9AUrkaKOWPduwH/0AZpSho5GxduFqK3KksxdrxlyOcQ==", null, false, "5d075187-dd3f-40f5-827b-471528d2dd79", 1, false, null, "ahmet1" },
                    { new Guid("b0000001-0000-0000-0000-000000000002"), 0, new DateOnly(1999, 3, 15), "a7a3490a-b717-41e6-913a-f6e2eff83fbc", new DateTime(2025, 6, 1, 14, 16, 44, 61, DateTimeKind.Local).AddTicks(5951), null, "busra2@mail.com", true, "Büşra", "Demir", false, null, "BUSRA2@MAIL.COM", "BUSRA2", "AQAAAAIAAYagAAAAEJRZ0IHmeTAtbzkWjmzQi5cu7Y7naBh53gjTgYS32Hn5tXni6M11nQBoihlRMjlqog==", null, false, "40806275-9567-4c9c-aabe-58f908f08746", 1, false, null, "busra2" },
                    { new Guid("b0000001-0000-0000-0000-000000000003"), 0, new DateOnly(2001, 8, 20), "2fdbd9cf-814b-452c-a141-258a2df90f5b", new DateTime(2025, 6, 1, 14, 16, 44, 104, DateTimeKind.Local).AddTicks(3957), null, "can3@mail.com", true, "Can", "Kara", false, null, "CAN3@MAIL.COM", "CAN3", "AQAAAAIAAYagAAAAEAhho0DKTB2XGCLgL1jVef6SKyMriXIizgynB90rqRu48/wSzJjO8NNp6/pNwmAL1Q==", null, false, "bcac831f-4a67-49c4-bdd1-e7f8f326f765", 1, false, null, "can3" },
                    { new Guid("b0000001-0000-0000-0000-000000000004"), 0, new DateOnly(2000, 11, 5), "2b3f1188-9cf0-4e4b-ad50-23be35a62e15", new DateTime(2025, 6, 1, 14, 16, 44, 149, DateTimeKind.Local).AddTicks(9120), null, "deniz4@mail.com", true, "Deniz", "Aydın", false, null, "DENIZ4@MAIL.COM", "DENIZ4", "AQAAAAIAAYagAAAAEHVdN6z1cNNnz5wghgFvtRjwJbyzZYC8a9GcHK6X8Ug13hQYPskC4frsxnEWrjuAuw==", null, false, "a5bf0928-0103-4a86-9719-af0ebbcb8f6f", 1, false, null, "deniz4" },
                    { new Guid("b0000001-0000-0000-0000-000000000005"), 0, new DateOnly(2000, 6, 1), "5f4600c1-d3d4-4b3a-9543-dc1d82647636", new DateTime(2025, 6, 1, 14, 16, 44, 194, DateTimeKind.Local).AddTicks(597), null, "emre5@mail.com", true, "Emre", "Aslan", false, null, "EMRE5@MAIL.COM", "EMRE5", "AQAAAAIAAYagAAAAEF6TL5uZKhrtCCCpOtLgjut7EoFiLvlemN0eai2iUdWoem6OG0q0nsDafUWXJ5fJEQ==", null, false, "72edb15a-c88b-4fa9-8884-d9d0f8e93c54", 1, false, null, "emre5" },
                    { new Guid("b0000001-0000-0000-0000-000000000006"), 0, new DateOnly(2000, 1, 10), "735cffb6-8a0d-432c-b58f-5cc2e9bbd3d7", new DateTime(2025, 6, 1, 14, 16, 44, 238, DateTimeKind.Local).AddTicks(5654), null, "fatma6@mail.com", true, "Fatma", "Çelik", false, null, "FATMA6@MAIL.COM", "FATMA6", "AQAAAAIAAYagAAAAEGFdzMrnbd2rDVwgvLt1KE5xPYOXpF/Q7dzA9D6KndGhShcVYuO+DI6TYRkBjr3Dxw==", null, false, "7628be26-2aa9-4133-843f-c4e0071b4874", 1, false, null, "fatma6" },
                    { new Guid("b0000001-0000-0000-0000-000000000007"), 0, new DateOnly(1999, 12, 15), "1617de97-1eec-4737-a522-fe1a54b20883", new DateTime(2025, 6, 1, 14, 16, 44, 281, DateTimeKind.Local).AddTicks(9353), null, "gokhan7@mail.com", true, "Gökhan", "Şimşek", false, null, "GOKHAN7@MAIL.COM", "GOKHAN7", "AQAAAAIAAYagAAAAEAFDr/RwwK937gsqNBxMgrDDzwkaypl99gYuG5/3DLzH/3Y68aA7HWV8PTsTN2SPCw==", null, false, "f086d2cc-1040-4f6e-84a3-1b434bc2d639", 1, false, null, "gokhan7" },
                    { new Guid("b0000001-0000-0000-0000-000000000008"), 0, new DateOnly(2001, 2, 25), "017589f6-adaf-401f-b8ac-4499c5dc3bc5", new DateTime(2025, 6, 1, 14, 16, 44, 325, DateTimeKind.Local).AddTicks(7460), null, "hale8@mail.com", true, "Hale", "Yalçın", false, null, "HALE8@MAIL.COM", "HALE8", "AQAAAAIAAYagAAAAEAWGeZVehhu0jM5h3fsoMHF8m4v+9XsTYO3qt49Nj7WvkCHbKdo8dlmx3DgI651QFA==", null, false, "e2cfbe36-2e0d-4791-9715-d65d53f90699", 1, false, null, "hale8" },
                    { new Guid("b0000001-0000-0000-0000-000000000009"), 0, new DateOnly(2000, 4, 3), "2ac85fd1-b6d2-4f49-a285-06fabe963272", new DateTime(2025, 6, 1, 14, 16, 44, 369, DateTimeKind.Local).AddTicks(2514), null, "ismail9@mail.com", true, "İsmail", "Öztürk", false, null, "ISMAIL9@MAIL.COM", "ISMAIL9", "AQAAAAIAAYagAAAAEBpMLACUJflLxPCrX1KpPYFcfohw7IZJJybmKFY6U+FCKobjSv4jHjdQ2BVeepCixg==", null, false, "447defeb-f9b3-4fba-8245-5e2e28de866d", 1, false, null, "ismail9" },
                    { new Guid("b0000001-0000-0000-0000-000000000010"), 0, new DateOnly(2000, 9, 9), "7a2ae388-138d-4918-94f9-1bdc72b8af89", new DateTime(2025, 6, 1, 14, 16, 44, 412, DateTimeKind.Local).AddTicks(4227), null, "jale10@mail.com", true, "Jale", "Bilgin", false, null, "JALE10@MAIL.COM", "JALE10", "AQAAAAIAAYagAAAAEBMAQwo7gZeROO7IWZwHTmDHTSeda04BoU38XazjuciBkRnP3TnDnui67PWWKPOsaQ==", null, false, "8d893a75-2988-4c4a-89da-48012f8b3b05", 1, false, null, "jale10" },
                    { new Guid("b0000001-0000-0000-0000-000000000011"), 0, new DateOnly(2001, 5, 12), "ede2997f-8a34-47c4-ae86-5027ed960d5c", new DateTime(2025, 6, 1, 14, 16, 44, 456, DateTimeKind.Local).AddTicks(1187), null, "kaan11@mail.com", true, "Kaan", "Bozkurt", false, null, "KAAN11@MAIL.COM", "KAAN11", "AQAAAAIAAYagAAAAEFj9KPh3yJNbn9iB5yR0x80q90tbxrD3oMcdaOuHzASmsN7/b9gzVay0n1DfV4VOsA==", null, false, "8aad5c0c-edc6-4e55-be63-0ed79828a7d0", 1, false, null, "kaan11" },
                    { new Guid("b0000001-0000-0000-0000-000000000012"), 0, new DateOnly(2001, 1, 8), "34944d64-d484-40b8-8591-a438c2440a24", new DateTime(2025, 6, 1, 14, 16, 44, 503, DateTimeKind.Local).AddTicks(7792), null, "leyla12@mail.com", true, "Leyla", "Karaca", false, null, "LEYLA12@MAIL.COM", "LEYLA12", "AQAAAAIAAYagAAAAEGH0fwK4DkxD1jS0jdViDr2u0OXdOCO/MRbwJen0Jy3K94fiVRDqlr1CrNUqm66GdQ==", null, false, "56eac219-b679-4cb8-9a0b-57c5295a4a5c", 1, false, null, "leyla12" },
                    { new Guid("b0000001-0000-0000-0000-000000000013"), 0, new DateOnly(2001, 7, 17), "80635456-1e10-42f4-a2f1-fa6c844b6acf", new DateTime(2025, 6, 1, 14, 16, 44, 548, DateTimeKind.Local).AddTicks(3546), null, "mert13@mail.com", true, "Mert", "Tunç", false, null, "MERT13@MAIL.COM", "MERT13", "AQAAAAIAAYagAAAAEHG2PckGEplGOamkX6biUAhGzO8LP8xssGe/u0G4DVX1CtlXkp91pBSXrdsyESVETA==", null, false, "5583356e-0b10-49cf-9755-454b2c3d6941", 1, false, null, "mert13" },
                    { new Guid("b0000001-0000-0000-0000-000000000014"), 0, new DateOnly(2000, 6, 30), "92c3d06a-f02d-4594-9764-cbcf2e0a25cb", new DateTime(2025, 6, 1, 14, 16, 44, 592, DateTimeKind.Local).AddTicks(5348), null, "nazli14@mail.com", true, "Nazlı", "Kurt", false, null, "NAZLI14@MAIL.COM", "NAZLI14", "AQAAAAIAAYagAAAAEKoFtnF/jOiW/O9dya3/d3KpAXfCwaReiwY5ECJPIiKlGs9xZVHQ6hZ/i/nwp3AQkg==", null, false, "836ab355-1583-4737-a3b6-f39b5f400685", 1, false, null, "nazli14" },
                    { new Guid("b0000001-0000-0000-0000-000000000015"), 0, new DateOnly(2001, 10, 10), "7cab77fb-49ae-4d29-9044-9e6014b9a7b3", new DateTime(2025, 6, 1, 14, 16, 44, 637, DateTimeKind.Local).AddTicks(7559), null, "onur15@mail.com", true, "Onur", "Yavuz", false, null, "ONUR15@MAIL.COM", "ONUR15", "AQAAAAIAAYagAAAAENpfrAs5EOFnAQSGXivOcbHadRS5BmtDMrG4QOVSDtIXuyYHH1lrCy4Snif6wfps5g==", null, false, "31a92ef6-31f6-46a0-af67-b5e5ab425fa2", 1, false, null, "onur15" },
                    { new Guid("c0000001-0000-0000-0000-000000000001"), 0, new DateOnly(1985, 6, 10), "13cb0b49-8be1-4338-9e78-77b115c2a7ff", new DateTime(2025, 6, 1, 14, 16, 44, 763, DateTimeKind.Local).AddTicks(1329), null, "ali@example.com", true, "Ali", "Yılmaz", false, null, "ALI@EXAMPLE.COM", "ALI", "AQAAAAIAAYagAAAAEKflTQqRL+OcrdG/Pg25u7L6AFOS5hFYPcgtLgtQLC7q7Wukp4pTCgfR94FV2aJFaQ==", null, false, "62d181a9-2286-4056-986e-827debd574ae", 1, false, null, "ali" },
                    { new Guid("c0000001-0000-0000-0000-000000000002"), 0, new DateOnly(1990, 3, 15), "327c4fb7-1407-4596-9d2c-e22961379a11", new DateTime(2025, 6, 1, 14, 16, 44, 804, DateTimeKind.Local).AddTicks(4157), null, "ayse@example.com", true, "Ayşe", "Demir", false, null, "AYSE@EXAMPLE.COM", "AYSE", "AQAAAAIAAYagAAAAEHCbHLsQV33eSTXwyAwwNwZa4qMSqNMdsQfkGlT3ptMpwOeHotn5SM5yB7QksAAIkA==", null, false, "a25326ec-237c-42a8-8bef-170ee82f9470", 1, false, null, "ayse" },
                    { new Guid("c0000001-0000-0000-0000-000000000003"), 0, new DateOnly(1980, 8, 22), "0ca0289d-d19c-4faa-bf3d-da14898ba7b1", new DateTime(2025, 6, 1, 14, 16, 44, 678, DateTimeKind.Local).AddTicks(8566), null, "mehmet@example.com", true, "Mehmet", "Kaya", false, null, "MEHMET@EXAMPLE.COM", "MEHMET", "AQAAAAIAAYagAAAAEIl7ELm91CMGZPY8cfu3EhNpVKRZInIfMQK5vK/PLP4RL4nLMw16+HLvcDt76BmCgA==", null, false, "a195e29a-3998-4167-b050-6484f21dda26", 1, false, null, "mehmet" },
                    { new Guid("c0000001-0000-0000-0000-000000000004"), 0, new DateOnly(1992, 11, 30), "f378dd3c-6e97-4fa8-8827-02e6cd29cfab", new DateTime(2025, 6, 1, 14, 16, 44, 719, DateTimeKind.Local).AddTicks(5174), null, "elif@example.com", true, "Elif", "Aydın", false, null, "ELIF@EXAMPLE.COM", "ELIF", "AQAAAAIAAYagAAAAEAo6JlDbFuTj9t4Qh3DoExRGcB5tx4ts0kvDLtOQArCko6TJEA+ClXOduoydiXLtNg==", null, false, "3506800c-20cc-431a-8303-a1c50d8dd075", 1, false, null, "elif" },
                    { new Guid("d0000001-0000-0000-0000-000000000001"), 0, new DateOnly(1990, 4, 15), "04d81f05-cffc-4231-9763-362e4d2d06cd", new DateTime(2025, 6, 1, 14, 16, 44, 846, DateTimeKind.Local).AddTicks(2282), null, "zeynep.yilmaz@example.com", true, "Zeynep", "Yılmaz", false, null, "ZEYNEP.YILMAZ@EXAMPLE.COM", "ZEYNEP", "AQAAAAIAAYagAAAAEHU78XqwqUPheu4qUNv3NrkJMk0JYQlMkl0BIHDCepdtOSAL4Qe5MU4up2djO2Hrmw==", null, false, "3fa004d5-68fe-4dd5-a162-191fdf963eb9", 1, false, null, "zeynep" },
                    { new Guid("d0000001-0000-0000-0000-000000000002"), 0, new DateOnly(1988, 9, 25), "9e86d90c-6182-4ea5-add4-3e59cde6b5d9", new DateTime(2025, 6, 1, 14, 16, 44, 890, DateTimeKind.Local).AddTicks(40), null, "burak.koc@example.com", true, "Burak", "Koç", false, null, "BURAK.KOC@EXAMPLE.COM", "BURAK", "AQAAAAIAAYagAAAAEG+VDRqya5t94/cVTpwkNlbQ9hNuCIHQHPrPEFVSGc7CUbgKQyNwv1+MkELlgVOV+w==", null, false, "18798b9c-8644-452e-8afa-18b6c213921a", 1, false, null, "burak" },
                    { new Guid("d0000001-0000-0000-0000-000000000003"), 0, new DateOnly(1992, 6, 30), "32e7a159-dca7-4e2c-9a0d-d6709da6100b", new DateTime(2025, 6, 1, 14, 16, 44, 931, DateTimeKind.Local).AddTicks(7515), null, "derya.ates@example.com", true, "Derya", "Ateş", false, null, "DERYA.ATES@EXAMPLE.COM", "DERYA", "AQAAAAIAAYagAAAAECVYEgP9RILcuKWaUmPc1Om9qn/3qkun/ZVBSmirXqDssLb59rNWQIhH9zmwrabPvw==", null, false, "8cbdfd54-d923-4a00-9fb1-0b395795de4b", 1, false, null, "derya" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("99999999-0000-0000-0000-000000000001"), new Guid("a0000001-0000-0000-0000-000000000001") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000001") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000002") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000003") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000004") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000005") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000006") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000007") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000008") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000009") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000010") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000011") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000012") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000013") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000014") },
                    { new Guid("99999999-0000-0000-0000-000000000002"), new Guid("b0000001-0000-0000-0000-000000000015") },
                    { new Guid("99999999-0000-0000-0000-000000000003"), new Guid("c0000001-0000-0000-0000-000000000001") },
                    { new Guid("99999999-0000-0000-0000-000000000003"), new Guid("c0000001-0000-0000-0000-000000000002") },
                    { new Guid("99999999-0000-0000-0000-000000000003"), new Guid("c0000001-0000-0000-0000-000000000003") },
                    { new Guid("99999999-0000-0000-0000-000000000003"), new Guid("c0000001-0000-0000-0000-000000000004") },
                    { new Guid("99999999-0000-0000-0000-000000000004"), new Guid("d0000001-0000-0000-0000-000000000001") },
                    { new Guid("99999999-0000-0000-0000-000000000004"), new Guid("d0000001-0000-0000-0000-000000000002") },
                    { new Guid("99999999-0000-0000-0000-000000000004"), new Guid("d0000001-0000-0000-0000-000000000003") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
