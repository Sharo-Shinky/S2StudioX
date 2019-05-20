using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_StudioX.Controllers
{
    public class AfspraakController : Controller
    {
        // GET: Afspraak
        public ActionResult Index()
        {
            return View();
        }

        // GET: Afspraak/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Afspraak/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Afspraak/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Afspraak/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Afspraak/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Afspraak/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Afspraak/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}