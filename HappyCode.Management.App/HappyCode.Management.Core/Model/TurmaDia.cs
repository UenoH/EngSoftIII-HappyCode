using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.Business;

namespace HappyCode.Management.Core.Model
{
    public class TurmaDia
    {
        #region Constructor
        public TurmaDia()
        {
            _objBUS = new TurmaDiaBUS(new DAO.TurmaDiaDAO());
        }
        #endregion

        #region Attributes
        public int Id_TurmaDia { get; set; }
        public int Id_Turma { get; set; }
        public int Nu_DiaSemana { get; set; }
        public TimeSpan Tm_Horario { get; set; }

        public string Tx_DiaSemana
        {
            get
            {
                string TxDia = string.Empty;
                switch (Nu_DiaSemana)
                {
                    case (int)DayOfWeek.Sunday: TxDia = "Domingo"; break;
                    case (int)DayOfWeek.Monday: TxDia = "Segunda-feira"; break;
                    case (int)DayOfWeek.Tuesday: TxDia = "Terça-feira"; break;
                    case (int)DayOfWeek.Wednesday: TxDia = "Quarta-feira"; break;
                    case (int)DayOfWeek.Thursday: TxDia = "Quinta-feira"; break;
                    case (int)DayOfWeek.Friday: TxDia = "Sexta-feira"; break;
                    case (int)DayOfWeek.Saturday: TxDia = "Sábado"; break;
                }
                return TxDia;
            }
        }

        private TurmaDiaBUS _objBUS;
        #endregion

        #region Methods
        public List<TurmaDia> ToList()
        {
            return _objBUS.ToList();
        }
        public List<TurmaDia> ToList(int IdTurma)
        {
            return _objBUS.ToList(IdTurma);
        }
        public List<TurmaDia> ToListProfessor(int IdProfessor)
        {
            return _objBUS.ToListProfessor(IdProfessor);
        }
        public int Save()
        {
            return Id_TurmaDia > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }
        #endregion
    }
}
