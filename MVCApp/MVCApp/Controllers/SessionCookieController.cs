using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class SessionCookieController : Controller
    {
        // GET: SessionCookie
        public ActionResult Index()//Kullanıcı icin oturum acma islemleri.
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            //Session'a deger atama
            Session["deger"]=text;
            //Session.Add("deger", text);
            return View();
        }
        public ActionResult Sessions()
        {
            if (Session["deger"] != null)
            {
                ViewBag.SessDeger = Session["deger"].ToString();
            }
            else
            {
                ViewBag.SessDeger = "Session degeri bos";
            }
            return View();
        }
    }
}