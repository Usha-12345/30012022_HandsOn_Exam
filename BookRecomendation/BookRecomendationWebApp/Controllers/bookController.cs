using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookRecomendationWebApp.Controllers
{
    public class bookController : Controller
    {
        // GET: book
        BookRecomendationBL blobj;
        public ActionResult Index()
        {
            return View();
        }

        // GET: book/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
