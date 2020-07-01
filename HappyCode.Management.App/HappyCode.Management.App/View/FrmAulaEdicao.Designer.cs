namespace HappyCode.Management.App
{
    partial class FrmAulaEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAulaEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.ckbAvaliacao = new System.Windows.Forms.CheckBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cboCursoTurma = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
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
            this.pnlBasico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.ckbAvaliacao);
            this.pnlBasico.Controls.Add(this.lblAssunto);
            this.pnlBasico.Controls.Add(this.txtAssunto);
            this.pnlBasico.Controls.Add(this.dtpData);
            this.pnlBasico.Controls.Add(this.cboCursoTurma);
            this.pnlBasico.Controls.Add(this.lblData);
            this.pnlBasico.Controls.Add(this.lblTurma);
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
            this.pnlBasico.Size = new System.Drawing.Size(784, 392);
            this.pnlBasico.TabIndex = 0;
            // 
            // ckbAvaliacao
            // 
            this.ckbAvaliacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbAvaliacao.AutoSize = true;
            this.ckbAvaliacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ckbAvaliacao.Location = new System.Drawing.Point(625, 113);
            this.ckbAvaliacao.Name = "ckbAvaliacao";
            this.ckbAvaliacao.Size = new System.Drawing.Size(88, 21);
            this.ckbAvaliacao.TabIndex = 24;
            this.ckbAvaliacao.Text = "Avaliação?";
            this.ckbAvaliacao.UseVisualStyleBackColor = true;
            // 
            // lblAssunto
            // 
            this.lblAssunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.Black;
            this.lblAssunto.Location = new System.Drawing.Point(218, 91);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(63, 17);
            this.lblAssunto.TabIndex = 23;
            this.lblAssunto.Text = "Assunto *";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAssunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.ForeColor = System.Drawing.Color.Black;
            this.txtAssunto.Location = new System.Drawing.Point(221, 111);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(398, 25);
            this.txtAssunto.TabIndex = 22;
            this.txtAssunto.Tag = "*";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(68, 111);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(147, 25);
            this.dtpData.TabIndex = 21;
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
            this.cboCursoTurma.Location = new System.Drawing.Point(181, 61);
            this.cboCursoTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cboCursoTurma.Name = "cboCursoTurma";
            this.cboCursoTurma.Size = new System.Drawing.Size(532, 25);
            this.cboCursoTurma.TabIndex = 20;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(65, 91);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(92, 17);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data da Aula *";
            // 
            // lblTurma
            // 
            this.lblTurma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.ForeColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(178, 41);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(93, 17);
            this.lblTurma.TabIndex = 18;
            this.lblTurma.Text = "Curso/Turma *";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.Black;
            this.lblObservacoes.Location = new System.Drawing.Point(65, 271);
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
            this.txtObservacoes.Location = new System.Drawing.Point(68, 291);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(645, 84);
            this.txtObservacoes.TabIndex = 5;
            this.txtObservacoes.Tag = "";
            // 
            // lblConteudo
            // 
            this.lblConteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.ForeColor = System.Drawing.Color.Black;
            this.lblConteudo.Location = new System.Drawing.Point(65, 137);
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
            this.txtConteudo.Location = new System.Drawing.Point(68, 157);
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
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(252, 390);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 13;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(395, 421);
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
            this.btnSalvar.Location = new System.Drawing.Point(231, 421);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAulaEdicao
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
            this.Name = "FrmAulaEdicao";
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
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cboCursoTurma;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.CheckBox ckbAvaliacao;
    }
}