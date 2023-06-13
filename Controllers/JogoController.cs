using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_app.Filters;
using web_app.Services;

namespace WebApp.Controllers
{

    public class JogoController : Controller
    {

        private readonly ISessao sessao;
        private readonly Repositories.ADO.SQL_SERVER.Jogo repository;
        public JogoController()
        {
            repository = new Repositories.ADO.SQL_SERVER.Jogo();
            this.sessao = sessao;
        }
        // GET: jogosController

        [UsuarioLogado]
        public ActionResult Index()
        {
            //return this.sessao.get() == null ? RedirectToAction("IndexUsuario", "Jogo") : View(repository.get());
            return View(repository.get());
        }

        public ActionResult IndexUsuario()
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

            return View(this.repository.getEdit(idjogo));
        }

        // POST: jogosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idJogo, Models.Jogo jogo)
        {
            try
            {
                repository.edit(idJogo, jogo);
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
