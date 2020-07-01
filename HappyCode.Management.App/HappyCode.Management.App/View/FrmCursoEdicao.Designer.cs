namespace HappyCode.Management.App
{
    partial class FrmCursoEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBasicoHeader = new System.Windows.Forms.Label();
            this.lblInfoObrigatorio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblNumAulas = new System.Windows.Forms.Label();
            this.txtNumAulas = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlBasico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.lblCargaHoraria);
            this.pnlBasico.Controls.Add(this.txtCargaHoraria);
            this.pnlBasico.Controls.Add(this.lblNumAulas);
            this.pnlBasico.Controls.Add(this.txtNumAulas);
            this.pnlBasico.Controls.Add(this.lblNome);
            this.pnlBasico.Controls.Add(this.txtNome);
            this.pnlBasico.Controls.Add(this.lblObservacoes);
            this.pnlBasico.Controls.Add(this.txtObservacoes);
            this.pnlBasico.Controls.Add(this.lblConteudo);
            this.pnlBasico.Controls.Add(this.txtConteudo);
            this.pnlBasico.Controls.Add(this.lblID);
            this.pnlBasico.Controls.Add(this.txtID);
            this.pnlBasico.Controls.Add(this.lblBasicoHeader);
            this.pnlBasico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasico.Location = new System.Drawing.Point(0, 0);
            this.pnlBasico.Name = "pnlBasico";
            this.pnlBasico.Size = new System.Drawing.Size(784, 372);
            this.pnlBasico.TabIndex = 0;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.Black;
            this.lblObservacoes.Location = new System.Drawing.Point(65, 223);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(84, 17);
            this.lblObservacoes.TabIndex = 15;
            this.lblObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.Black;
            this.txtObservacoes.Location = new System.Drawing.Point(68, 243);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(645, 111);
            this.txtObservacoes.TabIndex = 5;
            this.txtObservacoes.Tag = "";
            // 
            // lblConteudo
            // 
            this.lblConteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.ForeColor = System.Drawing.Color.Black;
            this.lblConteudo.Location = new System.Drawing.Point(65, 89);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(74, 17);
            this.lblConteudo.TabIndex = 13;
            this.lblConteudo.Text = "Conteudo *";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConteudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.ForeColor = System.Drawing.Color.Black;
            this.txtConteudo.Location = new System.Drawing.Point(68, 109);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(645, 111);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Tag = "*";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(65, 41);
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
            this.txtID.Location = new System.Drawing.Point(68, 61);
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
            // lblInfoObrigatorio
            // 
            this.lblInfoObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoObrigatorio.AutoSize = true;
            this.lblInfoObrigatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(259, 368);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 13;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(402, 399);
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
            this.btnSalvar.Location = new System.Drawing.Point(238, 399);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.lblCargaHoraria.Location = new System.Drawing.Point(590, 41);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(100, 17);
            this.lblCargaHoraria.TabIndex = 21;
            this.lblCargaHoraria.Text = "Carga Horária *";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCargaHoraria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.txtCargaHoraria.Location = new System.Drawing.Point(593, 61);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(120, 25);
            this.txtCargaHoraria.TabIndex = 18;
            this.txtCargaHoraria.Tag = "*";
            // 
            // lblNumAulas
            // 
            this.lblNumAulas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumAulas.AutoSize = true;
            this.lblNumAulas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAulas.ForeColor = System.Drawing.Color.Black;
            this.lblNumAulas.Location = new System.Drawing.Point(464, 41);
            this.lblNumAulas.Name = "lblNumAulas";
            this.lblNumAulas.Size = new System.Drawing.Size(82, 17);
            this.lblNumAulas.TabIndex = 20;
            this.lblNumAulas.Text = "№ de Aulas*";
            // 
            // txtNumAulas
            // 
            this.txtNumAulas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumAulas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAulas.ForeColor = System.Drawing.Color.Black;
            this.txtNumAulas.Location = new System.Drawing.Point(467, 61);
            this.txtNumAulas.Name = "txtNumAulas";
            this.txtNumAulas.Size = new System.Drawing.Size(120, 25);
            this.txtNumAulas.TabIndex = 17;
            this.txtNumAulas.Tag = "*";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(179, 41);
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
            this.txtNome.Location = new System.Drawing.Point(182, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 25);
            this.txtNome.TabIndex = 16;
            this.txtNome.Tag = "*";
            // 
            // FrmCursoEdicao
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
            this.Name = "FrmCursoEdicao";
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
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblInfoObrigatorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label lblNumAulas;
        private System.Windows.Forms.TextBox txtNumAulas;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}