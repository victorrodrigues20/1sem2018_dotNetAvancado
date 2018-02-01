using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrjBiblioteca.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [StringLength(300)]
        public string Descricao { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}