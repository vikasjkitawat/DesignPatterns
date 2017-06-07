using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionMVCDemo
{
    public class SampleService : IMyService
    {
        public string[] GetNames()
        {
            return new string[] { "X", "Y", "Z" };
        }
    }
}