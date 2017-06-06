using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class MailMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Mail Message Sender");
        }
    }
}
