using GerenciamentoProject.Models;

namespace GerenciamentoProject.Helper
{
   
        public interface ISessao
        {
            void CriarSessaoDoUsuario(UsuarioModel usuario);
            void RemoverSessaoUsuario();
            UsuarioModel BuscarSessaoDoUsuario();
        }
    
}
