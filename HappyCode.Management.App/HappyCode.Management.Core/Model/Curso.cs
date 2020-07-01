using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class Curso
    {
        #region Constructor
        public Curso()
        {
            _objBUS = new CursoBUS(new DAO.CursoDAO());
        }
        #endregion

        #region Attributes
        public int Id_Curso { get; set; }
        public string Tx_Nome { get; set; }
        public int Nu_Aulas { get; set; }
        public int Nu_CargaHoraria { get; set; }
        public string Tx_Conteudo { get; set; }
        public string Tx_Observacoes { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool St_Ativo { get; set; }

        private CursoBUS _objBUS;
        #endregion

        #region Methods
        public List<Curso> ToList()
        {
            return _objBUS.ToList();
        }
        public Curso Find(int IdCurso)
        {
            return _objBUS.ToList(IdCurso).FirstOrDefault();
        }
        public int Save()
        {
            return Id_Curso > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }

        #endregion
    }
}
