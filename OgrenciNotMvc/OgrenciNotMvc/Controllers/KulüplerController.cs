using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.Entity;

namespace OgrenciNotMvc.Controllers
{
    public class KulüplerController : Controller
    {
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        // GET: Kulüpler
        public ActionResult Index()
        {
            var kulüpler = db.TBLKULUP.ToList();
            return View(kulüpler);
        }
        [HttpGet]
        public ActionResult YeniKulüp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKulüp(TBLKULUP p)
        {
            db.TBLKULUP.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var kulup = db.TBLKULUP.Find(id);
            db.TBLKULUP.Remove(kulup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KulupGetir(int id)
        {
            var kulup = db.TBLKULUP.Find(id);
            return View("KulupGetir",kulup);
          
        }
        public ActionResult Guncelle(TBLKULUP p)
        {
            var klp = db.TBLKULUP.Find(p.KULUPID);
            klp.KULUPAD = p.KULUPAD;
            db.SaveChanges();
            return RedirectToAction("Index","Kulüpler");
        }
    }
}