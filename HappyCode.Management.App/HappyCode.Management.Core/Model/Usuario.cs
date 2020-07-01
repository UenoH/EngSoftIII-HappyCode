using HappyCode.Management.Core.Business;
using System;
using System.Collections.Generic;

namespace HappyCode.Management.Core.Model
{
    public class Usuario
    {
        #region Constructor
        public Usuario()
        {
            _objBUS = new UsuarioBUS(new DAO.UsuarioDAO());
        }
        #endregion

        #region Attributes
        public int Id_Usuario { get; set; }
        public int Id_Professor { get; set; }
        public string Tx_Nome { get; set; }
        public string Tx_Login { get; set; }
        public string Tx_Senha { get; set; }
        public bool St_Admin { get; set; }
        public bool St_Ativo { get; set; }

        private UsuarioBUS _objBUS;
        #endregion

        #region Methods
        public List<Usuario> ToList()
        {
            return _objBUS.ToList();
        }
        public Usuario Login(string TxLogin, string TxSenha)
        {
            return _objBUS.Login(TxLogin, TxSenha);
        }
        public int Save()
        {
            return Id_Usuario > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }
        #endregion
    }
}
