namespace HappyCode.Management.App
{
    partial class FrmMatriculaEdicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriculaEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.lblNumFaltas = new System.Windows.Forms.Label();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.txtTotalFaltas = new System.Windows.Forms.TextBox();
            this.txtNotaFinal = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataMatricula = new System.Windows.Forms.Label();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.cboCursoTurma = new System.Windows.Forms.ComboBox();
            this.lblCursoTurma = new System.Windows.Forms.Label();
            this.lblBasicoHeader = new System.Windows.Forms.Label();
            this.lblInfoObrigatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBasico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.lblNumFaltas);
            this.pnlBasico.Controls.Add(this.lblNotaFinal);
            this.pnlBasico.Controls.Add(this.txtTotalFaltas);
            this.pnlBasico.Controls.Add(this.txtNotaFinal);
            this.pnlBasico.Controls.Add(this.cboStatus);
            this.pnlBasico.Controls.Add(this.lblStatus);
            this.pnlBasico.Controls.Add(this.lblDataMatricula);
            this.pnlBasico.Controls.Add(this.dtpMatricula);
            this.pnlBasico.Controls.Add(this.cboAluno);
            this.pnlBasico.Controls.Add(this.lblAluno);
            this.pnlBasico.Controls.Add(this.cboCursoTurma);
            this.pnlBasico.Controls.Add(this.lblCursoTurma);
            this.pnlBasico.Controls.Add(this.lblBasicoHeader);
            this.pnlBasico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasico.Location = new System.Drawing.Point(0, 0);
            this.pnlBasico.Name = "pnlBasico";
            this.pnlBasico.Size = new System.Drawing.Size(784, 193);
            this.pnlBasico.TabIndex = 0;
            // 
            // lblNumFaltas
            // 
            this.lblNumFaltas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumFaltas.AutoSize = true;
            this.lblNumFaltas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFaltas.ForeColor = System.Drawing.Color.Black;
            this.lblNumFaltas.Location = new System.Drawing.Point(236, 130);
            this.lblNumFaltas.Name = "lblNumFaltas";
            this.lblNumFaltas.Size = new System.Drawing.Size(92, 17);
            this.lblNumFaltas.TabIndex = 18;
            this.lblNumFaltas.Text = "Total de Faltas";
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.ForeColor = System.Drawing.Color.Black;
            this.lblNotaFinal.Location = new System.Drawing.Point(97, 131);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(67, 17);
            this.lblNotaFinal.TabIndex = 17;
            this.lblNotaFinal.Text = "Nota Final";
            // 
            // txtTotalFaltas
            // 
            this.txtTotalFaltas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalFaltas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTotalFaltas.Location = new System.Drawing.Point(239, 150);
            this.txtTotalFaltas.Name = "txtTotalFaltas";
            this.txtTotalFaltas.Size = new System.Drawing.Size(153, 25);
            this.txtTotalFaltas.TabIndex = 16;
            // 
            // txtNotaFinal
            // 
            this.txtNotaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNotaFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNotaFinal.Location = new System.Drawing.Point(100, 150);
            this.txtNotaFinal.Name = "txtNotaFinal";
            this.txtNotaFinal.Size = new System.Drawing.Size(135, 25);
            this.txtNotaFinal.TabIndex = 15;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "0 - Não Iniciado",
            "1 - Cursando",
            "2 - Aprovado",
            "3 - Reprovado por Nota",
            "4 - Reprovado por Falta"});
            this.cboStatus.Location = new System.Drawing.Point(397, 150);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(275, 25);
            this.cboStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(394, 131);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // lblDataMatricula
            // 
            this.lblDataMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataMatricula.AutoSize = true;
            this.lblDataMatricula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblDataMatricula.Location = new System.Drawing.Point(522, 85);
            this.lblDataMatricula.Name = "lblDataMatricula";
            this.lblDataMatricula.Size = new System.Drawing.Size(112, 17);
            this.lblDataMatricula.TabIndex = 12;
            this.lblDataMatricula.Text = "Data da Matrícula";
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpMatricula.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpMatricula.Enabled = false;
            this.dtpMatricula.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatricula.Location = new System.Drawing.Point(522, 104);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(150, 25);
            this.dtpMatricula.TabIndex = 11;
            // 
            // cboAluno
            // 
            this.cboAluno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(100, 104);
            this.cboAluno.Margin = new System.Windows.Forms.Padding(2);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(417, 25);
            this.cboAluno.TabIndex = 10;
            // 
            // lblAluno
            // 
            this.lblAluno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.Color.Black;
            this.lblAluno.Location = new System.Drawing.Point(97, 85);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(41, 17);
            this.lblAluno.TabIndex = 9;
            this.lblAluno.Text = "Aluno";
            // 
            // cboCursoTurma
            // 
            this.cboCursoTurma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCursoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursoTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboCursoTurma.FormattingEnabled = true;
            this.cboCursoTurma.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino"});
            this.cboCursoTurma.Location = new System.Drawing.Point(100, 58);
            this.cboCursoTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cboCursoTurma.Name = "cboCursoTurma";
            this.cboCursoTurma.Size = new System.Drawing.Size(572, 25);
            this.cboCursoTurma.TabIndex = 8;
            // 
            // lblCursoTurma
            // 
            this.lblCursoTurma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCursoTurma.AutoSize = true;
            this.lblCursoTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoTurma.ForeColor = System.Drawing.Color.Black;
            this.lblCursoTurma.Location = new System.Drawing.Point(97, 39);
            this.lblCursoTurma.Name = "lblCursoTurma";
            this.lblCursoTurma.Size = new System.Drawing.Size(84, 17);
            this.lblCursoTurma.TabIndex = 7;
            this.lblCursoTurma.Text = "Curso/Turma";
            // 
            // lblBasicoHeader
            // 
            this.lblBasicoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBasicoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBasicoHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicoHeader.ForeColor = System.Drawing.Color.White;
            this.lblBasicoHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBasicoHeader.Name = "lblBasicoHeader";
            this.lblBasicoHeader.Size = new System.Drawing.Size(784, 28);
            this.lblBasicoHeader.TabIndex = 1;
            this.lblBasicoHeader.Text = " Informações Basicas";
            this.lblBasicoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoObrigatorio
            // 
            this.lblInfoObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoObrigatorio.AutoSize = true;
            this.lblInfoObrigatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(254, 187);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 13;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(397, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(233, 218);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HappyCode.Management.App.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 35;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HappyCode.Management.App.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 35;
            // 
            // FrmMatriculaEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfoObrigatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlBasico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMatriculaEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlBasico.ResumeLayout(false);
            this.pnlBasico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasico;
        private System.Windows.Forms.Label lblBasicoHeader;
        private System.Windows.Forms.Label lblInfoObrigatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cboCursoTurma;
        private System.Windows.Forms.Label lblCursoTurma;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblNumFaltas;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.TextBox txtTotalFaltas;
        private System.Windows.Forms.TextBox txtNotaFinal;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataMatricula;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
    }
}