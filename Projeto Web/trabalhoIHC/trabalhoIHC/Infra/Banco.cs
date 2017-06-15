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
            livros.Add(new Livro("C#", "iscaminosfleuris", "Fodastica", DateTime.Now));
            livros.Add(new Livro("C", "Ze mane", "Fodastica", DateTime.Now));
            livros.Add(new Livro("C++", "Alguem", "Pebinha", DateTime.Now));
            livros.Add(new Livro("Java", "iscaminosfleuris", "Paranaue", DateTime.Now));
            livros.Add(new Livro("Python", "Xanaina", "The Best", DateTime.Now));
            livros.Add(new Livro("Ruby", "Ze mane", "Edição", DateTime.Now));
            livros.Add(new Livro("PHP", "Xanaina", "Paranaue", DateTime.Now));
            livros.Add(new Livro("Laravel", "Bill gates", "Aquela la", DateTime.Now));
            livros.Add(new Livro("Git", "Zuckerberg", "Blablabla", DateTime.Now));
            livros.Add(new Livro("Scrum", "Einstein", "Aquela la", DateTime.Now));
        }
    }
}