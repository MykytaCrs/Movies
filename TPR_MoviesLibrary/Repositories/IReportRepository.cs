using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPR_MoviesLibrary.Models;

namespace TPR_MoviesLibrary.Repositories
{
    public interface IReportRepository
    {
        List<ReportViewModel> GetAllReports();
        void UpdateVerdict(int reportId, string verdict, DateTime date);

    }
}
