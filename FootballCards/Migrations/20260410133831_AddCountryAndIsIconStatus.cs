using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryAndIsIconStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsIcon",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "IsIcon" },
                values: new object[] { "Argentina", false });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "IsIcon" },
                values: new object[] { "Portugal", false });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Country", "IsIcon", "OvrRating" },
                values: new object[] { "France", false, 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Country", "IsIcon" },
                values: new object[] { "Belgium", false });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", true, "Zinedine Zidane", 94 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", true, "Therry Henry", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Norway", false, "Erling Haaland", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Country", "IsIcon", "Name" },
                values: new object[] { "France", false, "Ousmane Dembele" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", false, "Michael Olise", 86 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", false, "Mike Maignan", 87 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", false, "Rayan Cherki", 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", false, "Kurt Zouma", 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/benzemaCard.png", "France", false, "Karem Benzema", 85 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "France", false, "Olivier Giroud", 79 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Egypt", false, "Mohamed Salah", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Country", "IsIcon", "Name" },
                values: new object[] { "Netherlands", false, "Virgil van Dijk" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Belgium", false, "Thibaut Courtois", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Poland", false, "Robert Lewandowski", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Croatia", false, "Luka Modric", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "Brazil", false, "Vinicius Jr", 89 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[,]
                {
                    { 21, "tbd", "Brazil", false, "Neymar Jr", 89 },
                    { 22, "tbd", "South Korea", false, "Heung Min Son", 88 },
                    { 23, "tbd", "England", false, "Harry Kane", 89 },
                    { 24, "tbd", "Brazil", false, "Alisson", 89 },
                    { 25, "tbd", "Germany", false, "Joshua Kimmich", 89 },
                    { 26, "tbd", "Brazil", false, "Casemiro", 89 },
                    { 27, "tbd", "Brazil", false, "Ederson", 88 },
                    { 28, "tbd", "Portugal", false, "Ruben Dias", 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "IsIcon",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "OvrRating",
                value: 93);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Erling Haaland", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Mohamed Salah", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Virgil van Dijk", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Thibaut Courtois");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Robert Lewandowski", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Karem Benzema", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Luka Modric", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Vinicius Jr", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Name", "OvrRating" },
                values: new object[] { "tbd", "Neymar Jr", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Heung Min Son", 88 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Harry Kane", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Alisson");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Joshua Kimmich", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Casemiro", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Ederson", 88 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "OvrRating" },
                values: new object[] { "Ruben Dias", 88 });
        }
    }
}
