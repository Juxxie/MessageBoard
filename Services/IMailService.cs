using System;
namespace MessageBoard.Services
{
    public interface IMailService
    {
        bool SendMail(string form, string to, string subject, string body);
    }
}
