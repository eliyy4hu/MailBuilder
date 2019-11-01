using System.Collections.Generic;

namespace MailBuilder
{
    public class Mail
    {
        public List<string> MailTo = new List<string>();
        public string Body;
        public string Topic;
    }
}