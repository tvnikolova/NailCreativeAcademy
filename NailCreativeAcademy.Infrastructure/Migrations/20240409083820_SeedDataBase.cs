using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "68a865ce-5b33-4275-a460-dc00683172d2", 0, "57b9ff64-db5c-483f-bfd4-f02858e17e34", "student1@abv.bg", false, false, null, "STUDENT1@ABV.BG", "STUDENT1@ABV.BG", "AQAAAAEAACcQAAAAECvbz/KX2jjxsPBgDCbwHLnTnKptmuWNw1MK19ZHs7UNDmSGiNzoFTi/U/9lQ/jLXg==", null, false, "c48dee2f-21a1-4252-bc10-17fb3fb33b85", false, "student1@abv.bg" },
                    { "714e73f4716d4cf9946d494ed0d72cf7", 0, "ae6c78f4-5ff5-4765-b482-1a9cc9a76bbb", "student2@abv.bg", false, false, null, "STUDENT2@ABV.BG", "STUDENT2@ABV.BG", "AQAAAAEAACcQAAAAEHNdOlsmPHo89bL6jpqBa/NvWe9Zjj3SGvycZwtnFKXbtMP/4D48rkf4J/maCn3lsQ==", null, false, "712c79ea-8eef-4332-a743-c935f203f472", false, "student2@abv.bg" },
                    { "b8b63dd7e8f14a01b3d4ef4bb901b2e4", 0, "6757fee8-14db-4a86-9b28-9c8884f325aa", "t_nikolova1985@abv.bg", false, false, null, "T_NIKOLOVA1985@ABV.BG", "T_NIKOLOVA1985@ABV.BG", "AQAAAAEAACcQAAAAEEGhmnPuZWy0ieqrAD+Efajj3auFAgvufr2vJ+p0OBnqzPI0yTjQ42eubAx4uZCdxg==", null, false, "6d1166c1-fd30-49d7-ab3a-6c554438d59f", false, "t_nikolova1985@abv.bg" },
                    { "cf756f58ca9146f2889a54a32cde2dfc", 0, "8a4816d4-bb26-4efa-8d76-256956055a93", "client1@abv.bg", false, false, null, "CLIENT1@ABV.BG", "CLIENT1@ABV.BG", "AQAAAAEAACcQAAAAEAddtTf5KMXehvMcVwF5JtSLuQGj/X/G2VDuyhvcBivI7l8KNsReCdD+HFMBVFWiqA==", null, false, "d4a4642d-cd03-4084-bfb5-715034c14377", false, "client1@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "CoursesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Начинаещи" },
                    { 2, "Напреднали" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "Name" },
                values: new object[,]
                {
                    { 1, "Екатерина Николова е обучител в академията от 3 години. Тя е със 7 години опит в областта на маникюра. Има няколко първи места от спечелени международни конкурси за маникюр ", "Екатерина Николова" },
                    { 2, "Елена Кушниренко е международен съдия и обучител. Тя е майстор с над 10 години опит в областта на маникюра. Създала е програми за основни и надграждащи курсове. Елена е международен съдия и многократен победител в международни конкурси за ноктопластика.", "Елена Кушниренко" },
                    { 3, "Диана Александровна е обучител по маникюр и педикюр. Тя е с над 11 години опит и е сертифицирана в Украйна. Диана провежда курсове по класически маникюр, класически педикюр и ноктопластика с гел.", "Диана Александровна" }
                });

            migrationBuilder.InsertData(
                table: "Saloons",
                columns: new[] { "Id", "Address", "ClientId", "PhoneNumber" },
                values: new object[] { 1, "Пазарджик, бул. \"България\" 2", "cf756f58ca9146f2889a54a32cde2dfc", "0888 222 555" });

            migrationBuilder.InsertData(
                table: "Saloons",
                columns: new[] { "Id", "Address", "ClientId", "PhoneNumber" },
                values: new object[] { 2, "София, пл. \"Света Неделя\" 5", "68a865ce-5b33-4275-a460-dc00683172d2", "0888 222 555" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4");

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc");
        }
    }
}
