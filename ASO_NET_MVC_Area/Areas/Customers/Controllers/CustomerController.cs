using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASO_NET_MVC_Area.Areas.Customers.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customers/Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}