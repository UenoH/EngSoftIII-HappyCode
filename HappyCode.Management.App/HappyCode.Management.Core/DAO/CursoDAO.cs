using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class CursoDAO
    {
        private string _SQLList = @"Select * from Curso ";
        private string _SQLInsert = @"insert into Curso (Tx_Nome, Nu_Aulas, Nu_CargaHoraria, Tx_Conteudo, Tx_Observacoes, Dt_Criacao, St_Ativo) Values (@Tx_Nome, @Nu_Aulas, @Nu_CargaHoraria, @Tx_Conteudo, @Tx_Observacoes, @Dt_Criacao, @St_Ativo);";
        private string _SQLUpdate = @"update Curso set Tx_Nome=@Tx_Nome, Nu_Aulas=@Nu_Aulas, Nu_CargaHoraria=@Nu_CargaHoraria, Tx_Conteudo=@Tx_Conteudo, Tx_Observacoes=@Tx_Observacoes, Dt_Criacao=@Dt_Criacao, St_Ativo=@St_Ativo where Id_Curso=@Id_Curso;";
        private string _SQLDelete = @"delete from Curso where Id_Curso=@Id_Curso;";
        public List<Curso> ToList(string TxWhere = "")
        {
            List<Curso> LstCurso = new List<Curso>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstCurso.Add(ReaderToObject(ref Reader));
                }
            }
            return LstCurso;
        }
        public int Insert(Curso objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Curso objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Curso objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Curso obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Curso", obj.Id_Curso));
            LstParameters.Add(new SqlParameter("@Tx_Nome", obj.Tx_Nome));
            LstParameters.Add(new SqlParameter("@Nu_Aulas", obj.Nu_Aulas));
            LstParameters.Add(new SqlParameter("@Nu_CargaHoraria", obj.Nu_CargaHoraria));
            LstParameters.Add(new SqlParameter("@Tx_Conteudo", obj.Tx_Conteudo));
            LstParameters.Add(new SqlParameter("@Tx_Observacoes", obj.Tx_Observacoes));
            LstParameters.Add(new SqlParameter("@Dt_Criacao", obj.Dt_Criacao));
            LstParameters.Add(new SqlParameter("@St_Ativo", obj.St_Ativo));
            return LstParameters.ToArray();
        }
        public Curso ReaderToObject(ref SqlDataReader Reader)
        {
            return new Curso()
            {
                Id_Curso = int.Parse(Reader["Id_Curso"].ToString()),
                Tx_Nome = Reader["Tx_Nome"].ToString(),
                Nu_Aulas = int.Parse(Reader["Nu_Aulas"].ToString()),
                Nu_CargaHoraria = int.Parse(Reader["Nu_CargaHoraria"].ToString()),
                Tx_Conteudo = Reader["Tx_Conteudo"].ToString(),
                Tx_Observacoes = Reader["Tx_Observacoes"].ToString(),
                Dt_Criacao = DateTime.Parse(Reader["Dt_Criacao"].ToString()),
                St_Ativo = bool.Parse(Reader["St_Ativo"].ToString())
            };
        }
    }
}
