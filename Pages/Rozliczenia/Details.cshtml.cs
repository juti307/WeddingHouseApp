using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Rozliczenia
{
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Rozliczenia_szczegoly Rozliczenia_szczegoly { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rozliczenia_szczegoly = await _context.Rozliczenia_szczegoly
                .Include(r => r.Umowa)
                .Include(r => r.Wesele_szczegoly).FirstOrDefaultAsync(m => m.Rozliczenia_szczegolyID == id);

            if (Rozliczenia_szczegoly == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
