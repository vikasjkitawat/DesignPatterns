using DecoratorPattern.Decorator;
using DecoratorPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new RsaEncryptionSecurityDecorator(new ZipCompressionDecorator(new UnicodeMessage()));
            message.Write("Hello");
            Console.WriteLine(message.Read());

            Console.ReadKey();
        }
    }
}
