using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace prjSistemaReclameEnsino.reclameensino.oo.model
{
    public class E_mail
    {
        ConexaoBD conexao = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();
        private string servidor;
        private int porta;
        private char ssl;
        Pessoa.Administrador admin;
        private int aux;

        public E_mail(Pessoa.Administrador admin)
        {
            this.admin = admin;
        }

        public E_mail(string servidor, int porta, char ssl, Pessoa.Administrador admin)
        {
            this.servidor = servidor;
            this.porta = porta;
            this.ssl = ssl;
            this.admin = admin;
        }

        public int getAuxiliar()
        {
            return aux;
        }

        public string getServidor()
        {
            return servidor;
        }

        public int getPorta()
        {
            return porta;
        }

        public char getSsl()
        {
            return ssl;
        }

        public bool CadastrarServidor()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO tb_smptserver VALUES (@id_admin, @nome_servidor, @porta_servidor, @security_ssl)";

            cmd.Parameters.AddWithValue("@id_admin", admin.getIdAdmin());
            cmd.Parameters.AddWithValue("@nome_servidor", servidor);
            cmd.Parameters.AddWithValue("@porta_servidor", porta);
            cmd.Parameters.AddWithValue("@security_ssl", ssl);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                if(cmd.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        public bool RetornarConfiguracao()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT nome_servidor, porta_servidor, security_ssl FROM tb_smptserver WHERE id_admin = @id_admin";

            cmd.Parameters.AddWithValue("@id_admin", admin.getIdAdmin());

            try
            {
                cmd.Connection = conexao.abrirConexao();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        servidor = dr.GetString(0);
                        porta = dr.GetInt32(1);
                        ssl = Convert.ToChar(dr.GetString(2));
                        aux = 1;
                        return true;
                    }
                    else
                    {
                        aux = 0;
                        return false;
                    }
                }

            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        public bool AtualizarRegistroServidor()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "UPDATE tb_smptserver SET nome_servidor = @nome_servidor, porta_servidor = @porta_servidor, security_ssl = @security_ssl WHERE id_admin = @id_admin";

            cmd.Parameters.AddWithValue("@id_admin", admin.getIdAdmin());
            cmd.Parameters.AddWithValue("@nome_servidor", servidor);
            cmd.Parameters.AddWithValue("@porta_servidor", porta);
            cmd.Parameters.AddWithValue("@security_ssl", ssl);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                if (cmd.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.fecharConexao();
            }
        }
        
    }
}
