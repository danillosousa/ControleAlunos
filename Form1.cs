using ControleAlunos.Views;

namespace ControleAlunos
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            if(usuario == "DANILOSOUSA" && senha == "1234")
            {
                FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
