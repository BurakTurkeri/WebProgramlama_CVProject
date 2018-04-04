using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Project.Controllers
{
    public class informationController : Controller
    {
        // GET: information
        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }

        public ActionResult Experience()
        {
            return View();
        }

        public ActionResult ContactMe()
        {
            return View();
        }
    }
}