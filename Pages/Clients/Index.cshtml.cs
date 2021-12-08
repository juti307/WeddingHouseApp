using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using WeddingHouseApp.Data;

namespace WeddingHouseApp.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly WeddingHouseApp.Data.WeddingContext _context;

        public IndexModel(WeddingHouseApp.Data.WeddingContext context)
        {
            _context = context;
        }

        public List<Osoba_personalia> Osoba_personalia { get;set; }
        public List<Dokument> Dokument { get; set; }

        public async Task OnGetAsync()
        {
            Osoba_personalia = await _context.Osoba_personalia.ToListAsync();
            Dokument = await _context.Dokument.ToListAsync();



        }
    }
}
