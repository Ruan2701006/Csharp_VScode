using CursoC;

namespace CursoC
{
    class Biblioteca
    {
        private List<Livro> acervo = new List<Livro>();

        public void AdicionarLivro(Livro l)
        {
            acervo.Add(l);
        }
        public void RemoverLivro(Livro l)
        {
            if(acervo.Contains(l))
            {
                acervo.Remove(l);
            }
        }
    }
}