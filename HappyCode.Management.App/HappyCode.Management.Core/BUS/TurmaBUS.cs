using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyCode.Management.Core.Business
{
    public class TurmaBUS
    {
        #region Constructor
        public TurmaBUS(TurmaDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private TurmaDAO _IDAO;
        #endregion

        #region Methods
        public List<Turma> ToList()
        {
            return _IDAO.ToList();
        }
        public Turma Find(int Id_Turma)
        {
            return _IDAO.ToList($" WHERE Id_Turma={Id_Turma};").FirstOrDefault();
        }
        public int Insert(Turma obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(Turma obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(Turma obj)
        {
            return _IDAO.Delete(obj);
        }

        internal int GetLastId()
        {
            return _IDAO.GetLastId();
        }
        #endregion
    }
}
