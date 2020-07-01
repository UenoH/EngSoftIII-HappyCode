using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.DAO
{
    public class AulaAvaliacaoDAO
    {
        private string _SQLList = @"Select * from AulaAvaliacao ";
        private string _SQLInsert = @"insert into AulaAvaliacao (Id_Aula, Id_Matricula, Vl_Avaliacao) Values (@Id_Aula, @Id_Matricula, @Vl_Avaliacao);";
        private string _SQLUpdate = @"update AulaAvaliacao set Vl_Avaliacao=@Vl_Avaliacao where Id_AulaAvaliacao=@Id_AulaAvaliacao AND Id_Aula=@Id_Aula AND Id_Matricula=@Id_Matricula;";
        private string _SQLDelete = @"delete from AulaAvaliacao where Id_AulaAvaliacao=@Id_AulaAvaliacao AND Id_Aula=@Id_Aula AND Id_Matricula=@Id_Matricula;";

        public List<AulaAvaliacao> ToList(string TxWhere="")
        {
            List <AulaAvaliacao> LstAulaAvaliacao = new List<AulaAvaliacao>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstAulaAvaliacao.Add(ReaderToObject(ref Reader));
                }
            }
            return LstAulaAvaliacao;
        }
        public int Insert(AulaAvaliacao objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(AulaAvaliacao objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(AulaAvaliacao objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(AulaAvaliacao obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_AulaAvaliacao", obj.Id_AulaAvaliacao));
            LstParameters.Add(new SqlParameter("@Id_Aula", obj.Id_Aula));
            LstParameters.Add(new SqlParameter("@Id_Matricula", obj.Id_Matricula));
            LstParameters.Add(new SqlParameter("@Vl_Avaliacao", obj.Vl_Avaliacao));
            return LstParameters.ToArray();
        }
        public AulaAvaliacao ReaderToObject(ref SqlDataReader Reader)
        {
            return new AulaAvaliacao()
            {
                Id_AulaAvaliacao = int.Parse(Reader["Id_AulaAvaliacao"].ToString()),
                Id_Aula = int.Parse(Reader["Id_Aula"].ToString()),
                Id_Matricula = int.Parse(Reader["Id_Matricula"].ToString()),
                Vl_Avaliacao = decimal.Parse(Reader["Vl_Avaliacao"].ToString())
            };
        }
    }
}
