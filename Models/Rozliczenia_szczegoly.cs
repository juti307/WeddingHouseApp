//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rozliczenia_szczegoly
    {
        public int Rozliczenia_szczegolyID { get; set; }
        public int UmowaID { get; set; }
        public int Wesele_szczegolyID { get; set; }


        public System.DateTime Data_rozliczenia { get; set; }
        public string Nr_paragonu_faktury { get; set; }
        public double Kwota_wplaty { get; set; }
        public string Rodzaj_platnosci { get; set; }

        public virtual Umowa Umowa { get; set; }
        public virtual Wesele_szczegoly Wesele_szczegoly { get; set; }
    }
}
