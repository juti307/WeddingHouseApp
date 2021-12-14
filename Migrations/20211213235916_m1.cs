using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingHouseApp.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dokument_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Dokument");

            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Klient");

            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Para_mloda_Para_młodaPara_mlodaId",
                table: "Klient");

            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Adres_korespondencyjny_Adres_korespondencyjnyId",
                table: "Kontakt");

            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Osoba_personalia_Osoba_personaliaId",
                table: "Kontakt");

            migrationBuilder.DropForeignKey(
                name: "FK_Pracownik_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Pracownik");

            migrationBuilder.DropForeignKey(
                name: "FK_Rozliczenia_szczegoly_Umowa_UmowaId",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropForeignKey(
                name: "FK_Rozliczenia_szczegoly_Wesele_szczegoly_Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropForeignKey(
                name: "FK_Umowa_Pracownik_PracownikId",
                table: "Umowa");

            migrationBuilder.DropForeignKey(
                name: "FK_Wesele_szczegoly_Menu_MenuId",
                table: "Wesele_szczegoly");

            migrationBuilder.DropIndex(
                name: "IX_Rozliczenia_szczegoly_Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropIndex(
                name: "IX_Pracownik_Osoba_personaliaForeignKey",
                table: "Pracownik");

            migrationBuilder.DropIndex(
                name: "IX_Klient_Osoba_personaliaForeignKey",
                table: "Klient");

            migrationBuilder.DropIndex(
                name: "IX_Klient_Para_młodaPara_mlodaId",
                table: "Klient");

            migrationBuilder.DropIndex(
                name: "IX_Dokument_Osoba_personaliaForeignKey",
                table: "Dokument");

            migrationBuilder.DropColumn(
                name: "Id_menu",
                table: "Wesele_szczegoly");

            migrationBuilder.DropColumn(
                name: "Id_pracownika",
                table: "Umowa");

            migrationBuilder.DropColumn(
                name: "Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaForeignKey",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "Id_osoby",
                table: "Kontakt");

            migrationBuilder.DropColumn(
                name: "Id_pary_mlodej",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaForeignKey",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Para_młodaPara_mlodaId",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaForeignKey",
                table: "Dokument");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Wesele_szczegoly",
                newName: "MenuID");

            migrationBuilder.RenameColumn(
                name: "Wesele_szczegolyId",
                table: "Wesele_szczegoly",
                newName: "Wesele_szczegolyID");

            migrationBuilder.RenameIndex(
                name: "IX_Wesele_szczegoly_MenuId",
                table: "Wesele_szczegoly",
                newName: "IX_Wesele_szczegoly_MenuID");

            migrationBuilder.RenameColumn(
                name: "PracownikId",
                table: "Umowa",
                newName: "PracownikID");

            migrationBuilder.RenameColumn(
                name: "UmowaId",
                table: "Umowa",
                newName: "UmowaID");

            migrationBuilder.RenameIndex(
                name: "IX_Umowa_PracownikId",
                table: "Umowa",
                newName: "IX_Umowa_PracownikID");

            migrationBuilder.RenameColumn(
                name: "UmowaId",
                table: "Rozliczenia_szczegoly",
                newName: "UmowaID");

            migrationBuilder.RenameColumn(
                name: "Rozliczenia_szczegolyId",
                table: "Rozliczenia_szczegoly",
                newName: "Rozliczenia_szczegolyID");

            migrationBuilder.RenameIndex(
                name: "IX_Rozliczenia_szczegoly_UmowaId",
                table: "Rozliczenia_szczegoly",
                newName: "IX_Rozliczenia_szczegoly_UmowaID");

            migrationBuilder.RenameColumn(
                name: "PracownikId",
                table: "Pracownik",
                newName: "PracownikID");

            migrationBuilder.RenameColumn(
                name: "Para_mlodaId",
                table: "Para_mloda",
                newName: "Para_mlodaID");

            migrationBuilder.RenameColumn(
                name: "Osoba_personaliaId",
                table: "Osoba_personalia",
                newName: "Osoba_personaliaID");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Menu",
                newName: "MenuID");

            migrationBuilder.RenameColumn(
                name: "Osoba_personaliaId",
                table: "Kontakt",
                newName: "Osoba_personaliaID");

            migrationBuilder.RenameColumn(
                name: "Adres_korespondencyjnyId",
                table: "Kontakt",
                newName: "Adres_korespondencyjnyID");

            migrationBuilder.RenameColumn(
                name: "KontaktId",
                table: "Kontakt",
                newName: "KontaktID");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_Osoba_personaliaId",
                table: "Kontakt",
                newName: "IX_Kontakt_Osoba_personaliaID");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_Adres_korespondencyjnyId",
                table: "Kontakt",
                newName: "IX_Kontakt_Adres_korespondencyjnyID");

            migrationBuilder.RenameColumn(
                name: "KlientId",
                table: "Klient",
                newName: "KlientID");

            migrationBuilder.RenameColumn(
                name: "DokumentId",
                table: "Dokument",
                newName: "DokumentID");

            migrationBuilder.RenameColumn(
                name: "Adres_korespondencyjnyId",
                table: "Adres_korespondencyjny",
                newName: "Adres_korespondencyjnyID");

            migrationBuilder.AlterColumn<int>(
                name: "MenuID",
                table: "Wesele_szczegoly",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rozliczenia_szczegolyID",
                table: "Wesele_szczegoly",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PracownikID",
                table: "Umowa",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UmowaID",
                table: "Rozliczenia_szczegoly",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaID",
                table: "Pracownik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DokumentID",
                table: "Osoba_personalia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KontaktID",
                table: "Osoba_personalia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracownikID",
                table: "Osoba_personalia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Osoba_personaliaID",
                table: "Kontakt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Adres_korespondencyjnyID",
                table: "Kontakt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaID",
                table: "Klient",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Para_mlodaID",
                table: "Klient",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaID",
                table: "Dokument",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rozliczenia_szczegoly_Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly",
                column: "Wesele_szczegolyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_Osoba_personaliaID",
                table: "Pracownik",
                column: "Osoba_personaliaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Klient_Osoba_personaliaID",
                table: "Klient",
                column: "Osoba_personaliaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Klient_Para_mlodaID",
                table: "Klient",
                column: "Para_mlodaID");

            migrationBuilder.CreateIndex(
                name: "IX_Dokument_Osoba_personaliaID",
                table: "Dokument",
                column: "Osoba_personaliaID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dokument_Osoba_personalia_Osoba_personaliaID",
                table: "Dokument",
                column: "Osoba_personaliaID",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Osoba_personalia_Osoba_personaliaID",
                table: "Klient",
                column: "Osoba_personaliaID",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Para_mloda_Para_mlodaID",
                table: "Klient",
                column: "Para_mlodaID",
                principalTable: "Para_mloda",
                principalColumn: "Para_mlodaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Adres_korespondencyjny_Adres_korespondencyjnyID",
                table: "Kontakt",
                column: "Adres_korespondencyjnyID",
                principalTable: "Adres_korespondencyjny",
                principalColumn: "Adres_korespondencyjnyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Osoba_personalia_Osoba_personaliaID",
                table: "Kontakt",
                column: "Osoba_personaliaID",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pracownik_Osoba_personalia_Osoba_personaliaID",
                table: "Pracownik",
                column: "Osoba_personaliaID",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rozliczenia_szczegoly_Umowa_UmowaID",
                table: "Rozliczenia_szczegoly",
                column: "UmowaID",
                principalTable: "Umowa",
                principalColumn: "UmowaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rozliczenia_szczegoly_Wesele_szczegoly_Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly",
                column: "Wesele_szczegolyID",
                principalTable: "Wesele_szczegoly",
                principalColumn: "Wesele_szczegolyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Umowa_Pracownik_PracownikID",
                table: "Umowa",
                column: "PracownikID",
                principalTable: "Pracownik",
                principalColumn: "PracownikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wesele_szczegoly_Menu_MenuID",
                table: "Wesele_szczegoly",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dokument_Osoba_personalia_Osoba_personaliaID",
                table: "Dokument");

            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Osoba_personalia_Osoba_personaliaID",
                table: "Klient");

            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Para_mloda_Para_mlodaID",
                table: "Klient");

            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Adres_korespondencyjny_Adres_korespondencyjnyID",
                table: "Kontakt");

            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Osoba_personalia_Osoba_personaliaID",
                table: "Kontakt");

            migrationBuilder.DropForeignKey(
                name: "FK_Pracownik_Osoba_personalia_Osoba_personaliaID",
                table: "Pracownik");

            migrationBuilder.DropForeignKey(
                name: "FK_Rozliczenia_szczegoly_Umowa_UmowaID",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropForeignKey(
                name: "FK_Rozliczenia_szczegoly_Wesele_szczegoly_Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropForeignKey(
                name: "FK_Umowa_Pracownik_PracownikID",
                table: "Umowa");

            migrationBuilder.DropForeignKey(
                name: "FK_Wesele_szczegoly_Menu_MenuID",
                table: "Wesele_szczegoly");

            migrationBuilder.DropIndex(
                name: "IX_Rozliczenia_szczegoly_Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropIndex(
                name: "IX_Pracownik_Osoba_personaliaID",
                table: "Pracownik");

            migrationBuilder.DropIndex(
                name: "IX_Klient_Osoba_personaliaID",
                table: "Klient");

            migrationBuilder.DropIndex(
                name: "IX_Klient_Para_mlodaID",
                table: "Klient");

            migrationBuilder.DropIndex(
                name: "IX_Dokument_Osoba_personaliaID",
                table: "Dokument");

            migrationBuilder.DropColumn(
                name: "Rozliczenia_szczegolyID",
                table: "Wesele_szczegoly");

            migrationBuilder.DropColumn(
                name: "Wesele_szczegolyID",
                table: "Rozliczenia_szczegoly");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaID",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "DokumentID",
                table: "Osoba_personalia");

            migrationBuilder.DropColumn(
                name: "KontaktID",
                table: "Osoba_personalia");

            migrationBuilder.DropColumn(
                name: "PracownikID",
                table: "Osoba_personalia");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaID",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Para_mlodaID",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "Osoba_personaliaID",
                table: "Dokument");

            migrationBuilder.RenameColumn(
                name: "MenuID",
                table: "Wesele_szczegoly",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "Wesele_szczegolyID",
                table: "Wesele_szczegoly",
                newName: "Wesele_szczegolyId");

            migrationBuilder.RenameIndex(
                name: "IX_Wesele_szczegoly_MenuID",
                table: "Wesele_szczegoly",
                newName: "IX_Wesele_szczegoly_MenuId");

            migrationBuilder.RenameColumn(
                name: "PracownikID",
                table: "Umowa",
                newName: "PracownikId");

            migrationBuilder.RenameColumn(
                name: "UmowaID",
                table: "Umowa",
                newName: "UmowaId");

            migrationBuilder.RenameIndex(
                name: "IX_Umowa_PracownikID",
                table: "Umowa",
                newName: "IX_Umowa_PracownikId");

            migrationBuilder.RenameColumn(
                name: "UmowaID",
                table: "Rozliczenia_szczegoly",
                newName: "UmowaId");

            migrationBuilder.RenameColumn(
                name: "Rozliczenia_szczegolyID",
                table: "Rozliczenia_szczegoly",
                newName: "Rozliczenia_szczegolyId");

            migrationBuilder.RenameIndex(
                name: "IX_Rozliczenia_szczegoly_UmowaID",
                table: "Rozliczenia_szczegoly",
                newName: "IX_Rozliczenia_szczegoly_UmowaId");

            migrationBuilder.RenameColumn(
                name: "PracownikID",
                table: "Pracownik",
                newName: "PracownikId");

            migrationBuilder.RenameColumn(
                name: "Para_mlodaID",
                table: "Para_mloda",
                newName: "Para_mlodaId");

            migrationBuilder.RenameColumn(
                name: "Osoba_personaliaID",
                table: "Osoba_personalia",
                newName: "Osoba_personaliaId");

            migrationBuilder.RenameColumn(
                name: "MenuID",
                table: "Menu",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "Osoba_personaliaID",
                table: "Kontakt",
                newName: "Osoba_personaliaId");

            migrationBuilder.RenameColumn(
                name: "Adres_korespondencyjnyID",
                table: "Kontakt",
                newName: "Adres_korespondencyjnyId");

            migrationBuilder.RenameColumn(
                name: "KontaktID",
                table: "Kontakt",
                newName: "KontaktId");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_Osoba_personaliaID",
                table: "Kontakt",
                newName: "IX_Kontakt_Osoba_personaliaId");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_Adres_korespondencyjnyID",
                table: "Kontakt",
                newName: "IX_Kontakt_Adres_korespondencyjnyId");

            migrationBuilder.RenameColumn(
                name: "KlientID",
                table: "Klient",
                newName: "KlientId");

            migrationBuilder.RenameColumn(
                name: "DokumentID",
                table: "Dokument",
                newName: "DokumentId");

            migrationBuilder.RenameColumn(
                name: "Adres_korespondencyjnyID",
                table: "Adres_korespondencyjny",
                newName: "Adres_korespondencyjnyId");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Wesele_szczegoly",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_menu",
                table: "Wesele_szczegoly",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PracownikId",
                table: "Umowa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_pracownika",
                table: "Umowa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UmowaId",
                table: "Rozliczenia_szczegoly",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaForeignKey",
                table: "Pracownik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Osoba_personaliaId",
                table: "Kontakt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Adres_korespondencyjnyId",
                table: "Kontakt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_osoby",
                table: "Kontakt",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_pary_mlodej",
                table: "Klient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaForeignKey",
                table: "Klient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Para_młodaPara_mlodaId",
                table: "Klient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Osoba_personaliaForeignKey",
                table: "Dokument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rozliczenia_szczegoly_Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly",
                column: "Wesele_szczegolyForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_Osoba_personaliaForeignKey",
                table: "Pracownik",
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
                name: "IX_Dokument_Osoba_personaliaForeignKey",
                table: "Dokument",
                column: "Osoba_personaliaForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dokument_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Dokument",
                column: "Osoba_personaliaForeignKey",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Klient",
                column: "Osoba_personaliaForeignKey",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Para_mloda_Para_młodaPara_mlodaId",
                table: "Klient",
                column: "Para_młodaPara_mlodaId",
                principalTable: "Para_mloda",
                principalColumn: "Para_mlodaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Adres_korespondencyjny_Adres_korespondencyjnyId",
                table: "Kontakt",
                column: "Adres_korespondencyjnyId",
                principalTable: "Adres_korespondencyjny",
                principalColumn: "Adres_korespondencyjnyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Osoba_personalia_Osoba_personaliaId",
                table: "Kontakt",
                column: "Osoba_personaliaId",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pracownik_Osoba_personalia_Osoba_personaliaForeignKey",
                table: "Pracownik",
                column: "Osoba_personaliaForeignKey",
                principalTable: "Osoba_personalia",
                principalColumn: "Osoba_personaliaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rozliczenia_szczegoly_Umowa_UmowaId",
                table: "Rozliczenia_szczegoly",
                column: "UmowaId",
                principalTable: "Umowa",
                principalColumn: "UmowaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rozliczenia_szczegoly_Wesele_szczegoly_Wesele_szczegolyForeignKey",
                table: "Rozliczenia_szczegoly",
                column: "Wesele_szczegolyForeignKey",
                principalTable: "Wesele_szczegoly",
                principalColumn: "Wesele_szczegolyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Umowa_Pracownik_PracownikId",
                table: "Umowa",
                column: "PracownikId",
                principalTable: "Pracownik",
                principalColumn: "PracownikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wesele_szczegoly_Menu_MenuId",
                table: "Wesele_szczegoly",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
