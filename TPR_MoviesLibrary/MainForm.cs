using System.Net.Http.Json;
using System.Windows.Forms;
using TPR_MoviesLibrary.Models;
using TPR_MoviesLibrary.Repositories;

namespace TPR_MoviesLibrary
{
    public partial class MainForm : Form
    {
        private readonly IPrivelegedUserRepository _privelegedUserRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IReportRepository _reportRepository;
        private PrivelegedUser? _currentUser;

        public MainForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;

            _privelegedUserRepository = factory.CreatePrivelegedUserRepository();
            _movieRepository = factory.CreateMovieRepository();
            _reportRepository = factory.CreateReportRepository();
            InitializeSearchTypes();
            InitializeVerdicts();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_empl_id.Text, out int userId))
            {
                MessageBox.Show("Invalid user ID format.");
                return;
            }

            string password = txt_password.Text;
            _currentUser = _privelegedUserRepository.Authenticate(userId, password);

            if (_currentUser != null)
            {
                ApplyRoleAccess(_currentUser.Role);
                MessageBox.Show($"Welcome, {_currentUser.Role}!");
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void ApplyRoleAccess(string role)
        {
            if (role == "Admin")
            {
                tabControl1.TabPages[1].Enabled = true;
                tabControl1.TabPages[2].Enabled = false;

            }
            else if (role == "Moderator")
            {
                tabControl1.TabPages[1].Enabled = false;
                tabControl1.TabPages[2].Enabled = true;
            }
            lbl_username.Text = $"Role: {role}";
            lbl_username2.Text = $"Role: {role}";
        }


        private void btn_LoadInfo_Click(object sender, EventArgs e)
        {
            var searchType = cb_searchType.SelectedItem?.ToString();

            List<Movie> movies;

            if (searchType == "All")
            {
                movies = _movieRepository.GetAllMovies();
                /*var decoratedMovies = movies.Select(m => new MovieWithNovelty(m)).ToList();
                dgv_movies.DataSource = decoratedMovies;
                dgv_movies.Columns["Novelty"].HeaderText = "Novelty";
                dgv_movies.Columns["Novelty"].DisplayIndex = 5;*/
                dgv_movies.DataSource = movies;
                dgv_movies.AutoResizeColumns();
            }
            else if (searchType == "New...")
            {
                var newSearchForm = new NewSearchForm(_movieRepository);
                newSearchForm.SearchCompleted += (results) =>
                {
                    /*var decoratedMovies = results.Select(m => new MovieWithNovelty(m)).ToList();
                    dgv_movies.DataSource = decoratedMovies;
                    dgv_movies.Columns["Novelty"].HeaderText = "Novelty";
                    dgv_movies.Columns["Novelty"].DisplayIndex = 5;*/
                    dgv_movies.DataSource = results;
                    dgv_movies.AutoResizeColumns();
                };
                newSearchForm.ShowDialog();
            }
            else
            {
                movies = _movieRepository.GetAllMovies(); // тимчасово
                dgv_movies.DataSource = movies;
                dgv_movies.AutoResizeColumns();
            }
        }


        private void InitializeSearchTypes()
        {
            cb_searchType.Items.Clear();
            cb_searchType.Items.Add("All");
            cb_searchType.Items.Add("New...");
            cb_searchType.SelectedIndex = 0;
        }


        private void btn_AddFilm_Click(object sender, EventArgs e)
        {
            var addForm = new AddFilmForm(_movieRepository);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                cb_searchType.SelectedIndex = 0;
                btn_LoadInfo.PerformClick(); // оновити таблицю
            }
        }

        private void dgv_movies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_movies.Rows[e.RowIndex].DataBoundItem is Movie selectedMovie)
            {
                var editForm = new EditFilmForm(_movieRepository, selectedMovie);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Оновити список
                    cb_searchType.SelectedIndex = 0;
                    btn_LoadInfo.PerformClick();
                }
            }
        }

        private void btn_showReports_Click(object sender, EventArgs e)
        {
            try
            {
                var reports = _reportRepository.GetAllReports();
                dgv_moderator.DataSource = reports;
                dgv_moderator.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeVerdicts()
        {
            cb_verdicts.Items.Clear();
            cb_verdicts.Items.Add("No Action");
            cb_verdicts.Items.Add("Temporary Suspension");
            cb_verdicts.Items.Add("Ban");
            cb_verdicts.SelectedIndex = 0;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (dgv_moderator.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report.");
                return;
            }

            var selectedRow = dgv_moderator.SelectedRows[0];
            if (selectedRow.DataBoundItem is not ReportViewModel selectedReport)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            string selectedVerdict = cb_verdicts.SelectedItem?.ToString() ?? "No Action";

            var confirm = MessageBox.Show(
                $"Apply verdict '{selectedVerdict}' to report #{selectedReport.ReportId}?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _reportRepository.UpdateVerdict(selectedReport.ReportId, selectedVerdict, DateTime.Now);
                MessageBox.Show("Verdict applied successfully.");

                // Оновлення таблиці
                LoadReports();
            }
        }
        private void LoadReports()
        {
            var reports = _reportRepository.GetAllReports();
            dgv_moderator.DataSource = reports;
            dgv_moderator.AutoResizeColumns();
        }

        private async void dgv_moderator_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var description = dgv_moderator.Rows[e.RowIndex].Cells["Description"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(description)) return;

            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(5); // timeout to prevent hanging

                var response = await client.PostAsJsonAsync("http://localhost:5230/api/moderation/analyze", new { text = description });

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<dynamic>();
                    MessageBox.Show($"Moderation result: {result.result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Moderation service returned an error:\n{(int)response.StatusCode} {response.ReasonPhrase}", "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Failed to connect to the moderation service.\n\n" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("The request to the moderation service timed out.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n\n" + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}