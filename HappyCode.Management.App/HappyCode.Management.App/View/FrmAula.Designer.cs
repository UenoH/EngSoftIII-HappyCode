namespace HappyCode.Management.App
{
    partial class FrmAula
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvaliacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmPresenca = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rdbAndamento = new System.Windows.Forms.RadioButton();
            this.rdbConcluido = new System.Windows.Forms.RadioButton();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.gpbLegenda = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpbLegenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(125, 37);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmTurma,
            this.clmDataAula,
            this.clmAssunto,
            this.clmAvaliacao,
            this.clmPresenca,
            this.clmEdit,
            this.clmDelete});
            this.dgvData.Location = new System.Drawing.Point(12, 133);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(810, 150);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            // 
            // clmId
            // 
            this.clmId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmId.DataPropertyName = "Id_Aula";
            this.clmId.HeaderText = "#";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 80;
            // 
            // clmTurma
            // 
            this.clmTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTurma.DataPropertyName = "Tx_Turma";
            this.clmTurma.HeaderText = "Turma";
            this.clmTurma.Name = "clmTurma";
            this.clmTurma.ReadOnly = true;
            // 
            // clmDataAula
            // 
            this.clmDataAula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmDataAula.DataPropertyName = "Dt_Aula";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.clmDataAula.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmDataAula.HeaderText = "Data da Aula";
            this.clmDataAula.Name = "clmDataAula";
            this.clmDataAula.ReadOnly = true;
            this.clmDataAula.Width = 120;
            // 
            // clmAssunto
            // 
            this.clmAssunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAssunto.DataPropertyName = "Tx_Assunto";
            this.clmAssunto.HeaderText = "Assunto";
            this.clmAssunto.Name = "clmAssunto";
            this.clmAssunto.ReadOnly = true;
            this.clmAssunto.Width = 250;
            // 
            // clmAvaliacao
            // 
            this.clmAvaliacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAvaliacao.DataPropertyName = "St_Avaliacao";
            this.clmAvaliacao.HeaderText = "Avaliação?";
            this.clmAvaliacao.Name = "clmAvaliacao";
            this.clmAvaliacao.ReadOnly = true;
            this.clmAvaliacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAvaliacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmPresenca
            // 
            this.clmPresenca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPresenca.HeaderText = "";
            this.clmPresenca.Image = global::HappyCode.Management.App.Properties.Resources.btnMatricula;
            this.clmPresenca.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmPresenca.Name = "clmPresenca";
            this.clmPresenca.ReadOnly = true;
            this.clmPresenca.Width = 35;
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
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::HappyCode.Management.App.Properties.Resources.Delete;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 35;
            // 
            // rdbAndamento
            // 
            this.rdbAndamento.AutoSize = true;
            this.rdbAndamento.Checked = true;
            this.rdbAndamento.Location = new System.Drawing.Point(12, 64);
            this.rdbAndamento.Name = "rdbAndamento";
            this.rdbAndamento.Size = new System.Drawing.Size(121, 17);
            this.rdbAndamento.TabIndex = 6;
            this.rdbAndamento.TabStop = true;
            this.rdbAndamento.Text = "Aulas não Aplicadas";
            this.rdbAndamento.UseVisualStyleBackColor = true;
            this.rdbAndamento.CheckedChanged += new System.EventHandler(this.rdbChange);
            // 
            // rdbConcluido
            // 
            this.rdbConcluido.AutoSize = true;
            this.rdbConcluido.Location = new System.Drawing.Point(139, 64);
            this.rdbConcluido.Name = "rdbConcluido";
            this.rdbConcluido.Size = new System.Drawing.Size(106, 17);
            this.rdbConcluido.TabIndex = 7;
            this.rdbConcluido.Text = "Aulas Realizadas";
            this.rdbConcluido.UseVisualStyleBackColor = true;
            this.rdbConcluido.CheckedChanged += new System.EventHandler(this.rdbChange);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(9, 90);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(69, 13);
            this.lblTurma.TabIndex = 8;
            this.lblTurma.Text = "Curso/Turma";
            // 
            // cboTurma
            // 
            this.cboTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(12, 106);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(354, 21);
            this.cboTurma.TabIndex = 9;
            this.cboTurma.SelectedValueChanged += new System.EventHandler(this.cboTurma_SelectedValueChanged);
            // 
            // gpbLegenda
            // 
            this.gpbLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbLegenda.Controls.Add(this.label3);
            this.gpbLegenda.Controls.Add(this.label2);
            this.gpbLegenda.Controls.Add(this.label1);
            this.gpbLegenda.Controls.Add(this.pictureBox3);
            this.gpbLegenda.Controls.Add(this.pictureBox4);
            this.gpbLegenda.Controls.Add(this.pictureBox1);
            this.gpbLegenda.Location = new System.Drawing.Point(12, 289);
            this.gpbLegenda.Name = "gpbLegenda";
            this.gpbLegenda.Size = new System.Drawing.Size(277, 83);
            this.gpbLegenda.TabIndex = 10;
            this.gpbLegenda.TabStop = false;
            this.gpbLegenda.Text = "Legendas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Excluir Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Editar Aula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Presença/Avaliação";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyCode.Management.App.Properties.Resources.Delete;
            this.pictureBox3.Location = new System.Drawing.Point(162, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HappyCode.Management.App.Properties.Resources.Edit;
            this.pictureBox4.Location = new System.Drawing.Point(162, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyCode.Management.App.Properties.Resources.btnMatricula;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.ControlBox = false;
            this.Controls.Add(this.gpbLegenda);
            this.Controls.Add(this.cboTurma);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.rdbConcluido);
            this.Controls.Add(this.rdbAndamento);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvData);
            this.Name = "FrmAula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpbLegenda.ResumeLayout(false);
            this.gpbLegenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.RadioButton rdbAndamento;
        private System.Windows.Forms.RadioButton rdbConcluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssunto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAvaliacao;
        private System.Windows.Forms.DataGridViewImageColumn clmPresenca;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.GroupBox gpbLegenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}