using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class ProfessorBUS
    {
        #region Constructor
        public ProfessorBUS (ProfessorDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private ProfessorDAO _IDAO;
        #endregion

        #region Methods
        public List<Professor> ToList()
        {
            return _IDAO.ToList();
        }
        public int Insert(Professor obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Professor obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Professor obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
