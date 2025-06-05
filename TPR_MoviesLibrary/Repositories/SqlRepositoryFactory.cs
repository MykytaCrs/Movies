using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Repositories
{
    public class SqlRepositoryFactory : IRepositoryFactory
    {
        private readonly string _connectionString;

        public SqlRepositoryFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IMovieRepository CreateMovieRepository()
        {
            return new MovieRepository(_connectionString);
        }

        public IPrivelegedUserRepository CreatePrivelegedUserRepository()
        {
            return new PrivelegedUserRepository(_connectionString);
        }

        public IReportRepository CreateReportRepository()
        {
            return new ReportRepository(_connectionString);
        }
    }
}
