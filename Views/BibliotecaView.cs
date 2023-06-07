using System;
using Models;
using System.Collections.Generic;

namespace Views{
    public class BibliotecaView
    {
        public void MostrarLivros(BibliotecaModel livros)
        {
            foreach (Livro livro in livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}");
            }
        }
    }

}