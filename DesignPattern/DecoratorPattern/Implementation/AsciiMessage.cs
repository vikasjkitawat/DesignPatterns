using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Implementation
{
    public class AsciiMessage : Message
    {
        private string msg;

        public override string Read()
        {
            return msg;
        }

        public override void Write(string str)
        {
            this.msg = "ASCII Message: " + str;
        }
    }
}
