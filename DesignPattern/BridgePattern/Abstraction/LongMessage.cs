using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public class LongMessage : Message
    {
        IMessageSender sender;

        public LongMessage(IMessageSender sender)
        {
            this.sender = sender;
        }

        public void SendMessage(string message)
        {
            sender.SendMessage(message);
        }
    }
}
