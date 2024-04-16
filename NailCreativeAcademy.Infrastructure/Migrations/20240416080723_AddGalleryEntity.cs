using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    public partial class AddGalleryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ee2e797-f293-4742-aac7-bdb685b34ecd", "Атанас", "Атанасов", "AQAAAAEAACcQAAAAEMCHWzYPlnyZ2gl/MtTzXtLZ4Vc83A3umCpL9Bv1lXC28MX3D7HK/YWZ1fvPeC/0BQ==", "17c949b9-841e-44cb-9e17-3eb0c06c884d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe016bb-0ec6-4aee-8429-3e1ef4d2b0e2", "Николай", "Николов", "AQAAAAEAACcQAAAAEJZNqX5ewyvzoYI1JeEiDm2fXAlG9f3CfiIyvJy7HVwrVrb6zDdOu2LCLt4gT4L9Pg==", "05ac70e1-380f-446e-8709-2506a4620323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09ba785-d9b3-4beb-9309-f14b0fc825c2", "Таня", "Николова", "AQAAAAEAACcQAAAAEAOFrU4X6O88XxHrIgLqOV+/hnGo8sweFx5WVK3JIAhRdUTWSct6jOCVK3DBbJbNJA==", "f66f01b6-dae7-4f80-91de-95de5fa295fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247c716c-118c-4752-bd59-5d2b8fa0b631", "Иван", "Иванов", "AQAAAAEAACcQAAAAEImJrm3g0SG+ZDm/xPrvsoyYpVqsVgyeFhrm/K+UIOS6TDiRaucHsWGJDLjBzQo8PQ==", "e3778032-ac0a-413f-b30f-e7078c780cd6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a865ce-5b33-4275-a460-dc00683172d2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015035fc-062b-4795-9dd2-63c33d3887b5", "", "", "AQAAAAEAACcQAAAAEKPYInzy1Bx+DQ4nTiUzm0H2GtE2xFeKZh+rsaF9++6c048eDJeviVQZzWG48QFi4g==", "01529072-796e-447b-bdca-3953f9a0d8d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714e73f4716d4cf9946d494ed0d72cf7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "581e9833-663a-49e7-b131-19a6e78499be", "", "", "AQAAAAEAACcQAAAAEKrsKZ9+Tz1Lyg4h4gRuZ8X4V88n8SjeXYOUPgdx5XCi85GS+1p6oUa59USsTu6BQw==", "a2270a33-301a-444c-943e-3519bea6d5a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35914f19-0c98-4b40-b697-488163de3037", "", "", "AQAAAAEAACcQAAAAEKsfpUyQZXPatv6w/9bPRMR+VwAxRvaeaIELFARtJLv4jwKQFkNFt1aRobKiK9JDCQ==", "99c27591-bac2-417b-b567-affe92294c17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf756f58ca9146f2889a54a32cde2dfc",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62a42373-d9a6-4d2a-b1f1-7f13ee23b082", "", "", "AQAAAAEAACcQAAAAEKZFQ4rEQQ2s2vPh9m+gscRejQLvdr2/QRzi82i9gJB+vFSRgajl4rkhkRR2MidVUA==", "4eda4c73-60d9-4725-8adf-8eea5c40a10a" });
        }
    }
}
