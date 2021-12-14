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

namespace WeddingHouseApp.Pages.Wesela
{
    public class EditModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public EditModel(WeddingHouseApp.Data.WeddingContext context)
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
           ViewData["MenuID"] = new SelectList(_context.Menu, "MenuID", "MenuID");
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

            _context.Attach(Wesele_szczegoly).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Wesele_szczegolyExists(Wesele_szczegoly.Wesele_szczegolyID))
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

        private bool Wesele_szczegolyExists(int id)
        {
            return _context.Wesele_szczegoly.Any(e => e.Wesele_szczegolyID == id);
        }
    }
}
