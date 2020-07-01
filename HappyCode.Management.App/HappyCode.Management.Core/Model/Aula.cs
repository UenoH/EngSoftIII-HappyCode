using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class Aula
    {
        #region Constructor
        public Aula()
        {
            _objBUS = new AulaBUS(new DAO.AulaDAO());
        }
        #endregion

        #region Attributes
        public int Id_Aula { get; set; }
        public int Id_Turma { get; set; }
        public DateTime Dt_Aula { get; set; }
        public string Tx_Assunto { get; set; }
        public string Tx_Conteudo { get; set; }
        public string Tx_Observacoes { get; set; }
        public bool St_Avaliacao { get; set; }
        public bool St_Concluida { get; set; }

        private AulaBUS _objBUS;
        #endregion

        #region Methods
        public List<Aula> ToList()
        {
            return _objBUS.ToList();
        }
        public List<Aula> ToList(int IdTurma)
        {
            return _objBUS.ToList(IdTurma);
        }
        public int Save()
        {
            return Id_Aula > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }
        #endregion
    }
}
