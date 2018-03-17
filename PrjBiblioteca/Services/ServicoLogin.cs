using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PrjBiblioteca.Dados;
using PrjBiblioteca.Models;

namespace PrjBiblioteca.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class ServicoLogin : IServicoLogin
    {
        private BibliotecaDbContext _context;

        private UserManager<ApplicationUser> _userManager;

        private HttpContext _httpContext;

        public ServicoLogin(BibliotecaDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _httpContext = httpContext.HttpContext;
        }
        
        public Usuario RecuperarUsuario()
        {
            var userID = _userManager.GetUserId(_httpContext.User);
            var userName = _userManager.GetUserName(_httpContext.User);

            Usuario usuario = _context.Usuario.FirstOrDefault(u => u.ApplicationUserId == userID);

            if (usuario == null)
            {
                usuario = new Usuario
                {
                    Nome = userName,
                    ApplicationUserId = userID
                };

                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }

            return usuario;
        }

        public bool UsuarioLogado()
        {
            return _httpContext.User.Identity.IsAuthenticated;
        }   
    }
}
