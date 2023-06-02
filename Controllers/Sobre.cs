using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class Sobre : Controller
    {
        // GET: Sobre
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sobre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sobre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sobre/Create
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

        // GET: Sobre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sobre/Edit/5
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

        // GET: Sobre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sobre/Delete/5
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
