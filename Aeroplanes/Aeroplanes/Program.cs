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
            Console.WriteLine("Labas, čia dispečerinė");

            DefoultValues.AddDefoultValuesToAllRepositories();

            Console.WriteLine("-----------------");

            HTMLGenerator Html = new HTMLGenerator();
            Html.GenerateHTMLWithColor();

            Console.ReadLine();
        }
    }
}
