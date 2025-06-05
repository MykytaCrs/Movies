using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary.Models
{
    public class ReportViewModel
    {
        public int ReportId { get; set; }
        public string UserNickname { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Verdict { get; set; } = string.Empty;
        public DateTime? Date { get; set; }
    }
}
