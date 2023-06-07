
using System.Collections;

namespace Models
{
    public class BibliotecaModel: IteratorAggregate
    {
        private List<Livro> livros = new List<Livro>();

         public List<Livro> getItems()
        {
            return livros;
        }

        public void AddItem(Livro item)
        {
            this.livros.Add(item);
        }

        public  IEnumerator GetEnumerator()
        {
            return new LivroIterator(this);
        }
    }
}