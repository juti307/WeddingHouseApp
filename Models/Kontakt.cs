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
    
    public partial class Kontakt
    {
        public int KontaktId { get; set; }
        public string Adres_email { get; set; }
        public string Nr_telefonu { get; set; }
        public int Id_osoby { get; set; }
    
        public virtual Osoba_personalia Osoba_personalia { get; set; }
        public virtual Adres_korespondencyjny Adres_korespondencyjny { get; set; }
    }
}
