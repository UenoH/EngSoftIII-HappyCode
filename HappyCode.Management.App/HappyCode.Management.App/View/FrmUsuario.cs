using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillGrid();
        }

        private void FillGrid()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = new Usuario().ToList();
            dgvData.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOpen(new FrmUsuarioEdicao(null));
        }
        private void FormOpen(FrmUsuarioEdicao obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Edição do Usuario");
            }
            Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is Usuario)
                {
                    var obj = (Usuario)Data;
                    switch (dgvData.Columns[e.ColumnIndex].Name)
                    {
                        case "clmEdit": FormOpen(new FrmUsuarioEdicao(obj)); break;
                        case "clmDelete":
                            if (Msg.Question("Deseja realmente excluir o registro??", "Excluir Registro"))
                            {
                                //obj.Tx_CPF = "######";
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
