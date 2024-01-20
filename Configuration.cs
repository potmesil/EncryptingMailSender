using System.Configuration;

namespace EncryptingMailSender
{
    public class MailSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("from")]
        public FromElement From => (FromElement)this["from"];

        [ConfigurationProperty("smtp")]
        public SmtpElement Smtp => (SmtpElement)this["smtp"];
    }

    public class FromElement : ConfigurationElement
    {
        [ConfigurationProperty("address")]
        public string Address => (string)this["address"];

        [ConfigurationProperty("name")]
        public string Name => (string)this["name"];
    }

    public class SmtpElement : ConfigurationElement
    {
        [ConfigurationProperty("host")]
        public string Host => (string)this["host"];

        [ConfigurationProperty("port", DefaultValue = 25)]
        public int Port => (int)this["port"];

        [ConfigurationProperty("enableSsl")]
        public bool EnableSsl => (bool)this["enableSsl"];

        [ConfigurationProperty("userName")]
        public string UserName => (string)this["userName"];

        [ConfigurationProperty("password")]
        public string Password => (string)this["password"];
    }
}