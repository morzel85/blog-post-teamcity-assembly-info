using Core;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace AssemblyInfoTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CoreAssemblyInfo = SomeCoreClass.GetAssemblyInfo();
            ViewBag.DataAccessAssemblyInfo = SomeDataAccessClass.GetAssemblyInfo();
            ViewBag.WebAssemblyInfo = Assembly.GetExecutingAssembly().FullName;
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