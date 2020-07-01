using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmCursoEdicao : Form
    {
        #region Constructor
        public FrmCursoEdicao(Curso obj)
        {
            _obj = obj;
            InitializeComponent();
            InitializeEvents();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Curso _obj { get; set; }
        #endregion

        #region Methods
        private void InitializeEvents()
        {
            txtNumAulas.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtCargaHoraria.KeyPress += ControlTreat.OnlyNumberKeyPress;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            if (_obj == null)
            {
                _obj = new Curso() { Dt_Criacao = DateTime.Now, St_Ativo = true };
            }

            txtID.Text = _obj.Id_Curso > 0 ? _obj.Id_Curso.ToString() : string.Empty;
            txtNome.Text = _obj.Tx_Nome;
            txtNumAulas.Text = _obj.Nu_Aulas > 0 ? _obj.Nu_Aulas.ToString() : string.Empty;
            txtCargaHoraria.Text = _obj.Nu_CargaHoraria > 0 ? _obj.Nu_CargaHoraria.ToString() : string.Empty;
            txtConteudo.Text = _obj.Tx_Conteudo;
            txtObservacoes.Text = _obj.Tx_Observacoes;
        }
        private void FormToObject()
        {
            _obj.Tx_Nome = txtNome.Text.Trim();
            _obj.Nu_Aulas = int.TryParse(txtNumAulas.Text, out int i) ? i : 0;
            _obj.Nu_CargaHoraria = int.TryParse(txtCargaHoraria.Text, out i) ? i : 0;
            _obj.Tx_Conteudo = txtConteudo.Text;
            _obj.Tx_Observacoes = txtObservacoes.Text;
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(new FrmCurso(), "Cadastro do Cursos");
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