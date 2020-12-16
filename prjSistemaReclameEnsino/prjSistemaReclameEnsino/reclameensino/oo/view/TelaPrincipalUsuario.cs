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
    public partial class TelaPrincipalUsuario : Form
    {

        Comentario comentario;
        int qtdCaracteres;

        public TelaPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaPrincipalUsuario_Load(object sender, EventArgs e)
        {
            PreencherCheckList();
        }

        private void PreencherCheckList()
        {
            List<string> listaTags = new List<string>();
            comentario = new Comentario();
            listaTags = comentario.RetornarDescEtiquetas();

            foreach(string x in listaTags)
            {
                chkTags.Items.Add(x);
            }

        }

        //Resumo:
        // Cadastra um comentário na base de dados.
        private void EnviandoComentario()
        {

            string titulo = txtTituloComentario.Text;
            string autor = txtAutor.Text;
            string descritivo = txtDescritivo.Text;
            string email = txtEmail.Text;

            if (String.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("O título não pode ser vázio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTituloComentario.Focus();
            }
            else
            {
                
                if (String.IsNullOrEmpty(descritivo))
                {
                    MessageBox.Show("O descritivo não pode ser vázio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescritivo.Focus();
                }
                else
                {
                    if (String.IsNullOrEmpty(autor))
                    {
                        MessageBox.Show("Autor da Sugestão não pode ser vázio!", "Atenção");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(email))
                        {
                            comentario = new Comentario(titulo, autor, descritivo);

                            //Declarar um lista que será passada contendo a descrição das tags!

                            List<string> listaEtiquetas = new List<string>();

                            foreach (string x in chkTags.CheckedItems)
                            {
                                listaEtiquetas.Add(x); // Adiciona na lista os itens(TAGs) selecionandos
                            }

                            if (comentario.CadastrarComentario(listaEtiquetas) == 1)
                            {
                                MessageBox.Show("Comentário Enviado Com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao Enviar o comentário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                        else
                        {
                            comentario = new Comentario(titulo, autor, descritivo, email);

                            //Declarar um lista que será passada contendo a descrição das tags!

                            List<string> listaEtiquetas = new List<string>();

                            foreach (string x in chkTags.CheckedItems)
                            {
                                listaEtiquetas.Add(x); // Adiciona na lista os itens(TAGs) selecionandos
                            }

                            if (comentario.CadastrarComentario(listaEtiquetas) == 1)
                            {
                                MessageBox.Show("Comentário Enviado Com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao Enviar o comentário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }

            }
            
        }

        private void btnEnviarComentario_Click(object sender, EventArgs e)
        {
            EnviandoComentario();
        }
        //Resumo:
        // Limpar a tela do comentário, desmarcar campos e demais.

        private void LimparTela()
        {
            txtAutor.Clear();
            txtDescritivo.Clear();
            txtTituloComentario.Clear();
            txtEmail.Clear();
        }

        private void txtDescritivo_TextChanged(object sender, EventArgs e)
        {
            //Continuar depois


            /*
             * //TESTEM ESTE MÉTODO POIS NÃO CONSEGUI, JCAIQUE.
            string texto = txtDescritivo.ToString();

            int tamanho = lblLimiteCaracter.Text.Max() - texto.Length;

            lblLimiteCaracter.Text = tamanho.ToString();
             */
        }

        private void chkAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAnonimo.Checked == true)
            {
                txtAutor.Text = "ANÔNIMO";
                txtAutor.Enabled = false;
            }
            else
            {
                txtAutor.Clear();
                txtAutor.Enabled = true;
            }
        }
    }
}
