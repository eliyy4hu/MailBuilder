namespace MailBuilder
{
    
    public interface IMailToMailBuilder
    {
        IBodyMailBuilder SetMailTo(string mailTo);

    }
    public interface IBodyMailBuilder
    {
        IBodyMailBuilder SetMailTo(string mailTo);
        IFinalMailBuilder SetBody(string body);
    }

    public interface IFinalMailBuilder
    {
        IFinalMailBuilder SetBody(string body);
        IFinalMailBuilder SetMailTo(string mailTo);
        IFinalMailBuilder SetTopic(string topic);
        Mail GetResult();

    }
}