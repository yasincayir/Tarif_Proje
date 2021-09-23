using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarif_Proje.Models.EntityFramework;

namespace Tarif_Proje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        YemekTarifEntities db = new YemekTarifEntities();
        public ActionResult Index()
        {
            var yemekler = db.Tbl_Yemekler.OrderByDescending(o => o.ID).ToList();
            return View(yemekler);
        }
        public ActionResult Tarifler()
        {
            var yemekler = db.Tbl_Yemekler.ToList();
            return View(yemekler);
        }
        public ActionResult TarifDetay()
        {
            var tarifdetay = db.Tbl_Yemekler.ToList();
            return View(tarifdetay);
        }
        public ActionResult YemekDetay(string id)
        {
            var yemekdetay = db.Tbl_Yemekler.Where(x => (x.IdValue).ToString() == id).ToList();
            return View(yemekdetay);
        }
        public ActionResult Kategoriler()
        {
            var kategori = db.Tbl_Kategoriler.ToList();
            return View(kategori);
        }
        public ActionResult KategoriDetay(int id)
        {
            var kategoridetay = db.Tbl_Yemekler.Where(x => (x.KategoriID) == id).ToList();
            return View(kategoridetay);
        }

        [HttpGet]
        public ActionResult TarifEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TarifEkle(Tbl_Yemekler deger)
        {
            db.Tbl_Yemekler.Add(deger);
            db.SaveChanges();
            return View();
        }


    }
}