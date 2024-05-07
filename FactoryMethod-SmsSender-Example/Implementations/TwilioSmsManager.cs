using System;
using FactoryMethod_SmsSender_Example.DTO;
using FactoryMethod_SmsSender_Example.Interfaces;

namespace FactoryMethod_SmsSender_Example.Implementations
{
    public class TwilioSmsManager: ISmsManager
    {
        public void SendMessage(SmsDto dto)
        {
            Console.WriteLine($"Send Message With Twilio... Receiver: {dto.Receiver}, Message: {dto.Message}");
        }
    }
}