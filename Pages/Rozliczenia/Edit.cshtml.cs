using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Rozliczenia
{
    public class EditModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public EditModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["UmowaID"] = new SelectList(_context.Umowa, "UmowaID", "UmowaID");
           ViewData["Wesele_szczegolyID"] = new SelectList(_context.Wesele_szczegoly, "Wesele_szczegolyID", "Wesele_szczegolyID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rozliczenia_szczegoly).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rozliczenia_szczegolyExists(Rozliczenia_szczegoly.Rozliczenia_szczegolyID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Rozliczenia_szczegolyExists(int id)
        {
            return _context.Rozliczenia_szczegoly.Any(e => e.Rozliczenia_szczegolyID == id);
        }
    }
}
