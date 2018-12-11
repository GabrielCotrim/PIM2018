using Nucleo.Enumeradores;
using Nucleo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Mapeadores
{
    public class MapeadorDeUsuario
    {
        public List<Usuario> ObtenhaTodos()
        {
            var sql = $@"SELECT * FROM TBUsuario";

            var usuarios = new List<Usuario>();
            using (var dr = AuxilliarDeBd.Instancia.ExecuteReader(sql))
            {
                while (dr.Read())
                {

                    var ordinalCod = dr.GetOrdinal("UserCod");
                    var ordinalNome = dr.GetOrdinal("UserNome");
                    var ordinalTipo = dr.GetOrdinal("UserTipoUsuario");
                    var ordinalUser = dr.GetOrdinal("UserNomeUser");
                    var ordinalSenha = dr.GetOrdinal("UserSenha");
                    var usuario = new Usuario
                    {
                        Codigo = dr.GetInt32(ordinalCod),
                        Nome = dr.GetString(ordinalNome),
                        Classificacao = EnumeradorClassificacaoUsuario.ObtenhaEnumerador(dr.GetInt32(ordinalTipo)),
                        Login = new Login
                        {
                            User = dr.GetString(ordinalUser),
                            Senha = dr.GetString(ordinalSenha)
                        }
                    };

                    usuarios.Add(usuario);
                }
                return usuarios;
            }

        }

        public void InsiraUsuario(Usuario usuario)
        {
            var sql = @"INSERT INTO TBUsuario (UserNome, UserTipoUsuario, UserNomeUser, UserSenha)
            VALUES (@UserNome, @UserTipoUsuario, @UserNomeUser, @UserSenha)";

            using (var command = AuxilliarDeBd.Instancia.CreateCommand(sql))
            {
                var parameter = command.CreateParameter();
                parameter.ParameterName = "@UserNome";
                parameter.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter.Value = usuario.Nome;
                command.Parameters.Add(parameter);

                var parameter1 = command.CreateParameter();
                parameter1.ParameterName = "@UserTipoUsuario";
                parameter1.SqlDbType = System.Data.SqlDbType.Int;
                parameter1.Value = usuario.Classificacao.Codigo;
                command.Parameters.Add(parameter1);
                var parameter2 = command.CreateParameter();

                parameter2.ParameterName = "@UserNomeUser";
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter2.Value = usuario.Login.User;
                command.Parameters.Add(parameter2);
                var parameter3 = command.CreateParameter();

                parameter3.ParameterName = "@UserSenha";
                parameter3.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter3.Value = usuario.Login.SenhaCriptografada;
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();
                command.Transaction.Commit();

                command.Connection.Close();
            }
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            var sql = $@"UPDATE TBUsuario SET UserNome = @UserNome, UserTipoUsuario = @UserTipoUsuario, UserNomeUser =  @UserNomeUser, UserSenha = @UserSenha
           WHERE UserNomeUser LIKE '{usuario.Login.User}'";

            using (var command = AuxilliarDeBd.Instancia.CreateCommand(sql))
            {
                var parameter = command.CreateParameter();
                parameter.ParameterName = "@UserNome";
                parameter.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter.Value = usuario.Nome;
                command.Parameters.Add(parameter);

                var parameter1 = command.CreateParameter();
                parameter1.ParameterName = "@UserTipoUsuario";
                parameter1.SqlDbType = System.Data.SqlDbType.Int;
                parameter1.Value = usuario.Classificacao.Codigo;
                command.Parameters.Add(parameter1);
                var parameter2 = command.CreateParameter();

                parameter2.ParameterName = "@UserNomeUser";
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter2.Value = usuario.Login.User;
                command.Parameters.Add(parameter2);
                var parameter3 = command.CreateParameter();

                parameter3.ParameterName = "@UserSenha";
                parameter3.SqlDbType = System.Data.SqlDbType.VarChar;
                parameter3.Value = usuario.Login.SenhaCriptografada;
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();
                command.Transaction.Commit();

                command.Connection.Close();
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            var sql = $@"DELETE FROM TBUsuario WHERE UserNomeUser LIKE '{usuario.Login.User}'";

            using (var command = AuxilliarDeBd.Instancia.CreateCommand(sql))
            {
                command.ExecuteNonQuery();
                command.Transaction.Commit();
                command.Connection.Close();
            }
        }

        public bool PossuiUsuarioCadastrado(Usuario usuario)
        {
            var sql = $@"SELECT * FROM TBUsuario 
                        WHERE UserNomeUser LIKE '{usuario.Login.User}'";

            using (var dr = AuxilliarDeBd.Instancia.ExecuteReader(sql))
            {
                return dr.Read();
            }
            
        }
    }
}
