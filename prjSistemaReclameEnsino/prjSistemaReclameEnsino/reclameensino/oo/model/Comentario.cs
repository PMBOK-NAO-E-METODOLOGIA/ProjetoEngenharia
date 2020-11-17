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
        SqlCommand cmdDois = new SqlCommand();

        //Atributos
        private int idComentario;
        private string nomeUsuario;
        private string tituloComentario;
        private string descritivoProblema;
        private int idTag;
        private string nomeTag;
        private char isVisto;
        private bool isCadastro;
        public Comentario()
        {

        }

        public Comentario(string titulo, string usuario, string descritivo)
        {
            this.tituloComentario = titulo;
            this.nomeUsuario = usuario;
            this.descritivoProblema = descritivo;
            this.isVisto = 'N';
        }


        public void setTituloComentario(string titulo)
        {
            this.tituloComentario = titulo;
        }
        public void setNomeTag(string nomeTag)
        {
            this.nomeTag = nomeTag;
        }

        //Declaração do método de cadastro de comentários
        public int CadastrarComentario(List<string> listaEtiqueta)
        {
            cmd.CommandText = "INSERT INTO comentarios (nomeUsuario, tituloComentario, descricaoProblema, dataComentario, foiVisto) VALUES (@nomeUsuario, @tituloComentario, @descricaoProblema, @dataComentario, @foiVisto)";

            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            cmd.Parameters.AddWithValue("@tituloComentario", tituloComentario);
            cmd.Parameters.AddWithValue("@descricaoProblema", descritivoProblema);
            cmd.Parameters.AddWithValue("@dataComentario", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@foiVisto", isVisto);


            try
            {
                cmd.Connection = conexao.abrirConexao();

                //A lógica pode ser mudada a fim de evitar o cadastro REAL do comentário.

                if (cmd.ExecuteNonQuery() != -1)
                {
                    conexao.fecharConexao();
                    isCadastro = true;
                    int i = 0;

                    RetornarIDUltimoComentario();

                    foreach (string x in listaEtiqueta)
                    {
                        if(AssociarTagComentario(isCadastro, x))
                        {
                            i = 1;
                            continue;
                        }
                        else
                        {
                            i = 0;
                            break;
                        }
                    }
                    return i;
                }
                else
                {
                    return -1;
                }

            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                return -1;
            }

        }

        //Esse método realiza a associação entre o ID do Comentário e os IDs das Tags
        private bool AssociarTagComentario(bool isCadastrado, string nomeTag)
        {
            if (isCadastrado)
            {
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO filtro_comentarios VALUES (@idComentario, @idTag)";

                cmd.Parameters.AddWithValue("@idComentario", idComentario);

                RetornarIDTags(nomeTag);

                cmd.Parameters.AddWithValue("@idTag", idTag);

                /* Passar como parâmetro a quantidade de tags selecionadas para o comentário!
                 * Logo, RetornarIDTags receberá uma lista contendo a descrição das tags,
                 * e executará a consulta dos IDs destas TAGs.
                 */

                
                try
                {
                    bool isTrue;
                    cmd.Connection = conexao.abrirConexao();

                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                    }

                    return isTrue;
                }
                catch (SqlException Mensagem)
                {
                    MessageBox.Show(Mensagem.Message);
                    return false;
                }
                finally
                {
                    conexao.fecharConexao();
                }
            }
            else
            {
                MessageBox.Show("Falha ao associar tags ao comentário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        //Esse método irá retornar o ID do último comentário.

        private int RetornarIDUltimoComentario()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT TOP 1 idComentario FROM comentarios ORDER BY idComentario desc";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                 //Utilizar o ExecuteScalar() para retornar a primeira coluna e a primeira linha da tabela.
                
                if ((int) cmd.ExecuteScalar() != -1)
                {
                    idComentario = (int)cmd.ExecuteScalar();
                    return idComentario;
                }
                else
                {
                    return -1;
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

        public List<string> RetornarDescEtiquetas()
        {
            cmd.CommandText = "SELECT descTag FROM tags";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                List<string> listaTags = new List<string>();

                using (SqlDataReader dr = cmd.ExecuteReader()) // Resolvido! Conexão anterior estava aberta ainda!
                {
                    if (dr.Read())
                    {

                        listaTags.Add(dr.GetString(0));

                        while (dr.Read())
                        {
                            listaTags.Add(dr.GetString(0));
                        }


                        return listaTags;

                    }
                    else
                    {
                        return null;
                    }
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Falha ao retornar as Etiquetas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            {
                conexao.fecharConexao();
            }

        }

        //Esse método irá retornar o ID das tags.
        public int RetornarIDTags(string nomeEtiqueta)
        {
            cmdDois.Parameters.Clear();

            cmdDois.CommandText = "SELECT idTag FROM tags WHERE descTag = @descTag";

            cmdDois.Parameters.AddWithValue("@descTag", nomeEtiqueta);

            try
            {
                cmdDois.Connection = conexao.abrirConexao();

                if ((int) cmdDois.ExecuteScalar() != -1)
                {
                    idTag = (int)cmdDois.ExecuteScalar();
                    return idTag;
                }
                else
                {
                    return -1;
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

        public SqlDataAdapter RetornarTodosComentarios()
        {
            cmd.CommandText = "SELECT idComentario, tituloComentario, dataComentario FROM comentarios";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        return da;
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
        /*
        public SqlDataAdapter RetornarComentariosFiltrados(bool foiVisto, bool eAnonimo)
        {
            if ()
            {

            }
        }
        
        */
    }
}
