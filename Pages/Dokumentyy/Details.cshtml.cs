using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Dokumentyy
{
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Dokument Dokument { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dokument = await _context.Dokument
                .Include(d => d.Osoba_personalia).FirstOrDefaultAsync(m => m.DokumentID == id);

            if (Dokument == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
