using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Kontakty
{
    public class IndexModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public IndexModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public IList<Kontakt> Kontakt { get;set; }

        public async Task OnGetAsync()
        {
            Kontakt = await _context.Kontakt
                .Include(k => k.Adres_korespondencyjny)
                .Include(k => k.Osoba_personalia).ToListAsync();
        }
    }
}
