using Aeroplanes.Models;
using System;
using Aeroplanes.Reports;
using Aeroplanes.Servises;

namespace Aeroplanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is Control Tower");
            Console.WriteLine("----------------------");

            //Adding default values to repositories. Simulating database.
            DefaultValues.AddDefaultValuesToAllRepositories();
            Console.WriteLine("----------------------");

            //Creating HTML report, and later passing him to EmailService
            HTMLGenerator Html = new HTMLGenerator();
            string htmlText = Html.GenerateHTMLWithColor();
            Console.WriteLine("----------------------");

            //Service to send raport via Email to Airaport director
            EmailService sendEmail = new EmailService();
            string recipientsEmail = "d2b@dr.com";
            sendEmail.SendEmail(htmlText, recipientsEmail);

            Console.ReadLine();
        }
    }
}
