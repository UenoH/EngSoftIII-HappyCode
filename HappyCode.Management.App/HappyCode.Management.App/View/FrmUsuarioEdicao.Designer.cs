namespace HappyCode.Management.App
{
    partial class FrmUsuarioEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.ckbProfessor = new System.Windows.Forms.CheckBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.ckbAdmin = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBasicoHeader = new System.Windows.Forms.Label();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.lblInfoObrigatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlBasico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.ckbProfessor);
            this.pnlBasico.Controls.Add(this.ckbAtivo);
            this.pnlBasico.Controls.Add(this.ckbAdmin);
            this.pnlBasico.Controls.Add(this.lblNome);
            this.pnlBasico.Controls.Add(this.txtNome);
            this.pnlBasico.Controls.Add(this.lblSenha);
            this.pnlBasico.Controls.Add(this.txtSenha);
            this.pnlBasico.Controls.Add(this.lblLogin);
            this.pnlBasico.Controls.Add(this.txtLogin);
            this.pnlBasico.Controls.Add(this.lblID);
            this.pnlBasico.Controls.Add(this.txtID);
            this.pnlBasico.Controls.Add(this.lblBasicoHeader);
            this.pnlBasico.Controls.Add(this.cboProfessor);
            this.pnlBasico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasico.Location = new System.Drawing.Point(0, 0);
            this.pnlBasico.Name = "pnlBasico";
            this.pnlBasico.Size = new System.Drawing.Size(784, 202);
            this.pnlBasico.TabIndex = 0;
            // 
            // ckbProfessor
            // 
            this.ckbProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbProfessor.AutoSize = true;
            this.ckbProfessor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ckbProfessor.Location = new System.Drawing.Point(168, 159);
            this.ckbProfessor.Name = "ckbProfessor";
            this.ckbProfessor.Size = new System.Drawing.Size(83, 21);
            this.ckbProfessor.TabIndex = 23;
            this.ckbProfessor.Text = "Professor";
            this.ckbProfessor.UseVisualStyleBackColor = true;
            this.ckbProfessor.CheckedChanged += new System.EventHandler(this.ckbProfessor_CheckedChanged);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ckbAtivo.Location = new System.Drawing.Point(374, 159);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(56, 21);
            this.ckbAtivo.TabIndex = 21;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ckbAdmin.Location = new System.Drawing.Point(258, 159);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(110, 21);
            this.ckbAdmin.TabIndex = 20;
            this.ckbAdmin.Text = "Administrador";
            this.ckbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(279, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(282, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 25);
            this.txtNome.TabIndex = 16;
            this.txtNome.Tag = "*";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(397, 99);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 17);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha *";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(400, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(225, 25);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Tag = "";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(165, 99);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 17);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Login *";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(168, 119);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(225, 25);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Tag = "";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(165, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 17);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Cód.";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(168, 71);
            this.txtID.MaxLength = 14;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(108, 25);
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "";
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
            // cboProfessor
            // 
            this.cboProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfessor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(282, 71);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(343, 25);
            this.cboProfessor.TabIndex = 22;
            this.cboProfessor.Visible = false;
            // 
            // lblInfoObrigatorio
            // 
            this.lblInfoObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoObrigatorio.AutoSize = true;
            this.lblInfoObrigatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(255, 199);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 13;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(398, 230);
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
            this.btnSalvar.Location = new System.Drawing.Point(234, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmUsuarioEdicao
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
            this.Name = "FrmUsuarioEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlBasico.ResumeLayout(false);
            this.pnlBasico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasico;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBasicoHeader;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblInfoObrigatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbAdmin;
        private System.Windows.Forms.CheckBox ckbProfessor;
        private System.Windows.Forms.ComboBox cboProfessor;
    }
}