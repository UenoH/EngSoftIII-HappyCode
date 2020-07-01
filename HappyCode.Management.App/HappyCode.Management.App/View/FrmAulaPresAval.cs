using HappyCode.Management.Core.Model;
using HappyCode.Management.Core.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HappyCode.Management.App
{
    public partial class FrmAulaPresAval : Form
    {
        public FrmAulaPresAval(Aula obj, string TxCurso)
        {
            InitializeComponent();
            _obj = obj;
            lblCurso.Text = $"{TxCurso}";
            lblAssunto.Text = $"Assunto: {obj.Tx_Assunto}";
            FillForm();
        }

        private Aula _obj;
        private List<AulaPresAval> LstData { get; set; }
        private List<AulaPresenca> LstPresenca { get; set; }
        private List<AulaAvaliacao> LstAvaliacao { get; set; }
        private List<Matricula> LstMatricula { get; set; }
        private List<Aluno> LstAluno { get; set; }

        private void FillForm()
        {
            dgvData.AutoGenerateColumns = false;
            if (!_obj.St_Avaliacao)
            {
                clmNota.Visible = false;
            }
            LstData = new List<AulaPresAval>();
            LstMatricula = new Matricula().ToList(_obj.Id_Turma);
            LstAluno = new Aluno().ToList();
            LstPresenca = new AulaPresenca().ToList(_obj.Id_Aula);
            LstAvaliacao = new AulaAvaliacao().ToList(_obj.Id_Aula);
            foreach (Matricula m in LstMatricula)
            {
                if (m.Id_Status == 0)
                {
                    m.Id_Status = 1;
                    m.Save();
                }
                Aluno aluno = LstAluno.Find(x => x.Id_Aluno == m.Id_Aluno);
                if (aluno != null)
                {
                    AulaPresenca pres = LstPresenca.Find(x => x.Id_Matricula == m.Id_Matricula);
                    AulaAvaliacao aval = LstAvaliacao.Find(x => x.Id_Matricula == m.Id_Matricula);
                    AulaPresAval obj = new AulaPresAval()
                    {
                        Id_Aula = _obj.Id_Aula,
                        Id_Matricula = m.Id_Matricula,
                        Tx_Aluno = aluno.Tx_Nome,
                        objPresenca = pres,
                        objAvaliacao = aval,
                        St_Presenca = pres?.St_Presenca ?? false,
                        Vl_Nota = aval?.Vl_Avaliacao ?? 0
                    };
                    LstData.Add(obj);
                }
            }
            dgvData.DataSource = null;
            dgvData.DataSource = LstData;
            dgvData.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in LstData)
            {
                var pres = item.objPresenca;
                if (pres == null) pres = new AulaPresenca() { Id_Aula = item.Id_Aula, Id_Matricula = item.Id_Matricula };
                pres.St_Presenca = item.St_Presenca;
                pres.Save();
                if (_obj.St_Avaliacao)
                {
                    var aval = item.objAvaliacao;
                    if (aval == null) aval = new AulaAvaliacao() { Id_Aula = item.Id_Aula, Id_Matricula = item.Id_Matricula };
                    aval.Vl_Avaliacao = item.Vl_Nota;
                    aval.Save();
                }
            }
            if (!_obj.St_Concluida)
            {
                _obj.St_Concluida = true;
                _obj.Save();
            }
            Msg.Info("Registro Salvo com Êxito", "Salvar Registro");
            Close();
        }
    }
}
