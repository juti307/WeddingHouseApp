using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Pary_mlode
{
    public class DeleteModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DeleteModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Para_mloda Para_mloda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Para_mloda = await _context.Para_mloda.FirstOrDefaultAsync(m => m.Para_mlodaID == id);

            if (Para_mloda == null)
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

            Para_mloda = await _context.Para_mloda.FindAsync(id);

            if (Para_mloda != null)
            {
                _context.Para_mloda.Remove(Para_mloda);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
