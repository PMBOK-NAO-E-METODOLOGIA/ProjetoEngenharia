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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.msOpcoes = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarComentárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.gbComentarios = new System.Windows.Forms.GroupBox();
            this.btnFiltrarComentarios = new System.Windows.Forms.Button();
            this.gbAnonimo = new System.Windows.Forms.GroupBox();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEtiquetas = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.msOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.gbComentarios.SuspendLayout();
            this.gbAnonimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(504, 182);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(109, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Tela de Administrador";
            // 
            // msOpcoes
            // 
            this.msOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.entrarToolStripMenuItem,
            this.enviarComentárioToolStripMenuItem});
            this.msOpcoes.Location = new System.Drawing.Point(0, 0);
            this.msOpcoes.Name = "msOpcoes";
            this.msOpcoes.Size = new System.Drawing.Size(643, 24);
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
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // enviarComentárioToolStripMenuItem
            // 
            this.enviarComentárioToolStripMenuItem.Name = "enviarComentárioToolStripMenuItem";
            this.enviarComentárioToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.enviarComentárioToolStripMenuItem.Text = "Enviar Comentário";
            this.enviarComentárioToolStripMenuItem.Click += new System.EventHandler(this.enviarComentárioToolStripMenuItem_Click);
            // 
            // pbAdmin
            // 
            this.pbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdmin.Location = new System.Drawing.Point(482, 45);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(149, 129);
            this.pbAdmin.TabIndex = 2;
            this.pbAdmin.TabStop = false;
            // 
            // gbComentarios
            // 
            this.gbComentarios.Controls.Add(this.btnFiltrarComentarios);
            this.gbComentarios.Controls.Add(this.gbAnonimo);
            this.gbComentarios.Controls.Add(this.label2);
            this.gbComentarios.Controls.Add(this.cbEtiquetas);
            this.gbComentarios.Controls.Add(this.txtTitulo);
            this.gbComentarios.Controls.Add(this.label1);
            this.gbComentarios.Controls.Add(this.dgvComentarios);
            this.gbComentarios.Location = new System.Drawing.Point(15, 38);
            this.gbComentarios.Name = "gbComentarios";
            this.gbComentarios.Size = new System.Drawing.Size(461, 352);
            this.gbComentarios.TabIndex = 3;
            this.gbComentarios.TabStop = false;
            this.gbComentarios.Text = "Comentários";
            // 
            // btnFiltrarComentarios
            // 
            this.btnFiltrarComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarComentarios.Location = new System.Drawing.Point(345, 102);
            this.btnFiltrarComentarios.Name = "btnFiltrarComentarios";
            this.btnFiltrarComentarios.Size = new System.Drawing.Size(101, 23);
            this.btnFiltrarComentarios.TabIndex = 6;
            this.btnFiltrarComentarios.Text = "Filtrar";
            this.btnFiltrarComentarios.UseVisualStyleBackColor = true;
            this.btnFiltrarComentarios.Click += new System.EventHandler(this.btnFiltrarComentarios_Click);
            // 
            // gbAnonimo
            // 
            this.gbAnonimo.Controls.Add(this.rbFalse);
            this.gbAnonimo.Controls.Add(this.rbTrue);
            this.gbAnonimo.Location = new System.Drawing.Point(12, 72);
            this.gbAnonimo.Name = "gbAnonimo";
            this.gbAnonimo.Size = new System.Drawing.Size(106, 44);
            this.gbAnonimo.TabIndex = 5;
            this.gbAnonimo.TabStop = false;
            this.gbAnonimo.Text = "Anônimo?";
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(54, 19);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(45, 17);
            this.rbFalse.TabIndex = 1;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "Não";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(6, 19);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(42, 17);
            this.rbTrue.TabIndex = 0;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "Sim";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etiquetas";
            // 
            // cbEtiquetas
            // 
            this.cbEtiquetas.FormattingEnabled = true;
            this.cbEtiquetas.Location = new System.Drawing.Point(212, 41);
            this.cbEtiquetas.Name = "cbEtiquetas";
            this.cbEtiquetas.Size = new System.Drawing.Size(142, 21);
            this.cbEtiquetas.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // dgvComentarios
            // 
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentarios.Location = new System.Drawing.Point(6, 131);
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.Size = new System.Drawing.Size(449, 212);
            this.dgvComentarios.TabIndex = 0;
            // 
            // TelaPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 402);
            this.Controls.Add(this.gbComentarios);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.msOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msOpcoes;
            this.Name = "TelaPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central";
            this.Load += new System.EventHandler(this.TelaPrincipalAdministrador_Load);
            this.msOpcoes.ResumeLayout(false);
            this.msOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.gbComentarios.ResumeLayout(false);
            this.gbComentarios.PerformLayout();
            this.gbAnonimo.ResumeLayout(false);
            this.gbAnonimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip msOpcoes;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarComentárioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.GroupBox gbComentarios;
        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEtiquetas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarComentarios;
        private System.Windows.Forms.GroupBox gbAnonimo;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
    }
}