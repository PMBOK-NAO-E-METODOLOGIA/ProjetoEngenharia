namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    partial class TelaPrincipalUsuario
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
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTags = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescritivo = new System.Windows.Forms.RichTextBox();
            this.btnEnviarComentario = new System.Windows.Forms.Button();
            this.lblLimiteCaracter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(12, 279);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 53);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTags);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTituloComentario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Descrição";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTituloComentario
            // 
            this.txtTituloComentario.Location = new System.Drawing.Point(21, 39);
            this.txtTituloComentario.Name = "txtTituloComentario";
            this.txtTituloComentario.Size = new System.Drawing.Size(124, 20);
            this.txtTituloComentario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(21, 84);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(252, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tags";
            // 
            // chkTags
            // 
            this.chkTags.BackColor = System.Drawing.Color.Silver;
            this.chkTags.CheckOnClick = true;
            this.chkTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTags.FormattingEnabled = true;
            this.chkTags.Location = new System.Drawing.Point(21, 142);
            this.chkTags.Name = "chkTags";
            this.chkTags.Size = new System.Drawing.Size(179, 89);
            this.chkTags.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLimiteCaracter);
            this.groupBox2.Controls.Add(this.txtDescritivo);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descritivo";
            // 
            // txtDescritivo
            // 
            this.txtDescritivo.Location = new System.Drawing.Point(17, 19);
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDescritivo.Size = new System.Drawing.Size(233, 212);
            this.txtDescritivo.TabIndex = 0;
            this.txtDescritivo.Text = "";
            // 
            // btnEnviarComentario
            // 
            this.btnEnviarComentario.BackColor = System.Drawing.Color.Yellow;
            this.btnEnviarComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarComentario.Location = new System.Drawing.Point(474, 279);
            this.btnEnviarComentario.Name = "btnEnviarComentario";
            this.btnEnviarComentario.Size = new System.Drawing.Size(110, 53);
            this.btnEnviarComentario.TabIndex = 4;
            this.btnEnviarComentario.Text = "Enviar comentário";
            this.btnEnviarComentario.UseVisualStyleBackColor = false;
            this.btnEnviarComentario.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLimiteCaracter
            // 
            this.lblLimiteCaracter.AutoSize = true;
            this.lblLimiteCaracter.Location = new System.Drawing.Point(164, 234);
            this.lblLimiteCaracter.Name = "lblLimiteCaracter";
            this.lblLimiteCaracter.Size = new System.Drawing.Size(86, 13);
            this.lblLimiteCaracter.TabIndex = 1;
            this.lblLimiteCaracter.Text = "<LimiteCaracter>";
            // 
            // TelaPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 342);
            this.Controls.Add(this.btnEnviarComentario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipalUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central do Usuário";
            this.Load += new System.EventHandler(this.TelaPrincipalUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloComentario;
        private System.Windows.Forms.CheckedListBox chkTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDescritivo;
        private System.Windows.Forms.Button btnEnviarComentario;
        private System.Windows.Forms.Label lblLimiteCaracter;
    }
}