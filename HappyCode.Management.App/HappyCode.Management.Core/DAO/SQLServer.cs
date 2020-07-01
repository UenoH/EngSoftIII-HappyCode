namespace HappyCode.Management.Core.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;

    public sealed class SQLServer : IDisposable
    {
        #region Constructor
        private static SqlConnection _cnn;
        public SQLServer()
        {
            _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString);
            _cnn.Open();
        }
        public void Dispose()
        {
            if (_cnn.State == ConnectionState.Open)
            {
                _cnn.Close();
            }
        }
        #endregion

        #region Commands
        public int CommandExecute(string strstring, SqlParameter[] Parameters = null, CommandType cmdType = CommandType.Text)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strstring,
                CommandType = cmdType,
                Connection = _cnn
            };
            if (Parameters?.Length > 0)
            {
                foreach (SqlParameter p in Parameters)
                {
                    if (p.Value == null)
                    {
                        p.Value = DBNull.Value;
                    }
                    cmdComando.Parameters.Add(p);
                }
            }
            return cmdComando.ExecuteNonQuery();
        }
        public SqlDataReader CommandReader(string strstring, SqlParameter[] Parameters = null, CommandType cmdType = CommandType.Text)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strstring,
                CommandType = cmdType,
                Connection = _cnn
            };
            if (Parameters?.Length > 0)
            {
                foreach (var p in Parameters)
                {
                    if (p.Value == null)
                    {
                        p.Value = DBNull.Value;
                    }
                    cmdComando.Parameters.Add(p);
                }
            }
            return cmdComando.ExecuteReader();
        }
        public SqlParameter[] MODToParameters(object obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            foreach (var att in obj.GetType().GetProperties())
            {
                object Value = att.GetValue(obj, null);
                if (Value == null) Value = DBNull.Value;
                LstParameters.Add(new SqlParameter("@" + att.Name, Value));
            }
            return LstParameters.ToArray();
        }
        #endregion
    }
}