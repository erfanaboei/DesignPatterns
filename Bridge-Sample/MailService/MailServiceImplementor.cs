using System;

namespace Bridge_Sample.MailService
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string title, string reciver, string message);
    }

    public class GmailService : IMailServiceImplementor
    {
        public void SendEmail(string title, string reciver, string message)
        {
            Console.WriteLine($"Email --{message}-- Sended To --{reciver}-- With {nameof(GmailService)}");
        }
    }
    public class YahooService : IMailServiceImplementor
    {
        public void SendEmail(string title, string reciver, string message)
        {
            Console.WriteLine($"Email --{message}-- Sended To --{reciver}-- With {nameof(YahooService)}");
        }
    }
}