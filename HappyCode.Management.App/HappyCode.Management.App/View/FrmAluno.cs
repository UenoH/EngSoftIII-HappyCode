using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillGrid();
        }

        private void FillGrid()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = new Aluno().ToList().Where(x=>x.St_Ativo).ToList();
            dgvData.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOpen(new FrmAlunoEdicao(null));
        }
        private void FormOpen(FrmMatricula obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Cadastro de Matrículas");
            }
            Close();
        }
        private void FormOpen(FrmAlunoEdicao obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Edição do Aluno");
            }
            Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is Aluno)
                {
                    var obj = (Aluno)Data;
                    switch (dgvData.Columns[e.ColumnIndex].Name)
                    { 
                        case "clmMatricula": FormOpen(new FrmMatricula(obj)); break;
                        case "clmEdit": FormOpen(new FrmAlunoEdicao(obj)); break;
                        case "clmDelete":
                            if (Msg.Question("Deseja realmente excluir o registro??", "Excluir Registro"))
                            {
                                obj.Tx_CPF = "######";
                                obj.St_Ativo = false;
                                obj.Save();
                            }
                            break;
                    }
                }
            }
        }
    }
}
