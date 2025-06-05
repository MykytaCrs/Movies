using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPR_MoviesLibrary.Models;

namespace TPR_MoviesLibrary.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _connectionString;

        public MovieRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = new List<Movie>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var sql = "SELECT Id, Name, Year, Country, Director, Genres, Description FROM Films";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            Country = reader["Country"].ToString(),
                            Director = reader["Director"].ToString(),
                            Genres = reader["Genres"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return movies;
        }

        public List<Movie> SearchMovies(string name, int? year, string country, string director, string genres, string description)
        {
            var movies = new List<Movie>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var sql = @"
            SELECT Id, Name, Year, Country, Director, Genres, Description
            FROM Films
            WHERE (@name IS NULL OR Name LIKE '%' + @name + '%')
              AND (@year IS NULL OR Year = @year)
              AND (@country IS NULL OR Country LIKE '%' + @country + '%')
              AND (@director IS NULL OR Director LIKE '%' + @director + '%')
              AND (@genres IS NULL OR Genres LIKE '%' + @genres + '%')
              AND (@description IS NULL OR Description LIKE '%' + @description + '%')";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                    cmd.Parameters.AddWithValue("@year", (object)year ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@country", string.IsNullOrEmpty(country) ? (object)DBNull.Value : country);
                    cmd.Parameters.AddWithValue("@director", string.IsNullOrEmpty(director) ? (object)DBNull.Value : director);
                    cmd.Parameters.AddWithValue("@genres", string.IsNullOrEmpty(genres) ? (object)DBNull.Value : genres);
                    cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Year = Convert.ToInt32(reader["Year"]),
                                Country = reader["Country"].ToString(),
                                Director = reader["Director"].ToString(),
                                Genres = reader["Genres"].ToString(),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }

            return movies;
        }

        public void UpdateMovie(Movie movie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Films 
                         SET Name = @Name, Year = @Year, Country = @Country, 
                             Director = @Director, Genres = @Genres, Description = @Description
                         WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", movie.Name);
                command.Parameters.AddWithValue("@Year", movie.Year);
                command.Parameters.AddWithValue("@Country", movie.Country);
                command.Parameters.AddWithValue("@Director", movie.Director);
                command.Parameters.AddWithValue("@Genres", movie.Genres);
                command.Parameters.AddWithValue("@Description", movie.Description);
                command.Parameters.AddWithValue("@Id", movie.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMovie(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Films WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddMovie(Movie movie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Films (Name, Year, Country, Director, Genres, Description) 
                         VALUES (@Name, @Year, @Country, @Director, @Genres, @Description)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", movie.Name);
                command.Parameters.AddWithValue("@Year", movie.Year);
                command.Parameters.AddWithValue("@Country", movie.Country);
                command.Parameters.AddWithValue("@Director", movie.Director);
                command.Parameters.AddWithValue("@Genres", movie.Genres);
                command.Parameters.AddWithValue("@Description", movie.Description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }



    }
}
