using System;
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
                    { "68a865ce-5b33-4275-a460-dc00683172d2", 0, "3451a373-38ed-4322-8ea2-1119a46a2e58", "student1@abv.bg", false, false, null, "student1@abv.bg", "student1@abv.bg", "AQAAAAEAACcQAAAAEGso+2xghabP5DWxVm/nCZsur+LiMqPl9oEV+7HAN++yMhZJdDQPEILN5or4nXMb1A==", null, false, "fee3364c-193a-4b8e-8399-67badbf078d5", false, "student1@abv.bg" },
                    { "714e73f4716d4cf9946d494ed0d72cf7", 0, "6bb16938-fce0-4358-bf77-5b3fc179092b", "student2@abv.bg", false, false, null, "student2@abv.bg", "student2@abv.bg", "AQAAAAEAACcQAAAAEAf+E16pJbK9RMzV2Z4ZlfH8p0/WPapqvt5MikEMEhmQmkht8H2IxVouMrmd1e3qww==", null, false, "22c71277-f764-4804-8c89-2967cd8c4976", false, "student2@abv.bg" },
                    { "b8b63dd7e8f14a01b3d4ef4bb901b2e4", 0, "44b0d19d-dbae-443b-8278-ed8bc35e41bb", "t_nikolova1985@abv.bg", false, false, null, "student1@abv.bg", "t_nikolova1985@abv.bg", "AQAAAAEAACcQAAAAEPl1dGmXTMaEmxOz8ylU80lnBlvv87/k8EmEQQ6Jt/2O/uhiBvEvxcEIY1LlUXimvw==", null, false, "19b3410e-adc5-4215-91e7-518e63a48c0c", false, "t_nikolova1985@abv.bg" },
                    { "cf756f58ca9146f2889a54a32cde2dfc", 0, "1af01644-d71d-491e-84ec-426f265881db", "client1@abv.bg", false, false, null, "client1@abv.bg", "client1@abv.bg", "AQAAAAEAACcQAAAAEP7gk55NWV8IAYlCEGbl9FlFF1WNOkZXKaWH0T4r2RQhhMUTn7GGfogxkwCqptGfMQ==", null, false, "0e144c42-ad3d-447e-bbeb-b4e80144100a", false, "client1@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "CourseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Начинаещи" },
                    { 2, "Напреднали" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Екатерина Николова е обучител в академията от 3 години. Тя е със 7 години опит в областта на маникюра. Има няколко първи места от спечелени международни конкурси за маникюр ", "Екатерина", "Николова" },
                    { 2, "Елена Кушниренко е международен съдия и обучител. Тя е майстор с над 10 години опит в областта на маникюра. Създала е програми за основни и надграждащи курсове. Елена е международен съдия и многократен победител в международни конкурси за ноктопластика.", "Елена", "Кушниренко" },
                    { 3, "Евгения Макаренко е обучител по маникюр и педикюр. Тя е с над 11 години опит и е сертифицирана в Украйна. Евгения провежда курсове по класически маникюр, класически педикюр и ноктопластика с гел.", "Евгения", "Макаренко" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseTypeId", "Details", "Duration", "EndDate", "Name", "Price", "Program", "StartDate", "TrainerId" },
                values: new object[] { 1, 1, "Курсът е за:\r\n- за начинаещи,\r\n- за маникюристи, които искат да обогатят знанията си.Състои се от теоретична и практическа част. Включва всички основни знания, от които се нуждае всеки бъдещ маникюрист.\",", "40 часа", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Базов курс по маникюр", 450.00m, "Курсът се състои от:\r\n-Теория - 2 часа дневно\r\n Практика - 6 часа дненво: \r\n- Как правилно да сваляте гел лак с почистващ препарат и да поддържате ноктите на вашите клиенти здрави.\r\n-Третиране на кожичките с подходящ препарат.\r\n- Как да избираме и работим с клещи и ножици.\r\n- Как се прави армировка с основа.\r\n- Как да нанесете гел лак близо до кутикулата.\r\nНашите преподаватели ще ви научат как да поддържате здрав и красив маникюр.", new DateTime(2016, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

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
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc");

            migrationBuilder.DeleteData(
                table: "CourseTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
