using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class AulaPresenca
    {
        #region Constructor
        public AulaPresenca()
        {
            _objBUS = new AulaPresencaBUS(new DAO.AulaPresencaDAO());
        }
        #endregion

        #region Attributes
        public int Id_AulaPresenca { get; set; }
        public int Id_Aula { get; set; }
        public int Id_Matricula { get; set; }
        public bool St_Presenca { get; set; }

        private AulaPresencaBUS _objBUS;
        #endregion

        #region Methods
        public List<AulaPresenca> ToList()
        {
            return _objBUS.ToList();
        }
        public List<AulaPresenca> ToList(int idAula)
        {
            return _objBUS.ToList(idAula);
        }
        public List<AulaPresenca> ToListTurma(int id_Turma)
        {
            return _objBUS.ToListTurma(id_Turma);
        }
        public int Save()
        {
            return Id_AulaPresenca > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }
        #endregion
    }
}
