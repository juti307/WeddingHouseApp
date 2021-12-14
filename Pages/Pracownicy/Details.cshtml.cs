using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Pracownicy
{
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Pracownik Pracownik { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pracownik = await _context.Pracownik
                .Include(p => p.Osoba_personalia).FirstOrDefaultAsync(m => m.PracownikID == id);

            if (Pracownik == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
