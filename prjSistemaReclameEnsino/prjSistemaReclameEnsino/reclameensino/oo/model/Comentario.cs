using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;

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
        private string emailUsuario;
        private string senhaEmailAdmin;

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

        public Comentario(string titulo, string usuario, string descritivo, string email)
        {
            this.tituloComentario = titulo;
            this.nomeUsuario = usuario;
            this.descritivoProblema = descritivo;
            this.isVisto = 'N';
            this.emailUsuario = email;
        }

        public void setSenhaEmailAdmin(string senha)
        {
            this.senhaEmailAdmin = senha;
        }
        public int getIdComentario()
        {
            return idComentario;
        }
        public void setIdComentario(int id)
        {
            this.idComentario = id;
        }
        public string getSenhaEmailAdmin()
        {
            return senhaEmailAdmin;
        }
        public void setIsVisto(char isVisto)
        {
            this.isVisto = isVisto;
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
            cmd.CommandText = "INSERT INTO comentarios (nomeUsuario, tituloComentario, descricaoProblema, dataComentario, foiVisto, emailUsuario, foiRespondido) VALUES (@nomeUsuario, @tituloComentario, @descricaoProblema, @dataComentario, @foiVisto, @emailUsuario, @foiRespondido)";

            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            cmd.Parameters.AddWithValue("@tituloComentario", tituloComentario);
            cmd.Parameters.AddWithValue("@descricaoProblema", descritivoProblema);
            cmd.Parameters.AddWithValue("@dataComentario", DateTime.Now);
            cmd.Parameters.AddWithValue("@foiVisto", isVisto);
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            cmd.Parameters.AddWithValue("@foiRespondido", 'N');


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
        //Criar tela de resumo do comentário!!!!!
        public SqlDataAdapter RetornarComentariosFiltrados(string cmdSql)
        {
            cmd.Parameters.Clear();

            cmd.CommandText = cmdSql;

            if (String.IsNullOrEmpty(nomeTag) != true)
            {
                cmd.Parameters.AddWithValue("@descTag", nomeTag);
            }


            if (String.IsNullOrEmpty(tituloComentario) != true)
            {
                cmd.Parameters.AddWithValue("@tituloComentario", tituloComentario);
            }

            cmd.Parameters.AddWithValue("@foiVisto", isVisto);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                using (SqlDataReader dr = cmd.ExecuteReader())
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
                MessageBox.Show(Mensagem.Message); // <-- Deve ser declarado uma variável escalar 'tag name'<< de valor único!!!
                return null;
            }
            finally
            {
                conexao.fecharConexao();
            }
            
        }

        public string[] RetornarDadosComentario()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT tituloComentario, dataComentario, foiVisto, nomeUsuario, descricaoProblema, emailUsuario FROM comentarios WHERE idComentario = @idComentario";

            cmd.Parameters.AddWithValue("@idComentario", idComentario);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                string[] dados = new string[6];

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        dados[0] = dr.GetString(0);
                        dados[1] = Convert.ToString(dr.GetDateTime(1));
                        dados[2] = dr.GetString(2);
                        dados[3] = dr.GetString(3);
                        dados[4] = dr.GetString(4);
                        if (dr.IsDBNull(5))
                        {
                            dados[5] = "";
                        }
                        else
                        {
                            dados[5] = dr.GetString(5);
                        }

                        return dados;
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

        public List<string> RetornarEtiquetasComentario()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT T.descTag FROM tags T INNER JOIN filtro_comentarios FC ON T.idTag = FC.idTag WHERE FC.idComentario = @idComentario";

            cmd.Parameters.AddWithValue("@idComentario", idComentario);

            try
            {
                cmd.Connection = conexao.abrirConexao();

                List<string> etiquetas = new List<string>();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        etiquetas.Add(dr.GetString(0));

                        while (dr.Read())
                        {
                            etiquetas.Add(dr.GetString(0));
                        }
                        return etiquetas;
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

        public bool AtualizarComentario()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "UPDATE comentarios SET foiVisto = @foiVisto WHERE idComentario = @idComentario";

            cmd.Parameters.AddWithValue("@foiVisto", isVisto);
            cmd.Parameters.AddWithValue("@idComentario", idComentario);

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

        public bool AtualizarRespostaComentario(string resposta, int respondente)
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "UPDATE comentarios SET foiRespondido = 'S', respostaComentario = @respostaComentario, respondente = @respondente WHERE idComentario = @idComentario";

            cmd.Parameters.AddWithValue("@respostaComentario", resposta);
            cmd.Parameters.AddWithValue("@respondente", respondente);
            cmd.Parameters.AddWithValue("@idComentario", idComentario);

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
            finally
            {
                conexao.fecharConexao();
            }
        }

        public char VerificarVistos()
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT foiVisto FROM comentarios WHERE idComentario = @idComentario";

            cmd.Parameters.AddWithValue("@idComentario", idComentario);

            try
            {
                cmd.Connection = conexao.abrirConexao();
                
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        char isVisto = Convert.ToChar(dr.GetString(0)); //Não há suporte para o método especificado
                        return isVisto;
                    }
                    else
                    {
                        return 'F';
                    }
                }

            }
            catch(SqlException Mensagem)
            {
                MessageBox.Show(Mensagem.Message);
                return 'F';
            }
            finally
            {
                conexao.fecharConexao();
            }
            
        }

        /// <summary>
        /// Transmite uma mensagem de email sem anexos
        /// </summary>
        /// <param name="destinatario"> Destinatario (Recipient)</param>
        /// <param name="remetente">Remetente (Sender)</param>
        /// <param name="assunto">Assunto da Mensagem (Subject) </param>
        /// <param name="enviaMensagem">Corpo da Mensagem(Body)</param>
        /// <returns></returns>
        public string EnviaMensagemEmail(string destinatario, string remetente, string assunto, string enviaMensagem, E_mail mail)
        {
            try
            {
                //Validar o email
                bool bValidaEmail = ValidaEnderecoEmail(destinatario);

                //Se o email não é valido retorna uma mensagem

                if(bValidaEmail == false)
                {
                    return "Email do Destinatário inválido: " + destinatario;
                }

                //Cria uma mensagem
                //MailMessage mensagemEmail = new MailMessage(remetente, destinatario, assunto, enviaMensagem);

                if(mail.RetornarConfiguracao() == true)
                {
                    SmtpClient client = new SmtpClient(mail.getServidor()); // <-- digitalconveniencia@outlook.com //smtp.live.com
                    client.Port = mail.getPorta();
                    client.Timeout = 100000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    
                    if (mail.getSsl() != 'N')
                    {
                        client.EnableSsl = true;
                    }
                    else
                    {
                        client.EnableSsl = false;
                    }

                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(remetente, senhaEmailAdmin);

                    //Inclui as credenciais

                    MailMessage msg = new MailMessage();

                    msg.To.Add(destinatario);
                    msg.From = new MailAddress(remetente);
                    msg.Subject = assunto;
                    msg.Body = enviaMensagem;


                    // envia a mensagem

                    client.Send(msg);

                    return "Mensagem enviada para " + destinatario + " às " + DateTime.Now.ToString() + ".";
                }
                else
                {
                    return "Falha ao retornar os dados!";
                }

                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regular para validar o email

                string texto_validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                //Testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_validar))
                {
                    //email é válido
                    return true;

                }
                else
                {
                    //email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int RetornarQtdVistados()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT COUNT(idComentario) FROM comentarios WHERE foiVisto = 'S' AND (foiRespondido = 'N' OR foiRespondido IS NULL)";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                int x = (int)cmd.ExecuteScalar();

                return x;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

        public int RetornarQtdRespondidos()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT COUNT(idComentario) FROM comentarios WHERE foiRespondido = 'S'";

            try
            {
                cmd.Connection = conexao.abrirConexao();

                int x = (int)cmd.ExecuteScalar();

                return x;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

    }
}
