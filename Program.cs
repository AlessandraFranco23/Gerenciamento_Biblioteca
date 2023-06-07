using Views;
using Models;
using Controllers;


namespace Gerenciamento_Biblioteca{
    public class Program
    {
        public static void Main()
        {
            Livro[] livros = new Livro[]
            {
                new Livro("Livro 1", "Autor 1"),
                new Livro("Livro 2", "Autor 2"),
                new Livro("Livro 3", "Autor 3")
            };

            Models.BibliotecaModel Models = new BibliotecaModel();
            Models.AddItem(livros[0]);
            Models.AddItem(livros[1]);
            Models.AddItem(livros[2]);
            
            Views.BibliotecaView Views = new Views.BibliotecaView();
            Controllers.BibliotecaController Controllers = new Controllers.BibliotecaController(Models, Views);

            Controllers.MostrarLivros();
        }
    }

}

