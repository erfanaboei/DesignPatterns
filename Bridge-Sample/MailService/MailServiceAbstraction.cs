using Bridge_Sample.DataTransferObjects;

namespace Bridge_Sample.MailService
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor _mailServiceImplementor;

        protected MailServiceAbstraction()
        {
            _mailServiceImplementor = Implementation.GetImplementor();
        }

        public virtual void Send(EmailDto dto)
        {
            _mailServiceImplementor.SendEmail(dto.Title, dto.Reciver, dto.Message);
        }
    }

    public class RefinedMailService : MailServiceAbstraction
    {
        
    }
}