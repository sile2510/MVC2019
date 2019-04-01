using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class BrojGodinaController : Controller
    {
        // GET: BrojGodina
        public ActionResult RacunajBrojGodina()
        {
            return View();
        }

        //POST /BrojGodina/RacunajBrojgodina
        [HttpPost]
        public ActionResult RacunajBrojGodina(DateTime Datum)
        {
            int danasnji = (int)((DateTime.Now-Datum).TotalDays / 365);
            //int razlikaGodina = DateTime.Now.Year;
            return View(danasnji);
        }
    }
}