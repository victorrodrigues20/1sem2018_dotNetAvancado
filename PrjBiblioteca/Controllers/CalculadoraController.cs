using Microsoft.AspNetCore.Mvc;

namespace PrjBiblioteca.Controllers
{
    public class CalculadoraController : Controller
    {
        public string Index() 
        {
            return "Hello Site MVC!";
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
