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
using prjSistemaReclameEnsino.reclameensino.oo.model;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaLoginAdmin : Form
    {
        Thread thread;
        public TelaLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (String.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Usuário Não Pode Ser Vázio/Nulo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Senha Não Pode Ser Vázia/Nula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Pessoa.Administrador administrador = new Pessoa.Administrador();

                    administrador.setNomeUsuario(usuario);
                    administrador.setSenhaUsuario(senha);

                    if (administrador.validarAcesso())
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Autenticar o Acesso!\nVerificar Credenciais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            
        }

        private void abrirTelaAdmin()
        {
            Application.Run(new TelaPrincipalAdministrador());
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
