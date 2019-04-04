using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6._2._1_TemplatedHelper.Models;

namespace _6._2._1_TemplatedHelper.Controllers
{
    public class MetaDataHtmlHelperiController : Controller
    {
        // GET: MetaDataHtmlHelperi
        public ActionResult MetaDataView()
        {
            return View(new OsobaMeta());
        }

        [HttpPost]
        public ActionResult MetaDataView(OsobaMeta osoba)
        {
            return View("/TemplHtmlHelperi/HtmlLabelDisplay", osoba);
        }

        
    }
}