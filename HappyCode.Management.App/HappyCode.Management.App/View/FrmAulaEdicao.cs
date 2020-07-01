using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmAulaEdicao : Form
    {
        #region Constructor
        public FrmAulaEdicao(Aula obj)
        {
            _obj = obj;
            InitializeComponent();
            InitializeCombo();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Aula _obj { get; set; }
        #endregion

        #region Methods
        private void InitializeCombo()
        {
            cboCursoTurma.DataSource = new TurmaGrid().ToList().Where(x => !x.St_Concluido).OrderBy(x => x.Tx_Combo).ToList();
            cboCursoTurma.DisplayMember = "Tx_Combo";
            cboCursoTurma.ValueMember = "Id_Turma";
            cboCursoTurma.SelectedIndex = -1;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            if (_obj == null)
            {
                _obj = new Aula() { Dt_Aula = DateTime.Now };
            }

            txtID.Text = _obj.Id_Aula > 0 ? _obj.Id_Aula.ToString() : string.Empty;
            cboCursoTurma.SelectedValue = _obj.Id_Turma;
            dtpData.Value = _obj.Dt_Aula;
            ckbAvaliacao.Checked = _obj.St_Avaliacao;
            txtAssunto.Text = _obj.Tx_Assunto;
            txtConteudo.Text = _obj.Tx_Conteudo;
            txtObservacoes.Text = _obj.Tx_Observacoes;

            cboCursoTurma.Enabled = !_obj.St_Concluida;
        }
        private void FormToObject()
        {
            DateTime dtAula = dtpData.Value;
            _obj.Id_Turma = cboCursoTurma.SelectedValue?.GetType() == typeof(int) ? (int)cboCursoTurma.SelectedValue : 0;
            _obj.Dt_Aula = new DateTime(dtAula.Year, dtAula.Month, dtAula.Day, dtAula.Hour, dtAula.Minute, 0);
            _obj.St_Avaliacao = ckbAvaliacao.Checked;
            _obj.Tx_Assunto = txtAssunto.Text.Trim();
            _obj.Tx_Conteudo = txtConteudo.Text.Trim();
            _obj.Tx_Observacoes = txtObservacoes.Text.Trim();
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(new FrmAula(), "Cadastro do Aulas");
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