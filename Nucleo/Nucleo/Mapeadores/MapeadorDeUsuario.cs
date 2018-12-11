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
                parameter3.Value = usuario.Login.Senha;
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();
                command.Transaction.Commit();

                command.Connection.Close();
            }
        }
    }
}
