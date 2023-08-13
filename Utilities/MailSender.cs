using System.Net;
using System.Net.Mail;
using Umbraco.Cms.Infrastructure.Mail;
using UmbracoProject.Models;

namespace UmbracoProject.Utilities
{
    public class MailSender
    {

        public static void SendEmail(EmailForm mailModel)
        {
        string recipientEmail = mailModel.Receiever;



            // Create a new MailMessage
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("admin@umbraco.com");
            mail.To.Add(recipientEmail);
            mail.Subject = mailModel.Title;
            mail.Body = mailModel.Message;

            // Create a new SmtpClient
            SmtpClient smtpClient = new SmtpClient("127.0.0.1",25);

            try
            {
                // Send the email
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
            

        }
    }
}
