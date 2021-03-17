using System;

namespace SlackClone.Domain
{
    public class SlackMessage
    {
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public string Message { get; set; }
    }
}