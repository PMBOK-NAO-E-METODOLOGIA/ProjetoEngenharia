namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    partial class TelaPrincipalAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.msOpcoes = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Administrador";
            // 
            // msOpcoes
            // 
            this.msOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.msOpcoes.Location = new System.Drawing.Point(0, 0);
            this.msOpcoes.Name = "msOpcoes";
            this.msOpcoes.Size = new System.Drawing.Size(502, 24);
            this.msOpcoes.TabIndex = 1;
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAdministradorToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastrarAdministradorToolStripMenuItem
            // 
            this.cadastrarAdministradorToolStripMenuItem.Name = "cadastrarAdministradorToolStripMenuItem";
            this.cadastrarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastrarAdministradorToolStripMenuItem.Text = "Cadastrar Administrador";
            this.cadastrarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAdministradorToolStripMenuItem_Click);
            // 
            // TelaPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msOpcoes;
            this.Name = "TelaPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central do Administrador";
            this.msOpcoes.ResumeLayout(false);
            this.msOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msOpcoes;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAdministradorToolStripMenuItem;
    }
}