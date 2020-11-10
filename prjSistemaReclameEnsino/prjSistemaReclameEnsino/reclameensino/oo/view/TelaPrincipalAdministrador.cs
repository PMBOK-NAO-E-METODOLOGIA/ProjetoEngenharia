using prjSistemaReclameEnsino.reclameensino.oo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaPrincipalAdministrador : Form
    {
        Pessoa.Administrador admin = new Pessoa.Administrador();


        public TelaPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void cadastrarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroAdministrador cadastroAdministrador = new TelaCadastroAdministrador();
            cadastroAdministrador.ShowDialog();
        }

        private void TelaPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            opçõesToolStripMenuItem.Enabled = false;
            gbComentarios.Visible = false;
            lblUsuario.Visible = false;

        }

        private void enviarComentárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPrincipalUsuario usuario = new TelaPrincipalUsuario();

            usuario.ShowDialog();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLoginAdmin loginAdmin = new TelaLoginAdmin();

            loginAdmin.ShowDialog();

            if (admin.getIsEntrou())
            {
                opçõesToolStripMenuItem.Enabled = true;
                enviarComentárioToolStripMenuItem.Enabled = false;

                pbAdmin.BackgroundImage = prjSistemaReclameEnsino.Properties.Resources.admin;

                gbComentarios.Visible = true;
                lblUsuario.Visible = true;

            }
        }
    }
}
