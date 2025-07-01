using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.IdenetityMigrations
{
    /// <inheritdoc />
    public partial class has_first_password_changed_added_to_appuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasFirsPasswordChanged",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 17, 45, 149, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 17, 45, 149, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 17, 45, 149, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 17, 45, 149, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e323771b-374a-4a23-9ae5-51f153d69283", false, "AQAAAAIAAYagAAAAEHb0Gi6+ZPmrZKOFO2AdRLamYKfOJI1W7W8h5RKoNSUlsmd0KeyxoQjja6hAViN2mQ==", "be031a40-6628-4499-8cc6-e77bda21c02a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2bcf171-8894-4560-96e1-2afd90e69240", false, "AQAAAAIAAYagAAAAEGXlaVtM3nCHWUdiq8+hoTbbxNOn21mMfRGzuTZH45GtedMehMn/6VIBvjNOEg8PGQ==", "6c637735-3e6d-4098-b27e-8d44355e41c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2bf8548-246e-4c55-9f45-8a14be2ebc16", false, "AQAAAAIAAYagAAAAEKZ+dmECMsHu0tPfjgAlfRu2luOV26i2OLFFcjRJRDf0773PFrfB3G7rICEeaOnH4w==", "edd59b3b-32bd-4d30-9cb6-25dd85cf69f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89335cd9-66d3-4b4c-8e30-2e3702e51ecf", false, "AQAAAAIAAYagAAAAEAsRfWBL4JNeWPLbYoSepTKPDUmhZWbUKTznAwEdAb8Q8ZH34ILDUSfdwhaFsHddPg==", "a9e09ce1-4b08-453a-b0cc-088f68c8f24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "825e8838-2924-48a2-a718-6f084ba5344f", false, "AQAAAAIAAYagAAAAELTFzCpljo2AIdC/vLxVRK8wjb42nPaSJO1sd3m6ITyHZeFKfXbWki1STr07+bwwUA==", "3b635330-648b-4711-af52-13b4c024e28c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b00c09-c189-498d-b1b9-e29106266fbd", false, "AQAAAAIAAYagAAAAEHWf7vWqVRPWv9zgfGJcPM177JRp0q+XW3poUKzDlSxM0yGpeu7XWlywKGwqCuU7rQ==", "2f01ca5b-04be-4c2b-a4f4-2529b89e46eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06af1710-fbdc-46ee-aed5-e3097c5bb910", false, "AQAAAAIAAYagAAAAEIfZ227eRLElAHU7jT7JqYqr2LjkTrLis0DRhB1Bf0RtkE4r9JzQtN+Od/S2XL7X2Q==", "f62def0c-e7e9-4d0b-9710-631941888e90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ef52080-19c4-4ae7-a151-3b791cbe0464", false, "AQAAAAIAAYagAAAAEM8HlVegbc/fwtS7VJtK3C4QWVB2tVDDE5cRUgIkunYHxFlaJ6zN9vsW6BXdrZDt+A==", "2382917e-37f9-488e-b2cf-70c38c43be6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83dfc2df-3296-4639-b62a-bcf99e632c7b", false, "AQAAAAIAAYagAAAAEKzXHUhx1nAktdOZtWCkz5PjU/WwHXi8N0pTRCum0HQpI9olSY3OhNF3KNM/JA80jw==", "4dfa7b7e-8299-440b-ad7e-4d839e1a2e98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50bd2201-dc33-4703-8362-7861c2b42f78", false, "AQAAAAIAAYagAAAAEOgnISPzTGV1KYOF+ewpl2NxvpgY0tyEywpzDKkycPOca/qDWeA9K/5jrzTL+4R/GQ==", "de781751-6e6d-4822-a2c0-f67e38591dd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b416bc1d-633a-472b-b029-9e057cc5bc94", false, "AQAAAAIAAYagAAAAEI1I5IlZbgd/WamLsqiZFbuHREN1JLFB0lrWXBirT127Nv4nku1k2HM8k0IitygbZg==", "7fc54991-8478-4f4a-ae8e-5765d25eca61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "885c52d8-ca73-441b-a5b8-50af4320c991", false, "AQAAAAIAAYagAAAAEMDtWR0qjw6wxfeFZvc+EMGWj/OS27RYNOTBCTNtE17HbIwZvLS9ABBhYP/hzLEBTg==", "c9b2510d-3abc-406a-8813-c543da6f37dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0347ded-3fa9-4d38-9f85-78e75dc7daaa", false, "AQAAAAIAAYagAAAAEOmMpC856qzGJ5eMRMdoUpk7jmWGugFtNviLWvGV0otoECjR03LZvpmUL1sy6KgICQ==", "181ce716-e011-44d5-8181-6dfdb72a9965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4470b66-45df-4d7d-932e-38e93c8d127a", false, "AQAAAAIAAYagAAAAENdFSnWHg25HXCm/fMCVyI1fYbBIL1tobrNZICDRn7qH5bNULuEfF94ZT1CIsLR7zg==", "c7566ef3-dd08-4656-9cdc-dbdbe4fe15e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d7182d-501b-44fa-b785-988d3a324aea", false, "AQAAAAIAAYagAAAAEO1dOLkCZUj9pokDSFQo0T3wE41di9w5W/8LHpAEzCCzJWSHXpPaSTKHKynssbx0FA==", "d292af1d-d0ed-47a7-99ec-355d4a1f824b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9de1629e-e0ec-4c68-9115-f590608518a4", false, "AQAAAAIAAYagAAAAELTMeQ1s3jRXaOwbddccg2RBHTHDUMq4RhVFcQs4tzBI0xlB7+mzWgirl3iMuJfIvA==", "a037099e-4567-483f-8cc6-c92552cff9a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d41620a-17b5-49f6-a5ef-43e4834d546a", false, "AQAAAAIAAYagAAAAEFiFMFxs9KRYYAqjDARAi8dPX/CCPA56dpWAQINWzqX+Obuv/FqVdx2hV2eDYFtydw==", "80b6c450-ff69-48d4-8336-05b7d86feb8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ded0fe-c00d-4ce8-b789-5982ae3703f0", false, "AQAAAAIAAYagAAAAEAPLNYvMcWsDM/KPRqw8yxN7ESTH0l64r/GTJnytArMDVvjENXSWD9JlbdPhjzmuAQ==", "ee0bcd91-3fbd-45e3-9b67-7176fbc65f7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e9d7e0b-7b78-449c-9013-e09a03fbeaca", false, "AQAAAAIAAYagAAAAEPTpYJL2G1/Nb1y91uh25luSrvbggjgw9y9A+38CuqoIhmD0TpX4JBl3THGdH32TjA==", "5439356f-79d5-4e64-8f86-f50bf1aeb8de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7123e04-78ea-4b2d-90f6-70cca048f977", false, "AQAAAAIAAYagAAAAELpy8mMXidmft5Hc4HzESABEf4fe3KSFrsqFq5me9pcbAD2dHctKl2vuWJemBaeMrQ==", "78a559cb-f212-4783-b2d0-558cdecd2140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21994df-1906-4e6d-9193-5b1ed8371f55", false, "AQAAAAIAAYagAAAAEHFRTJO4eWX+VbevEv0PSdTDcYJQknPpZh+Eqcs+VDQj7t+zV/WJ9HD719mh3c0HMQ==", "6762f506-8af2-4188-8748-e3b5edf636c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6587a673-1cc3-4156-a205-d330eb390f73", false, "AQAAAAIAAYagAAAAEE3RqBGiuhsmOlsv22iOII0mhmmoAeIdYp0GkDEyU35KEsklRTBC5BXcgjTSwhwa0g==", "4becf55c-264c-419c-bdfe-e79546e26036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirsPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c74727a3-27ae-49d3-a2ab-eb732e776427", false, "AQAAAAIAAYagAAAAEJ9BotEdcOrB50gWAVo9FkvTziSQ7iLXCtjlkCAxMnHsy9jcG41/CAZKMWs+zeQcVA==", "c751c3fb-9292-4a8c-90ef-2d56bf1672a9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasFirsPasswordChanged",
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
    }
}
