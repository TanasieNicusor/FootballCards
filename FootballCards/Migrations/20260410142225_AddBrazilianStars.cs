using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class AddBrazilianStars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name" },
                values: new object[] { "tbd", "France", true, "Zinedine Zidane" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", true, "Therry Henry", 92 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "France", "Ousmane Dembele", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { false, "Mike Maignan", 87 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { false, "Michael Olise", 86 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/benzemaCard.png", "France", "Karem Benzema", 85 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Rayan Cherki", 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Olivier Giroud", 79 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Kurt Zouma", 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/messi.png", "Argentina", "Lionel Messi", 94 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "Portugal", "Cristiano Ronaldo", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Belgium", "Kevin De Bruyne", 92 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "Norway", "Erling Haaland", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "OvrRating",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "OvrRating",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "OvrRating",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { true, "Ronaldinho", 92 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[,]
                {
                    { 29, "tbd", "Brazil", true, "Pelé", 95 },
                    { 30, "tbd", "Brazil", true, "Ronaldo", 93 },
                    { 31, "tbd", "Brazil", false, "Endrick", 77 },
                    { 32, "tbd", "Brazil", false, "Dante", 78 },
                    { 33, "tbd", "Brazil", false, "Talisca", 82 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name" },
                values: new object[] { "/cards/messi.png", "Argentina", false, "Lionel Messi" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Portugal", false, "Cristiano Ronaldo", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "Belgium", "Kevin De Bruyne", 92 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { true, "Zinedine Zidane", 94 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { true, "Therry Henry", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Norway", "Erling Haaland", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Ousmane Dembele", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Michael Olise", 86 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Mike Maignan", 87 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "France", "Rayan Cherki", 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "France", "Kurt Zouma", 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/benzemaCard.png", "France", "Karem Benzema", 85 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Country", "Name", "OvrRating" },
                values: new object[] { "France", "Olivier Giroud", 79 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "OvrRating",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "OvrRating",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "OvrRating",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { false, "Ederson", 88 });
        }
    }
}
