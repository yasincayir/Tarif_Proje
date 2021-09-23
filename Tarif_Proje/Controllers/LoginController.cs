using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tarif_Proje.Models.EntityFramework;
namespace Tarif_Proje.Controllers
{
    public class LoginController : Controller
    {
        YemekTarifEntities db = new YemekTarifEntities();
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login1()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Login1(Tbl_Yonetici deger)
        {
            var bilgiler = db.Tbl_Yonetici.FirstOrDefault(i => i.KullaniciAdi == deger.KullaniciAdi && i.SİFRE == deger.SİFRE);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi.ToString(), false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("AdminIndex", "Admin");
            }
            else
            {
                return RedirectToAction("LoginIndex", "Login");

            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginIndex", "Login");
        }



    }
}