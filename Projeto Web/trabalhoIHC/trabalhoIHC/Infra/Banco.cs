using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trabalhoIHC.Models;

namespace trabalhoIHC.Infra
{
    public static class Banco
    {
        public static IList<Livro> livros = new List<Livro>();

        public static void Inicializa()
        {
            livros.Add(new Livro("C#", "iscaminosfleuris", "Fodastica", DateTime.Now, "Disponível"));
            livros.Add(new Livro("C", "Ze mane", "Fodastica", DateTime.Now, "Disponível"));
            livros.Add(new Livro("C++", "Alguem", "Pebinha", DateTime.Now, "Indisponível"));
            livros.Add(new Livro("Java", "iscaminosfleuris", "Paranaue", DateTime.Now, "Disponível"));
            livros.Add(new Livro("Python", "Xanaina", "The Best", DateTime.Now, "Indisponível"));
            livros.Add(new Livro("Ruby", "Ze mane", "Edição", DateTime.Now, "Disponível"));
            livros.Add(new Livro("PHP", "Xanaina", "Paranaue", DateTime.Now, "Disponível"));
            livros.Add(new Livro("Laravel", "Bill gates", "Aquela la", DateTime.Now, "Indisponível"));
            livros.Add(new Livro("Git", "Zuckerberg", "Blablabla", DateTime.Now, "Disponível"));
            livros.Add(new Livro("Scrum", "Einstein", "Aquela la", DateTime.Now, "Disponível"));
        }

        public static IList<Livro> BuscaLivros(Livro livro)
        {
            IList<Livro> retorno = new List<Livro>();
            for (int i = 0; i < livros.Count; i++)
            {
                if(livros[i].Titulo == livro.Titulo || livros[i].Autor == livro.Autor || livros[i].Editora == livro.Editora || livros[i].DataPublicacao == livro.DataPublicacao)
                {
                    retorno.Add(livros[i]);
                }
            }

            return retorno;
        }
    }
}