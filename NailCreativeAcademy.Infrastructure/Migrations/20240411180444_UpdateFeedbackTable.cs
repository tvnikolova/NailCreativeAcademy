using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class UpdateFeedbackTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_FeedbacksBoards_FeedbackBoardId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_FeedbackBoardId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackBoardId",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d50bd44-976e-4471-a16d-a160b2bcfe33", "AQAAAAEAACcQAAAAEB2/lfaZF1pn7p6KxdS7eWAn7w8X+Qxsqr6nJu8ZGXdd5pnkeWtw6sn491PQ41kquw==", "cda73f69-6f1f-41d9-8e69-87505e0a2995" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efba8e61-0071-44d8-9c23-54ab62b6d6cc", "AQAAAAEAACcQAAAAENZhezHllYGoVtXwD6P5TTmVvhnxmsz7Rb55+sldO7Na5d2N6rYyyaLAdRKyiG2o0w==", "e0664b52-fc0d-4e73-8d84-5485c9a6c19e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03788902-9d63-43a1-9edd-38effdd81cf3", "AQAAAAEAACcQAAAAEGRElfeI6xf6Pex6WIyesv8XBM/Df3F+M5yGSvYNoX8d19MtDrwJz42B0NbePLH0aA==", "5ad122e0-a6a4-4f34-ac46-e7609b6de959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ebf456-6414-40cf-a483-4ee9a906b0b7", "AQAAAAEAACcQAAAAEDy8bzRu8+KujjSH4JwSAJav9Sta/4hY8rtcrv5nD9Nu62wNIkHfrMnuV77fl1KnPQ==", "cb9600d2-953d-4973-ba34-4249afbdb37b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeedbackBoardId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "FeedbackBoard identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b100b13-52ee-49c2-b03a-5c13f1ea9a5b", "AQAAAAEAACcQAAAAEPVzFlDvHosuphvgErOzKii467LR+cwPizoB9YIFIA+H8Q1B4WlPi64MPFlzXOYxew==", "ecbd8b2a-1b3c-46ed-a06b-4b7f8e8ddace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f850017d-3610-449e-b6a4-a045f103489f", "AQAAAAEAACcQAAAAEGtooSf2KMoywXWnzIPbPEqi3jC9fEUf46Y9nwf1RpGmSufXBgP1bGg0wMyQoailxQ==", "b8de93bb-ddf6-464d-8fdd-4237cd14bb86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e69b8920-9a23-4d61-9357-a0fb8726db4c", "AQAAAAEAACcQAAAAENTsB+Taa0kqSy0XuH3nmRwj2YXAxn808hUQWlKAkhd8JIDDy0cVHbhh24Xb8g2XIg==", "185508eb-2532-4ddf-adb3-20b5ad59cfde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8575222e-69a8-4fed-8cc3-aa65638ab35e", "AQAAAAEAACcQAAAAEOmPfPH449pdArxAfZ/dtAbLKKRo6S1VZAYbBELEf2cDt5sMhSoURnF2IXD5fsxZ9g==", "005b6c69-22bd-460e-a845-041861b5d4d3" });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FeedbackBoardId",
                table: "Feedbacks",
                column: "FeedbackBoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_FeedbacksBoards_FeedbackBoardId",
                table: "Feedbacks",
                column: "FeedbackBoardId",
                principalTable: "FeedbacksBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
