using Models;
using Views;
using System;
using System.Collections;

namespace Controllers{
    public class BibliotecaController
    {
        private Models.BibliotecaModel bibliotecaModel;
        private Views.BibliotecaView bibliotecaView;

        public BibliotecaController(Models.BibliotecaModel model, Views.BibliotecaView view)
        {
            bibliotecaModel = model;
            bibliotecaView = view;
        }

        public void MostrarLivros()
        {
           
            bibliotecaView.MostrarLivros(bibliotecaModel);
        }
    }
}

