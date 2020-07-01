using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class MatriculaDAO
    {
        private string _SQLList = @"SELECT m.Id_Matricula,m.Id_Aluno,a.Tx_Nome as Tx_Aluno,m.Id_Turma,c.Tx_Nome as Tx_Curso,m.Dt_Matricula,m.Vl_NotaFinal,m.Nu_FaltasFinal,m.Id_Status FROM Matricula m INNER JOIN Turma t ON (m.Id_Turma=t.Id_Turma) INNER JOIN Curso c on (t.Id_Turma=c.Id_Curso) INNER JOIN Aluno a on (m.Id_Aluno=a.Id_Aluno) ";
        private string _SQLInsert = @"insert into Matricula (Id_Aluno, Id_Turma, Dt_Matricula, Vl_NotaFinal, Nu_FaltasFinal, Id_Status) Values (@Id_Aluno, @Id_Turma, @Dt_Matricula, @Vl_NotaFinal, @Nu_FaltasFinal, @Id_Status);";
        private string _SQLUpdate = @"update Matricula set Dt_Matricula=@Dt_Matricula, Vl_NotaFinal=@Vl_NotaFinal, Nu_FaltasFinal=@Nu_FaltasFinal, Id_Status=@Id_Status where Id_Matricula=@Id_Matricula;";
        private string _SQLDelete = @"delete from Matricula where Id_Matricula=@Id_Matricula;";
        public List<Matricula> ToList(string TxWhere = "")
        {
            List<Matricula> LstMatricula = new List<Matricula>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstMatricula.Add(ReaderToObject(ref Reader));
                }
            }
            return LstMatricula;
        }
        public int Insert(Matricula objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Matricula objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Matricula objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Matricula obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Matricula", obj.Id_Matricula));
            LstParameters.Add(new SqlParameter("@Id_Aluno", obj.Id_Aluno));
            LstParameters.Add(new SqlParameter("@Id_Turma", obj.Id_Turma));
            LstParameters.Add(new SqlParameter("@Dt_Matricula", obj.Dt_Matricula));
            LstParameters.Add(new SqlParameter("@Vl_NotaFinal", obj.Vl_NotaFinal));
            LstParameters.Add(new SqlParameter("@Nu_FaltasFinal", obj.Nu_FaltasFinal));
            LstParameters.Add(new SqlParameter("@Id_Status", obj.Id_Status));
            return LstParameters.ToArray();
        }
        public Matricula ReaderToObject(ref SqlDataReader Reader)
        {
            return new Matricula()
            {
                Id_Matricula = int.Parse(Reader["Id_Matricula"].ToString()),
                Id_Aluno = int.Parse(Reader["Id_Aluno"].ToString()),
                Tx_Aluno = Reader["Tx_Aluno"].ToString(),
                Id_Turma = int.Parse(Reader["Id_Turma"].ToString()),
                Tx_Curso = Reader["Tx_Curso"].ToString(),
                Dt_Matricula = DateTime.Parse(Reader["Dt_Matricula"].ToString()),
                Vl_NotaFinal = decimal.Parse(Reader["Vl_NotaFinal"].ToString()),
                Nu_FaltasFinal = int.Parse(Reader["Nu_FaltasFinal"].ToString()),
                Id_Status = int.Parse(Reader["Id_Status"].ToString()),
            };
        }
    }
}
