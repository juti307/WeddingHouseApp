using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Clients
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
            return Page();
        }

        [BindProperty]
        public Osoba_personalia Osoba_personalia { get; set; }
        public Dokument Dokument { get; set; }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Osoba_personalia.Add(Osoba_personalia);
            _context.Dokument.Add(Dokument);
            Dokument.Osoba_personaliaForeignKey = Osoba_personalia.Osoba_personaliaId;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
