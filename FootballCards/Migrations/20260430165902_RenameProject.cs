using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballCards.Migrations
{
    /// <inheritdoc />
    public partial class RenameProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pelé");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Eusébio");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Santiago Giménez");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62,
                column: "Country",
                value: "Côte d'Ivoire");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63,
                column: "Country",
                value: "Côte d'Ivoire");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Iñaki Williams");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Brahim Díaz");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Sadio Mané");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71,
                column: "Country",
                value: "Curaçao");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Luis Díaz");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Moisés Caicedo");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Edin Džeko");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "Hakan Çalhanoğlu");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "Gündoğan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pel�");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Eus�bio");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Santiago Gim�nez");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62,
                column: "Country",
                value: "C�te d'Ivoire");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63,
                column: "Country",
                value: "C�te d'Ivoire");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "I�aki Williams");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Brahim D�az");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Sadio Man�");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71,
                column: "Country",
                value: "Cura�ao");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Luis D�az");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Mois�s Caicedo");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Edin D�eko");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "Hakan �alhanoglu");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "G�ndogan");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardImage", "Country", "IsIcon", "Name", "OvrRating" },
                values: new object[] { 43, "tbd", "Croatia", false, "Luka Modric", 83 });
        }
    }
}
