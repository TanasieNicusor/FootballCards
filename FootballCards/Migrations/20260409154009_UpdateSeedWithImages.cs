using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundPicture", "Picture" },
                values: new object[] { "/backgrounds/argentinaFlag.png", "/cards/messi.png" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundPicture", "Picture" },
                values: new object[] { "/backgrounds/franceFlag.png", "/cards/mbappe.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundPicture", "Picture" },
                values: new object[] { "tbd", "tbd" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundPicture", "Picture" },
                values: new object[] { "tbd", "tbd" });
        }
    }
}
