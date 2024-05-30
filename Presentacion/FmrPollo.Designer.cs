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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CboEstadoPollo = new System.Windows.Forms.ComboBox();
            this.txtCodigopollo = new System.Windows.Forms.TextBox();
            this.CboRazapollo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarPollo = new System.Windows.Forms.Button();
            this.BtnModificarPollo = new System.Windows.Forms.Button();
            this.BtnGuardarPollo = new System.Windows.Forms.Button();
            this.dtgPollo = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPollo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSalirPollo = new System.Windows.Forms.PictureBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCodigoPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarPollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirPollo)).BeginInit();
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
            this.CboEstadoPollo.Location = new System.Drawing.Point(262, 170);
            this.CboEstadoPollo.Name = "CboEstadoPollo";
            this.CboEstadoPollo.Size = new System.Drawing.Size(193, 24);
            this.CboEstadoPollo.TabIndex = 77;
            // 
            // txtCodigopollo
            // 
            this.txtCodigopollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigopollo.Location = new System.Drawing.Point(262, 68);
            this.txtCodigopollo.Name = "txtCodigopollo";
            this.txtCodigopollo.Size = new System.Drawing.Size(193, 21);
            this.txtCodigopollo.TabIndex = 75;
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
            this.CboRazapollo.Location = new System.Drawing.Point(262, 121);
            this.CboRazapollo.Name = "CboRazapollo";
            this.CboRazapollo.Size = new System.Drawing.Size(193, 24);
            this.CboRazapollo.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "RazaPollo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "FechaIngreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Codigo";
            // 
            // BtnEliminarPollo
            // 
            this.BtnEliminarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminarPollo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarPollo.Image = global::Presentacion.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.BtnEliminarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarPollo.Location = new System.Drawing.Point(480, 279);
            this.BtnEliminarPollo.Name = "BtnEliminarPollo";
            this.BtnEliminarPollo.Size = new System.Drawing.Size(136, 38);
            this.BtnEliminarPollo.TabIndex = 80;
            this.BtnEliminarPollo.Text = "Eliminar";
            this.BtnEliminarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnModificarPollo
            // 
            this.BtnModificarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarPollo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnModificarPollo.Image = global::Presentacion.Properties.Resources.edit_modify_icon_149489__1_;
            this.BtnModificarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarPollo.Location = new System.Drawing.Point(239, 279);
            this.BtnModificarPollo.Name = "BtnModificarPollo";
            this.BtnModificarPollo.Size = new System.Drawing.Size(146, 38);
            this.BtnModificarPollo.TabIndex = 79;
            this.BtnModificarPollo.Text = "Modificar";
            this.BtnModificarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarPollo
            // 
            this.BtnGuardarPollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardarPollo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarPollo.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarPollo.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnGuardarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarPollo.Location = new System.Drawing.Point(26, 279);
            this.BtnGuardarPollo.Name = "BtnGuardarPollo";
            this.BtnGuardarPollo.Size = new System.Drawing.Size(132, 38);
            this.BtnGuardarPollo.TabIndex = 78;
            this.BtnGuardarPollo.Text = "Guardar";
            this.BtnGuardarPollo.UseVisualStyleBackColor = false;
            // 
            // dtgPollo
            // 
            this.dtgPollo.AllowUserToAddRows = false;
            this.dtgPollo.AllowUserToDeleteRows = false;
            this.dtgPollo.AllowUserToResizeColumns = false;
            this.dtgPollo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPollo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPollo.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgPollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPollo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgPollo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPollo.ColumnHeadersHeight = 24;
            this.dtgPollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPollo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmCodigoPollo,
            this.ClmRaza,
            this.ClmEstado,
            this.ClmFechaIngreso});
            this.dtgPollo.EnableHeadersVisualStyles = false;
            this.dtgPollo.Location = new System.Drawing.Point(59, 314);
            this.dtgPollo.MultiSelect = false;
            this.dtgPollo.Name = "dtgPollo";
            this.dtgPollo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPollo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPollo.RowHeadersVisible = false;
            this.dtgPollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPollo.Size = new System.Drawing.Size(521, 234);
            this.dtgPollo.TabIndex = 108;
            // 
            // BtnBuscarPollo
            // 
            this.BtnBuscarPollo.BackColor = System.Drawing.Color.DimGray;
            this.BtnBuscarPollo.Image = global::Presentacion.Properties.Resources.busqueda;
            this.BtnBuscarPollo.Location = new System.Drawing.Point(452, 68);
            this.BtnBuscarPollo.Name = "BtnBuscarPollo";
            this.BtnBuscarPollo.Size = new System.Drawing.Size(27, 21);
            this.BtnBuscarPollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnBuscarPollo.TabIndex = 112;
            this.BtnBuscarPollo.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(677, 29);
            this.label7.TabIndex = 114;
            this.label7.Text = "Información Pollo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalirPollo
            // 
            this.BtnSalirPollo.BackColor = System.Drawing.Color.Red;
            this.BtnSalirPollo.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirPollo.Location = new System.Drawing.Point(653, 0);
            this.BtnSalirPollo.Name = "BtnSalirPollo";
            this.BtnSalirPollo.Size = new System.Drawing.Size(24, 29);
            this.BtnSalirPollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirPollo.TabIndex = 115;
            this.BtnSalirPollo.TabStop = false;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(262, 220);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaIngreso.TabIndex = 72;
            // 
            // ClmID
            // 
            this.ClmID.FillWeight = 96.8818F;
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Width = 50;
            // 
            // ClmCodigoPollo
            // 
            this.ClmCodigoPollo.FillWeight = 96.8818F;
            this.ClmCodigoPollo.HeaderText = "Codigo Pollo";
            this.ClmCodigoPollo.MinimumWidth = 6;
            this.ClmCodigoPollo.Name = "ClmCodigoPollo";
            this.ClmCodigoPollo.ReadOnly = true;
            this.ClmCodigoPollo.Width = 120;
            // 
            // ClmRaza
            // 
            this.ClmRaza.FillWeight = 96.8818F;
            this.ClmRaza.HeaderText = "Raza Pollo";
            this.ClmRaza.MinimumWidth = 6;
            this.ClmRaza.Name = "ClmRaza";
            this.ClmRaza.ReadOnly = true;
            this.ClmRaza.Width = 125;
            // 
            // ClmEstado
            // 
            this.ClmEstado.FillWeight = 96.8818F;
            this.ClmEstado.HeaderText = "Estado Salud";
            this.ClmEstado.MinimumWidth = 6;
            this.ClmEstado.Name = "ClmEstado";
            this.ClmEstado.ReadOnly = true;
            this.ClmEstado.Width = 125;
            // 
            // ClmFechaIngreso
            // 
            this.ClmFechaIngreso.FillWeight = 96.8818F;
            this.ClmFechaIngreso.HeaderText = "Fecha Ingreso";
            this.ClmFechaIngreso.MinimumWidth = 6;
            this.ClmFechaIngreso.Name = "ClmFechaIngreso";
            this.ClmFechaIngreso.ReadOnly = true;
            // 
            // FmrPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 560);
            this.Controls.Add(this.BtnSalirPollo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBuscarPollo);
            this.Controls.Add(this.dtgPollo);
            this.Controls.Add(this.BtnEliminarPollo);
            this.Controls.Add(this.BtnModificarPollo);
            this.Controls.Add(this.BtnGuardarPollo);
            this.Controls.Add(this.CboEstadoPollo);
            this.Controls.Add(this.txtCodigopollo);
            this.Controls.Add(this.CboRazapollo);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPollo";
            this.Text = "FmrPollo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarPollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirPollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminarPollo;
        private System.Windows.Forms.Button BtnModificarPollo;
        private System.Windows.Forms.Button BtnGuardarPollo;
        private System.Windows.Forms.ComboBox CboEstadoPollo;
        private System.Windows.Forms.TextBox txtCodigopollo;
        private System.Windows.Forms.ComboBox CboRazapollo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPollo;
        private System.Windows.Forms.PictureBox BtnBuscarPollo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BtnSalirPollo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaIngreso;
    }
}