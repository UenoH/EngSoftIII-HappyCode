using HappyCode.Management.Core.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class AulaPresencaDAO
    {
        private string _SQLList = @"Select * from AulaPresenca ";
        private string _SQLInsert = @"insert into AulaPresenca (Id_Aula, Id_Matricula, St_Presenca) Values (@Id_Aula, @Id_Matricula, @St_Presenca);";
        private string _SQLUpdate = @"update AulaPresenca set St_Presenca=@St_Presenca where Id_AulaPresenca=@Id_AulaPresenca AND Id_Aula=@Id_Aula AND Id_Matricula=@Id_Matricula;";
        private string _SQLDelete = @"delete from AulaPresenca where Id_AulaPresenca=@Id_AulaPresenca AND Id_Aula=@Id_Aula AND Id_Matricula=@Id_Matricula;";
        public List<AulaPresenca> ToList(string TxWhere = "")
        {
            List<AulaPresenca> LstAulaPresenca = new List<AulaPresenca>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstAulaPresenca.Add(ReaderToObject(ref Reader));
                }
            }
            return LstAulaPresenca;
        }
        public int Insert(AulaPresenca objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(AulaPresenca objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(AulaPresenca objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(AulaPresenca obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_AulaPresenca", obj.Id_AulaPresenca));
            LstParameters.Add(new SqlParameter("@Id_Aula", obj.Id_Aula));
            LstParameters.Add(new SqlParameter("@Id_Matricula", obj.Id_Matricula));
            LstParameters.Add(new SqlParameter("@St_Presenca", obj.St_Presenca));
            return LstParameters.ToArray();
        }
        public AulaPresenca ReaderToObject(ref SqlDataReader Reader)
        {
            return new AulaPresenca()
            {
                Id_AulaPresenca = int.Parse(Reader["Id_AulaPresenca"].ToString()),
                Id_Aula = int.Parse(Reader["Id_Aula"].ToString()),
                Id_Matricula = int.Parse(Reader["Id_Matricula"].ToString()),
                St_Presenca = bool.Parse(Reader["St_Presenca"].ToString())
            };
        }
    }
}
