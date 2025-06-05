using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TPR_MoviesLibrary.Models;

namespace TPR_MoviesLibrary.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly string _connectionString;

        public ReportRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ReportViewModel> GetAllReports()
        {
            var reports = new List<ReportViewModel>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
            SELECT 
                r.idReport,
                u.nickname,
                r.description,
                r.verdict,
                r.date
            FROM Report r
            JOIN Users u ON r.idUser = u.idUser
            ORDER BY 
                CASE WHEN r.date IS NULL THEN 0 ELSE 1 END, 
                r.date DESC", conn); 
        
        using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reports.Add(new ReportViewModel
                        {
                            ReportId = reader.GetInt32(0),
                            UserNickname = reader.GetString(1),
                            Description = reader.GetString(2),
                            Verdict = reader.GetString(3),
                            Date = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4)
                        });
                    }
                }
            }

            return reports;
        }


        public void UpdateVerdict(int reportId, string verdict, DateTime date)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
            UPDATE Report 
            SET verdict = @verdict, date = @date 
            WHERE idReport = @id", conn);

                cmd.Parameters.AddWithValue("@verdict", verdict);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@id", reportId);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
