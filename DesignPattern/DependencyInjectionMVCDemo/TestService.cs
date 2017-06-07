using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionMVCDemo
{
    public class TestService : IMyService
    {
        public string[] GetNames()
        {
            return new string[] { "A", "B", "C" };
        }
    }
}