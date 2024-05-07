using System;

namespace Adapter_Notification_Example
{
    public class Telegram: ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"Message Send With {nameof(Telegram)} => {message}");
        }
    }
}