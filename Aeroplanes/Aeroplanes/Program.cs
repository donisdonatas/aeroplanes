using Aeroplanes.Repositories;
using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeroplanes.Reports;

namespace Aeroplanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("labas, čia dispečerinė");


            DefoultValues.AddDefoultValuesToAllRepositories();

            //DefoultValues.AddDefoultCountriesToRepository();
            //country.AddDefoultCountriesToRepository();
            //country.AddDefoultCountriesToRepository();
            //country.GetCountryList();
            Console.WriteLine("-----------------");

            //AircraftModel aircrafModel = new AircraftModel("E75S", "Embraer E175STD");
            //AircraftModelRepository.aircraftModel.Add(aircrafModel);
            //aircrafModel.AddDefoultAircraftModelsToRepository();
            //aircrafModel.GetAircraftModelsList();

            //ReportGenerator report = new ReportGenerator();
            Console.WriteLine("-----------------");
            //report.ReadAllRepositories();
            HTMLGenerator Html = new HTMLGenerator();
            //ReportGenerator report = new ReportGenerator();
            Html.GenerateHTMLWithColor();

            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");

            //ReportGenerator report = new ReportGenerator();
            //report.GenerateReportAircraftInEurope();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
