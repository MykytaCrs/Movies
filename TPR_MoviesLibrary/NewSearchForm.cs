using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPR_MoviesLibrary.Models;
using TPR_MoviesLibrary.Repositories;

namespace TPR_MoviesLibrary
{
    public partial class NewSearchForm : Form
    {
        private readonly IMovieRepository _movieRepository;

        public delegate void SearchCompletedHandler(List<Movie> results);
        public event SearchCompletedHandler SearchCompleted;

        public NewSearchForm(IMovieRepository movieRepository)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            var name = txt_name.Text.Trim();
            var yearText = txt_year.Text.Trim();
            int? year = null;
            if (int.TryParse(yearText, out int y))
                year = y;

            var country = txt_country.Text.Trim();
            var director = txt_director.Text.Trim();
            var genres = txt_genres.Text.Trim();
            var description = txt_description.Text.Trim();

            // Виконуємо пошук
            var results = _movieRepository.SearchMovies(name, year, country, director, genres, description);

            // Викликаємо подію, щоб MainForm оновив dgv
            SearchCompleted?.Invoke(results);

            this.Close();
        }
    }
}
