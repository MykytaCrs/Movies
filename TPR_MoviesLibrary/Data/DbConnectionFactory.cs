using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TPR_MoviesLibrary.Data
{
    

    public static class DbConnectionFactory
    {
        public static SqlConnection Create(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
