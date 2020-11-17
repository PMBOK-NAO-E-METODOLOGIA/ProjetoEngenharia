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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalAdministrador));
            this.msOpcoes = new System.Windows.Forms.MenuStrip();
            this.gbComentarios = new System.Windows.Forms.GroupBox();
            this.gbAnonimo = new System.Windows.Forms.GroupBox();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEtiquetas = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.idComentarioDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloComentarioDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataComentarioDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarComentárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVistoTrue = new System.Windows.Forms.RadioButton();
            this.rbVistoFalse = new System.Windows.Forms.RadioButton();
            this.msOpcoes.SuspendLayout();
            this.gbComentarios.SuspendLayout();
            this.gbAnonimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // gbComentarios
            // 
            this.gbComentarios.Controls.Add(this.groupBox1);
            this.gbComentarios.Controls.Add(this.btnFiltrar);
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
            this.rbFalse.Text = "Não";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Checked = true;
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
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tags";
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
            this.dgvComentarios.AllowUserToAddRows = false;
            this.dgvComentarios.AllowUserToDeleteRows = false;
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComentarioDataGridView,
            this.tituloComentarioDataGridView,
            this.dataComentarioDataGridView});
            this.dgvComentarios.Location = new System.Drawing.Point(6, 131);
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.ReadOnly = true;
            this.dgvComentarios.Size = new System.Drawing.Size(449, 212);
            this.dgvComentarios.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(532, 182);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "userName";
            // 
            // idComentarioDataGridView
            // 
            this.idComentarioDataGridView.DataPropertyName = "idComentario";
            this.idComentarioDataGridView.HeaderText = "ID";
            this.idComentarioDataGridView.Name = "idComentarioDataGridView";
            this.idComentarioDataGridView.ReadOnly = true;
            // 
            // tituloComentarioDataGridView
            // 
            this.tituloComentarioDataGridView.DataPropertyName = "tituloComentario";
            this.tituloComentarioDataGridView.HeaderText = "Título";
            this.tituloComentarioDataGridView.Name = "tituloComentarioDataGridView";
            this.tituloComentarioDataGridView.ReadOnly = true;
            // 
            // dataComentarioDataGridView
            // 
            this.dataComentarioDataGridView.DataPropertyName = "dataComentario";
            this.dataComentarioDataGridView.HeaderText = "Data de Entrada";
            this.dataComentarioDataGridView.Name = "dataComentarioDataGridView";
            this.dataComentarioDataGridView.ReadOnly = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::prjSistemaReclameEnsino.Properties.Resources.loupe_2_;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(327, 91);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(119, 34);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAdministradorToolStripMenuItem});
            this.opçõesToolStripMenuItem.Image = global::prjSistemaReclameEnsino.Properties.Resources.option;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastrarAdministradorToolStripMenuItem
            // 
            this.cadastrarAdministradorToolStripMenuItem.Image = global::prjSistemaReclameEnsino.Properties.Resources.plus;
            this.cadastrarAdministradorToolStripMenuItem.Name = "cadastrarAdministradorToolStripMenuItem";
            this.cadastrarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastrarAdministradorToolStripMenuItem.Text = "Cadastrar Administrador";
            this.cadastrarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAdministradorToolStripMenuItem_Click);
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Image = global::prjSistemaReclameEnsino.Properties.Resources.log_in_1;
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // enviarComentárioToolStripMenuItem
            // 
            this.enviarComentárioToolStripMenuItem.Image = global::prjSistemaReclameEnsino.Properties.Resources.comment;
            this.enviarComentárioToolStripMenuItem.Name = "enviarComentárioToolStripMenuItem";
            this.enviarComentárioToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.enviarComentárioToolStripMenuItem.Text = "Fazer uma Sugestão";
            this.enviarComentárioToolStripMenuItem.Click += new System.EventHandler(this.enviarComentárioToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVistoFalse);
            this.groupBox1.Controls.Add(this.rbVistoTrue);
            this.groupBox1.Location = new System.Drawing.Point(124, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foi Visto?";
            // 
            // rbVistoTrue
            // 
            this.rbVistoTrue.AutoSize = true;
            this.rbVistoTrue.Checked = true;
            this.rbVistoTrue.Location = new System.Drawing.Point(6, 19);
            this.rbVistoTrue.Name = "rbVistoTrue";
            this.rbVistoTrue.Size = new System.Drawing.Size(42, 17);
            this.rbVistoTrue.TabIndex = 0;
            this.rbVistoTrue.TabStop = true;
            this.rbVistoTrue.Text = "Sim";
            this.rbVistoTrue.UseVisualStyleBackColor = true;
            // 
            // rbVistoFalse
            // 
            this.rbVistoFalse.AutoSize = true;
            this.rbVistoFalse.Location = new System.Drawing.Point(54, 19);
            this.rbVistoFalse.Name = "rbVistoFalse";
            this.rbVistoFalse.Size = new System.Drawing.Size(45, 17);
            this.rbVistoFalse.TabIndex = 1;
            this.rbVistoFalse.Text = "Não";
            this.rbVistoFalse.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(643, 402);
            this.Controls.Add(this.gbComentarios);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.msOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOpcoes;
            this.Name = "TelaPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentários";
            this.Load += new System.EventHandler(this.TelaPrincipalAdministrador_Load);
            this.msOpcoes.ResumeLayout(false);
            this.msOpcoes.PerformLayout();
            this.gbComentarios.ResumeLayout(false);
            this.gbComentarios.PerformLayout();
            this.gbAnonimo.ResumeLayout(false);
            this.gbAnonimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gbAnonimo;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComentarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloComentarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataComentarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVistoFalse;
        private System.Windows.Forms.RadioButton rbVistoTrue;
    }
}