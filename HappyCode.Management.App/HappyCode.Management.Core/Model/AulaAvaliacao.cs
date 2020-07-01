using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class AulaAvaliacao
    {
        #region Constructor
        public AulaAvaliacao()
        {
            _objBUS = new AulaAvaliacaoBUS(new DAO.AulaAvaliacaoDAO());
        }
        #endregion

        #region Attributes
        public int Id_AulaAvaliacao { get; set; }
        public int Id_Aula { get; set; }
        public int Id_Matricula { get; set; }
        public decimal Vl_Avaliacao { get; set; }

        private AulaAvaliacaoBUS _objBUS;
        #endregion

        #region Methods
        public List<AulaAvaliacao> ToList()
        {
            return _objBUS.ToList();
        }
        public List<AulaAvaliacao> ToList(int idAula)
        {
            return _objBUS.ToList(idAula);
        }
        public List<AulaAvaliacao> ToListTurma(int id_Turma)
        {
            return _objBUS.ToListTurma(id_Turma);
        }
        public int Save()
        {
            return Id_AulaAvaliacao > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }

        #endregion
    }
}
