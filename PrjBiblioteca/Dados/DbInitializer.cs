
using System.Linq;
using PrjBiblioteca.Dados;
using PrjBiblioteca.Models;

public static class DbInitializer
    {
        public static void Initialize(BibliotecaDbContext context)
        {
            if (context.Database.EnsureCreated())
                return;

            // Se existir algum livro.
            if (context.Livro.Any())
            {
                return;   // DB possui registros
            }

            #region Livros
            var livros = new Livro[]
            {
                new Livro {Titulo = "PHP para quem conhece PHP",Quantidade = 10},
                new Livro {Titulo = "Internet das Coisas com ESP8266, Arduino e Raspber-ry",Quantidade = 10},
                new Livro {Titulo = "Gamification em Help Desk e Service Desk",Quantidade = 10},
                new Livro {Titulo = "Avaliação de segurança de redes",Quantidade = 10},
                new Livro {Titulo = "Desenvolvendo Jogos Mobile com HTML5",Quantidade = 10}
            };

            foreach (Livro l in livros)
            {
                context.Livro.Add(l);
            }

            #endregion

            #region Autores

            var autores = new Autor[]
            {
                new Autor { Nome = "Sérgio de Oliveira" },
                new Autor { Nome = "Renato da Silva"},
                new Autor { Nome = "Paulo Sérgio Travolla"},
                new Autor { Nome = "Juliano Niederauer"},
                new Autor { Nome = "Roberto Cohen"},
                new Autor { Nome = "Chris McNab"},
                new Autor { Nome = "Luiz Fernando Estevarengo"}
            };

            foreach (Autor a in autores)
            {
                context.Autor.Add(a);
            }

            #endregion

            context.SaveChanges();
        }
    }
