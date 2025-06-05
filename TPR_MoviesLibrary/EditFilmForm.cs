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
    public partial class EditFilmForm : Form
    {
        private readonly IMovieRepository _movieRepository;
        private readonly Movie _movie;

        public EditFilmForm(IMovieRepository movieRepository, Movie movie)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            _movie = movie;

            LoadMovieData();
        }

        private void LoadMovieData()
        {
            txt_name.Text = _movie.Name;
            txt_year.Text = _movie.Year.ToString();
            txt_country.Text = _movie.Country;
            txt_director.Text = _movie.Director;
            txt_genres.Text = _movie.Genres;
            txt_description.Text = _movie.Description;
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", $"{_movie.Id}.jpg");

            if (File.Exists(imagePath))
            {
                pb_photo.Image = Image.FromFile(imagePath);
                pb_photo.SizeMode = PictureBoxSizeMode.StretchImage; // опційно
            }
            else
            {
                pb_photo.Image = null; // або встановити зображення-заглушку
            }
        }

        private void btn_submitEdit_Click(object sender, EventArgs e)
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

            if (!int.TryParse(yearText, out int year) || year <= 0)
            {
                MessageBox.Show("The \"Year\" field must be a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _movie.Name = name;
            _movie.Year = year;
            _movie.Country = txt_country.Text.Trim();
            _movie.Director = txt_director.Text.Trim();
            _movie.Genres = txt_genres.Text.Trim();
            _movie.Description = txt_description.Text.Trim();

            _movieRepository.UpdateMovie(_movie);

            MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
        "Are you sure you want to delete this movie?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _movieRepository.DeleteMovie(_movie.Id);
                MessageBox.Show("Movie deleted successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
