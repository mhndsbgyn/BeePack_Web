using BeePack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BeePack.Controllers
{
    public class trController : Controller
    {
       
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
        public ActionResult Tesis()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(iletisimModel model)
        {
            if (ModelState.IsValid)
            {

                var body = new StringBuilder();
                body.AppendLine("İsim: " + model.Name);
                body.AppendLine("Mail: " + model.Email);
                body.AppendLine("Konu: " + model.Konu);
                body.AppendLine("Mesaj: " + model.Aciklama);
                Email.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }
    }
}