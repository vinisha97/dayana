using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages2020.Models;

namespace RazorPages2020.Data
{
    public class RazorPages2020Context : DbContext
    {
        public RazorPages2020Context (DbContextOptions<RazorPages2020Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPages2020.Models.Movie> Movie { get; set; }
    }
}
