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
    public partial class FormCadastroAluno : Form
    {
        private readonly Servico _service = new();
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private async void ButtonSalvarDados_ClickAsync(object sender, EventArgs e)
        {
            string nome = textBoxNomeAluno.Text;
            string cpf = textBoxCpf.Text;
            DateTime dataNascimento = dateTimePickerDataNascimento.Value; // já é DateTime
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string numero = textBoxNumeroCasa.Text;
            string bairro = textBoxBairro.Text;
            string cidade = textBoxCidade.Text;
            string nomeMae = textBoxNomeMae.Text;
            string nomePai = textBoxNomePai.Text;
            DateTime dataCadastro = DateTime.Now.Date; // já é DateTime

            // Validação simples
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(numero) ||
                string.IsNullOrWhiteSpace(bairro) || string.IsNullOrWhiteSpace(cidade) || string.IsNullOrWhiteSpace(nomeMae) ||
                string.IsNullOrWhiteSpace(nomePai))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            var aluno = new ModeloAluno
            {
                Nome = nome,
                Cpf = cpf,
                DataNasc = dataNascimento.Date,
                Telefone = telefone,
                Endereco = endereco,
                Numero = numero,
                Bairro = bairro,
                Cidade = cidade,
                NomeMae = nomeMae,
                NomePai = nomePai,
                DataCadastro = dataCadastro.Date
            };

            await _service.AdicionarAsync(aluno);

            MessageBox.Show("Dados salvos com sucesso!");
            LimparCampos(); // Limpa os campos após salvar
        }
        private void LimparCampos()
        {
            textBoxNomeAluno.Clear();
            textBoxCpf.Clear();
            dateTimePickerDataNascimento.Value = DateTime.Now; // reseta para data atual
            textBoxTelefone.Clear();
            textBoxEndereco.Clear();
            textBoxNumeroCasa.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxNomeMae.Clear();
            textBoxNomePai.Clear();
        }


    }
}
