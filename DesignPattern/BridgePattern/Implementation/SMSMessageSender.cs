using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class SMSMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS Sender");
        }
    }
}
