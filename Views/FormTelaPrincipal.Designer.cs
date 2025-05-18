namespace ControleAlunos.Views
{
    partial class FormTelaPrincipal
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
            menuStrip1 = new MenuStrip();
            aLUNOSToolStripMenuItem = new ToolStripMenuItem();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            aTUALIZARINFORMACOESToolStripMenuItem = new ToolStripMenuItem();
            pESQUISASToolStripMenuItem = new ToolStripMenuItem();
            aLUNOToolStripMenuItem = new ToolStripMenuItem();
            apagarBnacoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aLUNOSToolStripMenuItem, pESQUISASToolStripMenuItem, apagarBnacoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(458, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aLUNOSToolStripMenuItem
            // 
            aLUNOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cADASTROToolStripMenuItem, aTUALIZARINFORMACOESToolStripMenuItem });
            aLUNOSToolStripMenuItem.Name = "aLUNOSToolStripMenuItem";
            aLUNOSToolStripMenuItem.Size = new Size(65, 20);
            aLUNOSToolStripMenuItem.Text = "ALUNOS";
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Size = new Size(219, 22);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            cADASTROToolStripMenuItem.Click += cADASTROToolStripMenuItem_Click;
            // 
            // aTUALIZARINFORMACOESToolStripMenuItem
            // 
            aTUALIZARINFORMACOESToolStripMenuItem.Name = "aTUALIZARINFORMACOESToolStripMenuItem";
            aTUALIZARINFORMACOESToolStripMenuItem.Size = new Size(219, 22);
            aTUALIZARINFORMACOESToolStripMenuItem.Text = "ATUALIZAR INFORMACOES";
            // 
            // pESQUISASToolStripMenuItem
            // 
            pESQUISASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLUNOToolStripMenuItem });
            pESQUISASToolStripMenuItem.Name = "pESQUISASToolStripMenuItem";
            pESQUISASToolStripMenuItem.Size = new Size(78, 20);
            pESQUISASToolStripMenuItem.Text = "PESQUISAS";
            pESQUISASToolStripMenuItem.Click += pESQUISASToolStripMenuItem_Click;
            // 
            // aLUNOToolStripMenuItem
            // 
            aLUNOToolStripMenuItem.Name = "aLUNOToolStripMenuItem";
            aLUNOToolStripMenuItem.Size = new Size(114, 22);
            aLUNOToolStripMenuItem.Text = "ALUNO";
            aLUNOToolStripMenuItem.Click += aLUNOToolStripMenuItem_Click;
            // 
            // apagarBnacoToolStripMenuItem
            // 
            apagarBnacoToolStripMenuItem.Name = "apagarBnacoToolStripMenuItem";
            apagarBnacoToolStripMenuItem.Size = new Size(167, 20);
            apagarBnacoToolStripMenuItem.Text = "APAGAR BANCO DE DADOS";
            apagarBnacoToolStripMenuItem.Click += apagarBnacoToolStripMenuItem_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 454);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aLUNOSToolStripMenuItem;
        private ToolStripMenuItem cADASTROToolStripMenuItem;
        private ToolStripMenuItem aTUALIZARINFORMACOESToolStripMenuItem;
        private ToolStripMenuItem pESQUISASToolStripMenuItem;
        private ToolStripMenuItem aLUNOToolStripMenuItem;
        private ToolStripMenuItem apagarBnacoToolStripMenuItem;
    }
}