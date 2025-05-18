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
    public partial class FormPesquisarAluno : Form
    {
        private readonly Servico _service = new(); // instância do serviço para acessar o banco de dados
        public FormPesquisarAluno()
        {
            InitializeComponent();
        }

        private async void buttonPesquisaNomeAluno_Click(object sender, EventArgs e)
        {
            string nome = textBoxEntradaNomeAluno.Text.Trim(); // textbox para o nome da pesquisa

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome para pesquisar.");
                return;
            }

            try
            {
                var listaAlunos = await _service.BuscarPorNomeAsync(nome);

                if (listaAlunos == null || listaAlunos.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno encontrado com esse nome.");
                    dataGridViewAlunos.DataSource = null;
                    return;
                }

                dataGridViewAlunos.DataSource = listaAlunos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar alunos: {ex.Message}");
            }
        }

        private async void buttonbuttonPesquisarCpfAluno_Click(object sender, EventArgs e)
        {
            string cpf = textBoxEntradaCpf.Text.Trim(); // textbox para o cpf da pesquisa

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Digite um CPF para pesquisar.");
                return;
            }

            try
            {
                var aluno = await _service.BuscarPorCpfAsync(cpf);

                if (aluno == null)
                {
                    MessageBox.Show("Nenhum aluno encontrado com esse CPF.");
                    dataGridViewAlunos.DataSource = null;
                    return;
                }

                // Para exibir um único resultado, colocamos numa lista para DataGridView
                dataGridViewAlunos.DataSource = new List<ModeloAluno> { aluno };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar aluno: {ex.Message}");
            }
        }

    }
}
