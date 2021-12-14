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

namespace WeddingHouseApp.Pages.Kontakty
{
    public class EditModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public EditModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["Adres_korespondencyjnyID"] = new SelectList(_context.Adres_korespondencyjny, "Adres_korespondencyjnyID", "Adres_korespondencyjnyID");
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

            _context.Attach(Kontakt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KontaktExists(Kontakt.KontaktID))
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

        private bool KontaktExists(int id)
        {
            return _context.Kontakt.Any(e => e.KontaktID == id);
        }
    }
}
