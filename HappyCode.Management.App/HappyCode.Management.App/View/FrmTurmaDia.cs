using HappyCode.Management.Core.Model;
using System;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmTurmaDia : Form
    {
        #region Constructor
        public FrmTurmaDia(TurmaDia obj)
        {
            _obj = obj;
            InitializeComponent();
            FillForm();
        }
        #endregion

        #region Attributes
        private TurmaDia _obj;
        #endregion

        #region Methods
        private void FillForm()
        {
            if (_obj == null)
            {
                _obj = new TurmaDia();
            }
            else
            {
                cboDia.SelectedIndex = _obj.Nu_DiaSemana;
                dtpHorario.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    _obj.Tm_Horario.Hours, _obj.Tm_Horario.Minutes, _obj.Tm_Horario.Seconds);
            }
        }
        private void FillObject()
        {
            _obj.Nu_DiaSemana = cboDia.SelectedIndex;
            _obj.Tm_Horario = new TimeSpan(dtpHorario.Value.Hour, dtpHorario.Value.Minute, 0);
        }
        #endregion

        #region Events
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FillObject();
            Tag = _obj;
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Tag = null;
            Close();
        }
        #endregion

    }
}
