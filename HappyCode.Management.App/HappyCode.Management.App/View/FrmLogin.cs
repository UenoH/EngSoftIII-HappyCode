using HappyCode.Management.Core.Util;
using System;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmLogin : Form
    {
        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtUser.Focus();
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new Core.Model.Usuario().Login(txtUser.Text, txtPass.Text);
            if (user == null)
            {
                Error("Usuário ou senha inválido");
                return;
            }
            if (!user.St_Ativo)
            {
                Error("Usuario inativo. Entre em contato com o Administrador de sistemas");
                return;
            }
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmUI))
                ((FrmUI)ParentForm).OpenForm(new FrmPrincipal(user));
            Close();
        }
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPass.Focus();
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }
        private void Error(string Message)
        {
            Msg.Alert(Message);
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtUser.Focus();
        }
        #endregion
    }
}