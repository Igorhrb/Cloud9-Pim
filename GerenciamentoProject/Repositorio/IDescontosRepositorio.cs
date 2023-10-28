using GerenciamentoProject.Models;

namespace GerenciamentoProject.Repositorio
{
    public interface IDescontosRepositorio 
    {
        List<DescontosModel> BuscarTodos();
        DescontosModel Adicionar(DescontosModel descontos);
    }
}
