using ChainOfResponsibility.Entity;
using ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class Manager : RequestHandler
    {        
        public override void ProcessRequest(Request request)
        {
            if (request.Severity == 1)
            {
                request.Approved = true;
                Console.WriteLine("Request for '{0}' is approved by {1}", request.Subject, this.Name);
            }
            else
            {
                Console.WriteLine("Request for '{0}' is forwared to {1}", request.Subject, Next.Name);
                Next.ProcessRequest(request);
            }
        }
    }
}
