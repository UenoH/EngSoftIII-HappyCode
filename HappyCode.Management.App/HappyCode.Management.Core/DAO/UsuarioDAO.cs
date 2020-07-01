using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.DAO
{
    public class UsuarioDAO
    {
        private string _SQLList = @"Select * from Usuario ";
        private string _SQLInsert = @"insert into Usuario (Id_Professor, Tx_Nome, Tx_Login, Tx_Senha, St_Admin, St_Ativo) Values (@Id_Professor, @Tx_Nome, @Tx_Login, @Tx_Senha, @St_Admin, @St_Ativo);";
        private string _SQLUpdate = @"update Usuario set Id_Professor=@Id_Professor, Tx_Nome=@Tx_Nome, Tx_Login=@Tx_Login, Tx_Senha=@Tx_Senha, St_Admin=@St_Admin, St_Ativo=@St_Ativo where Id_Usuario=@Id_Usuario;";
        private string _SQLDelete = @"delete from Usuario where Id_Usuario=@Id_Usuario;";
        public List<Usuario> ToList(string TxWhere="")
        {
            List <Usuario> LstUsuario = new List<Usuario>();
            using (var DBContext = new SQLServer())
            {
                SqlDataReader Reader = DBContext.CommandReader(_SQLList + TxWhere);
                while (Reader.Read())
                {
                    LstUsuario.Add(ReaderToObject(ref Reader));
                }
            }
            return LstUsuario;
        }
        public int Insert(Usuario objInsert)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLInsert, objParameters(objInsert));
            }
        }
        public int Update(Usuario objUpdate)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLUpdate, objParameters(objUpdate));
            }
        }
        public int Delete(Usuario objDelete)
        {
            using (var DBContext = new SQLServer())
            {
                return DBContext.CommandExecute(_SQLDelete, objParameters(objDelete));
            }
        }
        private SqlParameter[] objParameters(Usuario obj)
        {
            List<SqlParameter> LstParameters = new List<SqlParameter>();
            LstParameters.Add(new SqlParameter("@Id_Usuario", obj.Id_Usuario));
            LstParameters.Add(new SqlParameter("@Id_Professor", obj.Id_Professor));
            LstParameters.Add(new SqlParameter("@Tx_Nome", obj.Tx_Nome));
            LstParameters.Add(new SqlParameter("@Tx_Login", obj.Tx_Login));
            LstParameters.Add(new SqlParameter("@Tx_Senha", obj.Tx_Senha));
            LstParameters.Add(new SqlParameter("@St_Admin", obj.St_Admin));
            LstParameters.Add(new SqlParameter("@St_Ativo", obj.St_Ativo));
            return LstParameters.ToArray();
        }
        public Usuario ReaderToObject(ref SqlDataReader Reader)
        {
            return new Usuario()
            {
                Id_Usuario = int.Parse(Reader["Id_Usuario"].ToString()),
                Id_Professor = int.Parse(Reader["Id_Professor"].ToString()),
                Tx_Nome = Reader["Tx_Nome"].ToString(),
                Tx_Login = Reader["Tx_Login"].ToString(),
                Tx_Senha = Util.Encrypt.DecryptString(Reader["Tx_Senha"].ToString()),
                St_Admin = bool.Parse(Reader["St_Admin"].ToString()),
                St_Ativo = bool.Parse(Reader["St_Ativo"].ToString())
            };
        }
    }
}
