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
            DesativarRecursos();
            new TelaRelatorioGrafico().Show();
        }

        private void DesativarRecursos()
        {
            entrarToolStripMenuItem.Enabled = true;
            opçõesToolStripMenuItem.Enabled = false;
            gbComentarios.Visible = false;
            lblUsuario.Visible = false;
            sairToolStripMenuItem.Visible = false;
            pbAdmin.BackgroundImage = null;
            enviarComentárioToolStripMenuItem.Enabled = true;
            configuraçãoToolStripMenuItem.Enabled = false;
            cbEtiquetas.Items.Clear();
            ds.Clear();

        }

        private void enviarComentárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPrincipalUsuario usuario = new TelaPrincipalUsuario();

            usuario.ShowDialog();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLoginAdmin loginAdmin = new TelaLoginAdmin(admin);

            loginAdmin.ShowDialog();

            if (admin.getIsEntrou())
            {
                opçõesToolStripMenuItem.Enabled = true;
                enviarComentárioToolStripMenuItem.Enabled = false;
                sairToolStripMenuItem.Visible = true;
                entrarToolStripMenuItem.Enabled = false;
                configuraçãoToolStripMenuItem.Enabled = true;
                pbAdmin.BackgroundImage = prjSistemaReclameEnsino.Properties.Resources.admin;

                gbComentarios.Visible = true;
                lblUsuario.Text = admin.getNomeUsuario();
                lblUsuario.Visible = true;
                PreencherDataGridView();
                PreencherEtiquetaComboBox();
            }
        }

        private void VerificacaoVistos()
        {
            int aux = 0;
            int idComentario;
            char visto;

            while (aux < dgvComentarios.Rows.Count)
            {
                idComentario = Convert.ToInt32(dgvComentarios.Rows[aux].Cells[idComentarioDataGridView.Index].Value);

                comentario.setIdComentario(idComentario);

                visto = comentario.VerificarVistos();

                if (visto == 'S')
                {
                    for (int i = 0; i < dgvComentarios.ColumnCount; i++)
                    {
                        dgvComentarios.Rows[aux].Cells[i].Style.BackColor = Color.LightGreen;
                    }
                }
                else if(visto == 'N')
                {
                    for (int i = 0; i<dgvComentarios.ColumnCount; i++)
                    {
                        dgvComentarios.Rows[aux].Cells[i].Style.BackColor = Color.IndianRed;
                    }
                }
                else
                {
                    for (int i = 0; i < dgvComentarios.ColumnCount; i++)
                    {
                        dgvComentarios.Rows[aux].Cells[i].Style.BackColor = Color.LightYellow;
                    }

                }

                aux++;

            }

        }


        private void PreencherDataGridView()
        {
            //Comentario comentario = new Comentario();
            ds.Clear();
            da = comentario.RetornarTodosComentarios();

            if (da != null)
            {
                da.Fill(ds);
                dgvComentarios.DataSource = ds;
                dgvComentarios.DataMember = ds.Tables[0].TableName;
            }

            VerificacaoVistos();

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
        
        private SqlDataAdapter Filtragem()
        {
            string titulo = txtTitulo.Text;
            string tag = cbEtiquetas.Text;
            char condicaoFoiVisto;
            string cmd;

            cmd = "SELECT C.idComentario, C.tituloComentario, C.dataComentario FROM comentarios C";

            if(String.IsNullOrEmpty(tag) != true)
            {
                comentario.setNomeTag(tag);
                cmd = IncrementarTags(cmd);

                if (String.IsNullOrEmpty(titulo) != true)
                {
                    comentario.setTituloComentario(titulo);
                    cmd = IncrementarTituloComOutras(cmd);
                }

                if(rbTrue.Checked == true)
                {
                    cmd = IncrementarAnonimoComOutras(cmd);
                }

                if(rbVistoTrue.Checked == true)
                {
                    condicaoFoiVisto = 'S';
                }
                else
                {
                    condicaoFoiVisto = 'N';
                }
                comentario.setIsVisto(condicaoFoiVisto);
                cmd = IncrementarFoiVistoComOutras(cmd);
            }
            else
            {
                if (rbTrue.Checked == true)
                {
                    cmd = IncrementarAnonimo(cmd);

                    if (String.IsNullOrEmpty(titulo) != true)
                    {
                        comentario.setTituloComentario(titulo);
                        cmd = IncrementarTituloComOutras(cmd);
                    }

                    if (rbVistoTrue.Checked == true)
                    {
                        condicaoFoiVisto = 'S';
                    }
                    else
                    {
                        condicaoFoiVisto = 'N';
                    }

                    comentario.setIsVisto(condicaoFoiVisto);
                    cmd = IncrementarFoiVistoComOutras(cmd);

                }
                else
                {
                    if (String.IsNullOrEmpty(titulo) != true)
                    {
                        comentario.setTituloComentario(titulo);
                        cmd = IncrementarTitulo(cmd);

                        if (rbVistoTrue.Checked == true)
                        {
                            condicaoFoiVisto = 'S';
                        }
                        else
                        {
                            condicaoFoiVisto = 'N';
                        }

                        comentario.setIsVisto(condicaoFoiVisto);
                        cmd = IncrementarFoiVistoComOutras(cmd);

                    }
                    else
                    {
                        if (rbVistoTrue.Checked == true)
                        {
                            condicaoFoiVisto = 'S';
                        }
                        else
                        {
                            condicaoFoiVisto = 'N';
                        }

                        comentario.setIsVisto(condicaoFoiVisto);
                        cmd = IncrementarFoiVisto(cmd);
                    }
                }
            }

            return comentario.RetornarComentariosFiltrados(cmd);

        }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            da = Filtragem();

            if(da != null)
            {
                ds.Clear();
                da.Fill(ds); // Resolvido!!! <<< Bug do SelectCommand Fill
                dgvComentarios.DataSource = ds;
                dgvComentarios.DataMember = ds.Tables[0].TableName;
                da.Dispose();
            }

            VerificacaoVistos();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesativarRecursos();
        }

        private string IncrementarTitulo(string cmdSql)
        {
            cmdSql += " WHERE C.tituloComentario = @tituloComentario";
            return cmdSql;
        }

        private string IncrementarTituloComOutras(string cmdSql)
        {
            cmdSql += " AND C.tituloComentario = @tituloComentario";
            return cmdSql;
        }

        private string IncrementarAnonimo(string cmdSql)
        {
            cmdSql += " WHERE C.nomeUsuario = 'ANÔNIMO'";
            return cmdSql;
        }

        private string IncrementarAnonimoComOutras(string cmdSql)
        {
            cmdSql += " AND C.nomeUsuario = 'ANÔNIMO'";
            return cmdSql;
        }

        private string IncrementarFoiVisto(string cmdSql)
        {
            cmdSql += " WHERE C.foiVisto = @foiVisto";
            return cmdSql;
        }

        private string IncrementarFoiVistoComOutras(string cmdSql)
        {
            cmdSql += " AND C.foiVisto = @foiVisto";
            return cmdSql;
        }

        private string IncrementarTags(string cmdSql)
        {
            cmdSql += " INNER JOIN filtro_comentarios FC ON C.idComentario = FC.idComentario INNER JOIN " +
                " tags T ON T.idTag = FC.idTag WHERE T.descTag = @descTag";

            return cmdSql;
        }

        private void dgvComentarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idComentario = Convert.ToInt32(dgvComentarios.Rows[e.RowIndex].Cells[idComentarioDataGridView.Index].Value);
            
            comentario.setIdComentario(idComentario);

            new TelaReviewComentario(comentario, admin).ShowDialog();

            PreencherDataGridView();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
            txtTitulo.Clear();
            cbEtiquetas.Text = "";
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaConfigEmail(admin).ShowDialog();
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaRelatorioGrafico().ShowDialog();
        }
    }
}
