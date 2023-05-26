using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class TimeController : Controller
    {
        // GET: TimeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TimeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeController/Create
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

        // GET: TimeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeController/Edit/5
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

        // GET: TimeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeController/Delete/5
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
