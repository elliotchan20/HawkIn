using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HawkerIn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult WhyJoinUs()
        {
            ViewBag.Message = "Why Join Us";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Hawker Profile";

            return View();
        }

        public ActionResult Hawkersell()
        {
            ViewBag.Message = "Hawkersell";

            return View();
        }

        public ActionResult HawkerHistory()
        {
            ViewBag.Message = "HawkerHistory";

            return View();
        }

        public List<string> HawkerAddress()
        {
            List<string> hawkerAddresses = new List<string>
            {
                "ABC Brickworks Market and Food Centre"
            };

            return hawkerAddresses;
        }


    }
}