using System.ComponentModel.DataAnnotations;

namespace PrjBiblioteca.Models
{
    public class Livro
    {
        [Key]
        public int LivroID { get; set; }

        public string Titulo { get; set; }
    }
}
