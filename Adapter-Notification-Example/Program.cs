using System;

namespace Adapter_Notification_Example
{
    internal abstract class Program
    {
        internal static void Main(string[] args)
        {
            ISendMessage telegram = new Telegram();
            telegram.Send("Hello Erfan");

            ISendMessage whatsapp = new Whatsapp();
            whatsapp.Send("Hello Ali");

            ISendMessage gmail = new GmailAdapter();
            gmail.Send("Hello Amir");
            
            Console.ReadKey();
        }
    }
}