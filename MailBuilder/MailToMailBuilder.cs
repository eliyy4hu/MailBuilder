namespace MailBuilder
{
    public class MailToMailBuilder : IMailToMailBuilder
    {
        private Mail Mail = new Mail();
        public IBodyMailBuilder SetMailTo(string mailTo)
        {
            Mail.MailTo.Add(mailTo);
            return new BodyMailBuilder(Mail);
        }
    }

    public class BodyMailBuilder : IBodyMailBuilder
    {
        private Mail Mail;
        public BodyMailBuilder(Mail mail)
        {
            Mail = mail;
        }

        public IBodyMailBuilder SetMailTo(string mailTo)
        {
            Mail.MailTo.Add(mailTo);
            return this;
        }

        public IFinalMailBuilder SetBody(string body)
        {
            Mail.Body = body;
            return new FinalMailBuilder(Mail);
        }
    }

    public class FinalMailBuilder : IFinalMailBuilder
    {
        private Mail Mail;
        public FinalMailBuilder(Mail mail)
        {
            Mail = mail;
        }

        public IFinalMailBuilder SetBody(string body)
        {
            Mail.Body = body;
            return this;
        }

        public IFinalMailBuilder SetMailTo(string mailTo)
        {
            Mail.MailTo.Add(mailTo);
            return this;
        }

        public IFinalMailBuilder SetTopic(string topic)
        {
            Mail.Topic = topic;
            return this;
        }

        public Mail GetResult()
        {
            return Mail;
        }
    }
}