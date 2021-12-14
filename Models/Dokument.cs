namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dokument
    {
        public int DokumentID { get; set; }
        public int Osoba_personaliaID { get; set; }

        public string Rodzaj_dokumentu { get; set; }
        public string Seria_numer_dokumentu { get; set; }

        public virtual Osoba_personalia Osoba_personalia { get; set; }

    }
}
