using GmailService;

namespace Adapter_Notification_Example
{
    public class GmailAdapter:ISendMessage
    {
        private readonly GmailServiceGoogle _gmailServiceGoogle = new GmailServiceGoogle();
        
        public void Send(string message)
        {
            _gmailServiceGoogle.SendMail(message);
        }
    }
}