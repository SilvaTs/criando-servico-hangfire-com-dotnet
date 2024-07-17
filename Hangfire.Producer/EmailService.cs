using Hangfire.Shared.Services;

namespace Hangfire.Producer;

public class EmailService : IEmailService
{
    public Task SendEmail(string email, string password)
    {
        throw new NotImplementedException();
    }
}
