using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class VievResultController : Controller
    {
        // GET: VievResult
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()//Index2 methoduna istek gelince Home/Index sayfasına git.
        {
            return Redirect("Home/Index");
        }
    }
}