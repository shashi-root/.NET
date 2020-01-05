using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int id=0,int f1=0,int f2=0)
        {
            ViewBag.id = id;
           
            ViewBag.f3 = f1 + f2;
            return View();
        }
        public ActionResult Hello()
        {
            
            return View("Welcome");
        }
        public ActionResult Welcome()
        {
            return View();
        }
        
    }
}