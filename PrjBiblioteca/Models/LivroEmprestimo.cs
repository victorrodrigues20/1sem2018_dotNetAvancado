﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjBiblioteca.Models
{
    public class LivroEmprestimo
    {
        public int LivroID { get; set; }
        public Livro Livro { get; set; }

        public int EmprestimoID { get; set; }
        public Emprestimo Emprestimo { get; set; }
    }
}
