namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    partial class TelaOpcoesEntrada
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
            this.btnEntrarUsuario = new System.Windows.Forms.Button();
            this.btnEntrarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrarUsuario
            // 
            this.btnEntrarUsuario.Location = new System.Drawing.Point(34, 77);
            this.btnEntrarUsuario.Name = "btnEntrarUsuario";
            this.btnEntrarUsuario.Size = new System.Drawing.Size(92, 49);
            this.btnEntrarUsuario.TabIndex = 3;
            this.btnEntrarUsuario.Text = "Entrar como Usuário";
            this.btnEntrarUsuario.UseVisualStyleBackColor = true;
            this.btnEntrarUsuario.Click += new System.EventHandler(this.btnEntrarUsuario_Click);
            // 
            // btnEntrarAdmin
            // 
            this.btnEntrarAdmin.Location = new System.Drawing.Point(34, 23);
            this.btnEntrarAdmin.Name = "btnEntrarAdmin";
            this.btnEntrarAdmin.Size = new System.Drawing.Size(92, 48);
            this.btnEntrarAdmin.TabIndex = 4;
            this.btnEntrarAdmin.Text = "Entrar como Administrador";
            this.btnEntrarAdmin.UseVisualStyleBackColor = true;
            this.btnEntrarAdmin.Click += new System.EventHandler(this.btnEntrarAdmin_Click);
            // 
            // TelaOpcoesEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 151);
            this.Controls.Add(this.btnEntrarAdmin);
            this.Controls.Add(this.btnEntrarUsuario);
            this.Name = "TelaOpcoesEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarUsuario;
        private System.Windows.Forms.Button btnEntrarAdmin;
    }
}