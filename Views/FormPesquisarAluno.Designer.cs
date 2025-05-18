namespace ControleAlunos.Views
{
    partial class FormPesquisarAluno
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
            buttonPesquisaNomeAluno = new Button();
            textBoxEntradaNomeAluno = new TextBox();
            textBoxEntradaCpf = new TextBox();
            buttonbuttonPesquisarCpfAluno = new Button();
            label1 = new Label();
            label3 = new Label();
            dataGridViewAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisaNomeAluno
            // 
            buttonPesquisaNomeAluno.Location = new Point(519, 55);
            buttonPesquisaNomeAluno.Name = "buttonPesquisaNomeAluno";
            buttonPesquisaNomeAluno.Size = new Size(184, 23);
            buttonPesquisaNomeAluno.TabIndex = 0;
            buttonPesquisaNomeAluno.Text = "PESQUISAR";
            buttonPesquisaNomeAluno.UseVisualStyleBackColor = true;
            buttonPesquisaNomeAluno.Click += buttonPesquisaNomeAluno_Click;
            // 
            // textBoxEntradaNomeAluno
            // 
            textBoxEntradaNomeAluno.CharacterCasing = CharacterCasing.Upper;
            textBoxEntradaNomeAluno.Location = new Point(30, 55);
            textBoxEntradaNomeAluno.Name = "textBoxEntradaNomeAluno";
            textBoxEntradaNomeAluno.Size = new Size(309, 23);
            textBoxEntradaNomeAluno.TabIndex = 1;
            // 
            // textBoxEntradaCpf
            // 
            textBoxEntradaCpf.CharacterCasing = CharacterCasing.Upper;
            textBoxEntradaCpf.Location = new Point(30, 127);
            textBoxEntradaCpf.MaxLength = 11;
            textBoxEntradaCpf.Name = "textBoxEntradaCpf";
            textBoxEntradaCpf.Size = new Size(309, 23);
            textBoxEntradaCpf.TabIndex = 2;
            // 
            // buttonbuttonPesquisarCpfAluno
            // 
            buttonbuttonPesquisarCpfAluno.Location = new Point(519, 126);
            buttonbuttonPesquisarCpfAluno.Name = "buttonbuttonPesquisarCpfAluno";
            buttonbuttonPesquisarCpfAluno.Size = new Size(184, 23);
            buttonbuttonPesquisarCpfAluno.TabIndex = 3;
            buttonbuttonPesquisarCpfAluno.Text = "PESQUISAR";
            buttonbuttonPesquisarCpfAluno.UseVisualStyleBackColor = true;
            buttonbuttonPesquisarCpfAluno.Click += buttonbuttonPesquisarCpfAluno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 4;
            label1.Text = "DIGITE O NOME DO ALUNO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 6;
            label3.Text = "DIGITE O CPF DO ALUNO :";
            // 
            // dataGridViewAlunos
            // 
            dataGridViewAlunos.AllowUserToAddRows = false;
            dataGridViewAlunos.AllowUserToDeleteRows = false;
            dataGridViewAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlunos.Location = new Point(12, 190);
            dataGridViewAlunos.Name = "dataGridViewAlunos";
            dataGridViewAlunos.ReadOnly = true;
            dataGridViewAlunos.Size = new Size(691, 248);
            dataGridViewAlunos.TabIndex = 7;
            // 
            // FormPesquisarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(dataGridViewAlunos);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonbuttonPesquisarCpfAluno);
            Controls.Add(textBoxEntradaCpf);
            Controls.Add(textBoxEntradaNomeAluno);
            Controls.Add(buttonPesquisaNomeAluno);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormPesquisarAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Aluno";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisaNomeAluno;
        private TextBox textBoxEntradaNomeAluno;
        private TextBox textBoxEntradaCpf;
        private Button buttonbuttonPesquisarCpfAluno;
        private Label label1;
        private Label label3;
        private DataGridView dataGridViewAlunos;
    }
}