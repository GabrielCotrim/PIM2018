using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Mapeadores
{
    public class AuxilliarDeBd
    {

        private const string CONEXAOPADRAO = @"Data Source=DESKTOP-PC1EFCM;Initial Catalog=BdPIM;Integrated Security=True";

        public static AuxilliarDeBd Instancia
        { get
            {
                if (_instacia == null)
                {
                    lock (syncLock)
                    {
                        if (_instacia == null)
                        {
                            _instacia = new AuxilliarDeBd();
                        }
                    }
                }

                return _instacia;
            }
        }

        private static object syncLock = new object();

        private static AuxilliarDeBd _instacia;

        private AuxilliarDeBd()
        {

        }

        public SqlCommand CreateCommand(string sql)
        {
            using (var conn = CreateConnection())
            {
                var transacao = conn.BeginTransaction();
                using (var command = conn.CreateCommand())
                {
                    command.Transaction = transacao;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    return command;
                }
            }
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            using (var conn = CreateConnection())
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    return command.ExecuteReader();
                }
            }
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(CONEXAOPADRAO);
        }
    }
}
