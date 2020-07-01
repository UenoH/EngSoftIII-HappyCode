using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmUsuarioEdicao : Form
    {
        #region Constructor
        public FrmUsuarioEdicao(Usuario obj)
        {
            _obj = obj;
            InitializeComponent();
            InitializeCombo();
            InitializeForms();
        }
        #endregion

        #region Attributes
        private Usuario _obj { get; set; }
        #endregion

        #region Methods
        private void InitializeCombo()
        {
            cboProfessor.DataSource = new Professor().ToList().Where(x => x.St_Ativo).OrderBy(x => x.Tx_Nome).ToList();
            cboProfessor.DisplayMember = "Tx_Nome";
            cboProfessor.ValueMember = "Id_Professor";
            cboProfessor.SelectedIndex = -1;
        }
        private void InitializeForms()
        {
            VerticalScroll.Visible = true;
            if (_obj == null)
            {
                _obj = new Usuario() { St_Admin = false, St_Ativo = true };
            }

            txtID.Text = _obj.Id_Usuario > 0 ? _obj.Id_Usuario.ToString() : string.Empty;
            txtNome.Text = _obj.Tx_Nome;
            if (_obj.Id_Professor > 0)
            {
                ckbProfessor.Checked = true;
                cboProfessor.SelectedValue = _obj.Id_Professor;
            }
            txtLogin.Text = _obj.Tx_Login;
            txtSenha.Text = _obj.Tx_Senha;
            ckbAdmin.Checked = _obj.St_Admin;
            ckbAtivo.Checked = _obj.St_Ativo;
        }
        private void FormToObject()
        {
            _obj.Id_Professor = 0;
            _obj.Tx_Nome = txtNome.Text.Trim();
            if (ckbProfessor.Checked)
            {
                Professor objProfessor = null;
                if (cboProfessor.SelectedItem?.GetType() == typeof(Professor))
                {
                    objProfessor = (Professor)cboProfessor.SelectedItem;
                }
                if (objProfessor != null)
                {
                    _obj.Id_Professor = objProfessor.Id_Professor;
                    _obj.Tx_Nome = objProfessor.Tx_Nome;
                }
            }
            _obj.Tx_Login = txtLogin.Text.Trim();
            _obj.Tx_Senha = Encrypt.EncryptString(txtSenha.Text.Trim());
            _obj.St_Admin = ckbAdmin.Checked;
            _obj.St_Ativo = ckbAtivo.Checked;
        }
        private void FormClose()
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(new FrmUsuario(), "Cadastro do Usuarios");
            }
            Close();
        }
        #endregion

        #region Events
        private void ckbProfessor_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Visible = !ckbProfessor.Checked;
            cboProfessor.Visible = ckbProfessor.Checked;
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