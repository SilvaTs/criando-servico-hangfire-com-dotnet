using Hangfire.Shared.Services;
using System.Net.Mail;
using System.Net;

namespace Hangfire.Producer;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string fromEmail, string password)
    {
        var email = new MailMessage();
        email.From = new MailAddress(fromEmail);
        email.Subject = "Hangfire Job";
        email.To.Add(new MailAddress("test@gmail.com"));
        email.Body = $"<html><body>Hello this is an email sent from HangfireJob</body></html>";
        email.IsBodyHtml = true;

        using var smtpClient = new SmtpClient
        {
            Host = "outlook.office365.com",
            Port = 587,
            Credentials = new NetworkCredential(fromEmail, password),
            EnableSsl = true
        };

        await smtpClient.SendMailAsync(email);
    }
}
