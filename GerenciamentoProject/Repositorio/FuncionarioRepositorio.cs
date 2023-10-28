using GerenciamentoProject.Data;
using GerenciamentoProject.Models;

namespace GerenciamentoProject.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioRepositorio(ApplicationDbContext dbContext)
        {
            _context = dbContext;

        }


        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            this._context.SaveChanges();
            return funcionario;
        }

        public bool Apagar(int id)
        {
            FuncionarioModel funcionarioBd = ListarporID(id);
            if (funcionarioBd == null) throw new System.Exception("Houve um erro na deleção do funcionario");
            _context.Funcionarios.Remove(funcionarioBd);
            this._context.SaveChanges();
            return true;    
        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {
            FuncionarioModel funcionarioBd = ListarporID(funcionario.Id_funcionario);
            if (funcionarioBd == null) throw new System.Exception("Houve um erro na atualização do funcionario");
            funcionarioBd.Nome = funcionario.Nome;
            funcionarioBd.PIS = funcionario.PIS;
            funcionarioBd.Salario = funcionario.Salario;
            funcionarioBd.celular = funcionario.celular;
            funcionarioBd.ContaBanco = funcionario  .ContaBanco;
            funcionarioBd.Cargo =   funcionario.Cargo;
            funcionarioBd.CPF = funcionario.CPF;
            funcionarioBd.Dtnascimento = funcionario.Dtnascimento;
            funcionarioBd.Endereco = funcionario.Endereco;
            funcionarioBd.Gerente = funcionario.Gerente;
            funcionarioBd.Sexo = funcionario.Sexo;
            _context.Funcionarios.Update(funcionarioBd);
            this._context.SaveChanges();
            return funcionarioBd;
        }

        public List<FuncionarioModel> ListarFuncionario()
        {
            return _context.Funcionarios.ToList();

        }

        public FuncionarioModel ListarporID(int id)
        {
            return _context.Funcionarios.FirstOrDefault(x => x.Id_funcionario == id);
        }
    }
}