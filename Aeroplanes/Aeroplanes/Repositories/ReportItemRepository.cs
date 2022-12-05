using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Repositories
{
    public static class ReportItemRepository
    {
        public static List<ReportItem> report = new List<ReportItem>();

        public static List<ReportItem> Retrieve()
        {
            return report;
        }
    }
}
