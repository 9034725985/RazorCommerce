#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCommerce.Data;
using RazorCommerce.Models;

namespace RazorCommerce.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorCommerce.Data.ApplicationDbContext _context;

        public IndexModel(RazorCommerce.Data.ApplicationDbContext context)
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
