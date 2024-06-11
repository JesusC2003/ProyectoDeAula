namespace Presentacion
{
    partial class frmAgregarGalpon
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstadoGalpon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarGalpon = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalirGalpon = new Guna.UI2.WinForms.Guna2Button();
            this.txtAreaGalpon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoGalpon = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datos de Galpon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEstadoGalpon
            // 
            this.cmbEstadoGalpon.AutoCompleteCustomSource.AddRange(new string[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.cmbEstadoGalpon.FormattingEnabled = true;
            this.cmbEstadoGalpon.Items.AddRange(new object[] {
            "Mantenimiento",
            "Disponible"});
            this.cmbEstadoGalpon.Location = new System.Drawing.Point(176, 201);
            this.cmbEstadoGalpon.Name = "cmbEstadoGalpon";
            this.cmbEstadoGalpon.Size = new System.Drawing.Size(181, 21);
            this.cmbEstadoGalpon.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 127;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 131;
            this.label3.Text = "Area";
            // 
            // btnAgregarGalpon
            // 
            this.btnAgregarGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarGalpon.BorderRadius = 12;
            this.btnAgregarGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnAgregarGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAgregarGalpon.Image = global::Presentacion.Properties.Resources.new_file_40454;
            this.btnAgregarGalpon.Location = new System.Drawing.Point(175, 279);
            this.btnAgregarGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarGalpon.Name = "btnAgregarGalpon";
            this.btnAgregarGalpon.Size = new System.Drawing.Size(123, 25);
            this.btnAgregarGalpon.TabIndex = 149;
            this.btnAgregarGalpon.Text = "Agregar";
            this.btnAgregarGalpon.TextFormatNoPrefix = true;
            // 
            // btnSalirGalpon
            // 
            this.btnSalirGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirGalpon.BorderRadius = 12;
            this.btnSalirGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSalirGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalirGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalirGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnSalirGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalirGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnSalirGalpon.Image = global::Presentacion.Properties.Resources.icons8_logout_321;
            this.btnSalirGalpon.Location = new System.Drawing.Point(423, 281);
            this.btnSalirGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirGalpon.Name = "btnSalirGalpon";
            this.btnSalirGalpon.Size = new System.Drawing.Size(39, 25);
            this.btnSalirGalpon.TabIndex = 148;
            this.btnSalirGalpon.TextFormatNoPrefix = true;
            this.btnSalirGalpon.Click += new System.EventHandler(this.btnSalirGalpon_Click_1);
            // 
            // txtAreaGalpon
            // 
            this.txtAreaGalpon.AutoSize = true;
            this.txtAreaGalpon.BorderColor = System.Drawing.Color.Silver;
            this.txtAreaGalpon.BorderRadius = 5;
            this.txtAreaGalpon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaGalpon.DefaultText = "";
            this.txtAreaGalpon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAreaGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAreaGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAreaGalpon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAreaGalpon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAreaGalpon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaGalpon.ForeColor = System.Drawing.Color.Black;
            this.txtAreaGalpon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAreaGalpon.Location = new System.Drawing.Point(177, 138);
            this.txtAreaGalpon.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaGalpon.Name = "txtAreaGalpon";
            this.txtAreaGalpon.PasswordChar = '\0';
            this.txtAreaGalpon.PlaceholderText = "";
            this.txtAreaGalpon.SelectedText = "";
            this.txtAreaGalpon.Size = new System.Drawing.Size(180, 24);
            this.txtAreaGalpon.TabIndex = 153;
            // 
            // txtCodigoGalpon
            // 
            this.txtCodigoGalpon.AutoSize = true;
            this.txtCodigoGalpon.BorderColor = System.Drawing.Color.Silver;
            this.txtCodigoGalpon.BorderRadius = 5;
            this.txtCodigoGalpon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoGalpon.DefaultText = "";
            this.txtCodigoGalpon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoGalpon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoGalpon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoGalpon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoGalpon.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoGalpon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoGalpon.Location = new System.Drawing.Point(177, 74);
            this.txtCodigoGalpon.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoGalpon.Name = "txtCodigoGalpon";
            this.txtCodigoGalpon.PasswordChar = '\0';
            this.txtCodigoGalpon.PlaceholderText = "";
            this.txtCodigoGalpon.SelectedText = "";
            this.txtCodigoGalpon.Size = new System.Drawing.Size(180, 23);
            this.txtCodigoGalpon.TabIndex = 154;
            // 
            // frmAgregarGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.txtCodigoGalpon);
            this.Controls.Add(this.txtAreaGalpon);
            this.Controls.Add(this.btnAgregarGalpon);
            this.Controls.Add(this.btnSalirGalpon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEstadoGalpon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarGalpon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarGalpon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstadoGalpon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAgregarGalpon;
        private Guna.UI2.WinForms.Guna2Button btnSalirGalpon;
        private Guna.UI2.WinForms.Guna2TextBox txtAreaGalpon;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoGalpon;
    }
}