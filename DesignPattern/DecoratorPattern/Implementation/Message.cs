using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Implementation
{
    public abstract class Message
    {
        public abstract string Read();

        public abstract void Write(string str);
    }
}
