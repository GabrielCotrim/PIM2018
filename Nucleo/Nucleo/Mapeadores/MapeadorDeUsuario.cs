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
            var sql = @"INSERT INTO TBUsuario (UserNome, UserTipoUsuario, UserNomeUser, UserSenha, UserCodFoto)
           ([UserNome]
           ,[UserTipoUsuario]
           ,[UserNomeUser]
           ,[UserSenha]
           ,[UserCodFoto])
     VALUES
           (<UserNome, varchar(50),>
           ,<UserTipoUsuario, int,>
           ,<UserNomeUser, varchar(50),>
           ,<UserSenha, varchar(50),>
           ,<UserCodFoto, int,>)"
        }
    }
}
