using DecoratorPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class ZipCompressionDecorator : MessageDecorator
    {
        public ZipCompressionDecorator(Message message) : base(message)
        {
        }

        public override string Read()
        {
            Console.WriteLine("Zipped Message");
            return base.Read();
        }

        public override void Write(string str)
        {
            Console.WriteLine("Compressing Message using ZIP");
            base.Write(str);
        }
    }
}
