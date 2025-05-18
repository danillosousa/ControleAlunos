using ControleAlunos.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAlunos.Views
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        private void pESQUISASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aLUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisarAluno formPesquisarAluno = new FormPesquisarAluno();
            formPesquisarAluno.Show();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formCadastroAluno = new FormCadastroAluno();
            formCadastroAluno.Show();
        }

        private async void apagarBnacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show(
                "Isso excluirá permanentemente todos os registros de alunos.\nDeseja continuar?",
                "Confirmar exclusão do banco",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp != DialogResult.Yes) return;

            try
            {
                await DataBase.Instance.RecriarBancoAsync();
                MessageBox.Show("Banco apagado e recriado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao recriar o banco:\n{ex.Message}");
            }
        }
    }
}
