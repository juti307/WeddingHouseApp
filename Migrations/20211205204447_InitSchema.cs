using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingHouseApp.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres_korespondencyjny",
                columns: table => new
                {
                    Adres_korespondencyjnyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miasto = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Nr_domu_mieszkania = table.Column<string>(nullable: true),
                    Kod_pocztowy = table.Column<string>(nullable: true),
                    Kraj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres_korespondencyjny", x => x.Adres_korespondencyjnyId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    Alkohole = table.Column<string>(nullable: true),
                    Stol_wiejski = table.Column<string>(nullable: true),
                    Koszt_za_osobe = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Osoba_personalia",
                columns: table => new
                {
                    Osoba_personaliaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Drugie_imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba_personalia", x => x.Osoba_personaliaId);
                });

            migrationBuilder.CreateTable(
                name: "Para_mloda",
                columns: table => new
                {
                    Para_mlodaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sposob_przedstawienia_oferty = table.Column<string>(nullable: true),
                    Data_przedstawienia_oferty = table.Column<DateTime>(nullable: false),
                    Akceptacja_oferty = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Para_mloda", x => x.Para_mlodaId);
                });

            migrationBuilder.CreateTable(
                name: "Wesele_szczegoly",
                columns: table => new
                {
                    Wesele_szczegolyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_wesela = table.Column<DateTime>(nullable: false),
                    Godzina_rozpoczecia = table.Column<TimeSpan>(nullable: false),
                    Godzina_zakonczenia = table.Column<TimeSpan>(nullable: false),
                    Ile_osob = table.Column<int>(nullable: false),
                    Koszt_calkowity = table.Column<double>(nullable: false),
                    Id_menu = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wesele_szczegoly", x => x.Wesele_szczegolyId);
                    table.ForeignKey(
                        name: "FK_Wesele_szczegoly_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dokument",
                columns: table => new
                {
                    DokumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodzaj_dokumentu = table.Column<string>(nullable: true),
                    Seria_numer_dokumentu = table.Column<string>(nullable: true),
                    Osoba_personaliaForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokument", x => x.DokumentId);
                    table.ForeignKey(
                        name: "FK_Dokument_Osoba_personalia_Osoba_personaliaForeignKey",
                        column: x => x.Osoba_personaliaForeignKey,
                        principalTable: "Osoba_personalia",
                        principalColumn: "Osoba_personaliaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kontakt",
                columns: table => new
                {
                    KontaktId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres_email = table.Column<string>(nullable: true),
                    Nr_telefonu = table.Column<string>(nullable: true),
                    Id_osoby = table.Column<int>(nullable: false),
                    Osoba_personaliaId = table.Column<int>(nullable: true),
                    Adres_korespondencyjnyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakt", x => x.KontaktId);
                    table.ForeignKey(
                        name: "FK_Kontakt_Adres_korespondencyjny_Adres_korespondencyjnyId",
                        column: x => x.Adres_korespondencyjnyId,
                        principalTable: "Adres_korespondencyjny",
                        principalColumn: "Adres_korespondencyjnyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kontakt_Osoba_personalia_Osoba_personaliaId",
                        column: x => x.Osoba_personaliaId,
                        principalTable: "Osoba_personalia",
                        principalColumn: "Osoba_personaliaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    PracownikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stanowisko = table.Column<string>(nullable: true),
                    Data_zatrudnienia = table.Column<string>(nullable: true),
                    Pensja = table.Column<double>(nullable: false),
                    Prowizje = table.Column<double>(nullable: false),
                    Osoba_personaliaForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.PracownikId);
                    table.ForeignKey(
                        name: "FK_Pracownik_Osoba_personalia_Osoba_personaliaForeignKey",
                        column: x => x.Osoba_personaliaForeignKey,
                        principalTable: "Osoba_personalia",
                        principalColumn: "Osoba_personaliaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    KlientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_pary_mlodej = table.Column<int>(nullable: false),
                    Para_młodaPara_mlodaId = table.Column<int>(nullable: true),
                    Osoba_personaliaForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.KlientId);
                    table.ForeignKey(
                        name: "FK_Klient_Osoba_personalia_Osoba_personaliaForeignKey",
                        column: x => x.Osoba_personaliaForeignKey,
                        principalTable: "Osoba_personalia",
                        principalColumn: "Osoba_personaliaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klient_Para_mloda_Para_młodaPara_mlodaId",
                        column: x => x.Para_młodaPara_mlodaId,
                        principalTable: "Para_mloda",
                        principalColumn: "Para_mlodaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Umowa",
                columns: table => new
                {
                    UmowaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_podpisania = table.Column<DateTime>(nullable: false),
                    Id_pracownika = table.Column<int>(nullable: false),
                    PracownikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umowa", x => x.UmowaId);
                    table.ForeignKey(
                        name: "FK_Umowa_Pracownik_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracownik",
                        principalColumn: "PracownikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rozliczenia_szczegoly",
                columns: table => new
                {
                    Rozliczenia_szczegolyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_rozliczenia = table.Column<DateTime>(nullable: false),
                    Nr_paragonu_faktury = table.Column<string>(nullable: true),
                    Kwota_wplaty = table.Column<double>(nullable: false),
                    Rodzaj_platnosci = table.Column<string>(nullable: true),
                    UmowaId = table.Column<int>(nullable: true),
                    Wesele_szczegolyForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rozliczenia_szczegoly", x => x.Rozliczenia_szczegolyId);
                    table.ForeignKey(
                        name: "FK_Rozliczenia_szczegoly_Umowa_UmowaId",
                        column: x => x.UmowaId,
                        principalTable: "Umowa",
                        principalColumn: "UmowaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rozliczenia_szczegoly_Wesele_szczegoly_Wesele_szczegolyForeignKey",
                        column: x => x.Wesele_szczegolyForeignKey,
                        principalTable: "Wesele_szczegoly",
                        principalColumn: "Wesele_szczegolyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dokument_Osoba_personaliaForeignKey",
                table: "Dokument",
                column: "Osoba_personaliaForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Klient_Osoba_personaliaForeignKey",
                table: "Klient",
                column: "Osoba_personaliaForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Klient_Para_młodaPara_mlodaId",
                table: "Klient",
                column: "Para_młodaPara_mlodaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kontakt_Adres_korespondencyjnyId",
                table: "Kontakt",
                column: "Adres_korespondencyjnyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kontakt_Osoba_personaliaId",
                table: "Kontakt",
                column: "Osoba_personaliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_Osoba_personaliaForeignKey",
                table: "Pracownik",
                column: "Osoba_personaliaForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rozliczenia_szczegoly_UmowaId",
                table: "Rozliczenia_szczegoly",
                column: "UmowaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rozliczenia_szczegoly_Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly",
                column: "Wesele_szczegolyForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Umowa_PracownikId",
                table: "Umowa",
                column: "PracownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Wesele_szczegoly_MenuId",
                table: "Wesele_szczegoly",
                column: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokument");

            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Kontakt");

            migrationBuilder.DropTable(
                name: "Rozliczenia_szczegoly");

            migrationBuilder.DropTable(
                name: "Para_mloda");

            migrationBuilder.DropTable(
                name: "Adres_korespondencyjny");

            migrationBuilder.DropTable(
                name: "Umowa");

            migrationBuilder.DropTable(
                name: "Wesele_szczegoly");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Osoba_personalia");
        }
    }
}
