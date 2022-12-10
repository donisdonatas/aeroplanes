﻿using Aeroplanes.Models;
using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aeroplanes.Reports
{
    public class HTMLGenerator
    {
        public string GenerateHTMLWithColor()
        {
            ReportGenerator report = new ReportGenerator();
            report.GenerateReportAircraftInEurope();
            List<ReportItem> reportOutput = ReportItemRepository.Retrieve();
            generateConsoleRaport(reportOutput);
            string htmlOutput = generateHTMLraport(reportOutput);
            string pathToHTMLreport = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\..\Ariving Aeroplanes report.html"));
            File.WriteAllText(pathToHTMLreport, htmlOutput);
            Console.WriteLine($"HTML Report saved: {pathToHTMLreport}");
            System.Diagnostics.Process.Start(pathToHTMLreport);
            return htmlOutput;
        }

        private string generateHTMLraport(List<ReportItem> reportOutput)
        {
            string htmlOutput = "";
            htmlOutput += "<table style='border: solid 1px black;'>";
            htmlOutput += "<tr style='background-color: rgba(0, 0, 0, 0.8); color: rgb(255, 255, 255);'><th>Aircraft Tail Number</th><th>Model Number</th><th>Model Description</th><th>Owner Company Name</th><th>Company Country Code</th><th>Company Country Name</th></th>";
            foreach (ReportItem reportLine in reportOutput)
            {
                string rowStyle = reportLine.isEuropeCountry ? "style='background-color: rgba(31, 163, 255, 0.5);'" : "style='background-color: rgba(252, 99, 113, 0.5);'";
                htmlOutput += $"<tr {rowStyle}><td>{reportLine.aircraftTailNumber}</td><td>{reportLine.modelNumber}</td><td>{reportLine.modelDescription}</td><td>{reportLine.ownerComapanyName}</td><td>{reportLine.companyCountryCode}</td><td>{reportLine.companyCountryName}</td></tr>";
            }
            htmlOutput += "</table>";
            return htmlOutput;
        }

        private void generateConsoleRaport(List<ReportItem> reportOutput)
        {
            Console.WriteLine(String.Format("| {0,-10}| {1,-10}| {2,-32}| {3,-18}| {4,-15}| {5,-15}|", "Tail Nr.", "Model Nr.", "Model Description", "Owner Company Name", "Country Code", "Country Name"));
            foreach (ReportItem reportLine in reportOutput)
            {
                Console.WriteLine(String.Format("| {0,-8}{6, -2}| {1,-10}| {2,-32}| {3,-18}| {4,-15}| {5,-15}|", reportLine.aircraftTailNumber, reportLine.modelNumber, reportLine.modelDescription, reportLine.ownerComapanyName, reportLine.companyCountryCode, reportLine.companyCountryName, !reportLine.isEuropeCountry ? "*" : ""));
            }
            Console.WriteLine("* - Non Europe Country");
            Console.WriteLine("----------------------");
        }
    }
}
