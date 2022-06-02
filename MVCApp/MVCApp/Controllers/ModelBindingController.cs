using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {
            var sayfaModeli = new AnasayfaModel
            {
                Adresnesnesi = new Adres { Sehir = "Erzurum", Ilce = "Palandoken", AcıkAdres = "Pınar" },
                Kullanicinesnesi = new Kullanici { Ad = "Murat", Soyad = "Berberoglu", Email = "mberberogl@gmail.com" }
            };
            return View(sayfaModeli);
        }
        public ActionResult Kullanici() //GetMethodu. Varsayılan degerdir.
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = "Murat";
            kullanici.Soyad = "Berberoglu";
            kullanici.Email = "mberberogl@gmail.com";
            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici) //Post Methodu. Varsayılan degerdir.
        {
            ViewBag.Mesaj = "Kullanici Adı" + kullanici.Ad;
            ViewData["Vdata"] = "Kullanici Adi ve Soyadi" + kullanici.Ad + "" + kullanici.Soyad;
            TempData["TData"] = "Email" + kullanici.Email;
            return View();
        }
        public ActionResult Adres()
        {
            Adres adres = new Adres();
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres)
        {

            ViewBag.Mesaj = "Sehir :" + adres.Sehir;
            ViewData["Vdata"] = "İlce :" + adres.Ilce;
            TempData["TData"] = "Acik Adres :" + adres.AcıkAdres;
            return View();
        }
    }
}