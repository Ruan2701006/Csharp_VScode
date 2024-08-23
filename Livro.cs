using System;

namespace CursoC
{
    /* 1. Crie uma classe Livro com os atributos titulo, autor, anoPublicacao e numeroPaginas
    como private.
    Implemente as propriedades public com get e set para acessar esses atributos,
    aplicando encapsulamento. */
    public class Livro
    {
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private int AnoDePublicacao { get; set; }
        private int NumerosDePaginas { get; set; }

        public Livro(string titulo, string autor, int anoDePublicacao, int numerosDePaginas)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoDePublicacao = anoDePublicacao;
            this.NumerosDePaginas = numerosDePaginas;
        }

        /*  2. Implemente um construtor na classe Livro que inicialize os atributos titulo, autor,
         anoPublicacao e numeroPaginas.
         Demonstre o uso do construtor ao instanciar um objeto da classe Livro. */

        /*public string Titulo;
          public string Autor;
          public int AnoDePublicacao;
          public int NumerosDePaginas;


          public Livro(string titulo, string autor, int anoDePublicacao, int numerosDePaginas)
          {
              this.Titulo = titulo;
              this.Autor = autor;
              this.AnoDePublicacao = anoDePublicacao;
              this.NumerosDePaginas = numerosDePaginas;
          } */

        /* 3. Adicione um método ExibirDetalhes na classe Livro que exiba os detalhes do livro.
        Certifique-se de acessar os atributos private através das propriedades públicas. */

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O nome do Livro é: {this.Titulo}, o autor é: {this.Autor}, o ano de publicação é; {this.AnoDePublicacao}, a quantidade de paginas é:{this.NumerosDePaginas}");
        }

    }
}


