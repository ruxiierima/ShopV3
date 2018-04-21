using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers
{
    public class ConfirmationMail
    {
        public static void SendEmail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                client.UseDefaultCredentials = false;
                NetworkCredential credential = new NetworkCredential("cutemdown12@gmail.com", "Laborator2");
                MailMessage mailMessage = new MailMessage();
                client.Credentials = credential;

                mailMessage.From = new MailAddress("cutemdown12@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Cont creat cu succes";
                mailMessage.Body = "Bine ai venit în universul GLOBAL SHOP!\n Iti multumim ca ai apelat la serviciile noastre. ";
                client.EnableSsl = true;
                client.Send(mailMessage);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

