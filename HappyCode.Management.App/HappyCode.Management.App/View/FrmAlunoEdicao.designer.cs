namespace HappyCode.Management.App
{
    partial class FrmAlunoEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunoEdicao));
            this.pnlBasico = new System.Windows.Forms.Panel();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBasicoHeader = new System.Windows.Forms.Label();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.btnCEP = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblEnderecoHeader = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblInfoObrigatorio = new System.Windows.Forms.Label();
            this.pnlContato = new System.Windows.Forms.Panel();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblDDDCel = new System.Windows.Forms.Label();
            this.txtCelDDD = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblDDDFone = new System.Windows.Forms.Label();
            this.txtFoneDDD = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContatoHeader = new System.Windows.Forms.Label();
            this.pnlBasico.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.pnlContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasico
            // 
            this.pnlBasico.Controls.Add(this.cboSexo);
            this.pnlBasico.Controls.Add(this.lblSexo);
            this.pnlBasico.Controls.Add(this.lblDataNasc);
            this.pnlBasico.Controls.Add(this.dtpDataNasc);
            this.pnlBasico.Controls.Add(this.lblCPF);
            this.pnlBasico.Controls.Add(this.txtCPF);
            this.pnlBasico.Controls.Add(this.lblNome);
            this.pnlBasico.Controls.Add(this.txtNome);
            this.pnlBasico.Controls.Add(this.lblBasicoHeader);
            this.pnlBasico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasico.Location = new System.Drawing.Point(0, 0);
            this.pnlBasico.Name = "pnlBasico";
            this.pnlBasico.Size = new System.Drawing.Size(784, 149);
            this.pnlBasico.TabIndex = 0;
            // 
            // cboSexo
            // 
            this.cboSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(479, 109);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(164, 25);
            this.cboSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(476, 90);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 17);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo *";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.Black;
            this.lblDataNasc.Location = new System.Drawing.Point(305, 90);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(117, 17);
            this.lblDataNasc.TabIndex = 9;
            this.lblDataNasc.Text = "Data Nascimento *";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataNasc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(308, 109);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(165, 25);
            this.dtpDataNasc.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(135, 89);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF *";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(138, 109);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(165, 25);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Tag = "*";
            this.txtCPF.Enter += new System.EventHandler(this.Control_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(133, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(138, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(505, 25);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "*";
            this.txtNome.Enter += new System.EventHandler(this.Control_Enter);
            this.txtNome.Leave += new System.EventHandler(this.Control_Leave);
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
            // pnlEndereco
            // 
            this.pnlEndereco.Controls.Add(this.btnCEP);
            this.pnlEndereco.Controls.Add(this.txtEstado);
            this.pnlEndereco.Controls.Add(this.lblEstado);
            this.pnlEndereco.Controls.Add(this.lblCidade);
            this.pnlEndereco.Controls.Add(this.txtCidade);
            this.pnlEndereco.Controls.Add(this.lblBairro);
            this.pnlEndereco.Controls.Add(this.txtBairro);
            this.pnlEndereco.Controls.Add(this.lblComplemento);
            this.pnlEndereco.Controls.Add(this.txtComplemento);
            this.pnlEndereco.Controls.Add(this.lblRua);
            this.pnlEndereco.Controls.Add(this.txtRua);
            this.pnlEndereco.Controls.Add(this.lblNumero);
            this.pnlEndereco.Controls.Add(this.txtNumero);
            this.pnlEndereco.Controls.Add(this.lblCEP);
            this.pnlEndereco.Controls.Add(this.txtCEP);
            this.pnlEndereco.Controls.Add(this.lblEnderecoHeader);
            this.pnlEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEndereco.Location = new System.Drawing.Point(0, 149);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(784, 201);
            this.pnlEndereco.TabIndex = 1;
            // 
            // btnCEP
            // 
            this.btnCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCEP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCEP.Location = new System.Drawing.Point(309, 57);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(28, 28);
            this.btnCEP.TabIndex = 15;
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(602, 164);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(41, 25);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Tag = "*";
            this.txtEstado.Enter += new System.EventHandler(this.Control_Enter);
            this.txtEstado.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(599, 144);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(32, 17);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "UF *";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(376, 144);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 17);
            this.lblCidade.TabIndex = 13;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(379, 164);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(217, 25);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Tag = "*";
            this.txtCidade.Enter += new System.EventHandler(this.Control_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(135, 144);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 17);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro *";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(138, 164);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(235, 25);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.Tag = "*";
            this.txtBairro.Enter += new System.EventHandler(this.Control_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Black;
            this.lblComplemento.Location = new System.Drawing.Point(476, 92);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 17);
            this.lblComplemento.TabIndex = 9;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(479, 112);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(164, 25);
            this.txtComplemento.TabIndex = 3;
            // 
            // lblRua
            // 
            this.lblRua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.Black;
            this.lblRua.Location = new System.Drawing.Point(135, 92);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(39, 17);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua *";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(138, 112);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(235, 25);
            this.txtRua.TabIndex = 1;
            this.txtRua.Tag = "*";
            this.txtRua.Enter += new System.EventHandler(this.Control_Enter);
            this.txtRua.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(379, 92);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(33, 17);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Nº *";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(379, 112);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(94, 25);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Tag = "*";
            this.txtNumero.Enter += new System.EventHandler(this.Control_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Black;
            this.lblCEP.Location = new System.Drawing.Point(135, 39);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 17);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "CEP *";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(138, 59);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(165, 25);
            this.txtCEP.TabIndex = 0;
            this.txtCEP.Tag = "*";
            this.txtCEP.Enter += new System.EventHandler(this.Control_Enter);
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCEP_KeyDown);
            this.txtCEP.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // lblEnderecoHeader
            // 
            this.lblEnderecoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEnderecoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnderecoHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoHeader.ForeColor = System.Drawing.Color.White;
            this.lblEnderecoHeader.Location = new System.Drawing.Point(0, 0);
            this.lblEnderecoHeader.Name = "lblEnderecoHeader";
            this.lblEnderecoHeader.Size = new System.Drawing.Size(784, 28);
            this.lblEnderecoHeader.TabIndex = 1;
            this.lblEnderecoHeader.Text = " Endereço da Aluno";
            this.lblEnderecoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(234, 543);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar Informações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(398, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInfoObrigatorio
            // 
            this.lblInfoObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoObrigatorio.AutoSize = true;
            this.lblInfoObrigatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblInfoObrigatorio.Location = new System.Drawing.Point(255, 512);
            this.lblInfoObrigatorio.Name = "lblInfoObrigatorio";
            this.lblInfoObrigatorio.Size = new System.Drawing.Size(266, 17);
            this.lblInfoObrigatorio.TabIndex = 10;
            this.lblInfoObrigatorio.Text = "Campos marcados com (*) são obrigatórios";
            // 
            // pnlContato
            // 
            this.pnlContato.Controls.Add(this.lblCel);
            this.pnlContato.Controls.Add(this.lblFone);
            this.pnlContato.Controls.Add(this.txtCelular);
            this.pnlContato.Controls.Add(this.lblDDDCel);
            this.pnlContato.Controls.Add(this.txtCelDDD);
            this.pnlContato.Controls.Add(this.txtTelefone);
            this.pnlContato.Controls.Add(this.lblDDDFone);
            this.pnlContato.Controls.Add(this.txtFoneDDD);
            this.pnlContato.Controls.Add(this.lblEmail);
            this.pnlContato.Controls.Add(this.txtEmail);
            this.pnlContato.Controls.Add(this.lblContatoHeader);
            this.pnlContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContato.Location = new System.Drawing.Point(0, 350);
            this.pnlContato.Name = "pnlContato";
            this.pnlContato.Size = new System.Drawing.Size(784, 158);
            this.pnlContato.TabIndex = 2;
            // 
            // lblCel
            // 
            this.lblCel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.Color.Black;
            this.lblCel.Location = new System.Drawing.Point(349, 98);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(48, 17);
            this.lblCel.TabIndex = 13;
            this.lblCel.Text = "Celular";
            // 
            // lblFone
            // 
            this.lblFone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.ForeColor = System.Drawing.Color.Black;
            this.lblFone.Location = new System.Drawing.Point(179, 98);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(57, 17);
            this.lblFone.TabIndex = 12;
            this.lblFone.Text = "Telefone";
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(350, 118);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(93, 25);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.Tag = "";
            // 
            // lblDDDCel
            // 
            this.lblDDDCel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDDDCel.AutoSize = true;
            this.lblDDDCel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDDCel.ForeColor = System.Drawing.Color.Black;
            this.lblDDDCel.Location = new System.Drawing.Point(308, 98);
            this.lblDDDCel.Name = "lblDDDCel";
            this.lblDDDCel.Size = new System.Drawing.Size(35, 17);
            this.lblDDDCel.TabIndex = 10;
            this.lblDDDCel.Text = "DDD";
            // 
            // txtCelDDD
            // 
            this.txtCelDDD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelDDD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelDDD.ForeColor = System.Drawing.Color.Black;
            this.txtCelDDD.Location = new System.Drawing.Point(308, 118);
            this.txtCelDDD.MaxLength = 14;
            this.txtCelDDD.Name = "txtCelDDD";
            this.txtCelDDD.Size = new System.Drawing.Size(36, 25);
            this.txtCelDDD.TabIndex = 3;
            this.txtCelDDD.Tag = "";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(180, 118);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(93, 25);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Tag = "";
            // 
            // lblDDDFone
            // 
            this.lblDDDFone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDDDFone.AutoSize = true;
            this.lblDDDFone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDDFone.ForeColor = System.Drawing.Color.Black;
            this.lblDDDFone.Location = new System.Drawing.Point(138, 98);
            this.lblDDDFone.Name = "lblDDDFone";
            this.lblDDDFone.Size = new System.Drawing.Size(35, 17);
            this.lblDDDFone.TabIndex = 7;
            this.lblDDDFone.Text = "DDD";
            // 
            // txtFoneDDD
            // 
            this.txtFoneDDD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFoneDDD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoneDDD.ForeColor = System.Drawing.Color.Black;
            this.txtFoneDDD.Location = new System.Drawing.Point(138, 118);
            this.txtFoneDDD.MaxLength = 14;
            this.txtFoneDDD.Name = "txtFoneDDD";
            this.txtFoneDDD.Size = new System.Drawing.Size(36, 25);
            this.txtFoneDDD.TabIndex = 1;
            this.txtFoneDDD.Tag = "";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(135, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(138, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(505, 25);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Tag = "";
            // 
            // lblContatoHeader
            // 
            this.lblContatoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblContatoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContatoHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoHeader.ForeColor = System.Drawing.Color.White;
            this.lblContatoHeader.Location = new System.Drawing.Point(0, 0);
            this.lblContatoHeader.Name = "lblContatoHeader";
            this.lblContatoHeader.Size = new System.Drawing.Size(784, 28);
            this.lblContatoHeader.TabIndex = 1;
            this.lblContatoHeader.Text = " Contato";
            this.lblContatoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAlunoEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContato);
            this.Controls.Add(this.lblInfoObrigatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlEndereco);
            this.Controls.Add(this.pnlBasico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 593);
            this.Name = "FrmAlunoEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBasico.ResumeLayout(false);
            this.pnlBasico.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.pnlContato.ResumeLayout(false);
            this.pnlContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasico;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBasicoHeader;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblEnderecoHeader;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInfoObrigatorio;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlContato;
        private System.Windows.Forms.Label lblDDDFone;
        private System.Windows.Forms.TextBox txtFoneDDD;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContatoHeader;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblDDDCel;
        private System.Windows.Forms.TextBox txtCelDDD;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCEP;
    }
}