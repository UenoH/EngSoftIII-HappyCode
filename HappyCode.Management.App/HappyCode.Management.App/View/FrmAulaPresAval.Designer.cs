namespace HappyCode.Management.App
{
    partial class FrmAulaPresAval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAulaPresAval));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPresenca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
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
            this.clmNome,
            this.clmPresenca,
            this.clmNota});
            this.dgvData.Location = new System.Drawing.Point(12, 59);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvData.Size = new System.Drawing.Size(599, 268);
            this.dgvData.TabIndex = 5;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(12, 9);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(19, 17);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "lb";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(12, 35);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(19, 17);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "lb";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(457, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(12, 333);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // clmNome
            // 
            this.clmNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNome.DataPropertyName = "Tx_Aluno";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            // 
            // clmPresenca
            // 
            this.clmPresenca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPresenca.DataPropertyName = "St_Presenca";
            this.clmPresenca.HeaderText = "Presença";
            this.clmPresenca.Name = "clmPresenca";
            this.clmPresenca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPresenca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmNota
            // 
            this.clmNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmNota.DataPropertyName = "Vl_Nota";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmNota.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNota.HeaderText = "Avaliação";
            this.clmNota.Name = "clmNota";
            // 
            // FrmAulaPresAval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.dgvData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAulaPresAval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPresenca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota;
    }
}