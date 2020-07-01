using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmMatriculaEdicao : Form
    {
        #region Constructor
        public FrmMatriculaEdicao(Matricula obj, Aluno objAluno, Turma objTurma)
        {
            _obj = obj;
            _objAluno = objAluno;
            _objTurma = objTurma;
            InitializeComponent();
            InitializeCombos();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Matricula _obj { get; set; }
        private Aluno _objAluno { get; set; }
        private Turma _objTurma { get; set; }
        #endregion

        #region Methods
        private void InitializeCombos()
        {
            cboCursoTurma.DataSource = new TurmaGrid().ToList().Where(x => !x.St_Concluido).OrderBy(x => x.Tx_Combo).ToList();
            cboCursoTurma.DisplayMember = "Tx_Combo";
            cboCursoTurma.ValueMember = "Id_Turma";
            cboCursoTurma.SelectedIndex = -1;

            cboAluno.DataSource = new Aluno().ToList().Where(x => x.St_Ativo).OrderBy(x => x.Tx_Nome).ToList();
            cboAluno.DisplayMember = "Tx_Nome";
            cboAluno.ValueMember = "Id_Aluno";
            cboAluno.SelectedIndex = -1;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            cboCursoTurma.SelectedValue = _obj.Id_Turma;
            cboAluno.SelectedValue = _obj.Id_Aluno;
            if (_obj.Id_Matricula > 0)
            {
                cboCursoTurma.Enabled = false;
                cboAluno.Enabled = false;
            }
            dtpMatricula.Value = _obj.Dt_Matricula;
            txtNotaFinal.Text = _obj.Vl_NotaFinal > 0 || _obj.Id_Status > 1 ? _obj.Vl_NotaFinal.ToString() : "";
            txtTotalFaltas.Text = _obj.Nu_FaltasFinal > 0 || _obj.Id_Status > 1 ? _obj.Nu_FaltasFinal.ToString() : "";
            cboStatus.SelectedIndex = _obj.Id_Status;
        }
        private void FormToObject()
        {
            _obj.Id_Turma = cboCursoTurma.SelectedValue?.GetType() == typeof(int) ? (int)cboCursoTurma.SelectedValue : 0;
            _obj.Id_Aluno = cboAluno.SelectedValue?.GetType() == typeof(int) ? (int)cboAluno.SelectedValue : 0;
            _obj.Dt_Matricula = dtpMatricula.Value;
            _obj.Vl_NotaFinal = int.TryParse(txtNotaFinal.Text, out int i) ? i : 0;
            _obj.Nu_FaltasFinal = int.TryParse(txtTotalFaltas.Text, out i) ? i : 0;
            _obj.Id_Status = cboStatus.SelectedIndex;
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                FrmMatricula frmMatricula = new FrmMatricula();
                if (_objAluno != null)
                {
                    frmMatricula = new FrmMatricula(_objAluno);
                }
                if (_objTurma != null)
                {
                    frmMatricula = new FrmMatricula(_objTurma);
                }
                ((FrmPrincipal)ParentForm).OpenForm(frmMatricula, "Cadastro do Matrículas");
            }
            Close();
        }
        #endregion

        #region Events
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
            StringBuilder TxErro = new StringBuilder();

            if (cboCursoTurma.SelectedValue == null)
            {
                TxErro.Append("Selecione o Curso/Turma");
            }
            if (cboAluno.SelectedValue == null)
            {
                if (TxErro.Length > 0)
                {
                    TxErro.Append(" e ");
                }

                TxErro.Append("Seleciona o Aluno");
            }

            _obj.Id_Turma = cboCursoTurma.SelectedValue?.GetType() == typeof(int) ? (int)cboCursoTurma.SelectedValue : 0;
            _obj.Id_Aluno = cboAluno.SelectedValue?.GetType() == typeof(int) ? (int)cboAluno.SelectedValue : 0;
            if (_obj.Id_Matricula == 0 && _obj.AlunoJaMatriculado())
            {
                Msg.Alert("Aluno já matriculado para a turma selecionada...");
                return;
            }

            if (StContinue)
            {
                FormToObject();
                int NuResult = _obj.Save();
                if (NuResult > 0)
                {
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