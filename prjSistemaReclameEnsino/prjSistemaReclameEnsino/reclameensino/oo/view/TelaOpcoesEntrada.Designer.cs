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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaOpcoesEntrada));
            this.btnEntrarUsuario = new System.Windows.Forms.Button();
            this.btnEntrarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrarUsuario
            // 
            this.btnEntrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarUsuario.Location = new System.Drawing.Point(59, 54);
            this.btnEntrarUsuario.Name = "btnEntrarUsuario";
            this.btnEntrarUsuario.Size = new System.Drawing.Size(135, 53);
            this.btnEntrarUsuario.TabIndex = 3;
            this.btnEntrarUsuario.Text = "Fazer uma sugestão";
            this.btnEntrarUsuario.UseVisualStyleBackColor = false;
            this.btnEntrarUsuario.Click += new System.EventHandler(this.btnEntrarUsuario_Click);
            // 
            // btnEntrarAdmin
            // 
            this.btnEntrarAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntrarAdmin.Location = new System.Drawing.Point(59, 113);
            this.btnEntrarAdmin.Name = "btnEntrarAdmin";
            this.btnEntrarAdmin.Size = new System.Drawing.Size(135, 53);
            this.btnEntrarAdmin.TabIndex = 4;
            this.btnEntrarAdmin.Text = "Administrador";
            this.btnEntrarAdmin.UseVisualStyleBackColor = false;
            this.btnEntrarAdmin.Click += new System.EventHandler(this.btnEntrarAdmin_Click);
            // 
            // TelaOpcoesEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(253, 227);
            this.Controls.Add(this.btnEntrarAdmin);
            this.Controls.Add(this.btnEntrarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaOpcoesEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclame Ensino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarUsuario;
        private System.Windows.Forms.Button btnEntrarAdmin;
    }
}