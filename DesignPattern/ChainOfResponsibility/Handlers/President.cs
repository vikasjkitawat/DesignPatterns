using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Entity;

namespace ChainOfResponsibility.Handlers
{
    public class President : RequestHandler
    {
        public override void ProcessRequest(Request request)
        {
            request.Approved = true;
            Console.WriteLine("Request for '{0}' is approved by {1}", request.Subject, this.Name);           
        }
    }
}
