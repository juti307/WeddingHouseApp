using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Osoby
{
    public class DeleteModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DeleteModel(WeddingHouseApp.Data.WeddingContext context)
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

            Osoba_personalia = await _context.Osoba_personalia.FirstOrDefaultAsync(m => m.Osoba_personaliaID == id);

            if (Osoba_personalia == null)
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

            Osoba_personalia = await _context.Osoba_personalia.FindAsync(id);

            if (Osoba_personalia != null)
            {
                _context.Osoba_personalia.Remove(Osoba_personalia);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
