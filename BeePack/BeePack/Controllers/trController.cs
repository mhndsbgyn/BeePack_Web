using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeePack.Controllers
{
    public class trController : Controller
    {
        // GET: tr
        public ActionResult Anasayfa()
        {
            return View();
        }
      
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Urun()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}