using prjSistemaReclameEnsino.reclameensino.oo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaPrincipalAdministrador : Form
    {

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dataSet = new DataSet();

        Pessoa.Administrador admin = new Pessoa.Administrador();
        Comentario comentario = new Comentario();

        bool isTitulo;
        bool isAnonimo;
        bool isVisto;


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

                PreencherComboBoxEtiquetas();
                PreencherDataGridTimeLine();
                ConstruirColunasLinhasDGV();
                

            }
        }

        private void PreencherComboBoxEtiquetas()
        {
            List<string> nomeEtiquetas = new List<string>();

            nomeEtiquetas = comentario.RetornarDescEtiquetas();

            foreach(string x in nomeEtiquetas)
            {
                cbEtiquetas.Items.Add(x);
            }
        }

        private void PreencherDataGridTimeLine()
        {
            da = comentario.RetornarComentarios();

            da.Fill(dataSet);

            dgvComentarios.DataSource = dataSet;
            dgvComentarios.DataMember = dataSet.Tables[0].TableName;


        }

        private void ConstruirColunasLinhasDGV()
        {
            //Definindo os nomes de variáveis dos objetos
            
            dataSet.Tables[0].Columns[0].ColumnName = "ID";
            dataSet.Tables[0].Columns[1].ColumnName = "Título";
            dataSet.Tables[0].Columns[2].ColumnName = "Data de Entrada";
            

            //Definindo os rótulos
            dataSet.Tables[0].Columns[0].Caption = "idComentarioDGV";
            dataSet.Tables[0].Columns[1].Caption = "tituloComentarioDGV";
            dataSet.Tables[0].Columns[2].Caption = "dataComentarioDGV";
            
        }

        private void btnFiltrarComentarios_Click(object sender, EventArgs e)
        {
            
        }
        /* Continuação daqui....
         * 
         * O método abaixo irá filtrar de forma "dinâmica", dizendo aos tipos booleanos
         * se foi inserido, se é verdadeiro ou não....
         * para deixar uma string de SQL mais enxuta!
         * 
         */
        private void Filtragem()
        {
            string titulo = txtTitulo.Text;
        }

    }
}
