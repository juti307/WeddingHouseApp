using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Wesela
{
    public class CreateModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public CreateModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MenuID"] = new SelectList(_context.Menu, "MenuID", "MenuID");
            return Page();
        }

        [BindProperty]
        public Wesele_szczegoly Wesele_szczegoly { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wesele_szczegoly.Add(Wesele_szczegoly);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
