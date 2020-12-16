using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjSistemaReclameEnsino.reclameensino.oo.model
{
    public class Pessoa
    {

        ConexaoBD conexao = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();


        private string nomePessoa;

        public Pessoa()
        {

        }

        public Pessoa(string nomePessoa)
        {
            this.nomePessoa = nomePessoa;
        }

        public string getNomePessoa()
        {
            return nomePessoa;
        }

        public class Administrador : Pessoa
        {

            private int idAdmin;
            private string nomeUsuario;
            private string senhaUsuario;
            static private bool isEntrou;
            private DateTime dataAtual = DateTime.Today;
            private string emailAdmin;

            public Administrador()
            {

            }

            public Administrador(string nomePessoa, string nomeUsuario, string senhaUsuario) : base(nomePessoa)
            {
                this.nomeUsuario = nomeUsuario;
                this.senhaUsuario = senhaUsuario;
            }

            public Administrador(string nomePessoa, string nomeUsuario, string senhaUsuario, string email) : base(nomePessoa)
            {
                this.nomeUsuario = nomeUsuario;
                this.senhaUsuario = senhaUsuario;
                this.emailAdmin = email;
            }

            public int getIdAdmin()
            {
                return idAdmin;
            }
            public string getEmailAdmin()
            {
                return emailAdmin;
            }

            public void setNomeUsuario(string nome)
            {
                this.nomeUsuario = nome;
            }

            public void setSenhaUsuario(string senha)
            {
                this.senhaUsuario = senha;
            }

            public string getNomeUsuario()
            {
                return nomeUsuario;
            }
            
            public void setIsEntrou(bool entrada)
            {
                isEntrou = entrada;
            }

            public bool getIsEntrou()
            {
                return isEntrou;
            }
            
            /* Está função abaixo irá cadastrar um administrador na base
             * ReclameEnsinoBD.mdf!
             * Os valores que serão passados como parâmetros são:
             * Nome do Admin, Nome do Usuário, Senha do Usuário,
             * a data de cadastro [data atual] e o "status" se está ativo, neste
             * caso ele receberá 'S', referente que "SIM, ESTÁ ATIVO!".
             * 
             * Ass.: @Paulo Vinicius
             *       22/10/2020
             */

            public string RetornaEmailAdmin()
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT emailAdmin FROM tb_administradores WHERE nomeUsuario = @nomeUsuario";

                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

                try
                {
                    cmd.Connection = conexao.abrirConexao();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr.IsDBNull(0))
                            {
                                return null;
                            }
                            else
                            {
                                emailAdmin = dr.GetString(0);
                                return emailAdmin;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch(SqlException Mensagem)
                {
                    MessageBox.Show(Mensagem.Message);
                    return null;
                }
                finally
                {
                    conexao.fecharConexao();
                }
            }

            public bool cadastrarAdministrador()
            {

                cmd.CommandText = "INSERT INTO tb_administradores (nomeAdmin, nomeUsuario, senhaUsuario, dataCadastro, isAtivo, emailAdmin) VALUES (@nomeAdmin, @nomeUsuario, @senhaUsuario, @dataCadastro, @isAtivo, @emailAdmin)";

                cmd.Parameters.AddWithValue("@nomeAdmin", nomePessoa);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", senhaUsuario);
                cmd.Parameters.AddWithValue("@dataCadastro", dataAtual);
                cmd.Parameters.AddWithValue("@isAtivo", 'S');
                cmd.Parameters.AddWithValue("@emailAdmin", emailAdmin);

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
                catch(SqlException)
                {
                    //MessageBox.Show(Mensagem.Message);
                    return false;
                }
                finally
                {
                    conexao.fecharConexao();
                }

            }

            public bool validarAcesso()
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT idAdmin FROM tb_administradores WHERE nomeUsuario = @nomeUsuario AND senhaUsuario = @senhaUsuario";

                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", senhaUsuario);

                try
                {
                    cmd.Connection = conexao.abrirConexao();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            isEntrou = true;
                            idAdmin = dr.GetInt32(0);
                            return isEntrou;
                        }
                        else
                        {
                            isEntrou = false;
                            return isEntrou;
                        }
                    }

                }
                catch(SqlException Mensagem)
                {
                    MessageBox.Show(Mensagem.Message);
                    return false;
                }
                finally
                {
                    conexao.fecharConexao();
                }

            }

        }


    }
}
