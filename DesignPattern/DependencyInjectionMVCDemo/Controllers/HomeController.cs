using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        IMyService svc;

        //No parameterless constructor defined for this object.

        //If we use this then the above message is shown as we cannot create constructor using Parameterised Constructor
        //public HomeController(IMyService svc)
        //{
        //    this.svc = svc;
        //}

        //Named Dependency
        //https://stackoverflow.com/questions/7046779/with-unity-how-do-i-inject-a-named-dependency-into-a-constructor
        public HomeController([Dependency("Test")] IMyService svc)
        {
            this.svc = svc;
        }

        public ActionResult Index()
        {
            ViewBag.Names = svc.GetNames();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}