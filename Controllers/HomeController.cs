using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration =10)] // Cache data for 10 sec
        public ActionResult Index()
        {
            return View();
        }

        // Save Data on server
        [OutputCache(Duration = 10, Location =System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Save Data on Client
        [OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Check for Validate Input From Page
        [ValidateInput(false)] // True : Validate Data, False : Not Validate
        public ActionResult GetData()
        {
            return View();
        }
    }
}