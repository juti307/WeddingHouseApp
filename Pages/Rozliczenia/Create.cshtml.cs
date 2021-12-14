using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Rozliczenia
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
        ViewData["UmowaID"] = new SelectList(_context.Umowa, "UmowaID", "UmowaID");
        ViewData["Wesele_szczegolyID"] = new SelectList(_context.Wesele_szczegoly, "Wesele_szczegolyID", "Wesele_szczegolyID");
            return Page();
        }

        [BindProperty]
        public Rozliczenia_szczegoly Rozliczenia_szczegoly { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rozliczenia_szczegoly.Add(Rozliczenia_szczegoly);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
