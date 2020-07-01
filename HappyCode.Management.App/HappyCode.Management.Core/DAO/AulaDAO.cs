using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class AulaDAO
    {
        private string _SQLList = @"Select * from Aula ";
        private string _SQLInsert = @"insert into Aula (Id_Turma, Dt_Aula, Tx_Assunto, Tx_Conteudo, Tx_Observacoes, St_Avaliacao, St_Concluida) Values (@Id_Turma, @Dt_Aula, @Tx_Assunto, @Tx_Conteudo, @Tx_Observacoes, @St_Avaliacao, @St_Concluida);";
        private string _SQLUpdate = @"update Aula set Dt_Aula=@Dt_Aula, Tx_Assunto=@Tx_Assunto, Tx_Conteudo=@Tx_Conteudo, Tx_Observacoes=@Tx_Observacoes, St_Avaliacao=@St_Avaliacao, St_Concluida=@St_Concluida where Id_Aula=@Id_Aula AND Id_Turma=@Id_Turma;";
        private string _SQLDelete = @"delete from Aula where Id_Aula=@Id_Aula AND Id_Turma=@Id_Turma;";
        public List<Aula> ToList(string TxWhere = "")
        {
            List<Aula> LstAula = new List<Aula>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstAula.Add(ReaderToObject(ref Reader));
                }
            }
            return LstAula;
        }
        public int Insert(Aula objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Aula objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Aula objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Aula obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Aula", obj.Id_Aula));
            LstParameters.Add(new SqlParameter("@Id_Turma", obj.Id_Turma));
            LstParameters.Add(new SqlParameter("@Dt_Aula", obj.Dt_Aula));
            LstParameters.Add(new SqlParameter("@Tx_Assunto", obj.Tx_Assunto));
            LstParameters.Add(new SqlParameter("@Tx_Conteudo", obj.Tx_Conteudo));
            LstParameters.Add(new SqlParameter("@Tx_Observacoes", obj.Tx_Observacoes));
            LstParameters.Add(new SqlParameter("@St_Avaliacao", obj.St_Avaliacao));
            LstParameters.Add(new SqlParameter("@St_Concluida", obj.St_Concluida));
            return LstParameters.ToArray();
        }
        public Aula ReaderToObject(ref SqlDataReader Reader)
        {
            return new Aula()
            {
                Id_Aula = int.Parse(Reader["Id_Aula"].ToString()),
                Id_Turma = int.Parse(Reader["Id_Turma"].ToString()),
                Dt_Aula = DateTime.Parse(Reader["Dt_Aula"].ToString()),
                Tx_Assunto = Reader["Tx_Assunto"].ToString(),
                Tx_Conteudo = Reader["Tx_Conteudo"].ToString(),
                Tx_Observacoes = Reader["Tx_Observacoes"].ToString(),
                St_Avaliacao = bool.Parse(Reader["St_Avaliacao"].ToString()),
                St_Concluida = bool.Parse(Reader["St_Concluida"].ToString()),
            };
        }
    }
}
