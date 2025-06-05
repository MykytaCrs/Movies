using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Repositories
{
    public class PrivelegedUserRepository : IPrivelegedUserRepository
    {
        private readonly string _connectionString;

        public PrivelegedUserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PrivelegedUser? Authenticate(int userId, string password)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM PrivelegedUsers WHERE Id = @id AND Password = @password", connection);
            command.Parameters.AddWithValue("@id", userId);
            command.Parameters.AddWithValue("@password", password);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new PrivelegedUser
                {
                    Id = (int)reader["Id"],
                    Password = reader["Password"].ToString()!,
                    Role = reader["Role"].ToString()!
                };
            }

            return null;
        }
    }
}
