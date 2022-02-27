using MezunTakipSistemi.DAL;
using MezunTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunTakipSistemi.Controllers
{
    public class OgrenciController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Ogrenci ogrenci)
        {
            c.Ogrenciler.Add(ogrenci);
            c.SaveChanges();
            return View();
        }
    }
}