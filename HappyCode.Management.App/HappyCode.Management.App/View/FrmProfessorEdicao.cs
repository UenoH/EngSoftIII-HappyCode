using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmProfessorEdicao : Form
    {
        #region Constructor
        public FrmProfessorEdicao(Professor obj)
        {
            _obj = obj;
            InitializeComponent();
            InitializeEvents();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Professor _obj { get; set; }
        #endregion

        #region Methods
        private void InitializeEvents()
        {
            txtCPF.TextChanged += ControlTreat.MaskTextChanged;
            txtCEP.TextChanged += ControlTreat.MaskTextChanged;
            txtTelefone.TextChanged += ControlTreat.MaskTextChanged;
            txtCelular.TextChanged += ControlTreat.MaskTextChanged;

            txtCPF.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtCEP.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtNumero.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtFoneDDD.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtTelefone.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtCelDDD.KeyPress += ControlTreat.OnlyNumberKeyPress;
            txtCelular.KeyPress += ControlTreat.OnlyNumberKeyPress;

            txtCEP.KeyDown += TxtCEP_KeyDown;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            cboSexo.SelectedIndex = 0;
            if (_obj == null)
            {
                _obj = new Professor() { Dt_Criacao = DateTime.Now, Dt_Nascimento = DateTime.Now, St_Ativo = true };
            }

            long.TryParse(_obj.Tx_CPF, out long CPF);

            txtNome.Text = _obj.Tx_Nome;
            txtCPF.Text = CPF == 0 ? string.Empty : string.Format(@"{0:000\.000\.000\-00}", CPF);
            dtpDataNasc.Value = _obj.Dt_Nascimento;
            cboSexo.SelectedIndex = _obj.Tx_Sexo?.ToUpper() == "F" ? 1 : 0;
            txtCEP.Text = _obj.Tx_CEP;
            txtRua.Text = _obj.Tx_Rua;
            txtNumero.Text = _obj.Tx_Numero;
            txtComplemento.Text = _obj.Tx_Complemento;
            txtBairro.Text = _obj.Tx_Bairro;
            txtCidade.Text = _obj.Tx_Municipio;
            txtEstado.Text = _obj.Tx_UF;
            txtEmail.Text = _obj.Tx_Email;
            txtFoneDDD.Text = _obj.Nu_FoneDDD == 0 ? "" : _obj.Nu_FoneDDD.ToString();
            txtTelefone.Text = _obj.Nu_Fone == 0 ? "" : _obj.Nu_FoneDDD.ToString();
            txtCelDDD.Text = _obj.Nu_CelDDD == 0 ? "" : _obj.Nu_CelDDD.ToString();
            txtCelular.Text = _obj.Nu_Cel == 0 ? "" : _obj.Nu_Cel.ToString();
        }
        private void FormToObject()
        {
            _obj.Tx_Nome = txtNome.Text.Trim();
            _obj.Tx_CPF = ControlTreat.RemoveNonNumbers(txtCPF.Text);
            _obj.Dt_Nascimento = dtpDataNasc.Value;
            _obj.Tx_Sexo = cboSexo.Text.Substring(0, 1);
            _obj.Tx_CEP = txtCEP.Text;
            _obj.Tx_Rua = txtRua.Text.Trim();
            _obj.Tx_Numero = txtNumero.Text.Trim();
            _obj.Tx_Complemento = txtComplemento.Text.Trim();
            _obj.Tx_Bairro = txtBairro.Text.Trim();
            _obj.Tx_Municipio = txtCidade.Text.Trim();
            _obj.Tx_UF = txtEstado.Text.Trim();
            _obj.Tx_Email = txtEmail.Text.Trim();
            _obj.Nu_FoneDDD = int.TryParse(ControlTreat.RemoveNonNumbers(txtFoneDDD.Text.Trim()), out int i) ? i : 0;
            _obj.Nu_Fone = int.TryParse(ControlTreat.RemoveNonNumbers(txtTelefone.Text.Trim()), out i) ? i : 0;
            _obj.Nu_CelDDD = int.TryParse(ControlTreat.RemoveNonNumbers(txtCelDDD.Text.Trim()), out i) ? i : 0;
            _obj.Nu_Cel = int.TryParse(ControlTreat.RemoveNonNumbers(txtCelular.Text.Trim()), out i) ? i : 0;
            _obj.St_Ativo = true;
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(new FrmProfessor(), "Cadastro de Professores");
            }
            Close();
        }
        #endregion

        #region Events
        private void Control_Leave(object sender, EventArgs e)
        {
            ControlTreat.IsValid(sender);
        }
        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender != null && sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.White;
            }
        }
        private void btnCEP_Click(object sender, EventArgs e)
        {
            CarregarEndereco();
        }
        private void TxtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregarEndereco();
            }
        }

        private void CarregarEndereco()
        {
            Address add = Address.GetAddress(txtCEP.Text);
            if (add != null)
            {
                txtRua.Text = add.Tx_Rua;
                txtBairro.Text = add.Tx_Bairro;
                txtCidade.Text = add.Tx_Municipio;
                txtEstado.Text = add.Tx_UF;
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
            if (!Core.Util.Validate.IsValidCPF(ControlTreat.RemoveNonNumbers(txtCPF.Text)))
            {
                txtCPF.BackColor = Color.FromArgb(255, 106, 111);
                Msg.Alert("CPF Inválido");
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