using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class UsuarioBUS
    {
        #region Constructor
        public UsuarioBUS (UsuarioDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private UsuarioDAO _IDAO;
        #endregion

        #region Methods
        public List<Usuario> ToList()
        {
            return _IDAO.ToList();
        }
        public int Insert(Usuario obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Usuario obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Usuario obj)
        {
            return _IDAO.Delete(obj);
        }

        internal Usuario Login(string Tx_Login, string Tx_Senha)
        {
            Tx_Senha = Util.Encrypt.EncryptString(Tx_Senha);
            return _IDAO.ToList($" WHERE Tx_Login='{Tx_Login}' AND Tx_Senha='{Tx_Senha}';").FirstOrDefault();
        }
        #endregion
    }
}
