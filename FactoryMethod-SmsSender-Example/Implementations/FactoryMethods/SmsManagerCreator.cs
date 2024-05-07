using FactoryMethod_SmsSender_Example.DTO;
using FactoryMethod_SmsSender_Example.Interfaces;
using FactoryMethod_SmsSender_Example.Interfaces.IFactoryMethods;

namespace FactoryMethod_SmsSender_Example.Implementations.FactoryMethods
{
    public class SmsManagerCreator: ISmsManagerCreator
    {
        private readonly SmsManagerConfigEnum _config = SmsManagerConfigEnum.Twilio;
        
        public ISmsManager FactoryMethod()
        {
            if (_config == SmsManagerConfigEnum.KavehNagar) return new KavehNegarSmsManager(); 
            
            return new TwilioSmsManager();
        }
    }
}