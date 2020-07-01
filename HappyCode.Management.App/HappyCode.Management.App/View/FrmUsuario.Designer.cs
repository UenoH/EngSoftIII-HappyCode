namespace HappyCode.Management.App
{
    partial class FrmUsuario
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
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gpbLegenda = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpbLegenda.SuspendLayout();
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
            this.clmNome,
            this.clmLogin,
            this.clmAdmin,
            this.clmAtivo,
            this.clmEdit,
            this.clmDelete});
            this.dgvData.Location = new System.Drawing.Point(12, 55);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(810, 228);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmId.DataPropertyName = "Id_Usuario";
            this.clmId.HeaderText = "#";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 80;
            // 
            // clmNome
            // 
            this.clmNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNome.DataPropertyName = "Tx_Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            // 
            // clmLogin
            // 
            this.clmLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmLogin.DataPropertyName = "Tx_Login";
            this.clmLogin.HeaderText = "Login";
            this.clmLogin.Name = "clmLogin";
            this.clmLogin.ReadOnly = true;
            this.clmLogin.Width = 180;
            // 
            // clmAdmin
            // 
            this.clmAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAdmin.DataPropertyName = "St_Admin";
            this.clmAdmin.HeaderText = "Administrador";
            this.clmAdmin.Name = "clmAdmin";
            this.clmAdmin.ReadOnly = true;
            this.clmAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmAtivo
            // 
            this.clmAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAtivo.DataPropertyName = "St_Ativo";
            this.clmAtivo.HeaderText = "Ativo";
            this.clmAtivo.Name = "clmAtivo";
            this.clmAtivo.ReadOnly = true;
            this.clmAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // gpbLegenda
            // 
            this.gpbLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbLegenda.Controls.Add(this.label3);
            this.gpbLegenda.Controls.Add(this.label2);
            this.gpbLegenda.Controls.Add(this.pictureBox3);
            this.gpbLegenda.Controls.Add(this.pictureBox4);
            this.gpbLegenda.Location = new System.Drawing.Point(12, 289);
            this.gpbLegenda.Name = "gpbLegenda";
            this.gpbLegenda.Size = new System.Drawing.Size(156, 83);
            this.gpbLegenda.TabIndex = 10;
            this.gpbLegenda.TabStop = false;
            this.gpbLegenda.Text = "Legendas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Excluir Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Editar Registro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyCode.Management.App.Properties.Resources.Delete;
            this.pictureBox3.Location = new System.Drawing.Point(10, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HappyCode.Management.App.Properties.Resources.Edit;
            this.pictureBox4.Location = new System.Drawing.Point(10, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.ControlBox = false;
            this.Controls.Add(this.gpbLegenda);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvData);
            this.Name = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpbLegenda.ResumeLayout(false);
            this.gpbLegenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAtivo;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.GroupBox gpbLegenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}