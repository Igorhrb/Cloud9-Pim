using GerenciamentoProject.Models;
using GerenciamentoProject.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProject.Controllers
{
    public class FolhaPagamentoController : Controller
    {

        private readonly IDescontosRepositorio _modelo;
        public FolhaPagamentoController(IDescontosRepositorio modelo)
        {
            _modelo = modelo;

        }

        public IActionResult Index()
        {

            List<DescontosModel> descontos = _modelo.BuscarTodos();

            return View(descontos);
        }




        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DescontosModel func)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _modelo.Adicionar(func);
                    TempData["MensagemSucesso"] = "Folha de Pagamento Gerada com sucesso";
                    return RedirectToAction("Index", "FolhaPagamento");

                }

                return View(func);

            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita, não conseguimos gerar a folha,Sinto muito:{erro.Message}";
                return RedirectToAction("Index", "FolhaPagamento");
            }

        }
    }



}
