using System;
using Bridge_Sample.DataTransferObjects;
using Bridge_Sample.MailService;

namespace Bridge_Sample
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var mailService = new RefinedMailService();
            mailService.Send(new EmailDto()
            {
                Title = "Test Title",
                Message = "Hello My Friend",
                Reciver = "AmirHossein"
            });

            Console.ReadKey();
        }
    }
}