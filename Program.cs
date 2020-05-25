using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress from = new MailAddress("address@gmail.com", "Name");
            MailAddress to = new MailAddress("address@yandex.ru");

            MailMessage objectMail = new MailMessage(from, to);
            objectMail.Subject = "Тест";
            objectMail.Body = "<h2>Письмо-тест работы smtp-клиента</2>";
            objectMail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("address@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            Console.Read();
        }
    }
}

