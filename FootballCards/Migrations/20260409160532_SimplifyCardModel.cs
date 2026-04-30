using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class SimplifyCardModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundPicture",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Cards",
                newName: "CardImage");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardImage",
                value: "/cards/mbappeCard.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardImage",
                table: "Cards",
                newName: "Picture");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundPicture",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "BackgroundPicture",
                value: "/backgrounds/argentinaFlag.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundPicture", "Picture" },
                values: new object[] { "/backgrounds/franceFlag.png", "/cards/mbappe.png" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "BackgroundPicture",
                value: "tbd");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "BackgroundPicture",
                value: "tbd");
        }
    }
}
