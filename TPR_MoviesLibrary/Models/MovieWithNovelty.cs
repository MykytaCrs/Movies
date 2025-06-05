/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Models
{
    public class MovieWithNovelty : Movie
    {
        public string Novelty => GetNovelty();

        public MovieWithNovelty(Movie movie)
        {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.Year = movie.Year;
            this.Country = movie.Country;
            this.Director = movie.Director;
            this.Genres = movie.Genres;
            this.Description = movie.Description;
        }

        private string GetNovelty()
        {
            int age = DateTime.Now.Year - this.Year;

            if (age <= 3)
                return "Latest Hit";
            else if (age <= 10)
                return "Recent";
            else if (age <= 15)
                return "Modern Classic";
            else if (age <= 25)
                return "Old Gem";
            else
                return "Vintage";
        }
    }
}
*/