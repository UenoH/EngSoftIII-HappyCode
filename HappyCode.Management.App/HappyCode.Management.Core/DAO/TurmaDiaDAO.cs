using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.DAO
{
    public class TurmaDiaDAO
    {
        private string _SQLList = @"Select * from TurmaDia ";
        private string _SQLInsert = @"insert into TurmaDia (Id_Turma, Nu_DiaSemana, Tm_Horario) Values (@Id_Turma, @Nu_DiaSemana, @Tm_Horario);";
        private string _SQLUpdate = @"update TurmaDia set Nu_DiaSemana=@Nu_DiaSemana, Tm_Horario=@Tm_Horario where Id_TurmaDia=@Id_TurmaDia AND Id_Turma=@Id_Turma;";
        private string _SQLDelete = @"delete from TurmaDia where Id_TurmaDia=@Id_TurmaDia AND Id_Turma=@Id_Turma;";
        public List<TurmaDia> ToList(string TxWhere="")
        {
            List <TurmaDia> LstTurmaDia = new List<TurmaDia>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstTurmaDia.Add(ReaderToObject(ref Reader));
                }
            }
            return LstTurmaDia;
        }
        public int Insert(TurmaDia objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(TurmaDia objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(TurmaDia objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(TurmaDia obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_TurmaDia", obj.Id_TurmaDia));
            LstParameters.Add(new SqlParameter("@Id_Turma", obj.Id_Turma));
            LstParameters.Add(new SqlParameter("@Nu_DiaSemana", obj.Nu_DiaSemana));
            LstParameters.Add(new SqlParameter("@Tm_Horario", obj.Tm_Horario));
            return LstParameters.ToArray();
        }
        public TurmaDia ReaderToObject(ref SqlDataReader Reader)
        {
            return new TurmaDia()
            {
                Id_TurmaDia = int.Parse(Reader["Id_TurmaDia"].ToString()),
                Id_Turma = int.Parse(Reader["Id_Turma"].ToString()),
                Nu_DiaSemana = int.Parse(Reader["Nu_DiaSemana"].ToString()),
                Tm_Horario = TimeSpan.Parse(Reader["Tm_Horario"].ToString()),
            };
        }
    }
}
