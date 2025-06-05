using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Genres { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Year}), {Country}, Director: {Director}";
        }
    }

}
