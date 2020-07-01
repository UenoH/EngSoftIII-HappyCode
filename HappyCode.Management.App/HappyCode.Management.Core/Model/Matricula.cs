using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class Matricula
    {
        #region Constructor
        public Matricula()
        {
            _objBUS = new MatriculaBUS(new DAO.MatriculaDAO());
        }
        #endregion

        #region Attributes
        public int Id_Matricula { get; set; }
        public int Id_Aluno { get; set; }
        public string Tx_Aluno { get; set; }
        public int Id_Turma { get; set; }
        public string Tx_Curso { get; set; }
        public DateTime Dt_Matricula { get; set; }
        public decimal Vl_NotaFinal { get; set; }
        public int Nu_FaltasFinal { get; set; }
        public int Id_Status { get; set; }

        private MatriculaBUS _objBUS;
        #endregion

        #region Methods
        public List<Matricula> ToList()
        {
            return _objBUS.ToList();
        }
        public List<Matricula> ToList(int IdTurma)
        {
            return _objBUS.ToList(IdTurma);
        }
        public bool AlunoJaMatriculado()
        {
            return _objBUS.ToList(Id_Turma).Where(x=>x.Id_Aluno==Id_Aluno).Count()>0;
        }
        public int Save()
        {
            return Id_Matricula > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }

        #endregion
    }
}
