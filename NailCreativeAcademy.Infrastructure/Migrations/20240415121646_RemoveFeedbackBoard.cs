using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class RemoveFeedbackBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbacksBoards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015035fc-062b-4795-9dd2-63c33d3887b5", "AQAAAAEAACcQAAAAEKPYInzy1Bx+DQ4nTiUzm0H2GtE2xFeKZh+rsaF9++6c048eDJeviVQZzWG48QFi4g==", "01529072-796e-447b-bdca-3953f9a0d8d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "581e9833-663a-49e7-b131-19a6e78499be", "AQAAAAEAACcQAAAAEKrsKZ9+Tz1Lyg4h4gRuZ8X4V88n8SjeXYOUPgdx5XCi85GS+1p6oUa59USsTu6BQw==", "a2270a33-301a-444c-943e-3519bea6d5a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35914f19-0c98-4b40-b697-488163de3037", "AQAAAAEAACcQAAAAEKsfpUyQZXPatv6w/9bPRMR+VwAxRvaeaIELFARtJLv4jwKQFkNFt1aRobKiK9JDCQ==", "99c27591-bac2-417b-b567-affe92294c17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62a42373-d9a6-4d2a-b1f1-7f13ee23b082", "AQAAAAEAACcQAAAAEKZFQ4rEQQ2s2vPh9m+gscRejQLvdr2/QRzi82i9gJB+vFSRgajl4rkhkRR2MidVUA==", "4eda4c73-60d9-4725-8adf-8eea5c40a10a" });

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Nail Creative");

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Nail Creative-S");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedbacksBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Feedback's board identifier")
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbacksBoards", x => x.Id);
                });

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

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Nail Creative Saloon");

            migrationBuilder.UpdateData(
                table: "Saloons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Nail Creative-S Saloon");
        }
    }
}
