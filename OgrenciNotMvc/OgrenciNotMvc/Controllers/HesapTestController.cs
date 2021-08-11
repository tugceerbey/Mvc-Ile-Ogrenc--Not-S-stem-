using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1=0,double sayi2=0)
        {
            double toplam = sayi1 + sayi2;
            double cıkar = sayi1 - sayi2;
            double carp = sayi1 * sayi2;
            double bolme = sayi1 / sayi2;
            ViewBag.toplam = toplam;
            ViewBag.cıkar = cıkar;
            ViewBag.carp = carp;
            ViewBag.bolme = bolme;
            ViewBag.sayi1 = sayi1;
            ViewBag.sayi2 = sayi2;
            return View();
        }
    }
}