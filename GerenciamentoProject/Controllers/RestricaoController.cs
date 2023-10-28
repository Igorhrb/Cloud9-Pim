using GerenciamentoProject.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProject.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestricaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
