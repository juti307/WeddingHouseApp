using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Wesela
{
    public class IndexModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public IndexModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public IList<Wesele_szczegoly> Wesele_szczegoly { get;set; }

        public async Task OnGetAsync()
        {
            Wesele_szczegoly = await _context.Wesele_szczegoly
                .Include(w => w.Menu).ToListAsync();
        }
    }
}
