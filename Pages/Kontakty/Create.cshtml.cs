using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Kontakty
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
        ViewData["Adres_korespondencyjnyID"] = new SelectList(_context.Adres_korespondencyjny, "Adres_korespondencyjnyID", "Adres_korespondencyjnyID");
        ViewData["Osoba_personaliaID"] = new SelectList(_context.Osoba_personalia, "Osoba_personaliaID", "Osoba_personaliaID");
            return Page();
        }

        [BindProperty]
        public Kontakt Kontakt { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Kontakt.Add(Kontakt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
