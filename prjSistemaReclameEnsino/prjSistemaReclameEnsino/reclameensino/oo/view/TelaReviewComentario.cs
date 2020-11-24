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
        
        public TelaReviewComentario(Comentario comentario)
        {
            InitializeComponent();

            txtID.Text = Convert.ToString(comentario.getIdComentario());

            string[] dados = new string[5];

            //Falha --> Conexão estava fechada!!!!
            dados = comentario.RetornarDadosComentario();

            
            txtTitulo.Text = dados[0];
            txtDataEntrada.Text = dados[1];
            txtVisto.Text = dados[2];
            txtAutor.Text = dados[3];
            txtDescritivo.Text = dados[4];

            if(txtVisto.Text == "S")
            {
                chkVisto.Enabled = false;
                chkVisto.Checked = true;
                btnAtualizar.Enabled = false;
            }


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

        private void chkVisto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkVisto.Checked == true)
            {
                btnAtualizar.Enabled = true;
            }
            else
            {
                btnAtualizar.Enabled = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(chkVisto.Checked == true)
            {
                char visto = 'S';
                int idComentario = Convert.ToInt32(txtID.Text);
                Comentario comentario = new Comentario();

                comentario.setIdComentario(idComentario);
                comentario.setIsVisto(visto);

                if (comentario.AtualizarComentario())
                {
                    MessageBox.Show("Comentário " + txtTitulo.Text + " vistado!");
                    this.Close();
                }
            }
        }
    }
}
