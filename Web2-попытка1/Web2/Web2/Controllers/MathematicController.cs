using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class MathematicController : Controller
    {
        SubjectContext db = new SubjectContext();
        // GET: Mathematic        
        public ActionResult Mathematic()
        {
            ViewBag.Message = "Математика";

            return View(db.Subjects);
        }
    }
}