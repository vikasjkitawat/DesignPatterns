using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Implementation;

namespace DecoratorPattern.Decorator
{
    public class ShaEncryptionSecurityDecorator : MessageDecorator
    {
        public ShaEncryptionSecurityDecorator(Message message) : base(message)
        {
        }

        public override string Read()
        {
            Console.WriteLine("SHA Secured Message");
            return base.Read();
        }

        public override void Write(string str)
        {
            Console.WriteLine("Securing Message Using SHA");
            base.Write(str);
        }
    }
}
