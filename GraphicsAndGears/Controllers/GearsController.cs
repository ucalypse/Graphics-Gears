﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraphicsAndGears.Controllers
{
    public class GearsController : Controller
    {
        // GET: Gears
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gears/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
        // GET: Gears/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult PartsRequest()
        {
            return View();
        }

        // POST: Gears/Create
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

        // GET: Gears/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gears/Edit/5
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

        // GET: Gears/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gears/Delete/5
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
