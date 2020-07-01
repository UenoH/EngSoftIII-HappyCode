namespace HappyCode.Management.App
{
    partial class FrmMatricula
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
            this.clmAluno,
            this.clmMatricula,
            this.clmNotaFinal,
            this.clmFaltas,
            this.clmStatus,
            this.clmEdit,
            this.clmDelete});
            this.dgvData.Location = new System.Drawing.Point(12, 55);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(810, 317);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnVoltar.Location = new System.Drawing.Point(697, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 37);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            // clmAluno
            // 
            this.clmAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAluno.DataPropertyName = "Tx_Aluno";
            this.clmAluno.HeaderText = "Aluno";
            this.clmAluno.Name = "clmAluno";
            this.clmAluno.ReadOnly = true;
            // 
            // clmMatricula
            // 
            this.clmMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmMatricula.DataPropertyName = "Dt_Matricula";
            this.clmMatricula.HeaderText = "Data da Matrícula";
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            this.clmMatricula.Width = 120;
            // 
            // clmNotaFinal
            // 
            this.clmNotaFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmNotaFinal.DataPropertyName = "Vl_NotaFinal";
            this.clmNotaFinal.HeaderText = "Nota Final";
            this.clmNotaFinal.Name = "clmNotaFinal";
            this.clmNotaFinal.ReadOnly = true;
            this.clmNotaFinal.Width = 120;
            // 
            // clmFaltas
            // 
            this.clmFaltas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFaltas.DataPropertyName = "Nu_FaltasFinal";
            this.clmFaltas.HeaderText = "Total de Faltas";
            this.clmFaltas.Name = "clmFaltas";
            this.clmFaltas.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmStatus.DataPropertyName = "Id_Status";
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
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
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvData);
            this.Name = "FrmMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFaltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}