using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarif_Proje.Models.EntityFramework;
namespace Tarif_Proje.Controllers
{
    public class AdminController : Controller
    {
        YemekTarifEntities db = new YemekTarifEntities();
        [Authorize]
        public ActionResult AdminIndex()
        {
            var deger = db.Tbl_Yemekler.ToList();
            return View(deger);
        }
        [Authorize]
        public ActionResult Sil(int id)
        {
            var yemek = db.Tbl_Yemekler.Find(id);
            db.Tbl_Yemekler.Remove(yemek);
            db.SaveChanges();
            return RedirectToAction("AdminIndex");
        }
        [Authorize]
        public ActionResult Guncelle(int id)
        {
            var yemek = db.Tbl_Yemekler.Find(id);
            return View("Guncelle", yemek);
        }
        [Authorize]
        public ActionResult YemekGuncelle(Tbl_Yemekler deger)
        {
            var yemek = db.Tbl_Yemekler.Find(deger.ID);
            yemek.AD = deger.AD;
            yemek.MALZEME = deger.MALZEME;
            yemek.TARİF = deger.TARİF;
            yemek.IdValue = deger.IdValue;
            db.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

    }
}