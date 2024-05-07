using System;
using FactoryMethod_SmsSender_Example.DTO;
using FactoryMethod_SmsSender_Example.Implementations.FactoryMethods;
using FactoryMethod_SmsSender_Example.Interfaces;
using FactoryMethod_SmsSender_Example.Interfaces.IFactoryMethods;

namespace FactoryMethod_SmsSender_Example
{
    public abstract class Program
    {
        private static void Main(string[] args)
        {
            ISmsManagerCreator creator = new SmsManagerCreator();
            var smsManager = creator.FactoryMethod();
            smsManager.SendMessage(new SmsDto()
            {
                Message = "Hello Mohammad...",
                Receiver = "09140743840"
            });
        }
    }
}