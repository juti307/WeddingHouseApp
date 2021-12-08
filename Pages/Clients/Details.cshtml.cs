using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Osoba_personalia Osoba_personalia { get; set; }
        public Kontakt Kontakt { get; set; }
        public Dokument Dokument { get; set; }
        public Adres_korespondencyjny Adres_korespondencyjny { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Osoba_personalia = await _context.Osoba_personalia.FirstOrDefaultAsync(m => m.Osoba_personaliaId == id);
            Kontakt = await _context.Kontakt.FirstOrDefaultAsync(m => m.Id_osoby == id);
            Dokument = await _context.Dokument.FirstOrDefaultAsync(m => m.Osoba_personaliaForeignKey == id);
           // Adres_korespondencyjny = await _context.Adres_korespondencyjny.FirstOrDefaultAsync(m => m.Adres_korespondencyjnyId == Kontakt.Adres_korespondencyjnyId);



            if (Osoba_personalia == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
