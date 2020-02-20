using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages2020.Data;
using RazorPages2020.Models;

namespace RazorPages2020
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages2020.Data.RazorPages2020Context _context;

        public IndexModel(RazorPages2020.Data.RazorPages2020Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
