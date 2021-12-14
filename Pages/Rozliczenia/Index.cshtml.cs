using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Rozliczenia
{
    public class IndexModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public IndexModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public IList<Rozliczenia_szczegoly> Rozliczenia_szczegoly { get;set; }

        public async Task OnGetAsync()
        {
            Rozliczenia_szczegoly = await _context.Rozliczenia_szczegoly
                .Include(r => r.Umowa)
                .Include(r => r.Wesele_szczegoly).ToListAsync();
        }
    }
}
