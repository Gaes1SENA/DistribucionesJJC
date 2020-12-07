using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace distrijjc.Web.Controllers
{
    public class CodTelefonoController : Controller
    {
        // GET: CodTelefonoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CodTelefonoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CodTelefonoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodTelefonoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CodTelefonoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CodTelefonoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CodTelefonoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CodTelefonoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
