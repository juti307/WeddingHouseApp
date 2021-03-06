using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Adresy
{
    public class DetailsModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public DetailsModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public Adres_korespondencyjny Adres_korespondencyjny { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Adres_korespondencyjny = await _context.Adres_korespondencyjny.FirstOrDefaultAsync(m => m.Adres_korespondencyjnyID == id);

            if (Adres_korespondencyjny == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
