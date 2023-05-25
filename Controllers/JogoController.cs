using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class JogoController : Controller
    {                   


        private readonly Repositories.ADO.SQL_SERVER.Jogo repository;
        public JogoController() 
        {
            repository = new Repositories.ADO.SQL_SERVER.Jogo();
        }
        // GET: jogosController
        public ActionResult Index()
        {
            return View(repository.get());
        }

        // GET: jogosController/Details/5
        public ActionResult Details(int idJogo)
        {
            return View();
        }

        // GET: jogosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jogosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Jogo jogo)
        {
            try
            {
                repository.add(jogo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: jogosController/Edit/5
        public ActionResult Edit(int idjogo)
        {
           
            return View();
        }

        // POST: jogosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idJogo, Models.Jogo jogo)
        {
            try
            {
                repository.edit(jogo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: jogosController/Delete/5
        public ActionResult Delete(int idJogo)
        {
            repository.delete(idJogo);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
