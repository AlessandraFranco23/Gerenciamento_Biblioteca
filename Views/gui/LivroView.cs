
using Models;

namespace Views.GUI
{
    public class LivroView : Form
    {
        public TextBox TituloTextBox;
        public TextBox AutorTextBox;
        Label AutorLabel = new Label();
        Label TituloLabel = new Label();
        private Button CadastrarButton;
        private Controllers.BibliotecaController Controller;

        public LivroView(Controllers.BibliotecaController controller)
        {
            Controller = controller;
            InitializeComponents();

        }

        private void InitializeComponents()
        {
            this.Text = "Cadastro/Edição de Livro";
            this.Size = new Size(300, 200);

            TituloLabel.Text = "Título:";
            TituloLabel.Location = new Point(10, 10);
            TituloTextBox = new TextBox();
            TituloTextBox.Location = new Point(20, 30);
            TituloTextBox.Size = new Size(250, 20);

            AutorLabel.Text = "Autor:";
            AutorLabel.Location = new Point(10, 50);
            AutorTextBox = new TextBox();
            AutorTextBox.Location = new Point(20, 70);
            AutorTextBox.Size = new Size(250, 20);

            CadastrarButton = new Button();
            CadastrarButton.Location = new Point(20, 100);
            CadastrarButton.Size = new Size(100, 30);
            CadastrarButton.Text = "Cadastrar";
            CadastrarButton.Click += CadastrarButton_Click;

        
            this.Controls.Add(TituloTextBox);
            this.Controls.Add(AutorTextBox);
            this.Controls.Add(AutorLabel);
            this.Controls.Add(TituloLabel);
            this.Controls.Add(CadastrarButton);
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            string titulo = TituloTextBox.Text;
            string autor = AutorTextBox.Text;

            Controller.CadastrarLivro(titulo, autor);
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}