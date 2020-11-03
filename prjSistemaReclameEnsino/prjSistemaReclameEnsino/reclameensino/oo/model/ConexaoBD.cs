using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjSistemaReclameEnsino.reclameensino.oo.model
{
    public class ConexaoBD
    {

        private static string strConexao = prjSistemaReclameEnsino.Properties.Settings.Default.strConexao;

        private SqlConnection connection;

        public ConexaoBD()
        {
            this.connection = new SqlConnection(strConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                if(connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    return connection;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
            }
        }


    }
}
