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
                    { "68a865ce-5b33-4275-a460-dc00683172d2", 0, "55158165-0366-400d-a56b-d6f07551064d", "student1@abv.bg", false, false, null, "student1@abv.bg", "student1@abv.bg", "AQAAAAEAACcQAAAAEKVDipW2681dfjty6iNCzhCj/eesI3hS6eH6QjJweKEA3jYih1UwxLMDwKJK7PJ3Jg==", null, false, "6f979a33-7c6e-4dab-8c4a-148efe79983f", false, "student1@abv.bg" },
                    { "714e73f4716d4cf9946d494ed0d72cf7", 0, "3cd8885f-6d25-48a9-b30b-39648506a0d5", "student2@abv.bg", false, false, null, "student2@abv.bg", "student2@abv.bg", "AQAAAAEAACcQAAAAEAIHcfGcuXIPbKUpSW+ZtzvcIgoOe38Mr4yhDkjgNed5veib5RXE3E44MsU6pg2/bg==", null, false, "78282afc-6a9a-42db-b2c5-46a22e4233be", false, "student2@abv.bg" },
                    { "b8b63dd7e8f14a01b3d4ef4bb901b2e4", 0, "66b08e31-7968-4235-b096-cd17dc7d3f1f", "t_nikolova1985@abv.bg", false, false, null, "student1@abv.bg", "t_nikolova1985@abv.bg", "AQAAAAEAACcQAAAAEKErmbvEiTTBuAMx8GbcYZljfLo7WI8cALkWH545xfTRnmlSARzoaeSdpDZRcXBf0g==", null, false, "9d7ef027-4fc1-4904-a69f-e65bde5c9629", false, "t_nikolova1985@abv.bg" },
                    { "cf756f58ca9146f2889a54a32cde2dfc", 0, "879d315e-8058-4ee1-bb40-5aa14cdf2d7e", "client1@abv.bg", false, false, null, "client1@abv.bg", "client1@abv.bg", "AQAAAAEAACcQAAAAEGpGPkP8Nd8ZtKtY4zzS52RaaHKMROr2pEQxfK7KYp2YUHlG8wS2g3/inBNCIhWuPQ==", null, false, "cc62363b-b6e4-4bc0-8454-1634c2b8d7e7", false, "client1@abv.bg" }
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
