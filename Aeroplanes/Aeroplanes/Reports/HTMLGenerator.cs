using Aeroplanes.Models;
using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Reports
{
    public class HTMLGenerator
    {
        public void GenerateHTMLWithColor()
        {
            ReportGenerator report = new ReportGenerator();
            report.GenerateReportAircraftInEurope();
            List<ReportItem> reportOutput = ReportItemRepository.Retrieve();
            string htmlOutput = "";
            htmlOutput += "<table style='border: solid 1px black;'>";
            htmlOutput += "<tr style='background-color: rgba(0, 0, 0, 0.8); color: rgb(255, 255, 255);'><th>Aircraft Tail Number</th><th>Model Number</th><th>Model Description</th><th>Owner Company Name</th><th>Company Country Code</th><th>Company Country Name</th></th>";
            foreach(ReportItem reportLine in reportOutput)
            {
                Console.WriteLine(reportLine.aircraftTailNumber);
                string rowStyle;
                if(reportLine.isEuropeCountry)
                {
                    rowStyle = "style='background-color: rgba(31, 163, 255, 0.5);'";
                }
                else
                {
                    rowStyle = "style='background-color: rgba(252, 99, 113, 0.5);'";
                }
                htmlOutput += $"<tr {rowStyle}><td>{reportLine.aircraftTailNumber}</td><td>{reportLine.modelNumber}</td><td>{reportLine.modelDescription}</td><td>{reportLine.ownerComapanyName}</td><td>{reportLine.companyCountryCode}</td><td>{reportLine.companyCountryName}</td></tr>";
            }
            htmlOutput += "</table>";

            File.WriteAllText(@"H:\Shared drives\MG_donisdonatas\Code Academy\Paskaitos\dotNET\Savarankiskas darbas - Aerocrafts\Ariving Aeroplanes report.htm", htmlOutput);
            Console.WriteLine("HTML Report created.");
            Console.ReadLine();
            
        }
    }
}
