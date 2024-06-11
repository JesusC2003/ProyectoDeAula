namespace Presentacion
{
    partial class frmAgregarPollo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRazaPollo = new System.Windows.Forms.ComboBox();
            this.btnSalirPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.txtEstadoPollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoPollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos de Pollo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRazaPollo
            // 
            this.cmbRazaPollo.AutoCompleteCustomSource.AddRange(new string[] {
            "Avian",
            "Arbor Acres",
            "Cobb 500",
            "Ross 308",
            "Hubbard"});
            this.cmbRazaPollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRazaPollo.FormattingEnabled = true;
            this.cmbRazaPollo.Items.AddRange(new object[] {
            "Hubbard",
            "Ross 308",
            "Cobb 500",
            "Arbor Acres",
            "Avian"});
            this.cmbRazaPollo.Location = new System.Drawing.Point(179, 142);
            this.cmbRazaPollo.Name = "cmbRazaPollo";
            this.cmbRazaPollo.Size = new System.Drawing.Size(193, 24);
            this.cmbRazaPollo.TabIndex = 5;
            // 
            // btnSalirPollo
            // 
            this.btnSalirPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirPollo.BorderRadius = 12;
            this.btnSalirPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSalirPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalirPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalirPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnSalirPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalirPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnSalirPollo.Image = global::Presentacion.Properties.Resources.icons8_logout_321;
            this.btnSalirPollo.Location = new System.Drawing.Point(421, 282);
            this.btnSalirPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirPollo.Name = "btnSalirPollo";
            this.btnSalirPollo.Size = new System.Drawing.Size(39, 25);
            this.btnSalirPollo.TabIndex = 144;
            this.btnSalirPollo.TextFormatNoPrefix = true;
            this.btnSalirPollo.Click += new System.EventHandler(this.btnSalirPollo_Click_1);
            // 
            // btnAñadirVentas
            // 
            this.btnAñadirVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirVentas.BorderRadius = 12;
            this.btnAñadirVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirVentas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirVentas.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirVentas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirVentas.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirVentas.Location = new System.Drawing.Point(-320, 136);
            this.btnAñadirVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirVentas.Name = "btnAñadirVentas";
            this.btnAñadirVentas.Size = new System.Drawing.Size(100, 40);
            this.btnAñadirVentas.TabIndex = 143;
            this.btnAñadirVentas.Text = "Añadir";
            this.btnAñadirVentas.TextFormatNoPrefix = true;
            // 
            // btnAgregarPollo
            // 
            this.btnAgregarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPollo.BorderRadius = 12;
            this.btnAgregarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnAgregarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAgregarPollo.Image = global::Presentacion.Properties.Resources.new_file_40454;
            this.btnAgregarPollo.Location = new System.Drawing.Point(179, 281);
            this.btnAgregarPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPollo.Name = "btnAgregarPollo";
            this.btnAgregarPollo.Size = new System.Drawing.Size(123, 25);
            this.btnAgregarPollo.TabIndex = 145;
            this.btnAgregarPollo.Text = "Agregar";
            this.btnAgregarPollo.TextFormatNoPrefix = true;
            // 
            // txtEstadoPollo
            // 
            this.txtEstadoPollo.AutoSize = true;
            this.txtEstadoPollo.BorderColor = System.Drawing.Color.Silver;
            this.txtEstadoPollo.BorderRadius = 5;
            this.txtEstadoPollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadoPollo.DefaultText = "";
            this.txtEstadoPollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstadoPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstadoPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoPollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoPollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoPollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoPollo.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoPollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoPollo.Location = new System.Drawing.Point(179, 196);
            this.txtEstadoPollo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoPollo.Name = "txtEstadoPollo";
            this.txtEstadoPollo.PasswordChar = '\0';
            this.txtEstadoPollo.PlaceholderText = "";
            this.txtEstadoPollo.SelectedText = "";
            this.txtEstadoPollo.Size = new System.Drawing.Size(193, 23);
            this.txtEstadoPollo.TabIndex = 153;
            // 
            // txtCodigoPollo
            // 
            this.txtCodigoPollo.AutoSize = true;
            this.txtCodigoPollo.BorderColor = System.Drawing.Color.Silver;
            this.txtCodigoPollo.BorderRadius = 5;
            this.txtCodigoPollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPollo.DefaultText = "";
            this.txtCodigoPollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoPollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoPollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoPollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPollo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoPollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoPollo.Location = new System.Drawing.Point(179, 80);
            this.txtCodigoPollo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPollo.Name = "txtCodigoPollo";
            this.txtCodigoPollo.PasswordChar = '\0';
            this.txtCodigoPollo.PlaceholderText = "";
            this.txtCodigoPollo.SelectedText = "";
            this.txtCodigoPollo.Size = new System.Drawing.Size(193, 23);
            this.txtCodigoPollo.TabIndex = 154;
            // 
            // frmAgregarPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.txtCodigoPollo);
            this.Controls.Add(this.txtEstadoPollo);
            this.Controls.Add(this.btnAgregarPollo);
            this.Controls.Add(this.btnSalirPollo);
            this.Controls.Add(this.btnAñadirVentas);
            this.Controls.Add(this.cmbRazaPollo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarPollo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarPollo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRazaPollo;
        private Guna.UI2.WinForms.Guna2Button btnSalirPollo;
        private Guna.UI2.WinForms.Guna2Button btnAñadirVentas;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPollo;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoPollo;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoPollo;
    }
}