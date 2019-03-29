using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Controllers;
using HelloWorld.Models;



namespace HelloWorld.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osobe
        public ViewResult PopuniOsobu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult PrikaziOsobu (Osoba osoba)
        {
            return View(osoba);
        }
    }
}