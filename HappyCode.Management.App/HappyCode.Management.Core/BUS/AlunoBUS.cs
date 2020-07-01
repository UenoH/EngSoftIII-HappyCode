using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class AlunoBUS
    {
        #region Constructor
        public AlunoBUS (AlunoDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private AlunoDAO _IDAO;
        #endregion

        #region Methods
        public List<Aluno> ToList()
        {
            return _IDAO.ToList();
        }
        public int Insert(Aluno obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Aluno obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Aluno obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
