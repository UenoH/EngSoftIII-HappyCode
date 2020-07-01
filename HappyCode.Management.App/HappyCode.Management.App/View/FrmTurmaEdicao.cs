using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmTurmaEdicao : Form
    {
        #region Constructor
        public FrmTurmaEdicao(Turma obj)
        {
            _obj = obj;
            InitializeComponent();
            InitializeCombos();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Turma _obj { get; set; }
        private List<TurmaDia> _LstDias { get; set; }
        private List<TurmaDia> _LstDiasRetirados { get; set; }
        #endregion

        #region Methods
        private void InitializeCombos()
        {
            cboCurso.DataSource = new Curso().ToList().Where(x => x.St_Ativo).OrderBy(x => x.Tx_Nome).ToList();
            cboCurso.DisplayMember = "Tx_Nome";
            cboCurso.ValueMember = "Id_Curso";
            cboCurso.SelectedIndex = -1;

            cboProfessor.DataSource = new Professor().ToList().Where(x => x.St_Ativo).OrderBy(x => x.Tx_Nome).ToList();
            cboProfessor.DisplayMember = "Tx_Nome";
            cboProfessor.ValueMember = "Id_Professor";
            cboProfessor.SelectedIndex = -1;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            _LstDiasRetirados = new List<TurmaDia>();
            dgvData.AutoGenerateColumns = false;
            if (_obj == null)
            {
                _obj = new Turma() { St_Concluido = false };
                _LstDias = new List<TurmaDia>();
                _obj.St_Concluido = false;
            }
            else
            {
                _LstDias = new TurmaDia().ToList(_obj.Id_Turma);
                cboCurso.SelectedValue = _obj.Id_Curso;
                cboProfessor.SelectedValue = _obj.Id_Professor;
                dtpInicio.Value = _obj.Dt_Inicio;
                dtpTermino.Value = _obj.Dt_Termino;
                GridRefresh();
            }

        }
        private void FormToObject()
        {
            _obj.Id_Curso = cboCurso.SelectedValue?.GetType() == typeof(int) ? (int)cboCurso.SelectedValue : 0;
            _obj.Id_Professor = cboProfessor.SelectedValue?.GetType() == typeof(int) ?
                (int)cboProfessor.SelectedValue : 0;
            _obj.Dt_Inicio = dtpInicio.Value;
            _obj.Dt_Termino = dtpTermino.Value;
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(new FrmTurma(), "Cadastro do Turmas");
            }
            Close();
        }
        private void GridRefresh()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = _LstDias.OrderBy(x=>x.Nu_DiaSemana).ToList();
            dgvData.Refresh();
        }
        #endregion

        #region Events
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboProfessor.SelectedValue == null || (int)cboProfessor.SelectedValue == 0)
            {
                Msg.Alert("Selecione o professor antes de continuar...");
                return;
            }
            using (FrmTurmaDia frmTurmaDia = new FrmTurmaDia(null))
            {
                frmTurmaDia.ShowDialog();
                if (frmTurmaDia.Tag != null && frmTurmaDia.Tag is TurmaDia)
                {
                    List<TurmaDia> LstTd = new TurmaDia().ToListProfessor((int)cboProfessor.SelectedValue);
                    TurmaDia td = (TurmaDia)frmTurmaDia.Tag;
                    if (_LstDias.Where(x => x.Nu_DiaSemana == td.Nu_DiaSemana && x.Tm_Horario == td.Tm_Horario).Count() > 0 ||
                        LstTd.Where(x => x.Nu_DiaSemana == td.Nu_DiaSemana && x.Tm_Horario == td.Tm_Horario).Count() > 0)
                    {
                        Msg.Alert("Professor já possui aula marcada para a data/hora selecionado");
                        return;
                    }
                    _LstDias.Add(td);
                    GridRefresh();
                }

            }
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is TurmaDia)
                {
                    TurmaDia obj = (TurmaDia)Data;
                    switch (dgvData.Columns[e.ColumnIndex].Name)
                    {
                        case "clmEdit":
                            using (FrmTurmaDia frmTurmaDia = new FrmTurmaDia(new TurmaDia { Id_TurmaDia = obj.Id_TurmaDia, Id_Turma = obj.Id_Turma, Nu_DiaSemana = obj.Nu_DiaSemana, Tm_Horario = obj.Tm_Horario }))
                            {
                                frmTurmaDia.ShowDialog();
                                if (frmTurmaDia.Tag != null && frmTurmaDia.Tag is TurmaDia)
                                {
                                    List<TurmaDia> LstTd = new TurmaDia().ToListProfessor((int)cboProfessor.SelectedValue);
                                    TurmaDia td = (TurmaDia)frmTurmaDia.Tag;
                                    if (_LstDias.Where(x => x.Nu_DiaSemana == td.Nu_DiaSemana && x.Tm_Horario == td.Tm_Horario && x.Id_TurmaDia != td.Id_TurmaDia).Count() > 0 ||
                                        LstTd.Where(x => x.Nu_DiaSemana == td.Nu_DiaSemana && x.Tm_Horario == td.Tm_Horario && x.Id_TurmaDia != td.Id_TurmaDia).Count() > 0)
                                    {
                                        Msg.Alert("Professor já possui aula marcada para a data/hora selecionado");
                                        return;
                                    }
                                    obj.Nu_DiaSemana = td.Nu_DiaSemana;
                                    obj.Tm_Horario = td.Tm_Horario;
                                    GridRefresh();
                                }
                            };
                            break;
                        case "clmDelete":
                            if (obj.Id_TurmaDia == 0 || Msg.Question("Deseja realmente excluir o registro??",
                                "Excluir Registro"))
                            {
                                _LstDias.Remove(obj);
                                _LstDiasRetirados.Add(obj);
                                GridRefresh();
                            }
                            break;
                    }
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool StContinue = true;
            foreach (Control Control in Controls)
            {
                if (Control is Panel)
                {
                    foreach (object ChildControls in Control.Controls)
                    {
                        if (ChildControls is TextBox)
                        {
                            if (!ControlTreat.IsValid(ChildControls) && StContinue)
                            {
                                StContinue = false;
                            }
                        }
                    }
                }
            }

            if (StContinue)
            {
                FormToObject();
                int NuResult = _obj.Save();
                if (NuResult > 0)
                {
                    if (_obj.Id_Turma == 0)
                    {
                        _obj.Id_Turma = _obj.getLastId();
                    }
                    foreach (TurmaDia item in _LstDias)
                    {
                        if (item.Id_Turma == 0)
                        {
                            item.Id_Turma = _obj.Id_Turma;
                        }
                        item.Save();
                    }
                    foreach (TurmaDia item in _LstDiasRetirados)
                    {
                        if (item.Id_TurmaDia > 0)
                        {
                            item.Delete();
                        }
                    }
                    Msg.Info("Informações Salvas com Êxito!", "Salvar Registro");
                }
                else { Msg.Alert("Nenhum registro salvo..."); return; }
                FormClose();
            }
            else
            {
                Msg.Alert("Preencha todos os dados antes de salvar o registro...");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormClose();
        }
        #endregion

    }
}