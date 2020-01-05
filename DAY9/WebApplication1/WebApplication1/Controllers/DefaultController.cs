using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //return View("v2");
            return View();
        }
        public String Hello()
        {
            return "Hello <b>world!!</b><br>ASP.NET</br>";
        }
        public ActionResult Index2()
        {
            //return View("v2");
            return View();
        }

        public ActionResult View3(int id=0,String name="Shashi",String Surname="khetmalis")
        {
            ViewBag.id = id;
            ViewBag.name=name;
            ViewBag.Surname = Surname;
            //return View("v2");
            return View();
        }


    }
}