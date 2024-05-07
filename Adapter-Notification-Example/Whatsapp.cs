using System;

namespace Adapter_Notification_Example
{
    public class Whatsapp: ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"Message Send With {nameof(Whatsapp)} => {message}");
        }
    }
}