using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class InformationController : Controller
    {
        SubjectContext db = new SubjectContext();
        // GET: Information
        public ActionResult InformationIndex()
        {
            ViewBag.Message = "Информатика";
            return View(db.Subjects);
        }
        public ActionResult InformationLesson1()
        {
            return View();
        }
    }
}