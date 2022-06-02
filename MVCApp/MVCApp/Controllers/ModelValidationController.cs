using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ModelValidationController : Controller
    {
        // GET: ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UyeBilgi = $"Üye Adı :{uye.Ad} <hr> Soyadı : {uye.Soyad} <hr> Email : {uye.Email}";
                {
                    return View();
                }
            }
            return View();
        }
        public ActionResult UyeDuzenle()
        {
            return View();
        }

    }
}