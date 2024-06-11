namespace Presentacion
{
    partial class frmAgregarAlimento
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
            this.cmbMarcaAlimento = new System.Windows.Forms.ComboBox();
            this.cmbTipoAlimento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarAlimento = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalirAlimento = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigoAlimento = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cmbMarcaAlimento
            // 
            this.cmbMarcaAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaAlimento.FormattingEnabled = true;
            this.cmbMarcaAlimento.Items.AddRange(new object[] {
            "Purina",
            "Avifasa",
            "Italcol"});
            this.cmbMarcaAlimento.Location = new System.Drawing.Point(163, 139);
            this.cmbMarcaAlimento.Name = "cmbMarcaAlimento";
            this.cmbMarcaAlimento.Size = new System.Drawing.Size(193, 24);
            this.cmbMarcaAlimento.TabIndex = 110;
            // 
            // cmbTipoAlimento
            // 
            this.cmbTipoAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAlimento.FormattingEnabled = true;
            this.cmbTipoAlimento.Items.AddRange(new object[] {
            "Iniciación ",
            "Crecimiento",
            "Engorde"});
            this.cmbTipoAlimento.Location = new System.Drawing.Point(163, 187);
            this.cmbTipoAlimento.Name = "cmbTipoAlimento";
            this.cmbTipoAlimento.Size = new System.Drawing.Size(193, 24);
            this.cmbTipoAlimento.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 108;
            this.label6.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 126;
            this.label4.Text = "Datos de Alimento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarAlimento
            // 
            this.btnAgregarAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlimento.BorderRadius = 12;
            this.btnAgregarAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnAgregarAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAgregarAlimento.Image = global::Presentacion.Properties.Resources.new_file_40454;
            this.btnAgregarAlimento.Location = new System.Drawing.Point(173, 280);
            this.btnAgregarAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarAlimento.Name = "btnAgregarAlimento";
            this.btnAgregarAlimento.Size = new System.Drawing.Size(123, 25);
            this.btnAgregarAlimento.TabIndex = 151;
            this.btnAgregarAlimento.Text = "Agregar";
            this.btnAgregarAlimento.TextFormatNoPrefix = true;
            // 
            // btnSalirAlimento
            // 
            this.btnSalirAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirAlimento.BorderRadius = 12;
            this.btnSalirAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSalirAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalirAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalirAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnSalirAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalirAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnSalirAlimento.Image = global::Presentacion.Properties.Resources.icons8_logout_321;
            this.btnSalirAlimento.Location = new System.Drawing.Point(422, 281);
            this.btnSalirAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirAlimento.Name = "btnSalirAlimento";
            this.btnSalirAlimento.Size = new System.Drawing.Size(39, 25);
            this.btnSalirAlimento.TabIndex = 150;
            this.btnSalirAlimento.TextFormatNoPrefix = true;
            this.btnSalirAlimento.Click += new System.EventHandler(this.btnSalirAlimento_Click_1);
            // 
            // txtCodigoAlimento
            // 
            this.txtCodigoAlimento.AutoSize = true;
            this.txtCodigoAlimento.BorderColor = System.Drawing.Color.Silver;
            this.txtCodigoAlimento.BorderRadius = 5;
            this.txtCodigoAlimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoAlimento.DefaultText = "";
            this.txtCodigoAlimento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoAlimento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoAlimento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAlimento.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoAlimento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoAlimento.Location = new System.Drawing.Point(163, 90);
            this.txtCodigoAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAlimento.Name = "txtCodigoAlimento";
            this.txtCodigoAlimento.PasswordChar = '\0';
            this.txtCodigoAlimento.PlaceholderText = "";
            this.txtCodigoAlimento.SelectedText = "";
            this.txtCodigoAlimento.Size = new System.Drawing.Size(193, 23);
            this.txtCodigoAlimento.TabIndex = 152;
            // 
            // frmAgregarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.txtCodigoAlimento);
            this.Controls.Add(this.btnAgregarAlimento);
            this.Controls.Add(this.btnSalirAlimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMarcaAlimento);
            this.Controls.Add(this.cmbTipoAlimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarAlimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarcaAlimento;
        private System.Windows.Forms.ComboBox cmbTipoAlimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAgregarAlimento;
        private Guna.UI2.WinForms.Guna2Button btnSalirAlimento;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoAlimento;
    }
}