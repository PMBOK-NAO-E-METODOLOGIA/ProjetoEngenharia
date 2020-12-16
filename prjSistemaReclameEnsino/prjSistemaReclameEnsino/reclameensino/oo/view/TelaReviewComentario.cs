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
using System.Data.SqlClient;


namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaReviewComentario : Form
    {

        Pessoa.Administrador admin;
        Comentario comentario;
        public TelaReviewComentario(Comentario comentario, Pessoa.Administrador administrador)
        {
            InitializeComponent();
            this.comentario = comentario;
            this.admin = administrador;

            txtID.Text = Convert.ToString(comentario.getIdComentario());

            string[] dados = new string[6];

            //Falha --> Conexão estava fechada!!!!
            dados = comentario.RetornarDadosComentario();

            
            txtTitulo.Text = dados[0];
            txtDataEntrada.Text = dados[1];
            txtVisto.Text = dados[2];
            txtAutor.Text = dados[3];
            txtDescritivo.Text = dados[4];
            txtDestinatario.Text = dados[5];

            List<string> etiquetas = new List<string>();
            etiquetas = comentario.RetornarEtiquetasComentario();

            string lista = "";

            if(etiquetas != null)
            {
                foreach (string x in etiquetas)
                {
                    lista += x+"\n";
                    txtListaEtiquetas.Text = lista;
                }
            }
            else
            {
                txtListaEtiquetas.Text = "<Não há etiquetas relacionadas!>";
            }

        }

        public TelaReviewComentario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaReviewComentario_FormClosing(object sender, FormClosingEventArgs e)
        {
            char visto = Convert.ToChar(txtVisto.Text);
            if (visto != 'S')
            {
                /*
                int idComentario = Convert.ToInt32(txtID.Text);
                Comentario comentario = new Comentario();

                comentario.setIdComentario(idComentario);
                */
                visto = 'S';
                comentario.setIsVisto(visto);

                if (comentario.AtualizarComentario())
                {
                    MessageBox.Show("Comentário " + txtTitulo.Text + " vistado!");
                }
                else
                {
                    MessageBox.Show("Falha ao vistar o comentário!", "Atenção");
                }
            }

        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            if(txtResposta.Text != null)
            {
                btnEnviarComentario.Enabled = true;
            }
            else
            {
                btnEnviarComentario.Enabled = false;
            }
        }

        private void EnviarResposta()
        {
            string emailAdmin = admin.RetornaEmailAdmin();
            string emailUsuario = txtDestinatario.Text;
            string titulo = txtTitulo.Text;
            string resposta = txtResposta.Text;
            //É necessário pegar a senha do email.....

            if(emailAdmin == null || emailUsuario == null)
            {
                //Fazer método para registrar as alterações no comentário vigente.
                comentario.AtualizarRespostaComentario(resposta, admin.getIdAdmin());

            }
            else
            {
                //Receber a senha do e-mail do admin posteriormente!!!!!
                new CredenciaisEmail(comentario).ShowDialog();

                if(comentario.getSenhaEmailAdmin() == null)
                {
                    MessageBox.Show("Senha de E-mail não pode ser vázia!", "Atenção");
                }
                else
                {

                    comentario.AtualizarRespostaComentario(resposta, admin.getIdAdmin());

                    E_mail mail = new E_mail(admin);

                    string retorno = comentario.EnviaMensagemEmail(emailUsuario, emailAdmin, titulo, resposta, mail);

                    MessageBox.Show(retorno, "Atenção");
                }
            }
            this.Close();
        }

        private void btnEnviarComentario_Click(object sender, EventArgs e)
        {
            EnviarResposta();
        }
    }
}
