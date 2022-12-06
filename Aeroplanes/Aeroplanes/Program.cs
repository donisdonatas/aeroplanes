using Aeroplanes.Repositories;
using Aeroplanes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeroplanes.Reports;
using Aeroplanes.Servises;

namespace Aeroplanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, čia dispečerinė");
            Console.WriteLine("----------------------");

            DefaultValues.AddDefaultValuesToAllRepositories();

            Console.WriteLine("----------------------");

            HTMLGenerator Html = new HTMLGenerator();
            string htmlText = Html.GenerateHTMLWithColor();

            Console.WriteLine("----------------------");

            /*
            EmailServices sendEmail = new EmailServices();
            sendEmail.SendEmail(htmlText);
            */

            Console.ReadLine();
        }
    }
}
