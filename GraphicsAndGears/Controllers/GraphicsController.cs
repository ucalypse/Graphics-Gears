using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraphicsAndGears.Controllers
{
    public class GraphicsController : Controller
    {
        // GET: Graphics
        public ActionResult Index()
        {
            return View();
        }

        // GET: Graphics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Graphics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Graphics/Create
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

        // GET: Graphics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Graphics/Edit/5
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

        // GET: Graphics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Graphics/Delete/5
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
