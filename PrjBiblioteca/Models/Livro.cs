using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrjBiblioteca.Models
{
    public class Livro
    {
        [Key]
        public int LivroID { get; set; }

        [Required]
        [Display(Name = "Título")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter no má-ximo {1} caracteres")]
        public string Titulo { get; set; }

        [Range(1, 300, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        public int Quantidade { get; set; }

        public ICollection<LivroAutor> LivAutor { get; set; }

        public ICollection<LivroEmprestimo> LivEmprestimo { get; set; }
    }

}
