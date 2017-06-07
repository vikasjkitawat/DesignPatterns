using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace DependencyInjectionMVCDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //NamedTypes
            container.RegisterType<IMyService, TestService>("Test");
            container.RegisterType<IMyService, SampleService>("Sample");

            //Dependency Injection
            //container.RegisterType<IMyService, SampleService>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}