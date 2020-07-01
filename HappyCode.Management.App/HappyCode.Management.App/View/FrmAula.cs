using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmAula : Form
    {
        public FrmAula()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillCombo();
            FillGrid();
        }

        private List<Aula> LstAulas;
        private List<TurmaGrid> LstTurmas;

        private void FillCombo()
        {
            List<TurmaGrid> LstTurmaCombo = new TurmaGrid().ToList().Where(x => !x.St_Concluido).OrderBy(x => x.Tx_Combo).ToList();
            LstTurmaCombo.Insert(0, new TurmaGrid());
            cboTurma.DataSource = LstTurmaCombo;
            cboTurma.DisplayMember = "Tx_Combo";
            cboTurma.ValueMember = "Id_Turma";
            cboTurma.SelectedIndex = 0;
        }
        private void FillGrid()
        {
            LstAulas = new Aula().ToList();
            LstTurmas = new TurmaGrid().ToList();
            FilterGrid();
        }

        private void FilterGrid()
        {
            List<Aula> LstFilter = new List<Aula>();
            if (rdbAndamento.Checked)
            {
                LstFilter = LstAulas.Where(x => !x.St_Concluida).ToList();
            }
            if (rdbConcluido.Checked)
            {
                LstFilter = LstAulas.Where(x => x.St_Concluida).ToList();
            }
            int nuTurma = cboTurma.SelectedValue?.GetType() == typeof(int) ? (int)cboTurma.SelectedValue : 0;
            if (nuTurma > 0)
            {
                LstFilter = LstFilter.Where(x => x.Id_Turma == nuTurma).ToList();
            }
            dgvData.DataSource = null;
            dgvData.DataSource = LstFilter.OrderBy(x => x.Dt_Aula).ToList();
            dgvData.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOpen(new FrmAulaEdicao(null));
        }
        private void FormOpen(FrmAulaEdicao obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Edição da Aula");
            }
            Close();
        }
        private void FormOpen(FrmAulaPresAval obj)
        {
            obj.ShowDialog();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is Aula)
                {
                    Aula obj = (Aula)Data;
                    if (obj != null)
                    {
                        switch (dgvData.Columns[e.ColumnIndex].Name)
                        {
                            case "clmPresenca": FormOpen(new FrmAulaPresAval(obj, dgvData.Rows[e.RowIndex].Cells[1].FormattedValue?.ToString())); break;
                            case "clmEdit": FormOpen(new FrmAulaEdicao(obj)); break;
                            case "clmDelete":
                                if (Msg.Question("Deseja realmente excluir o registro??", "Excluir Registro"))
                                {
                                    obj.Delete();
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void rdbChange(object sender, EventArgs e)
        {
            if (sender != null && sender is RadioButton)
            {
                RadioButton button = (RadioButton)sender;
                if (button.Checked)
                {
                    if (button.Name == "rdbAndamento")
                    {
                        rdbConcluido.Checked = false;
                    }
                    if (button.Name == "rdbConcluido")
                    {
                        rdbAndamento.Checked = false;
                    }
                    FilterGrid();
                }
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (data != null)
                {
                    Aula obj = (Aula)data;
                    switch (dgvData.Columns[e.ColumnIndex].Name)
                    {
                        case "clmTurma":
                            TurmaGrid objTurma = LstTurmas.Find(x => x.Id_Turma == obj.Id_Turma);
                            e.Value = objTurma?.Tx_Combo ?? "Não Identificado"; break;
                    }
                }
            }
        }

        private void cboTurma_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LstAulas != null)
            {
                FilterGrid();
            }
        }
    }
}
