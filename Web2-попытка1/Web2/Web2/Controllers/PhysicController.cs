using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class PhysicController : Controller
    {
        SubjectContext db=new SubjectContext();
        // GET: Physic
        public ActionResult MainPagePhysic()
        {
            return View(db.Subjects);
        }    
    }
}
