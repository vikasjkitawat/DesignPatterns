using DecoratorPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class MessageDecorator : Message
    {
        Message message;

        public MessageDecorator(Message message)
        {
            this.message = message;
        }

        public override string Read()
        {
            return message.Read();
        }

        public override void Write(string str)
        {
            message.Write(str);
        }
    }
}
