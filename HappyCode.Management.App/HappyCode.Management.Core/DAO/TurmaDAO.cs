using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class TurmaDAO
    {
        private string _SQLList = @"Select * from Turma ";
        private string _SQLInsert = @"insert into Turma (Id_Curso, Id_Professor, Dt_Inicio, Dt_Termino, St_Concluido) Values (@Id_Curso, @Id_Professor, @Dt_Inicio, @Dt_Termino, @St_Concluido);";
        private string _SQLUpdate = @"update Turma set Dt_Inicio=@Dt_Inicio, Dt_Termino=@Dt_Termino, St_Concluido=@St_Concluido where Id_Turma=@Id_Turma AND Id_Curso=@Id_Curso AND Id_Professor=@Id_Professor;";
        private string _SQLDelete = @"delete from Turma where Id_Turma=@Id_Turma AND Id_Curso=@Id_Curso AND Id_Professor=@Id_Professor;";
        public List<Turma> ToList(string TxWhere = "")
        {
            List<Turma> LstTurma = new List<Turma>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstTurma.Add(ReaderToObject(ref Reader));
                }
            }
            return LstTurma;
        }

        internal int GetLastId()
        {
            int LastId = 0;
            using (var DBContext = new SQLServer())
            {
                var Reader = DBContext.CommandReader("SELECT COALESCE(MAX(Id_Turma), 0) as Id_Turma FROM Turma");
                while (Reader.Read())
                    int.TryParse(Reader[0].ToString(), out LastId);
            }
            return LastId;
        }

        public int Insert(Turma objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Turma objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Turma objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Turma obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Turma", obj.Id_Turma));
            LstParameters.Add(new SqlParameter("@Id_Curso", obj.Id_Curso));
            LstParameters.Add(new SqlParameter("@Id_Professor", obj.Id_Professor));
            LstParameters.Add(new SqlParameter("@Dt_Inicio", obj.Dt_Inicio));
            LstParameters.Add(new SqlParameter("@Dt_Termino", obj.Dt_Termino));
            LstParameters.Add(new SqlParameter("@St_Concluido", obj.St_Concluido));
            return LstParameters.ToArray();
        }
        public Turma ReaderToObject(ref SqlDataReader Reader)
        {
            return new Turma()
            {
                Id_Turma = int.Parse(Reader["Id_Turma"].ToString()),
                Id_Curso = int.Parse(Reader["Id_Curso"].ToString()),
                Id_Professor = int.Parse(Reader["Id_Professor"].ToString()),
                Dt_Inicio = DateTime.Parse(Reader["Dt_Inicio"].ToString()),
                Dt_Termino = DateTime.Parse(Reader["Dt_Termino"].ToString()),
                St_Concluido = bool.Parse(Reader["St_Concluido"].ToString()),
            };
        }
    }
}
