using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Business.Manager.Concrete
{
    public class EmailSenderManager : IEmailSender
    {
        private readonly SmtpClient _smtpClient;
        public EmailSenderManager()
        {
            _smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("devhkayan@gmail.com", "ugqkbaudilscvwqo"),
                EnableSsl = true
            }; 
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var mailMessage = new MailMessage 
            { 
                From =new MailAddress("devhkayan@gmail.com"),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);

            try
            {
                await _smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Mail gönderilemedi => " + ex.Message);
            }
        }
    }
}
