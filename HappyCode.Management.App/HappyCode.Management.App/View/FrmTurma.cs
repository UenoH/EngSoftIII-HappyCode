using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmTurma : Form
    {
        public FrmTurma()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillGrid();
        }

        private List<TurmaGrid> LstTurmas;

        private void FillGrid()
        {
            LstTurmas = new TurmaGrid().ToList();
            FilterGrid();
        }

        private void FilterGrid()
        {
            List<TurmaGrid> LstFilter = new List<TurmaGrid>();
            if (rdbAndamento.Checked)
            {
                LstFilter = LstTurmas.Where(x => !x.St_Concluido).ToList();
            }
            if (rdbConcluido.Checked)
            {
                LstFilter = LstTurmas.Where(x => x.St_Concluido).ToList();
            }
            dgvData.DataSource = null;
            dgvData.DataSource = LstFilter;
            dgvData.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOpen(new FrmTurmaEdicao(null));
        }
        private void FormOpen(FrmTurmaEdicao obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Edição do Curso");
            }
            Close();
        }
        private void FormOpen(FrmTurmaConclusao obj)
        {
            obj.ShowDialog();
            FillGrid();
        }
        private void FormOpen(FrmMatricula obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Cadastro de Matriculas");
            }
            Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is TurmaGrid)
                {
                    TurmaGrid item = (TurmaGrid)Data;
                    Turma obj = new Turma().Find(item.Id_Turma);
                    if (obj != null)
                    {
                        switch (dgvData.Columns[e.ColumnIndex].Name)
                        {
                            case "clmConcluir":
                                Curso objCurso = new Curso().Find(obj.Id_Curso);
                                List<Aula> LstAulas = new Aula().ToList(obj.Id_Turma);
                                if(LstAulas.Count == 0) 
                                {
                                    Msg.Alert("Nenhuma aula realizada...");
                                    return;
                                }
                                if(LstAulas.Where(x => !x.St_Concluida).Count() > 0)
                                {
                                    Msg.Alert("Turma ainda possui aulas não realizadas...");
                                    return;
                                }
                                if(objCurso.Nu_Aulas > 0 && LstAulas.Count < objCurso.Nu_Aulas)
                                {
                                    Msg.Alert($"Turma ainda completou o numero de aulas do curso...\n\nNumero de Aulas Exigidas: {objCurso.Nu_Aulas}");
                                    return;
                                }
                                StringBuilder stCurso = new StringBuilder();
                                stCurso.Append("Curso: " + dgvData.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                                stCurso.Append(" - ");
                                stCurso.Append("Turma: " + obj.Id_Turma);
                                stCurso.Append(" / ");
                                stCurso.Append("Professor: " + dgvData.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                                FormOpen(new FrmTurmaConclusao(obj, stCurso.ToString())); break;
                            case "clmMatricula": FormOpen(new FrmMatricula(obj)); break;
                            case "clmEdit": FormOpen(new FrmTurmaEdicao(obj)); break;
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
                        clmConcluir.Visible = true;
                        clmDelete.Visible = true;
                        clmMatricula.Visible = true;
                        rdbConcluido.Checked = false;
                    }
                    if (button.Name == "rdbConcluido")
                    {
                        clmConcluir.Visible = false;
                        clmDelete.Visible = false;
                        clmMatricula.Visible = false;
                        rdbAndamento.Checked = false;
                    }
                    FilterGrid();
                }
            }
        }
    }
}
