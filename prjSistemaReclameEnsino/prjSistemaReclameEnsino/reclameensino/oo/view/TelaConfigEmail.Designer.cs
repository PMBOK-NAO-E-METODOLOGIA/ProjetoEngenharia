namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    partial class TelaConfigEmail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortaSaida = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSSL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPortaSaida);
            this.panel1.Controls.Add(this.txtServidor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 105);
            this.panel1.TabIndex = 0;
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(19, 66);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(284, 17);
            this.chkSSL.TabIndex = 4;
            this.chkSSL.Text = "Este servidor requer uma conexão de segurança (SSL)";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta de Saída";
            // 
            // txtPortaSaida
            // 
            this.txtPortaSaida.Location = new System.Drawing.Point(159, 34);
            this.txtPortaSaida.Name = "txtPortaSaida";
            this.txtPortaSaida.Size = new System.Drawing.Size(50, 20);
            this.txtPortaSaida.TabIndex = 2;
            this.txtPortaSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortaSaida_KeyPress);
            // 
            // txtServidor
            // 
            this.txtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtServidor.Location = new System.Drawing.Point(19, 34);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(125, 20);
            this.txtServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor SMTP";
            // 
            // btnAplicarConfig
            // 
            this.btnAplicarConfig.Location = new System.Drawing.Point(248, 123);
            this.btnAplicarConfig.Name = "btnAplicarConfig";
            this.btnAplicarConfig.Size = new System.Drawing.Size(86, 28);
            this.btnAplicarConfig.TabIndex = 1;
            this.btnAplicarConfig.Text = "Aplicar";
            this.btnAplicarConfig.UseVisualStyleBackColor = true;
            this.btnAplicarConfig.Click += new System.EventHandler(this.btnAplicarConfig_Click);
            // 
            // TelaConfigEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 163);
            this.Controls.Add(this.btnAplicarConfig);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaConfigEmail";
            this.Text = "Config. SMTP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortaSaida;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicarConfig;
    }
}