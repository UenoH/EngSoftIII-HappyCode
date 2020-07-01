using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class TurmaDiaBUS
    {
        #region Constructor
        public TurmaDiaBUS (TurmaDiaDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private TurmaDiaDAO _IDAO;
        #endregion

        #region Methods
        public List<TurmaDia> ToList()
        {
            return _IDAO.ToList();
        }
        public List<TurmaDia> ToList(int Id_Turma)
        {
            return _IDAO.ToList($" WHERE Id_Turma={Id_Turma};");
        }
        public List<TurmaDia> ToListProfessor(int IdProfessor)
        {
            return _IDAO.ToList($" WHERE Id_Turma IN (SELECT Id_Turma FROM Turma WHERE Id_Professor={IdProfessor} AND St_Concluido='false');");
        }
        public int Insert(TurmaDia obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(TurmaDia obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(TurmaDia obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
