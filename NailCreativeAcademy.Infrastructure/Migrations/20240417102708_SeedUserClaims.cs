using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class SeedUserClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Таня Николова", "b8b63dd7e8f14a01b3d4ef4bb901b2e4" },
                    { 2, "user:fullname", "Атанас Атанасов", "68a865ce-5b33-4275-a460-dc00683172d2" },
                    { 3, "user:fullname", "Николай Николов", "714e73f4716d4cf9946d494ed0d72cf7" },
                    { 4, "user:fullname", "Иван Иванов", "cf756f58ca9146f2889a54a32cde2dfc" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32158fb0-2e68-4d8f-be71-561f8bb58dfb", "AQAAAAEAACcQAAAAEEHpShZ7JB3ES3pjlmVUfIpWGeYJgQGFrVVDqE5RZ+YRrjiKj1bG5ROggjQ8qPv13g==", "e1e139c9-d1f4-4a54-8889-83e197d80f46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b710621-baf8-4fbf-a11e-10b48bfc2c3a", "AQAAAAEAACcQAAAAEAFmRetqw2t1fPLna9rEk+yOj2dh3tyFHO0UpUCgy9a+1FqInLhwVxZTiQsRwVR8gw==", "3e9d42ce-cd7e-49b3-922b-a9b710bdddd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f84759f-c052-4c1d-8ccf-1005ca3df01f", "AQAAAAEAACcQAAAAEO6dLdmWP7G4qb6WNQtNYy7gfevbCQAiRRj4pZfnE5eXANw4j5rXRuvtL6Al4gphzQ==", "ac96122a-3e56-4303-83e1-b88a39472ef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ca1b639-e9aa-43d1-981f-dd61c8e5f565", "AQAAAAEAACcQAAAAELgGjtIwXgMGcBBHZ5okUe5GPLHPegc6LJ0yynWVKyWL/MXSWaEP13nFoOUvx8sKmA==", "2f63d5f8-8a72-4218-ad8b-da9f53187044" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ee2e797-f293-4742-aac7-bdb685b34ecd", "AQAAAAEAACcQAAAAEMCHWzYPlnyZ2gl/MtTzXtLZ4Vc83A3umCpL9Bv1lXC28MX3D7HK/YWZ1fvPeC/0BQ==", "17c949b9-841e-44cb-9e17-3eb0c06c884d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe016bb-0ec6-4aee-8429-3e1ef4d2b0e2", "AQAAAAEAACcQAAAAEJZNqX5ewyvzoYI1JeEiDm2fXAlG9f3CfiIyvJy7HVwrVrb6zDdOu2LCLt4gT4L9Pg==", "05ac70e1-380f-446e-8709-2506a4620323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09ba785-d9b3-4beb-9309-f14b0fc825c2", "AQAAAAEAACcQAAAAEAOFrU4X6O88XxHrIgLqOV+/hnGo8sweFx5WVK3JIAhRdUTWSct6jOCVK3DBbJbNJA==", "f66f01b6-dae7-4f80-91de-95de5fa295fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247c716c-118c-4752-bd59-5d2b8fa0b631", "AQAAAAEAACcQAAAAEImJrm3g0SG+ZDm/xPrvsoyYpVqsVgyeFhrm/K+UIOS6TDiRaucHsWGJDLjBzQo8PQ==", "e3778032-ac0a-413f-b30f-e7078c780cd6" });
        }
    }
}
