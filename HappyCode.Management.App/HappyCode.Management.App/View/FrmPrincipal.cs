using HappyCode.Management.Core.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmPrincipal : Form
    {
        #region Constructor
        public FrmPrincipal(Usuario objUsuario)
        {
            InitializeComponent();
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Attributes
        #endregion

        #region Events
        private void btnAluno_Click(object sender, EventArgs e)
        {
            CreateForm(new FrmAluno(), "Cadastro de Alunos");
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            int NuAdd = pnlCadastros.Height > 100 ? -1 : 1;
            for (int i = 49; i < 215; i++)
            {
                pnlCadastros.Height = pnlCadastros.Height + NuAdd;
                Application.DoEvents();
            }
        }
        private void btnAulas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAula(), "Cadastro de Aulas");
        }
        private void btnCalendario_Click(object sender, EventArgs e)
        {

        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmUsuario(), "Cadastro de Usuários");
        }
        private void btnProfessor_Click(object sender, EventArgs e)
        {
            CreateForm(new FrmProfessor(), "Cadastro de Professores");
        }
        private void btnCurso_Click(object sender, EventArgs e)
        {
            CreateForm(new FrmCurso(), "Cadastro do Cursos");
        }
        private void btnTurma_Click(object sender, EventArgs e)
        {
            CreateForm(new FrmTurma(), "Cadastro de Turmas");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmUI))
            {
                ((FrmUI)ParentForm).OpenForm(new FrmLogin());
            }

            Close();
        }
        #endregion

        #region Methods
        private void CreateForm(Form Frm, string Header)
        {
            pnlForm.Controls.Clear();
            Frm.TopLevel = false;
            pnlForm.Controls.Add(Frm);
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.WindowState = FormWindowState.Maximized;
            Frm.Dock = DockStyle.Fill;
            Frm.Show();
            lblForm.Text = Header;
        }
        internal void OpenForm(Form _Form, string Header)
        {
            CreateForm(_Form, Header);
        }
        #endregion

    }
}