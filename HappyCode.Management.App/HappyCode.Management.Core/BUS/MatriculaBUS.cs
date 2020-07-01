using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class MatriculaBUS
    {
        #region Constructor
        public MatriculaBUS (MatriculaDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private MatriculaDAO _IDAO;
        #endregion

        #region Methods
        public List<Matricula> ToList()
        {
            return _IDAO.ToList();
        }
        public List<Matricula> ToList(int Id_Turma)
        {
            return _IDAO.ToList($" WHERE m.Id_Turma={Id_Turma};");
        }
        public int Insert(Matricula obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Matricula obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Matricula obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
