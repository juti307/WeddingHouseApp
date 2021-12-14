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
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Kontakt Kontakt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kontakt = await _context.Kontakt
                .Include(k => k.Adres_korespondencyjny)
                .Include(k => k.Osoba_personalia).FirstOrDefaultAsync(m => m.KontaktID == id);

            if (Kontakt == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
