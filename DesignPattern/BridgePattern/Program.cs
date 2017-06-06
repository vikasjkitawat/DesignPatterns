using BridgePattern.Abstraction;
using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender sender = new SMSMessageSender();
            Message message = new ShortMessage(sender);
            message.SendMessage("Sms");

            IMessageSender sender2 = new MailMessageSender();
            Message message2 = new LongMessage(sender2);
            message2.SendMessage("Email Message");
            
            Console.ReadKey();
        }
    }
}
