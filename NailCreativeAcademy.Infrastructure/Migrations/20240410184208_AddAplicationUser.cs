using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class AddAplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b100b13-52ee-49c2-b03a-5c13f1ea9a5b", "", "", "AQAAAAEAACcQAAAAEPVzFlDvHosuphvgErOzKii467LR+cwPizoB9YIFIA+H8Q1B4WlPi64MPFlzXOYxew==", "ecbd8b2a-1b3c-46ed-a06b-4b7f8e8ddace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f850017d-3610-449e-b6a4-a045f103489f", "", "", "AQAAAAEAACcQAAAAEGtooSf2KMoywXWnzIPbPEqi3jC9fEUf46Y9nwf1RpGmSufXBgP1bGg0wMyQoailxQ==", "b8de93bb-ddf6-464d-8fdd-4237cd14bb86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e69b8920-9a23-4d61-9357-a0fb8726db4c", "", "", "AQAAAAEAACcQAAAAENTsB+Taa0kqSy0XuH3nmRwj2YXAxn808hUQWlKAkhd8JIDDy0cVHbhh24Xb8g2XIg==", "185508eb-2532-4ddf-adb3-20b5ad59cfde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8575222e-69a8-4fed-8cc3-aa65638ab35e", "", "", "AQAAAAEAACcQAAAAEOmPfPH449pdArxAfZ/dtAbLKKRo6S1VZAYbBELEf2cDt5sMhSoURnF2IXD5fsxZ9g==", "005b6c69-22bd-460e-a845-041861b5d4d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e416d56-d6e8-4887-8955-9a5e15d3749f", "AQAAAAEAACcQAAAAEDeTjKTjy3wFH0IUyNP3zKz9VOnFTCSRDnh2WsMAPvf/nGcZjXzDUuMsdnLcM9xC9g==", "91d4a806-c02a-4abb-b139-7b063c1c4806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d99783d-70b5-446d-9415-3ace3214914c", "AQAAAAEAACcQAAAAEIs9ZEilnK2ZeTuZwfoTn9LLgfGzfSRiJo7EOuApJ3+Q54PY4m+gYSuvW6VthDC4wQ==", "ad809ee1-7d84-4454-ad70-4cd06b16a8f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e79ea1d-5b05-4b7c-a8be-e0089d0ab5c0", "AQAAAAEAACcQAAAAEHQNiBbXgSxUaV7nLx1Fazn9yqsxno7Ttr5r6h62aRg9eNJGNwY4mdxPspCGHsXocg==", "2e2203c9-8f7c-41e2-a807-311f55d25467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5a0c4d-6373-45a8-bbb2-bf6c785f36a8", "AQAAAAEAACcQAAAAEG/xf54pBjfqts0U0J8L2KzaAwMExY76r99cVk3AGq3Sulaym7burX53laKv6TMfiA==", "b05c1468-96c9-4a15-87a2-37bff56736b4" });
        }
    }
}
