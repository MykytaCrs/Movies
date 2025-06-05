using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPR_MoviesLibrary.Models;

namespace TPR_MoviesLibrary.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        List<Movie> SearchMovies(string name, int? year, string country, string director, string genres, string description);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
        void AddMovie(Movie movie);

    }
}
