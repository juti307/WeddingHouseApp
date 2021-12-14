using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Wesela
{
    public class DeleteModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DeleteModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Wesele_szczegoly Wesele_szczegoly { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wesele_szczegoly = await _context.Wesele_szczegoly
                .Include(w => w.Menu).FirstOrDefaultAsync(m => m.Wesele_szczegolyID == id);

            if (Wesele_szczegoly == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wesele_szczegoly = await _context.Wesele_szczegoly.FindAsync(id);

            if (Wesele_szczegoly != null)
            {
                _context.Wesele_szczegoly.Remove(Wesele_szczegoly);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
