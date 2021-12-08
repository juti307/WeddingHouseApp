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

namespace WeddingHouseApp.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public EditModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Osoba_personalia Osoba_personalia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Osoba_personalia = await _context.Osoba_personalia.FirstOrDefaultAsync(m => m.Osoba_personaliaId == id);

            if (Osoba_personalia == null)
            {
                return NotFound();
            }
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

            _context.Attach(Osoba_personalia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Osoba_personaliaExists(Osoba_personalia.Osoba_personaliaId))
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

        private bool Osoba_personaliaExists(int id)
        {
            return _context.Osoba_personalia.Any(e => e.Osoba_personaliaId == id);
        }
    }
}
