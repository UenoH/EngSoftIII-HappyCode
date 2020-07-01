namespace HappyCode.Management.App
{
    partial class FrmTurmaEdicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmaEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblBasicoHeader = new System.Windows.Forms.Label();
            this.lblInfoObrigatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBasico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.btnAdicionar);
            this.pnlBasico.Controls.Add(this.dgvData);
            this.pnlBasico.Controls.Add(this.dtpTermino);
            this.pnlBasico.Controls.Add(this.label1);
            this.pnlBasico.Controls.Add(this.dtpInicio);
            this.pnlBasico.Controls.Add(this.lblDtInicio);
            this.pnlBasico.Controls.Add(this.cboProfessor);
            this.pnlBasico.Controls.Add(this.lblProfessor);
            this.pnlBasico.Controls.Add(this.cboCurso);
            this.pnlBasico.Controls.Add(this.lblCurso);
            this.pnlBasico.Controls.Add(this.lblBasicoHeader);
            this.pnlBasico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasico.Location = new System.Drawing.Point(0, 0);
            this.pnlBasico.Name = "pnlBasico";
            this.pnlBasico.Size = new System.Drawing.Size(784, 351);
            this.pnlBasico.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdicionar.BackgroundImage = global::HappyCode.Management.App.Properties.Resources.btnAdicionar;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(563, 180);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCargaHoraria,
            this.clmConteudo,
            this.clmEdit,
            this.clmDelete});
            this.dgvData.Location = new System.Drawing.Point(227, 180);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(330, 158);
            this.dgvData.TabIndex = 15;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // clmCargaHoraria
            // 
            this.clmCargaHoraria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCargaHoraria.DataPropertyName = "Tx_DiaSemana";
            this.clmCargaHoraria.HeaderText = "Dia da Semana";
            this.clmCargaHoraria.Name = "clmCargaHoraria";
            this.clmCargaHoraria.ReadOnly = true;
            // 
            // clmConteudo
            // 
            this.clmConteudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmConteudo.DataPropertyName = "Tm_Horario";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.clmConteudo.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmConteudo.HeaderText = "Horário";
            this.clmConteudo.Name = "clmConteudo";
            this.clmConteudo.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmEdit.HeaderText = "";
            this.clmEdit.Image = global::HappyCode.Management.App.Properties.Resources.Edit;
            this.clmEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 35;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::HappyCode.Management.App.Properties.Resources.Delete;
            this.clmDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 35;
            // 
            // dtpTermino
            // 
            this.dtpTermino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTermino.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpTermino.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(394, 149);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(163, 25);
            this.dtpTermino.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Término da Turma";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(227, 149);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(161, 25);
            this.dtpInicio.TabIndex = 12;
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicio.ForeColor = System.Drawing.Color.Black;
            this.lblDtInicio.Location = new System.Drawing.Point(224, 129);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(98, 17);
            this.lblDtInicio.TabIndex = 11;
            this.lblDtInicio.Text = "Início da Turma";
            // 
            // cboProfessor
            // 
            this.cboProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfessor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(227, 102);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(330, 25);
            this.cboProfessor.TabIndex = 10;
            // 
            // lblProfessor
            // 
            this.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.Color.Black;
            this.lblProfessor.Location = new System.Drawing.Point(224, 83);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(64, 17);
            this.lblProfessor.TabIndex = 9;
            this.lblProfessor.Text = "Professor";
            // 
            // cboCurso
            // 
            this.cboCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino"});
            this.cboCurso.Location = new System.Drawing.Point(227, 56);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(330, 25);
            this.cboCurso.TabIndex = 8;
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(224, 37);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(42, 17);
            this.lblCurso.TabIndex = 7;
            this.lblCurso.Text = "Curso";
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
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(254, 354);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 13;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(397, 385);
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
            this.btnSalvar.Location = new System.Drawing.Point(233, 385);
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
            // FrmTurmaEdicao
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
            this.Name = "FrmTurmaEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlBasico.ResumeLayout(false);
            this.pnlBasico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasico;
        private System.Windows.Forms.Label lblBasicoHeader;
        private System.Windows.Forms.Label lblInfoObrigatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.ComboBox cboProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCargaHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConteudo;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}