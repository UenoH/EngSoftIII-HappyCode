using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            btnVoltar.Visible = false;
            FillGrid();
        }
        public FrmMatricula(Aluno objAluno)
        {
            _objAluno = objAluno;
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillGrid();
        }
        public FrmMatricula(Turma objTurma)
        {
            _objTurma = objTurma;
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            FillGrid();
        }

        private Aluno _objAluno { get; set; }
        private Turma _objTurma { get; set; }

        private void FillGrid()
        {
            List<Matricula> LstTurmas = new Matricula().ToList();
            if (_objAluno != null)
            {
                LstTurmas = LstTurmas.Where(x => x.Id_Aluno == _objAluno.Id_Aluno).ToList();
            }
            if (_objTurma != null)
            {
                LstTurmas = LstTurmas.Where(x => x.Id_Turma == _objTurma.Id_Turma).ToList();
            }
            dgvData.DataSource = null;
            dgvData.DataSource = LstTurmas;
            dgvData.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Matricula obj = new Matricula() { Dt_Matricula = DateTime.Now };
            if (_objAluno != null)
            {
                obj.Id_Aluno = _objAluno.Id_Aluno;
            }

            if (_objTurma != null)
            {
                obj.Id_Turma = _objTurma.Id_Turma;
            }
            FormOpen(new FrmMatriculaEdicao(obj, _objAluno, _objTurma));
        }
        private void FormOpen(FrmMatriculaEdicao obj)
        {
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, "Edição da Matrícula");
            }
            Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object Data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (Data != null && Data is Matricula)
                {
                    Matricula obj = (Matricula)Data;
                    if (obj != null)
                    {
                        switch (dgvData.Columns[e.ColumnIndex].Name)
                        {
                            case "clmEdit": FormOpen(new FrmMatriculaEdicao(obj, _objAluno, _objTurma)); break;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form obj = new Form();
            string TxHeader = "Página Inicial";
            if (_objAluno != null)
            {
                obj = new FrmAluno();
                TxHeader = "Cadastro de Alunos";
            }
            if (_objTurma != null)
            {
                obj = new FrmTurma();
                TxHeader = "Cadastro de Turmas";
            }
            if (ParentForm != null && ParentForm.GetType() == typeof(FrmPrincipal))
            {
                ((FrmPrincipal)ParentForm).OpenForm(obj, TxHeader);
            }
            Close();
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var data = dgvData.Rows[e.RowIndex].DataBoundItem;
                if (data != null)
                {
                    var obj = (Matricula)data;
                    switch (dgvData.Columns[e.ColumnIndex].Name)
                    {
                        case "clmNotaFinal":
                            if (obj.Id_Status > 1)
                                e.Value = obj.Vl_NotaFinal.ToString("0.00");
                            else
                                e.Value = "";
                                break;
                        case "clmFaltas":
                            if (obj.Id_Status > 1)
                                e.Value = obj.Nu_FaltasFinal.ToString("00");
                            else
                                e.Value = ""; break;
                        case "clmStatus":
                            switch (obj.Id_Status)
                            {
                                case 0: e.Value = "0 - Não Iniciado"; break;
                                case 1: e.Value = "1 - Cursando"; break;
                                case 2: e.Value = "2 - Aprovado"; break;
                                case 3: e.Value = "3 - Reprovado por Nota"; break;
                                case 4: e.Value = "4 - Reprovado por Falta"; break;
                                default: e.Value = "Não Idenfificado"; break;
                            }
                            break;
                    }
                }
            }
        }
    }
}
