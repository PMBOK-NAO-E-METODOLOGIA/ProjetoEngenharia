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
using System.Data.SqlClient;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaPrincipalAdministrador : Form
    {
        Pessoa.Administrador admin = new Pessoa.Administrador();
        Comentario comentario = new Comentario();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

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
                PreencherDataGridView();
                PreencherEtiquetaComboBox();
            }
        }

        private void PreencherDataGridView()
        {
            //Comentario comentario = new Comentario();

            da = comentario.RetornarTodosComentarios();

            if (da != null)
            {
                da.Fill(ds);
                dgvComentarios.DataSource = ds;
                dgvComentarios.DataMember = ds.Tables[0].TableName;
            }
        }

        private void PreencherEtiquetaComboBox()
        {
            List<string> etiquetas = new List<string>(); 

            etiquetas = comentario.RetornarDescEtiquetas();

            if (etiquetas != null)
            {
                foreach(string desc in etiquetas)
                {
                    cbEtiquetas.Items.Add(desc);
                }
            }
        }
        /*
        private void Filtragem()
        {
            string titulo = txtTitulo.Text;
            string tag = cbEtiquetas.Text;
            string cmd;
            bool isAnonimo;
            bool isVisto;
            
            if (String.IsNullOrEmpty(titulo))
            {
                if (String.IsNullOrEmpty(tag))
                {
                    if(rbTrue.Checked == true)
                    {
                        isAnonimo = true;
                        cmd = "SELECT idComentario, tituloComentario, dataComentario FROM comentarios WHERE ISNULL(nomeUsuario)";
                        if(rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                            cmd += " AND foiVisto = S";
                        }
                        else
                        {
                            isVisto = false;
                            cmd += " AND foiVisto = N"; 
                        }
                    }
                    else
                    {
                        isAnonimo = false;
                        cmd = "SELECT idComentario, tituloComentario, dataComentario FROM comentarios WHERE";
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                            cmd += " foiVisto = S";
                        }
                        else
                        {
                            isVisto = false;
                            cmd += " foiVisto = N";
                        }
                    }
                }
                else
                {
                    cmd = "SELECT idComentario, tituloComentario, dataComentario FROM comentarios C INNER JOIN filtro_comentarios FC ON C.idComentario = FC.idComentario INNER JOIN tags T ON FC.idTag = T.idTag WHERE "
                    if (rbTrue.Checked == true)
                    {
                        isAnonimo = true;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                    else
                    {
                        isAnonimo = false;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(tag))
                {
                    if (rbTrue.Checked == true)
                    {
                        isAnonimo = true;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                    else
                    {
                        isAnonimo = false;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                }
                else
                {
                    if (rbTrue.Checked == true)
                    {
                        isAnonimo = true;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                    else
                    {
                        isAnonimo = false;
                        if (rbVistoTrue.Checked == true)
                        {
                            isVisto = true;
                        }
                        else
                        {
                            isVisto = false;
                        }
                    }
                }
            }




        }
        */
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
