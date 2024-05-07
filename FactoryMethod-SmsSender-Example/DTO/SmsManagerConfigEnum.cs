using System.ComponentModel.DataAnnotations;

namespace FactoryMethod_SmsSender_Example.DTO
{
    public enum SmsManagerConfigEnum
    {
        [Display(Name = "کاوه نگار")]
        KavehNagar = 1,
        [Display(Name = "تویلیو")]
        Twilio = 2,
    }
}