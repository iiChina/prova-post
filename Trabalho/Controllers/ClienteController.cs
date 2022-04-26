using Projeto.Context;
using Projeto.Models;
using System.Linq;
using System.Web.Mvc;

namespace Trabalho.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto _contexto = new Contexto();

        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = _contexto.Clientes.ToList();
            return View(clientes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }
    }
}