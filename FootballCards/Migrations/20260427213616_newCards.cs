using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class newCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "OvrRating",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "OvrRating",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "OvrRating",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "OvrRating",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/peleCard.png", "Brazil", true, "Pelé", 96 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/ronaldonazarioCard.png", "Brazil", true, "Ronaldo", 93 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name" },
                values: new object[] { "/cards/Brazil/ronaldinhoCard.png", "Brazil", true, "Ronaldinho" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/vinijrCard.png", "Brazil", "Vinicius Jr", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/alissonCard.png", "Brazil", "Alisson", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/neymarCard.png", "Brazil", "Neymar Jr", 83 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/taliscaCard.png", "Brazil", "Talisca", 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/casemiroCard.png", "Brazil", "Casemiro", 80 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/danteCard.png", "Brazil", "Dante", 78 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CardImage", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/endrickCard.png", "Endrick", 77 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/maradonaCard.png", "Argentina", true, "Maradona", 95 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/lautaroCard.png", "Argentina", "Lautaro Martinez", 87 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/dybalaCard.png", "Argentina", "Paulo Dybala", 84 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/messiCard.png", "Argentina", "Lionel Messi", 83 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/icardiCard.png", "Argentina", "Mauro Icardi", 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/garnachoCard.png", "Argentina", "Garnacho", 77 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/banegaCard.png", "Argentina", false, "Banega", 73 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { true, "Eusébio", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", false, "Vitihna", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", false, "Ruben Dias", 85 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", "Cristiano Ronaldo", 83 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", "Renato Sanches", 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", "Ricardo Pereira", 73 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[,]
                {
                    { 34, "tbd", "Belgium", false, "Thibaut Courtois", 86 },
                    { 35, "tbd", "Belgium", false, "Kevin De Bruyne", 84 },
                    { 36, "tbd", "Belgium", false, "Axel Witsel", 74 },
                    { 37, "tbd", "Canada", false, "Alphonso Davies", 83 },
                    { 38, "tbd", "Netherlands", true, "Cruyff", 94 },
                    { 39, "tbd", "Netherlands", false, "Virgil van Dijk", 90 },
                    { 40, "tbd", "Netherlands", false, "Cody Gakpo", 84 },
                    { 41, "tbd", "Netherlands", false, "Noa Lang", 80 },
                    { 42, "tbd", "Netherlands", false, "Georginio Wijnaldum", 75 },
                    { 43, "tbd", "Croatia", false, "Luka Modric", 83 },
                    { 44, "tbd", "Mexico", false, "Ochoa", 72 },
                    { 45, "tbd", "Mexico", false, "Santiago Giménez", 77 },
                    { 46, "tbd", "USA", false, "Christian Pulisic", 83 },
                    { 47, "tbd", "USA", false, "Yunus Musah", 72 },
                    { 48, "tbd", "Australia", false, "Mathew Ryan", 77 },
                    { 49, "tbd", "Iraq", false, "Ali Adnan", 72 },
                    { 50, "tbd", "Iran", false, "Mehdi Taremi", 77 },
                    { 51, "tbd", "Japan", false, "Kaoru Mitoma", 82 },
                    { 52, "tbd", "Jordan", false, "Musa Al Tamari", 75 },
                    { 53, "tbd", "South Korea", false, "Heung Min Son", 83 },
                    { 54, "tbd", "South Korea", false, "Min Jae Kim", 82 },
                    { 55, "tbd", "Saudi Arabia", false, "Salem Al Dawsari", 81 },
                    { 56, "tbd", "Qatar", false, "Akram Afif", 75 },
                    { 57, "tbd", "Uzbekistan", false, "Abdukodir Khusanov", 78 },
                    { 58, "tbd", "Algeria", false, "Riyad Mahrez", 82 },
                    { 59, "tbd", "Algeria", false, "Bentaleb", 76 },
                    { 60, "tbd", "Capo Verde", false, "Cabo Verde", 77 },
                    { 61, "tbd", "Congo DR", false, "Yoane Wissa", 82 },
                    { 62, "tbd", "Côte d'Ivoire", true, "Drogba", 90 },
                    { 63, "tbd", "Côte d'Ivoire", false, "Evan Ndicka", 81 },
                    { 64, "tbd", "Egypt", false, "Mohamed Salah", 88 },
                    { 65, "tbd", "Ghana", false, "Iñaki Williams", 83 },
                    { 66, "tbd", "Morocco", false, "Achraf Hakimi", 89 },
                    { 67, "tbd", "Morocco", false, "Brahim Díaz", 81 },
                    { 68, "tbd", "Senegal", false, "Sadio Mané", 84 },
                    { 69, "tbd", "South Africa", false, "Siyabonga Ngezana", 81 },
                    { 70, "tbd", "Tunisia", false, "Ellyes Skhiri", 80 },
                    { 71, "tbd", "Curaçao", false, "Riechedly Bazoer", 74 },
                    { 72, "tbd", "Haiti", false, "Bellegarde", 76 },
                    { 73, "tbd", "Panama", false, "Amir Murillo", 77 },
                    { 74, "tbd", "Columbia", false, "Luis Díaz", 85 },
                    { 75, "tbd", "Ecuador", false, "Moisés Caicedo", 86 },
                    { 76, "tbd", "Ecuador", false, "Willian Pacho", 85 },
                    { 77, "tbd", "Paraguay", false, "Gamarra", 79 },
                    { 78, "tbd", "Uruguay", false, "Federico Valverde", 89 },
                    { 79, "tbd", "Uruguay", false, "Ronald Araujo", 83 },
                    { 80, "tbd", "Uruguay", false, "Edinson Cavani", 76 },
                    { 81, "tbd", "New Zealand", false, "Chris Wood", 82 },
                    { 82, "tbd", "Austria", false, "Konrad Laimer", 84 },
                    { 83, "tbd", "Bosnia and Herzegovina", false, "Edin Džeko", 81 },
                    { 84, "tbd", "Croatia", false, "Gvardiol", 83 },
                    { 85, "tbd", "Croatia", false, "Luka Modric", 84 },
                    { 86, "tbd", "Czech Republic", false, "Patrik Schick", 86 },
                    { 87, "tbd", "England", true, "Rooney", 91 },
                    { 88, "tbd", "England", false, "Harry Kane", 91 },
                    { 89, "tbd", "England", false, "Jude Bellingham", 90 },
                    { 90, "tbd", "England", false, "Bukayo Saka", 87 },
                    { 91, "tbd", "England", false, "Phil Foden", 84 },
                    { 92, "tbd", "England", false, "Marcus Rashford", 80 },
                    { 93, "tbd", "England", false, "Harry Maguire", 80 },
                    { 94, "tbd", "England", false, "Raheem Sterling", 77 },
                    { 95, "tbd", "England", false, "Jamie Vardy", 75 },
                    { 96, "tbd", "England", false, "Jesse Lingard", 73 },
                    { 97, "tbd", "Sweden", true, "Ibrahimovic", 91 },
                    { 98, "tbd", "Sweden", false, "Alexander Isak", 87 },
                    { 99, "tbd", "Switzerland", false, "Yann Sommer", 86 },
                    { 100, "tbd", "Scotland", false, "Scott McTominay", 85 },
                    { 101, "tbd", "Norway", false, "Erling Haaland", 90 },
                    { 102, "tbd", "Turkey", false, "Hakan Çalhanoglu", 83 },
                    { 103, "tbd", "Germany", true, "Franz Beckenbauer", 93 },
                    { 104, "tbd", "Germany", false, "Joshua Kimmich", 89 },
                    { 105, "tbd", "Germany", false, "Musiala", 87 },
                    { 106, "tbd", "Germany", false, "Manuel Neuer", 83 },
                    { 107, "tbd", "Germany", false, "Gündogan", 81 },
                    { 108, "tbd", "Germany", false, "Timo Werner", 75 },
                    { 109, "tbd", "Germany", false, "Bisseck", 73 },
                    { 110, "tbd", "Spain", true, "Iniesta", 92 },
                    { 111, "tbd", "Spain", true, "Casillas", 90 },
                    { 112, "tbd", "Spain", false, "Lamine Yamal", 89 },
                    { 113, "tbd", "Spain", false, "Pedri", 88 },
                    { 114, "tbd", "Spain", false, "Dani Carvajal", 83 },
                    { 115, "tbd", "Spain", false, "Iago Aspas", 82 },
                    { 116, "tbd", "Spain", false, "Pedro Porro", 81 },
                    { 117, "tbd", "Spain", false, "Dean Huijsen", 79 },
                    { 118, "tbd", "Spain", false, "Eric Garcia", 77 },
                    { 119, "tbd", "Spain", false, "Pedro", 74 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "OvrRating",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "OvrRating",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "OvrRating",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "OvrRating",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Argentina/messiCard.png", "Argentina", false, "Lionel Messi", 84 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "tbd", "Portugal", false, "Cristiano Ronaldo", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name" },
                values: new object[] { "tbd", "Belgium", false, "Kevin De Bruyne" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Norway", "Erling Haaland", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Egypt", "Mohamed Salah", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Netherlands", "Virgil van Dijk", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Belgium", "Thibaut Courtois", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Poland", "Robert Lewandowski", 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Croatia", "Luka Modric", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CardImage", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/vinijrCard.png", "Vinicius Jr", 90 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/neymarCard.png", "Brazil", false, "Neymar Jr", 83 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "South Korea", "Heung Min Son", 88 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "England", "Harry Kane", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/alissonCard.png", "Brazil", "Alisson", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "tbd", "Germany", "Joshua Kimmich", 89 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/casemiroCard.png", "Brazil", "Casemiro", 80 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/ronaldinhoCard.png", "Brazil", true, "Ronaldinho", 92 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IsIcon", "Name", "OvrRating" },
                values: new object[] { false, "Ruben Dias", 88 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/peleCard.png", "Brazil", true, "Pelé", 95 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/ronaldonazarioCard.png", "Brazil", true, "Ronaldo", 93 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/endrickCard.png", "Brazil", "Endrick", 77 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/danteCard.png", "Brazil", "Dante", 78 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CardImage", "Country", "Name", "OvrRating" },
                values: new object[] { "/cards/Brazil/taliscaCard.png", "Brazil", "Talisca", 81 });
        }
    }
}
