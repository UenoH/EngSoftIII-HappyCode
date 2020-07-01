using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class CursoBUS
    {
        #region Constructor
        public CursoBUS (CursoDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private CursoDAO _IDAO;
        #endregion

        #region Methods
        public List<Curso> ToList()
        {
            return _IDAO.ToList();
        }
        public List<Curso> ToList(int Id_Curso)
        {
            return _IDAO.ToList($" WHERE Id_Curso={Id_Curso};");
        }
        public int Insert(Curso obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Curso obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Curso obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
