namespace HappyCode.Management.App
{
    partial class FrmTurma
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvaliaçoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMatricula = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rdbAndamento = new System.Windows.Forms.RadioButton();
            this.rdbConcluido = new System.Windows.Forms.RadioButton();
            this.gpbLegenda = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpbLegenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.clmCurso,
            this.clmNumAulas,
            this.clmInicio,
            this.clmConteudo,
            this.clmAulas,
            this.clmAvaliaçoes,
            this.clmConcluir,
            this.clmMatricula,
            this.clmEdit,
            this.clmDelete});
            this.dgvData.Location = new System.Drawing.Point(12, 87);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(810, 196);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmId.DataPropertyName = "Id_Curso";
            this.clmId.HeaderText = "#";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 80;
            // 
            // clmCurso
            // 
            this.clmCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCurso.DataPropertyName = "Tx_Curso";
            this.clmCurso.HeaderText = "Curso";
            this.clmCurso.Name = "clmCurso";
            this.clmCurso.ReadOnly = true;
            // 
            // clmNumAulas
            // 
            this.clmNumAulas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNumAulas.DataPropertyName = "Tx_Professor";
            this.clmNumAulas.HeaderText = "Professor";
            this.clmNumAulas.Name = "clmNumAulas";
            this.clmNumAulas.ReadOnly = true;
            // 
            // clmInicio
            // 
            this.clmInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmInicio.DataPropertyName = "Dt_Inicio";
            this.clmInicio.HeaderText = "Data de Inicio";
            this.clmInicio.Name = "clmInicio";
            this.clmInicio.ReadOnly = true;
            this.clmInicio.Width = 120;
            // 
            // clmConteudo
            // 
            this.clmConteudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmConteudo.DataPropertyName = "Dt_Termino";
            this.clmConteudo.HeaderText = "Data de Término";
            this.clmConteudo.Name = "clmConteudo";
            this.clmConteudo.ReadOnly = true;
            this.clmConteudo.Width = 120;
            // 
            // clmAulas
            // 
            this.clmAulas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAulas.DataPropertyName = "Tx_Aulas";
            this.clmAulas.HeaderText = "Aulas";
            this.clmAulas.Name = "clmAulas";
            this.clmAulas.ReadOnly = true;
            // 
            // clmAvaliaçoes
            // 
            this.clmAvaliaçoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAvaliaçoes.DataPropertyName = "Tx_Avaliacoes";
            this.clmAvaliaçoes.HeaderText = "Avaliações";
            this.clmAvaliaçoes.Name = "clmAvaliaçoes";
            this.clmAvaliaçoes.ReadOnly = true;
            // 
            // clmConcluir
            // 
            this.clmConcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmConcluir.HeaderText = "";
            this.clmConcluir.Image = global::HappyCode.Management.App.Properties.Resources.Approve;
            this.clmConcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmConcluir.Name = "clmConcluir";
            this.clmConcluir.ReadOnly = true;
            this.clmConcluir.Width = 35;
            // 
            // clmMatricula
            // 
            this.clmMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmMatricula.HeaderText = "";
            this.clmMatricula.Image = global::HappyCode.Management.App.Properties.Resources.btnMatricula;
            this.clmMatricula.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            this.clmMatricula.Width = 35;
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
            this.rdbAndamento.Size = new System.Drawing.Size(134, 17);
            this.rdbAndamento.TabIndex = 6;
            this.rdbAndamento.TabStop = true;
            this.rdbAndamento.Text = "Turmas em Andamento";
            this.rdbAndamento.UseVisualStyleBackColor = true;
            this.rdbAndamento.CheckedChanged += new System.EventHandler(this.rdbChange);
            // 
            // rdbConcluido
            // 
            this.rdbConcluido.AutoSize = true;
            this.rdbConcluido.Location = new System.Drawing.Point(152, 64);
            this.rdbConcluido.Name = "rdbConcluido";
            this.rdbConcluido.Size = new System.Drawing.Size(117, 17);
            this.rdbConcluido.TabIndex = 7;
            this.rdbConcluido.Text = "Turmas Concluídas";
            this.rdbConcluido.UseVisualStyleBackColor = true;
            this.rdbConcluido.CheckedChanged += new System.EventHandler(this.rdbChange);
            // 
            // gpbLegenda
            // 
            this.gpbLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbLegenda.Controls.Add(this.label4);
            this.gpbLegenda.Controls.Add(this.label3);
            this.gpbLegenda.Controls.Add(this.label2);
            this.gpbLegenda.Controls.Add(this.label1);
            this.gpbLegenda.Controls.Add(this.pictureBox3);
            this.gpbLegenda.Controls.Add(this.pictureBox4);
            this.gpbLegenda.Controls.Add(this.pictureBox2);
            this.gpbLegenda.Controls.Add(this.pictureBox1);
            this.gpbLegenda.Location = new System.Drawing.Point(12, 289);
            this.gpbLegenda.Name = "gpbLegenda";
            this.gpbLegenda.Size = new System.Drawing.Size(277, 83);
            this.gpbLegenda.TabIndex = 8;
            this.gpbLegenda.TabStop = false;
            this.gpbLegenda.Text = "Legendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyCode.Management.App.Properties.Resources.btnMatricula;
            this.pictureBox1.Location = new System.Drawing.Point(6, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HappyCode.Management.App.Properties.Resources.Approve;
            this.pictureBox2.Location = new System.Drawing.Point(6, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alunos Matriculados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Editar Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Excluir Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Concluir Turma";
            // 
            // FrmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.ControlBox = false;
            this.Controls.Add(this.gpbLegenda);
            this.Controls.Add(this.rdbConcluido);
            this.Controls.Add(this.rdbAndamento);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvData);
            this.Name = "FrmTurma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpbLegenda.ResumeLayout(false);
            this.gpbLegenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConteudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvaliaçoes;
        private System.Windows.Forms.DataGridViewImageColumn clmConcluir;
        private System.Windows.Forms.DataGridViewImageColumn clmMatricula;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.GroupBox gpbLegenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}