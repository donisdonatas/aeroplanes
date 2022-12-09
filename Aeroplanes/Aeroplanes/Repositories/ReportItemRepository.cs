using Aeroplanes.Models;
using System.Collections.Generic;

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
