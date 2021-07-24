using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class ClientController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Custom Exception Occured");
        }
    }
}