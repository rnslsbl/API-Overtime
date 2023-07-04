using API_Overtime.Utilities;

namespace API_Overtime.Contracts
{
    public interface IEmailService 
    {
        void SendEmailAsync();
        MailService SetEmail(string email);
        MailService SetSubject(string subject);
        MailService SetHtmlMessage(string htmlMessage);
    }
}
