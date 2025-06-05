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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPR_MoviesLibrary
{
    public partial class AddFilmForm : Form
    {
        private readonly IMovieRepository _movieRepository;

        public AddFilmForm(IMovieRepository movieRepository)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
        }

        private void btn_submitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_name.Text.Trim();
                string yearText = txt_year.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("The \"Movie Name\" field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(yearText))
                {
                    MessageBox.Show("The \"Year\" field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(yearText, out var year) || year <= 0)
                {
                    MessageBox.Show("The \"Year\" field must be a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newMovie = new Movie
                {
                    Name = name,
                    Year = year,
                    Country = txt_country.Text.Trim(),
                    Director = txt_director.Text.Trim(),
                    Genres = txt_genres.Text.Trim(),
                    Description = txt_description.Text.Trim()
                };

                _movieRepository.AddMovie(newMovie);
                MessageBox.Show("Movie successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
