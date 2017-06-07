using ChainOfResponsibility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public abstract class RequestHandler
    {
        public string Name { get; set; }

        public RequestHandler Next { get; set; }

        public abstract void ProcessRequest(Request request);
    }
}
