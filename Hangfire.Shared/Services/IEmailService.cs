namespace Hangfire.Shared.Services;

public interface IEmailService
{
    Task SendEmail(string email, string password);
}
