using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarif_Proje.Models.EntityFramework;
namespace Tarif_Proje.Controllers
{
    public class AdminListeController : Controller
    {
        YemekTarifEntities db = new YemekTarifEntities();
        [Authorize]
        public ActionResult ListeIndex()
        {
            var admin = db.Tbl_Yonetici.ToList();
            return View(admin);
        }

    }
}