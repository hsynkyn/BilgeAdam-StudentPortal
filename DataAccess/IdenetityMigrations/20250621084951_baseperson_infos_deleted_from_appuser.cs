using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.IdenetityMigrations
{
    /// <inheritdoc />
    public partial class baseperson_infos_deleted_from_appuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 49, 50, 920, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 49, 50, 920, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 49, 50, 920, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 11, 49, 50, 920, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce5f5ba-3833-43c0-977b-74e902a6acb8", "AQAAAAIAAYagAAAAEIcICbRMGb0dAStOVEH1fLVa4+9VG1BDmZ4Bcj/CY/OsvOlG6af4Mo3k7TdpXnvcMA==", "ecddcd92-8755-41f4-b789-de4a307ca6a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29599cbc-d4a7-4559-9789-f5ca114fe1c1", "AQAAAAIAAYagAAAAECZ46QCFaCdebUPq/pOG4CZu69W54qbr+HeV79NEb8DsbiL0HSx1oz6fKvzlik34lw==", "98194283-2fd1-44ce-8bfb-b429093ed633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e08d284f-3b7c-4f52-b4b2-c40d97ba9f4d", "AQAAAAIAAYagAAAAEPZ8KHgJ9XWhWuWNYW7Ch8vJA/mNqHiCHWd8s+3W2GrhbC5aRbyKFRvxilHfxHIYxg==", "a9b42b13-20af-4d4d-b549-253fbd029fed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb764b39-d0c2-4f94-b8f2-c3825e5efc95", "AQAAAAIAAYagAAAAEJjv0Rry4cezMTQPBPtKGh9jXbneJGOxpzDuS6llzilFp1Z8ywVGNBZMf4jNy8wCWw==", "52276a91-ef0e-4e02-8451-1af99ce45ff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3622b7-aaa8-409f-98cc-68137addc83e", "AQAAAAIAAYagAAAAEN/LJHsbP+c2yrxToV3mL14tLF/y7qz3+YVKW+cOQp6JebcjIYBZcX0woPXu25O3/w==", "4c458230-1523-4774-898e-3feedaf356bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fd4a8f2-b924-481a-8988-5cbf19dfe3f7", "AQAAAAIAAYagAAAAEBcDT1C4XWequv5k1deqIOKqnS5Hd0QrojoRt1TFpv30t36Yi6bSMZRt5qLxIXgoGQ==", "6b871fa7-0961-449b-b31e-6d46f119b3a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "758857c8-d0a3-4c23-9de3-3a5abd8d0163", "AQAAAAIAAYagAAAAEB/RT82pph5aLWtRQ9/tEcJ13wtRMggML9sLevujk+l1VXcAtkOc/wLujABZKxVGkg==", "ef06d3d7-ffe0-4814-afea-26a6451248e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cd46b43-0025-4e54-9dbe-9b6d721ea5ee", "AQAAAAIAAYagAAAAEHe+VeiwKcPbZ24k1CqRCpA1JOyMLXVJYXcnfw+gXa0meu8/zkpLoBUwigKQllnEYA==", "cc03a2f1-d125-4f0c-a62b-74ce2fc0c55b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d514aa33-c7f5-425b-8d9d-f7e2577445dd", "AQAAAAIAAYagAAAAECCGRTBXiAmyNaZJT2CyjrG6lkpWQquHjFNLMmsWtexABAtAtnMWf4D3dD7+l+Byqg==", "15c0df09-e5d4-4218-a99c-ae0043861cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "273c8324-a16b-4799-b5c1-78a01bc31e4f", "AQAAAAIAAYagAAAAEECOVOzcflQDWaClxJj+v4H3kGeKaQiqXAoKNDKkVdUStRvFFwp4WvYLkYQ1J/RJSA==", "b3096433-6dad-4031-90f7-c61401d65497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38137fc0-3751-43a1-abab-bcc3eaffd357", "AQAAAAIAAYagAAAAENgSs7985YmvjYgKLZCVIAjJlYiQU5tFj+qUMR/zSXnsxKSfcTarCjFJHJ/RvKBOAQ==", "bb07686a-a695-42c3-82d0-d6c4eef0f07b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd57749-92d8-4c79-bf93-93b9522ccbdf", "AQAAAAIAAYagAAAAEFEObDeNF4Em65JwTiffRIgMOVnXtLjZ49EXhFukPSQQ701SYl08xvyz45KyNAYqwA==", "b1c64276-51d6-4834-bd4e-63700be3d265" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09eab610-77fe-4c4a-86a5-b0fbf2ff8ec6", "AQAAAAIAAYagAAAAEP5/A/YixXdFYyWKtbVbKPsWfdZqkmmjYOtdcg9gJe5WgZsf3GNKmCCf6QUVMOfOug==", "182b5fd8-cc2f-4353-80f6-84cc213336e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea238e4-fcaa-4316-adda-d77c2a918db5", "AQAAAAIAAYagAAAAEGuToKOe8T4GNoufhoC7H1aQ32SEgRHhZq9gHO9Dpv8sLFC2TIfuZJM/Tmp9l7xsMQ==", "81f1e9df-550d-459f-8c04-7e2357cb8eb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7477a81-73f9-495b-a19c-8a86ce69ef18", "AQAAAAIAAYagAAAAEMXC2dEmGWdWh/VkKSy07dhA0PajdjJOc/CaPwm6X7ac12+Dy5AocP++ZJHSd6dA8g==", "f3685dfa-caa5-4981-b231-28579e1cbcd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba12f069-8743-40ac-a982-28c0f75af875", "AQAAAAIAAYagAAAAEOaek/I3tc3kIuiEsn3QbrOhGrDlghkfaCjgu36m1PZoliNsl3RKc6ZlYTIROmFP6w==", "7912237e-e65c-4e03-abe0-c74942910f85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1512ebe-ecbc-4256-b229-eb8bef673c60", "AQAAAAIAAYagAAAAEJvM/L/vCOlMil2ZvoliUI7FG+17Hk31xaWWhBiKnew9E3XJaPZavxiYCWzcRCRXAg==", "2cd99796-85d7-4098-9f53-3681a1663c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbaba49e-7720-47a9-84f0-4707f22aed30", "AQAAAAIAAYagAAAAENAw/QSnYvZQZFmuwrHh7yvwwxWuEbrpXkShBcBOwMt88orwyz61MjVG/AODDogNSQ==", "d0747ede-e4f2-4a4b-b98e-07e6c89ac1e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece4a2aa-1c38-4055-af4d-f1e584178300", "AQAAAAIAAYagAAAAEACK4BBdAMR8AjX4IAHXHt8GOFdNwd22hKCC2nBGNsnXyMp4SE6BJQ97OAHtBYDoyw==", "0a808fc4-a4bb-419e-9211-c8c841717c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1bf2888-3754-4be1-8837-3f7f78570210", "AQAAAAIAAYagAAAAEGLSAPOhZGVhg48AoTb3We3L1dGD+T2Kd/M5L4uT4Hf8FsGKoQpQl3lcZhJK9oYbGQ==", "1e9fcc98-1c8a-44c1-835b-b52d16fefc61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3129d709-b556-4b2d-82ce-d3c99e3270ba", "AQAAAAIAAYagAAAAEDojEcxxBQHG2BHRdvrVYRq0uqXltWyaANDojs+vh2hwEiifJ9NrJtlEramrR2rAsQ==", "dcaf5deb-ae63-4f41-92f2-cbd08c06ebf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54942315-4997-430f-8846-e724fed65566", "AQAAAAIAAYagAAAAEBv/zxNW/+pAwabcfpm+gudCb6IQFpf9M29jjvIJpHf2D6dOC/zvz62tgA0myfENcQ==", "bd2b7ad9-8fd9-4a24-b536-4aeb27f48e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6acd2248-3acb-40f6-95a3-fe0b9043816e", "AQAAAAIAAYagAAAAEINAVMwLYiEvJq+L7Xo4bTHAsB9CVTVTOZipwPIHvZorcipJOqjL+k4qv1elsCPJoA==", "ae62afd7-a388-40ed-a972-2a8e6952b0e0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Birthdate",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 14, 16, 44, 973, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0000001-0000-0000-0000-000000000001"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1990, 1, 1), "011971bc-b0ce-4f31-a233-7139229d301f", new DateTime(2025, 6, 1, 14, 16, 43, 976, DateTimeKind.Local).AddTicks(147), null, "Sistem", "Yöneticisi", "AQAAAAIAAYagAAAAEAlWjzWQ58EfVEceyRAb1/f9US4NgbVUqMI4jJTDRejOb0BFmZ5Z2wZlIyYQnr6gDg==", "4446d85b-db4b-44d4-83a4-4ed5d2312a32", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000001"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 5, 10), "1536e5fe-9d9d-4aff-ae2b-c7dcf13cb54a", new DateTime(2025, 6, 1, 14, 16, 44, 18, DateTimeKind.Local).AddTicks(496), null, "Ahmet", "Yıldız", "AQAAAAIAAYagAAAAEHcANyzDXx0Qk7e/vGcypMU9AUrkaKOWPduwH/0AZpSho5GxduFqK3KksxdrxlyOcQ==", "5d075187-dd3f-40f5-827b-471528d2dd79", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000002"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1999, 3, 15), "a7a3490a-b717-41e6-913a-f6e2eff83fbc", new DateTime(2025, 6, 1, 14, 16, 44, 61, DateTimeKind.Local).AddTicks(5951), null, "Büşra", "Demir", "AQAAAAIAAYagAAAAEJRZ0IHmeTAtbzkWjmzQi5cu7Y7naBh53gjTgYS32Hn5tXni6M11nQBoihlRMjlqog==", "40806275-9567-4c9c-aabe-58f908f08746", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000003"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 8, 20), "2fdbd9cf-814b-452c-a141-258a2df90f5b", new DateTime(2025, 6, 1, 14, 16, 44, 104, DateTimeKind.Local).AddTicks(3957), null, "Can", "Kara", "AQAAAAIAAYagAAAAEAhho0DKTB2XGCLgL1jVef6SKyMriXIizgynB90rqRu48/wSzJjO8NNp6/pNwmAL1Q==", "bcac831f-4a67-49c4-bdd1-e7f8f326f765", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000004"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 11, 5), "2b3f1188-9cf0-4e4b-ad50-23be35a62e15", new DateTime(2025, 6, 1, 14, 16, 44, 149, DateTimeKind.Local).AddTicks(9120), null, "Deniz", "Aydın", "AQAAAAIAAYagAAAAEHVdN6z1cNNnz5wghgFvtRjwJbyzZYC8a9GcHK6X8Ug13hQYPskC4frsxnEWrjuAuw==", "a5bf0928-0103-4a86-9719-af0ebbcb8f6f", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000005"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 6, 1), "5f4600c1-d3d4-4b3a-9543-dc1d82647636", new DateTime(2025, 6, 1, 14, 16, 44, 194, DateTimeKind.Local).AddTicks(597), null, "Emre", "Aslan", "AQAAAAIAAYagAAAAEF6TL5uZKhrtCCCpOtLgjut7EoFiLvlemN0eai2iUdWoem6OG0q0nsDafUWXJ5fJEQ==", "72edb15a-c88b-4fa9-8884-d9d0f8e93c54", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000006"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 1, 10), "735cffb6-8a0d-432c-b58f-5cc2e9bbd3d7", new DateTime(2025, 6, 1, 14, 16, 44, 238, DateTimeKind.Local).AddTicks(5654), null, "Fatma", "Çelik", "AQAAAAIAAYagAAAAEGFdzMrnbd2rDVwgvLt1KE5xPYOXpF/Q7dzA9D6KndGhShcVYuO+DI6TYRkBjr3Dxw==", "7628be26-2aa9-4133-843f-c4e0071b4874", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000007"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1999, 12, 15), "1617de97-1eec-4737-a522-fe1a54b20883", new DateTime(2025, 6, 1, 14, 16, 44, 281, DateTimeKind.Local).AddTicks(9353), null, "Gökhan", "Şimşek", "AQAAAAIAAYagAAAAEAFDr/RwwK937gsqNBxMgrDDzwkaypl99gYuG5/3DLzH/3Y68aA7HWV8PTsTN2SPCw==", "f086d2cc-1040-4f6e-84a3-1b434bc2d639", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000008"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 2, 25), "017589f6-adaf-401f-b8ac-4499c5dc3bc5", new DateTime(2025, 6, 1, 14, 16, 44, 325, DateTimeKind.Local).AddTicks(7460), null, "Hale", "Yalçın", "AQAAAAIAAYagAAAAEAWGeZVehhu0jM5h3fsoMHF8m4v+9XsTYO3qt49Nj7WvkCHbKdo8dlmx3DgI651QFA==", "e2cfbe36-2e0d-4791-9715-d65d53f90699", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000009"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 4, 3), "2ac85fd1-b6d2-4f49-a285-06fabe963272", new DateTime(2025, 6, 1, 14, 16, 44, 369, DateTimeKind.Local).AddTicks(2514), null, "İsmail", "Öztürk", "AQAAAAIAAYagAAAAEBpMLACUJflLxPCrX1KpPYFcfohw7IZJJybmKFY6U+FCKobjSv4jHjdQ2BVeepCixg==", "447defeb-f9b3-4fba-8245-5e2e28de866d", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000010"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 9, 9), "7a2ae388-138d-4918-94f9-1bdc72b8af89", new DateTime(2025, 6, 1, 14, 16, 44, 412, DateTimeKind.Local).AddTicks(4227), null, "Jale", "Bilgin", "AQAAAAIAAYagAAAAEBMAQwo7gZeROO7IWZwHTmDHTSeda04BoU38XazjuciBkRnP3TnDnui67PWWKPOsaQ==", "8d893a75-2988-4c4a-89da-48012f8b3b05", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000011"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 5, 12), "ede2997f-8a34-47c4-ae86-5027ed960d5c", new DateTime(2025, 6, 1, 14, 16, 44, 456, DateTimeKind.Local).AddTicks(1187), null, "Kaan", "Bozkurt", "AQAAAAIAAYagAAAAEFj9KPh3yJNbn9iB5yR0x80q90tbxrD3oMcdaOuHzASmsN7/b9gzVay0n1DfV4VOsA==", "8aad5c0c-edc6-4e55-be63-0ed79828a7d0", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000012"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 1, 8), "34944d64-d484-40b8-8591-a438c2440a24", new DateTime(2025, 6, 1, 14, 16, 44, 503, DateTimeKind.Local).AddTicks(7792), null, "Leyla", "Karaca", "AQAAAAIAAYagAAAAEGH0fwK4DkxD1jS0jdViDr2u0OXdOCO/MRbwJen0Jy3K94fiVRDqlr1CrNUqm66GdQ==", "56eac219-b679-4cb8-9a0b-57c5295a4a5c", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000013"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 7, 17), "80635456-1e10-42f4-a2f1-fa6c844b6acf", new DateTime(2025, 6, 1, 14, 16, 44, 548, DateTimeKind.Local).AddTicks(3546), null, "Mert", "Tunç", "AQAAAAIAAYagAAAAEHG2PckGEplGOamkX6biUAhGzO8LP8xssGe/u0G4DVX1CtlXkp91pBSXrdsyESVETA==", "5583356e-0b10-49cf-9755-454b2c3d6941", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000014"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2000, 6, 30), "92c3d06a-f02d-4594-9764-cbcf2e0a25cb", new DateTime(2025, 6, 1, 14, 16, 44, 592, DateTimeKind.Local).AddTicks(5348), null, "Nazlı", "Kurt", "AQAAAAIAAYagAAAAEKoFtnF/jOiW/O9dya3/d3KpAXfCwaReiwY5ECJPIiKlGs9xZVHQ6hZ/i/nwp3AQkg==", "836ab355-1583-4737-a3b6-f39b5f400685", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000015"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(2001, 10, 10), "7cab77fb-49ae-4d29-9044-9e6014b9a7b3", new DateTime(2025, 6, 1, 14, 16, 44, 637, DateTimeKind.Local).AddTicks(7559), null, "Onur", "Yavuz", "AQAAAAIAAYagAAAAENpfrAs5EOFnAQSGXivOcbHadRS5BmtDMrG4QOVSDtIXuyYHH1lrCy4Snif6wfps5g==", "31a92ef6-31f6-46a0-af67-b5e5ab425fa2", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000001"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1985, 6, 10), "13cb0b49-8be1-4338-9e78-77b115c2a7ff", new DateTime(2025, 6, 1, 14, 16, 44, 763, DateTimeKind.Local).AddTicks(1329), null, "Ali", "Yılmaz", "AQAAAAIAAYagAAAAEKflTQqRL+OcrdG/Pg25u7L6AFOS5hFYPcgtLgtQLC7q7Wukp4pTCgfR94FV2aJFaQ==", "62d181a9-2286-4056-986e-827debd574ae", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000002"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1990, 3, 15), "327c4fb7-1407-4596-9d2c-e22961379a11", new DateTime(2025, 6, 1, 14, 16, 44, 804, DateTimeKind.Local).AddTicks(4157), null, "Ayşe", "Demir", "AQAAAAIAAYagAAAAEHCbHLsQV33eSTXwyAwwNwZa4qMSqNMdsQfkGlT3ptMpwOeHotn5SM5yB7QksAAIkA==", "a25326ec-237c-42a8-8bef-170ee82f9470", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000003"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1980, 8, 22), "0ca0289d-d19c-4faa-bf3d-da14898ba7b1", new DateTime(2025, 6, 1, 14, 16, 44, 678, DateTimeKind.Local).AddTicks(8566), null, "Mehmet", "Kaya", "AQAAAAIAAYagAAAAEIl7ELm91CMGZPY8cfu3EhNpVKRZInIfMQK5vK/PLP4RL4nLMw16+HLvcDt76BmCgA==", "a195e29a-3998-4167-b050-6484f21dda26", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000004"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1992, 11, 30), "f378dd3c-6e97-4fa8-8827-02e6cd29cfab", new DateTime(2025, 6, 1, 14, 16, 44, 719, DateTimeKind.Local).AddTicks(5174), null, "Elif", "Aydın", "AQAAAAIAAYagAAAAEAo6JlDbFuTj9t4Qh3DoExRGcB5tx4ts0kvDLtOQArCko6TJEA+ClXOduoydiXLtNg==", "3506800c-20cc-431a-8303-a1c50d8dd075", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000001"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1990, 4, 15), "04d81f05-cffc-4231-9763-362e4d2d06cd", new DateTime(2025, 6, 1, 14, 16, 44, 846, DateTimeKind.Local).AddTicks(2282), null, "Zeynep", "Yılmaz", "AQAAAAIAAYagAAAAEHU78XqwqUPheu4qUNv3NrkJMk0JYQlMkl0BIHDCepdtOSAL4Qe5MU4up2djO2Hrmw==", "3fa004d5-68fe-4dd5-a162-191fdf963eb9", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000002"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1988, 9, 25), "9e86d90c-6182-4ea5-add4-3e59cde6b5d9", new DateTime(2025, 6, 1, 14, 16, 44, 890, DateTimeKind.Local).AddTicks(40), null, "Burak", "Koç", "AQAAAAIAAYagAAAAEG+VDRqya5t94/cVTpwkNlbQ9hNuCIHQHPrPEFVSGc7CUbgKQyNwv1+MkELlgVOV+w==", "18798b9c-8644-452e-8afa-18b6c213921a", 1, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000003"),
                columns: new[] { "Birthdate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "Status", "UpdatedDate" },
                values: new object[] { new DateOnly(1992, 6, 30), "32e7a159-dca7-4e2c-9a0d-d6709da6100b", new DateTime(2025, 6, 1, 14, 16, 44, 931, DateTimeKind.Local).AddTicks(7515), null, "Derya", "Ateş", "AQAAAAIAAYagAAAAECVYEgP9RILcuKWaUmPc1Om9qn/3qkun/ZVBSmirXqDssLb59rNWQIhH9zmwrabPvw==", "8cbdfd54-d923-4a00-9fb1-0b395795de4b", 1, null });
        }
    }
}
