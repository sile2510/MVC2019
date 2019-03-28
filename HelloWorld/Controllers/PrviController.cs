using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public ActionResult MetodaSParametrima(int id)
        {
            //  return View();
            return Content(id.ToString());
        }
    }
}