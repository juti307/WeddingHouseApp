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

namespace WeddingHouseApp.Pages.Dokumentyy
{
    public class EditModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public EditModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["Osoba_personaliaID"] = new SelectList(_context.Osoba_personalia, "Osoba_personaliaID", "Osoba_personaliaID");
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

            _context.Attach(Dokument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DokumentExists(Dokument.DokumentID))
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

        private bool DokumentExists(int id)
        {
            return _context.Dokument.Any(e => e.DokumentID == id);
        }
    }
}
