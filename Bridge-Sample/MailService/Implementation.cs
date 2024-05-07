using System.Configuration;

namespace Bridge_Sample.MailService
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            var config = ConfigurationManager.AppSettings;
            if (config["EmailImplementor"] == "Gmail")
            {
                return new GmailService();
            }

            return new YahooService();
        }
    }
}