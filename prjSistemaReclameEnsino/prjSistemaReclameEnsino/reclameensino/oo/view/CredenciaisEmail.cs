using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjSistemaReclameEnsino.reclameensino.oo.model;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class CredenciaisEmail : Form
    {
        Comentario comentario1;
        private string senhaEmail;

        public CredenciaisEmail()
        {
            InitializeComponent();
        }

        public CredenciaisEmail(Comentario comentario)
        {
            InitializeComponent();
            this.comentario1 = comentario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            senhaEmail = txtSenha.Text;
            if (senhaEmail != null)
            {
                comentario1.setSenhaEmailAdmin(senhaEmail);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comentario1.setSenhaEmailAdmin(null);
            this.Close();
        }
    }
}
