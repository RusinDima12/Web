using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = ".";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Forum()
        {
            ViewBag.Message = "Форум";

            return View();
        }
        public ActionResult Subject()
        {
            ViewBag.Message = "Выберите предмет";

            return View();
        }
        public ActionResult MainPagehysic()
        {
            //ViewBag.Message = "Выберите предмет";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingIndex()
        {
            ViewBag.Message = "Изменение главной страницы";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingIndex1()
        {
            ViewBag.Message = "Изменение главной страницы";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingAbout()
        {
            ViewBag.Message = "Изменение информации института";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingContact()
        {
            ViewBag.Message = "Изменение контактов";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingForum()
        {
            ViewBag.Message = "Изменение содержимого форума";

            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult EditingSubject()
        {
            ViewBag.Message = "Изменение содержимого предметов";

            return View();
        }
        public ActionResult Mathematic()
        {
            ViewBag.Message = "Математика";

            return View(ComCont.CommentModels);
        }
        public ActionResult InformationIndex()
        {
            ViewBag.Message = "Информатика";
            return View();
        }
        public ActionResult InformationLesson1()
        {
            return View();
        }
        private CommentContext ComCont = new CommentContext();
        public ActionResult Create()
        {
            ViewBag.Message = "Информатика";
            return View();
        }

        [HttpPost]
        public ActionResult Create(CommentModel Com, HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid && uploadImage != null)
            {
                //byte[] imageData = null;
                //// считываем переданный файл в массив байтов
                //using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                //{
                //    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                //}
                //// установка массива байтов
                //pic.Image = imageData;

                ComCont.CommentModels.Add(Com);
                ComCont.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(Com);
        }
    }
}