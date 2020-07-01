namespace HappyCode.Management.App
{
    partial class FrmTurmaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmaDia));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(186, 110);
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
            this.btnSalvar.Location = new System.Drawing.Point(22, 110);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Confirmar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpHorario
            // 
            this.dtpHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpHorario.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpHorario.CustomFormat = "HH:MM";
            this.dtpHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorario.Location = new System.Drawing.Point(22, 75);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(154, 25);
            this.dtpHorario.TabIndex = 18;
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(19, 55);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 17);
            this.lblHorario.TabIndex = 17;
            this.lblHorario.Text = "Horario";
            // 
            // cboDia
            // 
            this.cboDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.cboDia.Location = new System.Drawing.Point(22, 28);
            this.cboDia.Margin = new System.Windows.Forms.Padding(2);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(318, 25);
            this.cboDia.TabIndex = 16;
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(19, 9);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(96, 17);
            this.lblDia.TabIndex = 15;
            this.lblDia.Text = "Dia da Semana";
            // 
            // FrmTurmaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 161);
            this.ControlBox = false;
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cboDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTurmaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Label lblDia;
    }
}