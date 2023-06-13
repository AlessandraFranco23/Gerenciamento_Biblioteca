using Views;
using Models;
using Controllers;


namespace Gerenciamento_Biblioteca
{
    public class Program
    {
        public static void Main()
        {
            Models.BibliotecaModel models = new BibliotecaModel();
            Controllers.BibliotecaController controller = new Controllers.BibliotecaController(models);
            Views.GUI.BibliotecaForm form = new Views.GUI.BibliotecaForm(controller);
            Application.Run(form);
        }
    }

}

