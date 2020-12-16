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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalUsuario));
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAnonimo = new System.Windows.Forms.CheckBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.chkTags = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTituloComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLimiteCaracter = new System.Windows.Forms.Label();
            this.txtDescritivo = new System.Windows.Forms.RichTextBox();
            this.btnEnviarComentario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkTags);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTituloComentario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkAnonimo);
            this.groupBox3.Controls.Add(this.txtAutor);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Name = "txtEmail";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chkAnonimo
            // 
            resources.ApplyResources(this.chkAnonimo, "chkAnonimo");
            this.chkAnonimo.Name = "chkAnonimo";
            this.chkAnonimo.UseVisualStyleBackColor = true;
            this.chkAnonimo.CheckedChanged += new System.EventHandler(this.chkAnonimo_CheckedChanged);
            // 
            // txtAutor
            // 
            resources.ApplyResources(this.txtAutor, "txtAutor");
            this.txtAutor.Name = "txtAutor";
            // 
            // chkTags
            // 
            resources.ApplyResources(this.chkTags, "chkTags");
            this.chkTags.BackColor = System.Drawing.Color.Silver;
            this.chkTags.CheckOnClick = true;
            this.chkTags.FormattingEnabled = true;
            this.chkTags.Name = "chkTags";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTituloComentario
            // 
            resources.ApplyResources(this.txtTituloComentario, "txtTituloComentario");
            this.txtTituloComentario.Name = "txtTituloComentario";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblLimiteCaracter);
            this.groupBox2.Controls.Add(this.txtDescritivo);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblLimiteCaracter
            // 
            resources.ApplyResources(this.lblLimiteCaracter, "lblLimiteCaracter");
            this.lblLimiteCaracter.Name = "lblLimiteCaracter";
            // 
            // txtDescritivo
            // 
            resources.ApplyResources(this.txtDescritivo, "txtDescritivo");
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.TextChanged += new System.EventHandler(this.txtDescritivo_TextChanged);
            // 
            // btnEnviarComentario
            // 
            resources.ApplyResources(this.btnEnviarComentario, "btnEnviarComentario");
            this.btnEnviarComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEnviarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarComentario.Name = "btnEnviarComentario";
            this.btnEnviarComentario.UseVisualStyleBackColor = false;
            this.btnEnviarComentario.Click += new System.EventHandler(this.btnEnviarComentario_Click);
            // 
            // TelaPrincipalUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnEnviarComentario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipalUsuario";
            this.Load += new System.EventHandler(this.TelaPrincipalUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkAnonimo;
    }
}