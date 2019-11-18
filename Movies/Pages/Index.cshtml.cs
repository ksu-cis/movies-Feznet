using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Movies.Pages
{
    public class IndexModel : PageModel
    {
        public MovieDatabase movieDB = new MovieDatabase();
        public List<Movie> Movies;

        public void OnGet()
        {
            Movies = movieDB.All;
        }

        public void OnPost(string search, List<string> rating)
        {
            Movies = movieDB.SearchAndFilter(search, rating);
        }
    }
}
