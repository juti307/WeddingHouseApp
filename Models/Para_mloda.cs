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
    
    public partial class Para_mloda
    {
        public int Para_mlodaID { get; set; }

        public string Sposob_przedstawienia_oferty { get; set; }
        public System.DateTime Data_przedstawienia_oferty { get; set; }
        public bool Akceptacja_oferty { get; set; }

        public virtual ICollection<Klient> Klient { get; set; }
    }
}
