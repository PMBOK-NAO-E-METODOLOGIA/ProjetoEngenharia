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
    public partial class TelaConfigEmail : Form
    {
        Pessoa.Administrador administrador1;
        E_mail mail;
        int aux;

        public TelaConfigEmail()
        {
            InitializeComponent();
        }
        public TelaConfigEmail(Pessoa.Administrador administrador)
        {
            InitializeComponent();

            administrador1 = administrador;

            mail = new E_mail(administrador1);

            if(mail.RetornarConfiguracao() == true)
            {
                aux = mail.getAuxiliar();
                if (aux == 1)
                {
                    txtServidor.Text = mail.getServidor();
                    txtPortaSaida.Text = Convert.ToString(mail.getPorta());
                    if (mail.getSsl() == 'S') 
                    {
                        chkSSL.Checked = true;
                    }
                    else
                    {
                        chkSSL.Checked = false;
                    }

                }
            }

        }

        private void btnAplicarConfig_Click(object sender, EventArgs e)
        {
            string server_smtp = txtServidor.Text;
            int porta_smtp = Convert.ToInt32(txtPortaSaida.Text);
            char isSsl;
            int id_admin = administrador1.getIdAdmin();

            if(aux != 1)
            {
                if (chkSSL.Checked == true)
                {
                    isSsl = 'S';
                }
                else
                {
                    isSsl = 'N';
                }

                mail = new E_mail(server_smtp, porta_smtp, isSsl, administrador1);

                mail.CadastrarServidor();
            }
            else
            {
                if (chkSSL.Checked == true)
                {
                    isSsl = 'S';
                }
                else
                {
                    isSsl = 'N';
                }

                mail = new E_mail(server_smtp, porta_smtp, isSsl, administrador1);

                mail.AtualizarRegistroServidor();
            }
            this.Close();
        }

        private void txtPortaSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
