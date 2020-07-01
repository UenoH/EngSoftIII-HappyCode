using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmTurmaConclusao : Form
    {
        public FrmTurmaConclusao(Turma obj, string TxCurso)
        {
            InitializeComponent();
            _obj = obj;
            lblCurso.Text = $"{TxCurso}";
            FillForm();
        }

        private Turma _obj;
        private List<Aula> LstAulas { get; set; }
        private List<AulaPresenca> LstPresenca { get; set; }
        private List<AulaAvaliacao> LstAvaliacao { get; set; }
        private List<Matricula> LstMatricula { get; set; }

        private void FillForm()
        {
            clmStatus.DataSource = new BindingSource(ComboStatus(), null);
            clmStatus.DisplayMember = "Value";
            clmStatus.ValueMember = "Key";
            dgvData.AutoGenerateColumns = false;
            LstMatricula = new Matricula().ToList(_obj.Id_Turma);
            LstAulas = new Aula().ToList(_obj.Id_Turma);
            LstPresenca = new AulaPresenca().ToListTurma(_obj.Id_Turma);
            LstAvaliacao = new AulaAvaliacao().ToListTurma(_obj.Id_Turma);
            int NumProvas = LstAulas.Where(x => x.St_Avaliacao).Count();
            foreach (Matricula m in LstMatricula)
            {
                m.Nu_FaltasFinal = LstAulas.Count - LstPresenca.Where(x => x.Id_Matricula == m.Id_Matricula && x.St_Presenca).Count();
                m.Vl_NotaFinal = LstAvaliacao.Where(x => x.Id_Matricula == m.Id_Matricula).Sum(x => x.Vl_Avaliacao) / NumProvas;

                if (m.Vl_NotaFinal < 6)
                {
                    m.Id_Status = 3;
                }
                else
                {
                    m.Id_Status = 2;
                }
                if ((m.Nu_FaltasFinal / LstAulas.Count) > (decimal)0.25)
                {
                    m.Id_Status = 4;
                }                    
            }
            lblAulas.Text = $"Número de Aulas: {LstAulas.Count}";
            dgvData.DataSource = null;
            dgvData.DataSource = LstMatricula;
            dgvData.Refresh();
        }

        public static Dictionary<int, string> ComboStatus()
        {
            Dictionary<int, string> _i = new Dictionary<int, string>();
            _i.Add(0, "0 - Não Iniciado");
            _i.Add(1, "1 - Cursando");
            _i.Add(2, "2 - Aprovado");
            _i.Add(3, "3 - Reprovado por Nota");
            _i.Add(4, "4 - Reprovado por Falta");
            return _i;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (Matricula item in LstMatricula)
            {
                item.Save();
            }
            if (!_obj.St_Concluido)
            {
                _obj.St_Concluido = true;
                _obj.Save();
            }
            Msg.Info("Registro Salvo com Êxito", "Salvar Registro");
            Close();
        }
    }
}
