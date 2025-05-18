namespace ControleAlunos
{
    partial class FormTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEntrar = new Button();
            label1 = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label2 = new Label();
            buttonRecuperarSenha = new Button();
            buttonNovoUsuario = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(405, 191);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(289, 35);
            buttonEntrar.TabIndex = 0;
            buttonEntrar.Text = "ENTRAR";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario :";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.CharacterCasing = CharacterCasing.Upper;
            textBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsuario.Location = new Point(405, 39);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(289, 29);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.CharacterCasing = CharacterCasing.Upper;
            textBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSenha.Location = new Point(405, 120);
            textBoxSenha.MaxLength = 10;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(289, 29);
            textBoxSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha :";
            // 
            // buttonRecuperarSenha
            // 
            buttonRecuperarSenha.Location = new Point(405, 267);
            buttonRecuperarSenha.Name = "buttonRecuperarSenha";
            buttonRecuperarSenha.Size = new Size(126, 35);
            buttonRecuperarSenha.TabIndex = 5;
            buttonRecuperarSenha.Text = "RECUPERAR SENHA";
            buttonRecuperarSenha.UseVisualStyleBackColor = true;
            // 
            // buttonNovoUsuario
            // 
            buttonNovoUsuario.Location = new Point(568, 267);
            buttonNovoUsuario.Name = "buttonNovoUsuario";
            buttonNovoUsuario.Size = new Size(126, 35);
            buttonNovoUsuario.TabIndex = 6;
            buttonNovoUsuario.Text = "NOVO USUARIO";
            buttonNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 295);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormTelaInicial
            // 
            AcceptButton = buttonEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonRecuperarSenha;
            ClientSize = new Size(727, 339);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNovoUsuario);
            Controls.Add(buttonRecuperarSenha);
            Controls.Add(label2);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label1);
            Controls.Add(buttonEntrar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA INICIAL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar;
        private Label label1;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label2;
        private Button buttonRecuperarSenha;
        private Button buttonNovoUsuario;
        private PictureBox pictureBox1;
    }
}
