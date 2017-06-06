using DecoratorPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class RsaEncryptionSecurityDecorator : MessageDecorator
    {
        public RsaEncryptionSecurityDecorator(Message message) : base(message)
        {
        }

        public override string Read()
        {
            Console.WriteLine("RSA Secured Message");
            return base.Read();
        }

        public override void Write(string str)
        {
            Console.WriteLine("Securing Message Using RSA");
            base.Write(str);
        }
    }
}
