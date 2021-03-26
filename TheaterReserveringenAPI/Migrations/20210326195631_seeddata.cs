using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterReserveringenAPI.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Klanten",
                columns: new[] { "KlantId", "Adres", "Email", "Naam", "Woonplaats" },
                values: new object[,]
                {
                    { 1, "Sesamstraat 1", "piet@puck.nl", "Pietje Puk", "Hilversum" },
                    { 2, "Sesamstraat 2", "klaas@puck.nl", "Klaas Vaak", "Hilversum" },
                    { 3, "Sesamstraat 3", "Gerda@puck.nl", "Gerda Grutjes", "Hilversum" }
                });

            migrationBuilder.InsertData(
                table: "Reserveringen",
                columns: new[] { "ReserveringId", "Bezet", "KlantId", "Naam" },
                values: new object[,]
                {
                    { 17, false, null, "C5" },
                    { 18, false, null, "C6" },
                    { 19, false, null, "D1" },
                    { 20, false, null, "D2" },
                    { 21, false, null, "D3" },
                    { 22, false, null, "D4" },
                    { 23, false, null, "D5" },
                    { 24, false, null, "D6" },
                    { 25, false, null, "E1" },
                    { 26, false, null, "E2" },
                    { 27, false, null, "E3" },
                    { 28, false, null, "E4" },
                    { 16, false, null, "C4" },
                    { 15, false, null, "C3" },
                    { 14, false, null, "C2" },
                    { 13, false, null, "C1" },
                    { 12, false, null, "B6" },
                    { 11, false, null, "B5" },
                    { 10, false, null, "B4" },
                    { 9, false, null, "B3" },
                    { 8, false, null, "B2" },
                    { 7, false, null, "B1" },
                    { 6, false, null, "A6" },
                    { 5, false, null, "A5" },
                    { 4, false, null, "A4" },
                    { 3, false, null, "A3" },
                    { 2, false, null, "A2" },
                    { 1, false, null, "A1" },
                    { 29, false, null, "E5" },
                    { 30, false, null, "E6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "KlantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "KlantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "KlantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reserveringen",
                keyColumn: "ReserveringId",
                keyValue: 30);
        }
    }
}
