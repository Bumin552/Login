using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ControllerToVievController : Controller
    {
        // GET: ControllerToViev
        public ActionResult Index()
        {
            ViewBag.KategoriAdi = "Bilgisayar";
            ViewData["Urun Adi"] = "Hp";
            TempData["urun fiyati"] = 4990;
            return View();
        }
    }
}