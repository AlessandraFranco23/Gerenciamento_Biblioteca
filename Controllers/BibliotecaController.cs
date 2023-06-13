using Models;
using Views;
using System;
using System.Collections;

namespace Controllers
{
    public class BibliotecaController
    {
        private Models.BibliotecaModel bibliotecaModel;

        public BibliotecaController(Models.BibliotecaModel model)
        {
            bibliotecaModel = model;
        }

        public BibliotecaModel MostrarLivros()
        {
            return bibliotecaModel;
        }
        
        public void CadastrarLivro(string titulo, string autor)
        {
            bibliotecaModel.AddItem(new Livro(titulo, autor));
        }
    }
}

