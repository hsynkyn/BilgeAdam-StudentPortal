using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.IdenetityMigrations
{
    /// <inheritdoc />
    public partial class hasfirstpasswordchanged_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasFirsPasswordChanged",
                table: "AspNetUsers",
                newName: "HasFirstPasswordChanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 30, 58, 346, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 30, 58, 346, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 30, 58, 346, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("99999999-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 30, 58, 346, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc5db8c-6c8a-4367-9b87-e550aa82fda1", "AQAAAAIAAYagAAAAEEIIJv9+5PIo+0RWshQGkCP4aYWN/FBuIa4fTHGcEfnkPhmiv+R8kg6EyJQ4KX4Lcg==", "7bcd0e46-0e0d-4979-82ff-02dd36f666eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01cf6900-3c94-42e0-9895-129fc1d749d0", true, "AQAAAAIAAYagAAAAEHl56ZBSQazAJDB0OkeeVSgGW96pZtKVKFYW2t10I+BUPLocPjZ2pq2C8fGwocv9EQ==", "95dbb2f0-ed9e-46cf-8aed-284ca8ea46cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f027f33-261c-4831-b2a7-cc38e15a4f33", true, "AQAAAAIAAYagAAAAEFMI2S8+X2Q4bxBkAocr/ce5LDfWyPy3LcQeKE0KrYVQPpWhf1pBtMTb9qImOEuOwA==", "2a3eaab6-95ee-491c-a842-e1b2489e36f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddd328fd-3700-490e-8ee6-222ccb43319a", true, "AQAAAAIAAYagAAAAECZHABWbXCiAkXysPb/ZN2NUBSb2ZOJhhbHdfFa/fWX0P1gPq0FdaqwfL7bFx2g+9w==", "dfef103c-c8aa-4779-9c29-8d28880757df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd133896-076f-4982-a29e-3244d8cb37bb", true, "AQAAAAIAAYagAAAAEALqzpc/LfGebCxBQ1hYhW4X795QQ06iwUQcEHk+1LwyifuBjbAo6Ynh9GzNbLY5Jg==", "5a81f66c-174f-4fbf-b8c1-dc535b432a30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "677cbae7-6c95-4776-9100-68cbfcf9ff4f", true, "AQAAAAIAAYagAAAAEFwFxVBYI4lOLHSdfwqaQh4nSlNtUC7e8yjRMh2Z99sT9vqdMP+rFzP8zS2PELzZSA==", "90938922-1b1c-4786-ae85-4d1964b87b49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df180f31-61cd-48c3-b3d5-82f73c0e4f12", true, "AQAAAAIAAYagAAAAECkaGhEvp7ProrndUTXOgiC2P6Exv9jG72qHiz64McRa6PRZKKbiqUGvI67oPewh3w==", "1df1ab17-513a-49c1-afa3-96ba770af48a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14cce3d8-4c76-4893-89f3-b072ed6e67a5", true, "AQAAAAIAAYagAAAAEE71CR2X8DnlowCAf0T7ne+ZulVW7rTG/0W7+0K9eZUbUbt9T/x7i/CyQB+j9pbMiQ==", "a45deb32-fa52-4752-b8cc-2b659a74265d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd053156-a338-415c-b3f4-0b92bfd708a5", true, "AQAAAAIAAYagAAAAEEQ8n7iHyh+OhFKJj7aJ9guP2hdPNM993zcnI5mQvdlwwliq9lIoz9oqjOeXCpWvZg==", "8c534e25-a216-493e-b211-bf2e12fdb43a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08837f9e-aaa7-4184-9a83-bd5ce5c3bfef", true, "AQAAAAIAAYagAAAAEFtS3YCUjGxOS95mxkdICkMUznkqst0AHVWzzv+1r9EoYiQot/WRq2Ur/Hp5R34JGQ==", "5b4fc0fa-5191-4e6c-9fa5-958cade337cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1903708e-2613-418a-b24b-b7fe4849e5e7", true, "AQAAAAIAAYagAAAAED2FXM1PxtgLivUKiqnf1iVIlwZHty6mCfPzHZoLuTEiVyYHqULi/9nTjNjDRUI7qg==", "e200c697-ae31-4716-a6ac-2f4355ff505f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6d025c-7460-4033-a10a-0d92dee584ab", true, "AQAAAAIAAYagAAAAEEW9NMdTaaiuDfZN5HBRMa3lHcypI9CqYxviSb8D7AatymXz6BwBts/Phm/YgT9C5g==", "0f64631f-69b4-4f39-a29b-e3490f0ef478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e828f6e9-4be8-4d10-ad20-5449786b4d93", true, "AQAAAAIAAYagAAAAENuTCykTofgqZoPxb6TV5z9LRMaJTX8ENO130yOk1ApufzZaNhN/KjWJABlmWjZY0g==", "a55e18b4-2cc1-4fcf-96fe-b26c22a7bfa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4d72e81-9b39-44af-af59-2f1b49611391", true, "AQAAAAIAAYagAAAAEI9s4On1FtHoNJBlg0BJ89E99I0o5Xwojrwtg/6UDcVQc3RdpYEnDh7JNhhue3Wz1Q==", "0b0c8a85-3555-4a7c-864f-dad80f99d100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d97cd4-fd6b-47bc-a35a-fb3556367b56", true, "AQAAAAIAAYagAAAAEDHU7CdelBKDNifsu8V/jdh5/jCGBBEgspEy/ATMmc2y1rHaod/4pRj8x68F5WQ2Dg==", "b27f6829-6c58-441d-94f1-76b8644bd6cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0000001-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed941b7d-245f-421e-aaa9-c9ce046101c0", true, "AQAAAAIAAYagAAAAEJO/jj15hQZ3RWNDibCnLZMKsSDCikJI45k59VEmBP2aWKt2JEuUEFX+Mpf2oBNwBw==", "a1d316c5-db9e-4bc4-9cc0-84ac5ace408a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6d35f8e-611c-40a6-a378-f6151b6275c7", true, "AQAAAAIAAYagAAAAEHcDtfWEVkPksHm5A55QIRR6aCMxxnaWEU799YlR7Dr+1thmGN3o8ldZRfOBzxyTQw==", "17e98580-f5d5-42cd-b04a-0ed1ac24508d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e792e0-bcc5-4512-b0af-82693f1af65f", true, "AQAAAAIAAYagAAAAEEMM1jQShVCcysfcrNjJ9QW1L9il6kftNsmNBMAyRlB5Gxinm1+vLdWCH3QKaoT4LQ==", "bd66c626-f117-4892-81bb-11c0fcb43ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78fd69f6-cf90-4368-8a4c-df3a59dfd197", true, "AQAAAAIAAYagAAAAEFux6iSLkcMEUQzGecNtBFLg95oDXKa+v3MY1G6kfWGdS7ky9FQLEIIpLWJNLc2sLw==", "cbc7b26f-535c-444d-b9de-8e63444c5554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0000001-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "662c3493-4c4c-4dbd-ac3c-0e04e8a0dc40", true, "AQAAAAIAAYagAAAAEEIPb6DcfT6RyR3qiAUbW3/EQTYrWmy9B/MHlHSE1uCqsZnqO/mdLqf+f1To/EKNIQ==", "12d8659b-b229-4e03-8e15-0ed5ab9f3d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be89c74e-e4f0-429f-ab21-dad0e3b4f01f", true, "AQAAAAIAAYagAAAAEPGQ9T8P7j+41p90nLUsshx52oHzSfjjmfFjHV0FJLtzu8Lgs9XyJnaGeRgsB0kTNg==", "7d3c6bce-d7b1-4a81-8ca5-3beb58550deb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0af75712-8e95-4d85-b40b-68f6ffbf7254", true, "AQAAAAIAAYagAAAAEAe2jsmdJ3XXH+AZM78Jo+1AaofGP9QtHlHJ4Hgqh43Xy2emxv9OmsX+a5Iha6CgNw==", "95f7ab6b-9d9b-4398-b1e6-8dc8a0bd89c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0000001-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "HasFirstPasswordChanged", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c46ab1-f779-4a46-b820-f747b7dfa793", true, "AQAAAAIAAYagAAAAEI1TypDMMI/HpSeMm2IBGzqi6FeGIIDh1LLDdwgM50PgUFRq+VVV6B7IJFnDXtRXWA==", "5cd6793a-2a9b-43bd-b272-cf9bbe65749b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasFirstPasswordChanged",
                table: "AspNetUsers",
                newName: "HasFirsPasswordChanged");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e323771b-374a-4a23-9ae5-51f153d69283", "AQAAAAIAAYagAAAAEHb0Gi6+ZPmrZKOFO2AdRLamYKfOJI1W7W8h5RKoNSUlsmd0KeyxoQjja6hAViN2mQ==", "be031a40-6628-4499-8cc6-e77bda21c02a" });

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
    }
}
