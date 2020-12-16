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
    public partial class TelaCadastroAdministrador : Form
    {
        
        public TelaCadastroAdministrador()
        {
            InitializeComponent();
        }

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            string nomeAdmin = txtNomePessoa.Text;
            string usuarioAdmin = txtUsuario.Text;
            string senhaAdmin = txtSenha.Text;
            string emailAdmin = txtEmail.Text;

            if (String.IsNullOrEmpty(nomeAdmin))
            {
                MessageBox.Show("Nome do Administrador Não Pode Ser Vázio/Nulo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(usuarioAdmin))
                {
                    MessageBox.Show("Usuário Não Pode Ser Vázio/Nulo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (String.IsNullOrEmpty(senhaAdmin))
                    {
                        MessageBox.Show("Senha Não Pode Ser Vázia/Nula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(emailAdmin))
                        {
                            Pessoa.Administrador administrador = new Pessoa.Administrador(nomeAdmin, usuarioAdmin, senhaAdmin);

                            if (administrador.cadastrarAdministrador())
                            {
                                MessageBox.Show("Administrador Cadastrado com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao Cadastrar o Administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Pessoa.Administrador administrador = new Pessoa.Administrador(nomeAdmin, usuarioAdmin, senhaAdmin, emailAdmin);

                            if (administrador.cadastrarAdministrador())
                            {
                                MessageBox.Show("Administrador Cadastrado com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao Cadastrar o Administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        

                    }
                }
            }            
        }
        private void TelaCadastroAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
