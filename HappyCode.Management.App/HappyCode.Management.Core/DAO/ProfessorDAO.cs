using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HappyCode.Management.Core.DAO
{
    public class ProfessorDAO
    {
        private string _SQLList = @"Select * from Professor ";
        private string _SQLInsert = @"insert into Professor (Tx_Nome, Dt_Nascimento, Tx_CPF, Tx_Sexo, Tx_Rua, Tx_Numero, Tx_Complemento, Tx_Bairro, Tx_CEP, Tx_Municipio, Tx_UF, Nu_FoneDDD, Nu_Fone, Nu_CelDDD, Nu_Cel, Tx_Email, Tx_Responsavel, Dt_Criacao, St_Ativo) Values (@Tx_Nome, @Dt_Nascimento, @Tx_CPF, @Tx_Sexo, @Tx_Rua, @Tx_Numero, @Tx_Complemento, @Tx_Bairro, @Tx_CEP, @Tx_Municipio, @Tx_UF, @Nu_FoneDDD, @Nu_Fone, @Nu_CelDDD, @Nu_Cel, @Tx_Email, @Tx_Responsavel, @Dt_Criacao, @St_Ativo);";
        private string _SQLUpdate = @"update Professor set Tx_Nome=@Tx_Nome, Dt_Nascimento=@Dt_Nascimento, Tx_CPF=@Tx_CPF, Tx_Sexo=@Tx_Sexo, Tx_Rua=@Tx_Rua, Tx_Numero=@Tx_Numero, Tx_Complemento=@Tx_Complemento, Tx_Bairro=@Tx_Bairro, Tx_CEP=@Tx_CEP, Tx_Municipio=@Tx_Municipio, Tx_UF=@Tx_UF, Nu_FoneDDD=@Nu_FoneDDD, Nu_Fone=@Nu_Fone, Nu_CelDDD=@Nu_CelDDD, Nu_Cel=@Nu_Cel, Tx_Email=@Tx_Email, Tx_Responsavel=@Tx_Responsavel, Dt_Criacao=@Dt_Criacao, St_Ativo=@St_Ativo where Id_Professor=@Id_Professor;";
        private string _SQLDelete = @"delete from Professor where Id_Professor=@Id_Professor;";
        public List<Professor> ToList(string TxWhere = "")
        {
            List<Professor> LstProfessor = new List<Professor>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstProfessor.Add(ReaderToObject(ref Reader));
                }
            }
            return LstProfessor;
        }
        public int Insert(Professor objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Professor objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Professor objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Professor obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Professor", obj.Id_Professor));
            LstParameters.Add(new SqlParameter("@Tx_Nome", obj.Tx_Nome));
            LstParameters.Add(new SqlParameter("@Dt_Nascimento", obj.Dt_Nascimento));
            LstParameters.Add(new SqlParameter("@Tx_CPF", obj.Tx_CPF));
            LstParameters.Add(new SqlParameter("@Tx_Sexo", obj.Tx_Sexo));
            LstParameters.Add(new SqlParameter("@Tx_Rua", obj.Tx_Rua));
            LstParameters.Add(new SqlParameter("@Tx_Numero", obj.Tx_Numero));
            LstParameters.Add(new SqlParameter("@Tx_Complemento", obj.Tx_Complemento));
            LstParameters.Add(new SqlParameter("@Tx_Bairro", obj.Tx_Bairro));
            LstParameters.Add(new SqlParameter("@Tx_CEP", obj.Tx_CEP));
            LstParameters.Add(new SqlParameter("@Tx_Municipio", obj.Tx_Municipio));
            LstParameters.Add(new SqlParameter("@Tx_UF", obj.Tx_UF));
            LstParameters.Add(new SqlParameter("@Nu_FoneDDD", obj.Nu_FoneDDD));
            LstParameters.Add(new SqlParameter("@Nu_Fone", obj.Nu_Fone));
            LstParameters.Add(new SqlParameter("@Nu_CelDDD", obj.Nu_CelDDD));
            LstParameters.Add(new SqlParameter("@Nu_Cel", obj.Nu_Cel));
            LstParameters.Add(new SqlParameter("@Tx_Email", obj.Tx_Email));
            LstParameters.Add(new SqlParameter("@Tx_Responsavel", obj.Tx_Responsavel));
            LstParameters.Add(new SqlParameter("@Dt_Criacao", obj.Dt_Criacao));
            LstParameters.Add(new SqlParameter("@St_Ativo", obj.St_Ativo));
            return LstParameters.ToArray();
        }
        public Professor ReaderToObject(ref SqlDataReader Reader)
        {
            return new Professor()
            {
                Id_Professor = int.Parse(Reader["Id_Professor"].ToString()),
                Tx_Nome = Reader["Tx_Nome"].ToString(),
                Dt_Nascimento = DateTime.Parse(Reader["Dt_Nascimento"].ToString()),
                Tx_CPF = Reader["Tx_CPF"].ToString(),
                Tx_Sexo = Reader["Tx_Sexo"].ToString(),
                Tx_Rua = Reader["Tx_Rua"].ToString(),
                Tx_Numero = Reader["Tx_Numero"].ToString(),
                Tx_Complemento = Reader["Tx_Complemento"].ToString(),
                Tx_Bairro = Reader["Tx_Bairro"].ToString(),
                Tx_CEP = Reader["Tx_CEP"].ToString(),
                Tx_Municipio = Reader["Tx_Municipio"].ToString(),
                Tx_UF = Reader["Tx_UF"].ToString(),
                Nu_FoneDDD = int.Parse(Reader["Nu_FoneDDD"].ToString()),
                Nu_Fone = int.Parse(Reader["Nu_Fone"].ToString()),
                Nu_CelDDD = int.Parse(Reader["Nu_CelDDD"].ToString()),
                Nu_Cel = int.Parse(Reader["Nu_Cel"].ToString()),
                Tx_Email = Reader["Tx_Email"].ToString(),
                Tx_Responsavel = Reader["Tx_Responsavel"].ToString(),
                Dt_Criacao = DateTime.Parse(Reader["Dt_Criacao"].ToString()),
                St_Ativo = bool.Parse(Reader["St_Ativo"].ToString()),
            };
        }
    }
}
