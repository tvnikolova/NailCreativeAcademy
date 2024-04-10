using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class AddSaloonName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Saloons",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                comment: "Saloon's name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5023ce6-d3c5-4a00-adea-3e897bc427c1", "AQAAAAEAACcQAAAAEIaYQgoOAmMs+WCqadngRRz8qQ5FLJ3Zs7YJVuyF2uifJWLbBZPJCnBCtfoBOLPIQQ==", "fa59539f-ff0c-4b71-a060-08f67a930df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47220769-53cc-4cf7-a6d1-ee54fad9be17", "AQAAAAEAACcQAAAAEML7PVKfCEkDkN87EiJnTNAFT/cy3TaeCKZwQvatDHDtprWIHU9SWjcd29XUKnJSvA==", "820642bc-ee58-4f01-8d73-defb2745686a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d15be38-8307-48a9-b4e5-c4ac72749a53", "AQAAAAEAACcQAAAAEAEf3HEpSeIM2N1jqRrD0PGgxp99nEoCivq+V2rOY0g1ci8g9OKQh9Lq9jNBcMRxbw==", "36b0b7fd-714d-47aa-9c46-384bfb283a49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0128e81c-9aed-4dbd-883f-a814dd9ef02d", "AQAAAAEAACcQAAAAEEvtCcSkxAcyrG97DdluGAUmWUvmfq4nMhLKdggL2i6om2IqC2XC4yn85TjwQ+rW9g==", "2c2a60e7-f721-4c0f-b112-bc154c4fb8c6" });

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PhoneNumber" },
                values: new object[] { "Nail Creative Saloon", "+359888222555" });

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "PhoneNumber" },
                values: new object[] { "Nail Creative-S Saloon", "+359888333555" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Saloons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57b9ff64-db5c-483f-bfd4-f02858e17e34", "AQAAAAEAACcQAAAAECvbz/KX2jjxsPBgDCbwHLnTnKptmuWNw1MK19ZHs7UNDmSGiNzoFTi/U/9lQ/jLXg==", "c48dee2f-21a1-4252-bc10-17fb3fb33b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae6c78f4-5ff5-4765-b482-1a9cc9a76bbb", "AQAAAAEAACcQAAAAEHNdOlsmPHo89bL6jpqBa/NvWe9Zjj3SGvycZwtnFKXbtMP/4D48rkf4J/maCn3lsQ==", "712c79ea-8eef-4332-a743-c935f203f472" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6757fee8-14db-4a86-9b28-9c8884f325aa", "AQAAAAEAACcQAAAAEEGhmnPuZWy0ieqrAD+Efajj3auFAgvufr2vJ+p0OBnqzPI0yTjQ42eubAx4uZCdxg==", "6d1166c1-fd30-49d7-ab3a-6c554438d59f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a4816d4-bb26-4efa-8d76-256956055a93", "AQAAAAEAACcQAAAAEAddtTf5KMXehvMcVwF5JtSLuQGj/X/G2VDuyhvcBivI7l8KNsReCdD+HFMBVFWiqA==", "d4a4642d-cd03-4084-bfb5-715034c14377" });

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "0888 222 555");

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "0888 222 555");
        }
    }
}
