using HappyCode.Management.Core.Business;
using System;
using System.Collections.Generic;

namespace HappyCode.Management.Core.Model
{
    public class Turma
    {
        #region Constructor
        public Turma()
        {
            _objBUS = new TurmaBUS(new DAO.TurmaDAO());
        }
        #endregion

        #region Attributes
        public int Id_Turma { get; set; }
        public int Id_Curso { get; set; }
        public int Id_Professor { get; set; }
        public DateTime Dt_Inicio { get; set; }
        public DateTime Dt_Termino { get; set; }
        public bool St_Concluido { get; set; }

        private TurmaBUS _objBUS;
        #endregion

        #region Methods
        public List<Turma> ToList()
        {
            return _objBUS.ToList();
        }
        public Turma Find(int IdTurma)
        {
            return _objBUS.Find(IdTurma);
        }
        public int Save()
        {
            return Id_Turma > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }

        public int getLastId()
        {
            return _objBUS.GetLastId();
        }
        #endregion
    }
}
