using GerenciamentoProject.Models;

namespace GerenciamentoProject.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        
        public List<FuncionarioModel> ListarFuncionario(); //tela de registro

        FuncionarioModel ListarporID(int id); //Mostrar o funcionario que vai ser alterado

        FuncionarioModel Atualizar(FuncionarioModel funcionarios); //metodo de atualizar funcionario
        public FuncionarioModel Adicionar(FuncionarioModel funcionarios); //metodo de adcicionar o funcionario ao banco de dados

        bool Apagar(int id);
    }
}
