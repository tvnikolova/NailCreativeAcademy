using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class AddClientToFeedBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Feedbacks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Identifier of the client to which the feedback is.");

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

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ClientId",
                table: "Feedbacks",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_AspNetUsers_ClientId",
                table: "Feedbacks",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_AspNetUsers_ClientId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ClientId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Feedbacks");

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
        }
    }
}
