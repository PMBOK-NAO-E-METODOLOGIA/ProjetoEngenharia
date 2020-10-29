using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjSistemaReclameEnsino.reclameensino.oo.model
{
    public class Comentario
    {
        //Objetos

        ConexaoBD conexao = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();

        //Atributos
        private int idComentario;
        private string nomeUsuario;
        private string tituloComentario;
        private string descritivoProblema;
        private int idTag;
        private string nomeTag;
        private DateTime dataComentario;
        private char isVisto;
        private bool isCadastro;

        public Comentario(string titulo, string usuario, string descritivo)
        {
            this.tituloComentario = titulo;
            this.nomeUsuario = usuario;
            this.descritivoProblema = descritivo;
            this.isVisto = 'N';
        }

        //Declaração do método de cadastro de comentários
        public void CadastrarComentario()
        {
            cmd.CommandText = "INSERT INTO comentarios (nomeUsuario, tituloComentario, descricaoProblema, dataComentario, foiVisto) VALUES (@nomeUsuario, @tituloComentario, @descricaoProblema, @dataComentario, @foiVisto)";

            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            cmd.Parameters.AddWithValue("@tituloComentario", tituloComentario);
            cmd.Parameters.AddWithValue("@descricaoProblema", descritivoProblema);
            cmd.Parameters.AddWithValue("@dataComentario", dataComentario.ToShortDateString());
            cmd.Parameters.AddWithValue("@foiVisto", isVisto);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                if (cmd.ExecuteNonQuery() != -1)
                {
                    isCadastro = true;
                }
                else
                {
                    isCadastro = false;
                }

                AssociarTagComentario(isCadastro);
            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                isCadastro = false;
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        //Esse método realiza a associação entre o ID do Comentário e os IDs das Tags
        private bool AssociarTagComentario(bool isCadastrado)
        {

            if (isCadastrado)
            {
                cmd.CommandText = "INSERT INTO filtro_comentarios VALUES (@idComentario, @idTag)";

                if (RetornarIDUltimoComentario() > 0)
                {
                    cmd.Parameters.AddWithValue("@idComentario", idComentario);

                    if(RetornarIDTags() > 0)
                    {
                        cmd.Parameters.AddWithValue("@idTag", idTag);
                    }

                }
                else
                {
                    MessageBox.Show("Falha ao retornar o ID do Comentário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

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
                catch (SqlException Mensagem)
                {
                    MessageBox.Show(Mensagem.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o comentário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        //Esse método irá retornar o ID do último comentário.

        private int RetornarIDUltimoComentario()
        {
            cmd.CommandText = "SELECT TOP 1 idComentario FROM comentarios ORDER BY DESC";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idComentario = dr.GetInt32(0);
                        return idComentario;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                return -1;
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

        //Esse método irá retornar o ID das tags.
        private int RetornarIDTags()
        {
            cmd.CommandText = "SELECT idTag FROM tags WHERE descricao = @descricao";

            cmd.Parameters.AddWithValue("@descricao", nomeTag);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idTag = dr.GetInt32(0);
                        return idTag;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            catch (SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                return -1;
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

    }
}
