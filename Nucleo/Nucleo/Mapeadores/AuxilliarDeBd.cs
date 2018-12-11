using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Mapeadores
{
    public class AuxilliarDeBd
    {

        private const string CONEXAOPADRAO = @"Data Source=DEV-18;Initial Catalog=BdPIM;Integrated Security=True";

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
                var conn = CreateConnection();

                conn.Open();

                var transacao = conn.BeginTransaction();

                var command = conn.CreateCommand();
                command.Transaction = transacao;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                return command;
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            var conn = CreateConnection();
            conn.Open();

            var command = conn.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            return command.ExecuteReader();
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(CONEXAOPADRAO);
        }
    }
}
