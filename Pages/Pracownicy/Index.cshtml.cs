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
    public class IndexModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public IndexModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public IList<Pracownik> Pracownik { get;set; }

        public async Task OnGetAsync()
        {
            Pracownik = await _context.Pracownik
                .Include(p => p.Osoba_personalia).ToListAsync();
        }
    }
}
