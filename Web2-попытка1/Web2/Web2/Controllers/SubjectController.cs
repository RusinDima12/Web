using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class SubjectController : Controller
    {

        SubjectContext db = new SubjectContext();
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(db.Subjects);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public ActionResult Create(SubjectModel sub, HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid && uploadImage != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                {
                    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                }
                // установка массива байтов
                sub.Image = imageData;

                db.Subjects.Add(sub);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(sub);
        }
        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult Delete()
        {
            SubjectModel m = new SubjectModel();           
            return View(m);
        }
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string ID)
        {
            int id = Convert.ToInt32(ID);
            SubjectModel m = db.Subjects.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            db.Subjects.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
