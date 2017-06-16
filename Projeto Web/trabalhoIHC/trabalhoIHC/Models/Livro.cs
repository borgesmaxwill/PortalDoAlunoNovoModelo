using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using trabalhoIHC.Infra;

namespace trabalhoIHC.Models
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string Situacao { get; set; }

        public Livro()
        {

        }

        public Livro(string titulo, string autor, string editora, DateTime dataPublicacao, string situacao)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.DataPublicacao = dataPublicacao;
            this.Situacao = situacao;
        }

        public IList<Livro> Busca()
        {
            return Banco.BuscaLivros(this);
        }
    }
}