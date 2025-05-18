namespace ControleAlunos.Views
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSalvarDados = new Button();
            textBoxNomeAluno = new TextBox();
            textBoxCpf = new TextBox();
            textBoxEndereco = new TextBox();
            textBoxNomeMae = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            textBoxNumeroCasa = new TextBox();
            textBoxNomePai = new TextBox();
            label7 = new Label();
            textBoxBairro = new TextBox();
            label8 = new Label();
            textBoxTelefone = new TextBox();
            label9 = new Label();
            textBoxCidade = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // buttonSalvarDados
            // 
            buttonSalvarDados.Location = new Point(238, 317);
            buttonSalvarDados.Name = "buttonSalvarDados";
            buttonSalvarDados.Size = new Size(100, 23);
            buttonSalvarDados.TabIndex = 0;
            buttonSalvarDados.Text = "SALVAR";
            buttonSalvarDados.UseVisualStyleBackColor = true;
            buttonSalvarDados.Click += ButtonSalvarDados_ClickAsync;
            // 
            // textBoxNomeAluno
            // 
            textBoxNomeAluno.CharacterCasing = CharacterCasing.Upper;
            textBoxNomeAluno.Location = new Point(26, 45);
            textBoxNomeAluno.Name = "textBoxNomeAluno";
            textBoxNomeAluno.Size = new Size(312, 23);
            textBoxNomeAluno.TabIndex = 1;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Location = new Point(26, 89);
            textBoxCpf.MaxLength = 11;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(312, 23);
            textBoxCpf.TabIndex = 2;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.CharacterCasing = CharacterCasing.Upper;
            textBoxEndereco.Location = new Point(26, 133);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(312, 23);
            textBoxEndereco.TabIndex = 3;
            // 
            // textBoxNomeMae
            // 
            textBoxNomeMae.CharacterCasing = CharacterCasing.Upper;
            textBoxNomeMae.Location = new Point(26, 221);
            textBoxNomeMae.Name = "textBoxNomeMae";
            textBoxNomeMae.Size = new Size(312, 23);
            textBoxNomeMae.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Endereco :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 71);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "CPF :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 203);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome da Mae :";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataNascimento.Location = new Point(132, 318);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(100, 23);
            dateTimePickerDataNascimento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 298);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 10;
            label5.Text = "Data Nascimento :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 159);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "Numero Casa :";
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.CharacterCasing = CharacterCasing.Upper;
            textBoxNumeroCasa.Location = new Point(132, 177);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(100, 23);
            textBoxNumeroCasa.TabIndex = 12;
            // 
            // textBoxNomePai
            // 
            textBoxNomePai.CharacterCasing = CharacterCasing.Upper;
            textBoxNomePai.Location = new Point(26, 265);
            textBoxNomePai.Name = "textBoxNomePai";
            textBoxNomePai.Size = new Size(312, 23);
            textBoxNomePai.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 247);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 14;
            label7.Text = "Nome do Pai :";
            // 
            // textBoxBairro
            // 
            textBoxBairro.CharacterCasing = CharacterCasing.Upper;
            textBoxBairro.Location = new Point(26, 177);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(100, 23);
            textBoxBairro.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 159);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 16;
            label8.Text = "Bairro :";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.CharacterCasing = CharacterCasing.Upper;
            textBoxTelefone.Location = new Point(26, 318);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(100, 23);
            textBoxTelefone.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 298);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 18;
            label9.Text = "Telefone :";
            // 
            // textBoxCidade
            // 
            textBoxCidade.CharacterCasing = CharacterCasing.Upper;
            textBoxCidade.Location = new Point(238, 177);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(100, 23);
            textBoxCidade.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(238, 159);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 20;
            label10.Text = "Cidade :";
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 379);
            Controls.Add(label10);
            Controls.Add(textBoxCidade);
            Controls.Add(label9);
            Controls.Add(textBoxTelefone);
            Controls.Add(label8);
            Controls.Add(textBoxBairro);
            Controls.Add(label7);
            Controls.Add(textBoxNomePai);
            Controls.Add(textBoxNumeroCasa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNomeMae);
            Controls.Add(textBoxEndereco);
            Controls.Add(textBoxCpf);
            Controls.Add(textBoxNomeAluno);
            Controls.Add(buttonSalvarDados);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalvarDados;
        private TextBox textBoxNomeAluno;
        private TextBox textBoxCpf;
        private TextBox textBoxEndereco;
        private TextBox textBoxNomeMae;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label label5;
        private Label label6;
        private TextBox textBoxNumeroCasa;
        private TextBox textBoxNomePai;
        private Label label7;
        private TextBox textBoxBairro;
        private Label label8;
        private TextBox textBoxTelefone;
        private Label label9;
        private TextBox textBoxCidade;
        private Label label10;
    }
}