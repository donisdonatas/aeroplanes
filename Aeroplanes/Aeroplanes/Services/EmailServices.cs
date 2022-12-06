using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
//using EASendMail;
using System.Threading.Tasks;

namespace Aeroplanes.Servises
{
    public class EmailServices
    {
        public void SendEmail(string reportContext)
        {
           
            /*
             * Neveikia, reikia daryti gmail dvigubą autentifikaciją ir susigeneruoti app paswordą
             * 
            var fromAddress = new MailAddress("donisdonatas@gmail.com", "Donatas");
            var toAddress = new MailAddress("d2b@dr.com", "Donatas");
            const string fromPassword = "xxpasswordxx";
            const string subject = "Arriving airplanes report";
            //const string body = reportContext;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 2000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = reportContext
            })
            {
                smtp.Send(message);
            }
            Console.WriteLine("The eMail was sent out.");
            */
        }
    }
}
