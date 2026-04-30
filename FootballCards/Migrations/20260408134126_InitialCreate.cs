using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OvrRating = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundPicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "BackgroundPicture", "Name", "OvrRating", "Picture" },
                values: new object[,]
                {
                    { 1, "tbd", "Lionel Messi", 94, "tbd" },
                    { 2, "tbd", "Cristiano Ronaldo", 91, "tbd" },
                    { 3, "tbd", "Kylian Mbappe", 93, "tbd" },
                    { 4, "tbd", "Kevin De Bruyne", 92, "tbd" },
                    { 5, "tbd", "Erling Haaland", 91, "tbd" },
                    { 6, "tbd", "Mohamed Salah", 90, "tbd" },
                    { 7, "tbd", "Virgil van Dijk", 89, "tbd" },
                    { 8, "tbd", "Thibaut Courtois", 90, "tbd" },
                    { 9, "tbd", "Robert Lewandowski", 91, "tbd" },
                    { 10, "tbd", "Karem Benzema", 91, "tbd" },
                    { 11, "tbd", "Luka Modric", 89, "tbd" },
                    { 12, "tbd", "Vinicius Jr", 89, "tbd" },
                    { 13, "tbd", "Neymar Jr", 89, "tbd" },
                    { 14, "tbd", "Heung Min Son", 88, "tbd" },
                    { 15, "tbd", "Harry Kane", 89, "tbd" },
                    { 16, "tbd", "Alisson", 89, "tbd" },
                    { 17, "tbd", "Joshua Kimmich", 89, "tbd" },
                    { 18, "tbd", "Casemiro", 89, "tbd" },
                    { 19, "tbd", "Ederson", 88, "tbd" },
                    { 20, "tbd", "Ruben Dias", 88, "tbd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
