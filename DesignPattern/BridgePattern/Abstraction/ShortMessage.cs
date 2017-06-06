using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Implementation;

namespace BridgePattern.Abstraction
{
    public class ShortMessage : Message
    {
        IMessageSender sender;

        public ShortMessage(IMessageSender sender)
        {
            this.sender = sender;
        }

        public void SendMessage(string message)
        {
            sender.SendMessage(message);
        }
    }
}
