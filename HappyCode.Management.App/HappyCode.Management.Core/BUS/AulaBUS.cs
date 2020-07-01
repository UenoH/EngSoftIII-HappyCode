using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class AulaBUS
    {
        #region Constructor
        public AulaBUS (AulaDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private AulaDAO _IDAO;
        #endregion

        #region Methods
        public List<Aula> ToList()
        {
            return _IDAO.ToList();
        }
        public List<Aula> ToList(int Id_Turma)
        {
            return _IDAO.ToList($" WHERE Id_Turma={Id_Turma};");
        }
        public int Insert(Aula obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Aula obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Aula obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
