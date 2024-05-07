using FactoryMethod_SmsSender_Example.DTO;

namespace FactoryMethod_SmsSender_Example.Interfaces
{
    public interface ISmsManager
    {
        void SendMessage(SmsDto dto);
    }
}