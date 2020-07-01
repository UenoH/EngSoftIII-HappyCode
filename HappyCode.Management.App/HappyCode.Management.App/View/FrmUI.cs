using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmUI : Form
    {
        #region Constructor
        public FrmUI(Form Frm)
        {
            InitializeComponent();
            _Frm = Frm;
        }
        #endregion

        #region Attributes
        Form _Frm;
        #endregion

        #region Methods
        private void FrmUI_Load(object sender, System.EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            CreateForm(_Frm);
        }
        private void CreateForm(Form Frm)
        {
            pnlForm.Controls.Clear();
            Frm.TopLevel = false;
            this.Text = Frm.Text;
            pnlForm.Controls.Add(Frm);
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.WindowState = FormWindowState.Maximized;
            Frm.Dock = DockStyle.Fill;
            Frm.Show();
        }
        internal void OpenForm(Form _Form)
        {
            CreateForm(_Form);
        }
        #endregion

        #region Events
        private void FrmUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a aplicação",
                "Encerrar Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion
    }
}