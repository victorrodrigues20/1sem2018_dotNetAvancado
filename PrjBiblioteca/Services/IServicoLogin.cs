using PrjBiblioteca.Models;

namespace PrjBiblioteca.Services
{
    public interface IServicoLogin
    {
        Usuario RecuperarUsuario();

        bool UsuarioLogado();
    }
}
