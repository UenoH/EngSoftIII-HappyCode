namespace HappyCode.Management.App
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.picWT = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlCadastros = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWT)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlTop.Controls.Add(this.lblForm);
            this.pnlTop.Controls.Add(this.picWT);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // lblForm
            // 
            this.lblForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblForm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(311, 17);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(439, 32);
            this.lblForm.TabIndex = 4;
            this.lblForm.Text = "Página Inicial";
            this.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picWT
            // 
            this.picWT.BackgroundImage = global::HappyCode.Management.App.Properties.Resources.Logo;
            this.picWT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWT.ErrorImage = null;
            this.picWT.Image = global::HappyCode.Management.App.Properties.Resources.Logo_bg;
            this.picWT.Location = new System.Drawing.Point(7, 12);
            this.picWT.Name = "picWT";
            this.picWT.Size = new System.Drawing.Size(42, 42);
            this.picWT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWT.TabIndex = 3;
            this.picWT.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::HappyCode.Management.App.Properties.Resources.Shutdown_White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(870, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(55, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciador de Aulas";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(217, 65);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(703, 410);
            this.pnlForm.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 475);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(920, 25);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "HappyCode (c) 2020";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnAluno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Location = new System.Drawing.Point(0, 49);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(217, 33);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "                Alunos";
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTurma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnTurma.ForeColor = System.Drawing.Color.White;
            this.btnTurma.Location = new System.Drawing.Point(0, 148);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(217, 33);
            this.btnTurma.TabIndex = 1;
            this.btnTurma.Text = "                Turmas";
            this.btnTurma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurma.UseVisualStyleBackColor = false;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlControls.Controls.Add(this.pnlCadastros);
            this.pnlControls.Controls.Add(this.btnLogoff);
            this.pnlControls.Controls.Add(this.btnAulas);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 65);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(217, 410);
            this.pnlControls.TabIndex = 1;
            // 
            // pnlCadastros
            // 
            this.pnlCadastros.Controls.Add(this.btnUsuario);
            this.pnlCadastros.Controls.Add(this.btnTurma);
            this.pnlCadastros.Controls.Add(this.btnCurso);
            this.pnlCadastros.Controls.Add(this.btnProfessor);
            this.pnlCadastros.Controls.Add(this.btnAluno);
            this.pnlCadastros.Controls.Add(this.btnCadastro);
            this.pnlCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastros.Location = new System.Drawing.Point(0, 49);
            this.pnlCadastros.Name = "pnlCadastros";
            this.pnlCadastros.Size = new System.Drawing.Size(217, 49);
            this.pnlCadastros.TabIndex = 0;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 181);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(217, 33);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "                Usuários";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurso.FlatAppearance.BorderSize = 0;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnCurso.ForeColor = System.Drawing.Color.White;
            this.btnCurso.Location = new System.Drawing.Point(0, 115);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(217, 33);
            this.btnCurso.TabIndex = 6;
            this.btnCurso.Text = "                Cursos";
            this.btnCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurso.UseVisualStyleBackColor = false;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnProfessor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Location = new System.Drawing.Point(0, 82);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(217, 33);
            this.btnProfessor.TabIndex = 3;
            this.btnProfessor.Text = "                Professores";
            this.btnProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(217, 49);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "        Cadastros";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogoff.FlatAppearance.BorderSize = 0;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.ForeColor = System.Drawing.Color.White;
            this.btnLogoff.Location = new System.Drawing.Point(0, 361);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(217, 49);
            this.btnLogoff.TabIndex = 4;
            this.btnLogoff.Text = "        Sair";
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAulas.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulas.ForeColor = System.Drawing.Color.White;
            this.btnAulas.Location = new System.Drawing.Point(0, 0);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(217, 49);
            this.btnAulas.TabIndex = 5;
            this.btnAulas.Text = "        Aulas";
            this.btnAulas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAulas.UseVisualStyleBackColor = true;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 500);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyCode Management";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWT)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlCadastros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.PictureBox picWT;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Panel pnlCadastros;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnUsuario;
    }
}