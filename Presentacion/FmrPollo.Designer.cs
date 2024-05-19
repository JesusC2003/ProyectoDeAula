namespace Presentacion
{
    partial class FmrPollo
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
            this.CboEstadoPollo = new System.Windows.Forms.ComboBox();
            this.txtPesopollo = new System.Windows.Forms.TextBox();
            this.txtidentifiacionpollo = new System.Windows.Forms.TextBox();
            this.CboRazapollo = new System.Windows.Forms.ComboBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalirPollo = new System.Windows.Forms.Button();
            this.BtnBuscarPollo = new System.Windows.Forms.Button();
            this.BtnEliminarPollo = new System.Windows.Forms.Button();
            this.BtnModificarPollo = new System.Windows.Forms.Button();
            this.BtnGuardarPollo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboEstadoPollo
            // 
            this.CboEstadoPollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoPollo.FormattingEnabled = true;
            this.CboEstadoPollo.Items.AddRange(new object[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.CboEstadoPollo.Location = new System.Drawing.Point(273, 145);
            this.CboEstadoPollo.Name = "CboEstadoPollo";
            this.CboEstadoPollo.Size = new System.Drawing.Size(193, 24);
            this.CboEstadoPollo.TabIndex = 77;
            // 
            // txtPesopollo
            // 
            this.txtPesopollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesopollo.Location = new System.Drawing.Point(273, 382);
            this.txtPesopollo.Name = "txtPesopollo";
            this.txtPesopollo.Size = new System.Drawing.Size(193, 21);
            this.txtPesopollo.TabIndex = 76;
            // 
            // txtidentifiacionpollo
            // 
            this.txtidentifiacionpollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentifiacionpollo.Location = new System.Drawing.Point(273, 85);
            this.txtidentifiacionpollo.Name = "txtidentifiacionpollo";
            this.txtidentifiacionpollo.Size = new System.Drawing.Size(193, 21);
            this.txtidentifiacionpollo.TabIndex = 75;
            // 
            // CboRazapollo
            // 
            this.CboRazapollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRazapollo.FormattingEnabled = true;
            this.CboRazapollo.Items.AddRange(new object[] {
            "Ross",
            "Hubbard",
            "Red Ranger",
            "Cornish Cross",
            "Broiler",
            "Cobb 500"});
            this.CboRazapollo.Location = new System.Drawing.Point(273, 320);
            this.CboRazapollo.Name = "CboRazapollo";
            this.CboRazapollo.Size = new System.Drawing.Size(193, 24);
            this.CboRazapollo.TabIndex = 74;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(273, 260);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaSalida.TabIndex = 73;
            this.dtpFechaSalida.Value = new System.DateTime(2024, 5, 18, 0, 0, 0, 0);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(273, 205);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaIngreso.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "RazaPollo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "FechaSalida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "FechaIngreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Id_Pollo";
            // 
            // BtnSalirPollo
            // 
            this.BtnSalirPollo.BackColor = System.Drawing.Color.Red;
            this.BtnSalirPollo.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirPollo.Location = new System.Drawing.Point(626, 0);
            this.BtnSalirPollo.Name = "BtnSalirPollo";
            this.BtnSalirPollo.Size = new System.Drawing.Size(52, 38);
            this.BtnSalirPollo.TabIndex = 82;
            this.BtnSalirPollo.UseVisualStyleBackColor = false;
            // 
            // BtnBuscarPollo
            // 
            this.BtnBuscarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnBuscarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarPollo.Image = global::Presentacion.Properties.Resources.busqueda;
            this.BtnBuscarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarPollo.Location = new System.Drawing.Point(544, 471);
            this.BtnBuscarPollo.Name = "BtnBuscarPollo";
            this.BtnBuscarPollo.Size = new System.Drawing.Size(122, 38);
            this.BtnBuscarPollo.TabIndex = 81;
            this.BtnBuscarPollo.Text = "Buscar";
            this.BtnBuscarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarPollo
            // 
            this.BtnEliminarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarPollo.Image = global::Presentacion.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.BtnEliminarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarPollo.Location = new System.Drawing.Point(373, 471);
            this.BtnEliminarPollo.Name = "BtnEliminarPollo";
            this.BtnEliminarPollo.Size = new System.Drawing.Size(136, 38);
            this.BtnEliminarPollo.TabIndex = 80;
            this.BtnEliminarPollo.Text = "Eliminar";
            this.BtnEliminarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnModificarPollo
            // 
            this.BtnModificarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarPollo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnModificarPollo.Image = global::Presentacion.Properties.Resources.edit_modify_icon_149489__1_;
            this.BtnModificarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarPollo.Location = new System.Drawing.Point(193, 471);
            this.BtnModificarPollo.Name = "BtnModificarPollo";
            this.BtnModificarPollo.Size = new System.Drawing.Size(146, 38);
            this.BtnModificarPollo.TabIndex = 79;
            this.BtnModificarPollo.Text = "Modificar";
            this.BtnModificarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarPollo
            // 
            this.BtnGuardarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarPollo.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnGuardarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarPollo.Location = new System.Drawing.Point(12, 473);
            this.BtnGuardarPollo.Name = "BtnGuardarPollo";
            this.BtnGuardarPollo.Size = new System.Drawing.Size(132, 38);
            this.BtnGuardarPollo.TabIndex = 78;
            this.BtnGuardarPollo.Text = "Guardar";
            this.BtnGuardarPollo.UseVisualStyleBackColor = false;
            // 
            // FmrPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 511);
            this.Controls.Add(this.BtnSalirPollo);
            this.Controls.Add(this.BtnBuscarPollo);
            this.Controls.Add(this.BtnEliminarPollo);
            this.Controls.Add(this.BtnModificarPollo);
            this.Controls.Add(this.BtnGuardarPollo);
            this.Controls.Add(this.CboEstadoPollo);
            this.Controls.Add(this.txtPesopollo);
            this.Controls.Add(this.txtidentifiacionpollo);
            this.Controls.Add(this.CboRazapollo);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPollo";
            this.Text = "FmrPollo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalirPollo;
        private System.Windows.Forms.Button BtnBuscarPollo;
        private System.Windows.Forms.Button BtnEliminarPollo;
        private System.Windows.Forms.Button BtnModificarPollo;
        private System.Windows.Forms.Button BtnGuardarPollo;
        private System.Windows.Forms.ComboBox CboEstadoPollo;
        private System.Windows.Forms.TextBox txtPesopollo;
        private System.Windows.Forms.TextBox txtidentifiacionpollo;
        private System.Windows.Forms.ComboBox CboRazapollo;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}