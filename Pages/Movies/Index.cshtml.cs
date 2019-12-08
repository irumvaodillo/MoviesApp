using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieShopApp.Data;
using MovieShopApp.Models;

namespace MovieShopApp.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieShopApp.Data.MoviesContext _context;

        public IndexModel(MovieShopApp.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
