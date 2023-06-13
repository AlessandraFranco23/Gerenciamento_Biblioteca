namespace Views.GUI
{
    public class BibliotecaForm : Form
    {
        private ListView livrosListView;
        private Button cadastrarButton;
        private Button editarButton;
        private Controllers.BibliotecaController Controller;

        public BibliotecaForm(Controllers.BibliotecaController controller)
        {
            Controller = controller;
            InitializeComponents();

        }

        private void InitializeComponents()
        {

            this.Text = "Biblioteca";
            this.Size = new Size(400, 300);

            livrosListView = new ListView();
            livrosListView.Location = new Point(20, 20);
            livrosListView.Size = new Size(360, 200);
            livrosListView.View = View.Details;
            livrosListView.Columns.Add("Título", 150);
            livrosListView.Columns.Add("Autor", 150);

            cadastrarButton = new Button();
            cadastrarButton.Location = new Point(20, 240);
            cadastrarButton.Size = new Size(100, 30);
            cadastrarButton.Text = "Cadastrar";
            cadastrarButton.Click += CadastrarButton_Click;

            editarButton = new Button();
            editarButton.Location = new Point(130, 240);
            editarButton.Size = new Size(100, 30);
            editarButton.Text = "Editar";
            editarButton.Click += EditarButton_Click;

            this.Controls.Add(livrosListView);
            this.Controls.Add(cadastrarButton);
            this.Controls.Add(editarButton);
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {

            LivroView livroForm = new LivroView(Controller);

            DialogResult result = livroForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MostrarLivros();
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {

            if (livrosListView.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = livrosListView.SelectedItems[0];
                string titulo = selectedItem.SubItems[0].Text;
                string autor = selectedItem.SubItems[1].Text;


                LivroView livroForm = new LivroView(Controller);
                livroForm.TituloTextBox.Text = titulo;
                livroForm.AutorTextBox.Text = autor;

                DialogResult result = livroForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MostrarLivros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado.", "Editar Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MostrarLivros()
        {

            livrosListView.Items.Clear();

            Models.BibliotecaModel bibliotecaModel = Controller.MostrarLivros();

            foreach (Models.Livro livro in bibliotecaModel)
            {
                string[] row = { livro.Titulo, livro.Autor };
                ListViewItem item = new ListViewItem(row);
                livrosListView.Items.Add(item);
            }
        }
    }
}