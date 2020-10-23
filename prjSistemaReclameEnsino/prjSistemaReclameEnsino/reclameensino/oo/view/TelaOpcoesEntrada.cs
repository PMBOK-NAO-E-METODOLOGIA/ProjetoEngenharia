using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaOpcoesEntrada : Form
    {
        Thread thread;

        public TelaOpcoesEntrada()
        {
            InitializeComponent();
        }

        private void btnEntrarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirTelaLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(abrirTelaUsuario);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        private void abrirTelaLogin()
        {
            Application.Run(new TelaLoginAdmin());
        }

        private void abrirTelaUsuario(object sender)
        {
            Application.Run(new TelaPrincipalUsuario());
        }

    }
}
