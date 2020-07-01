using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCode.Management.Core.Model
{
    public class TurmaGrid
    {
        #region Constructor
        public TurmaGrid()
        {
            _objBUS = new BUS.TurmaGridBUS(new DAO.TurmaGridDAO());
        }
        #endregion

        #region Attributes
        public int Id_Turma { get; set; }
        public string Tx_Curso { get; set; }
        public string Tx_Professor { get; set; }
        public DateTime Dt_Inicio { get; set; }
        public DateTime Dt_Termino { get; set; }
        public string Tx_Aulas { get; set; }
        public string Tx_Avaliacoes { get; set; }
        public bool St_Concluido { get; set; }

        public string Tx_Combo { get { return Id_Turma>0 ?$"Curso: {Tx_Curso} - Turma: {Id_Turma} / Professor: {Tx_Professor}":"Todos as Turmas"; } }
        private BUS.TurmaGridBUS _objBUS;
        #endregion

        #region Methods
        public List<TurmaGrid> ToList()
        {
            return _objBUS.ToList();
        }
        #endregion
    }
}
