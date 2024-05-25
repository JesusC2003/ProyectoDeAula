namespace Presentacion
{
    partial class FmrGalpon
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
            this.BtnEliminarGalpon = new System.Windows.Forms.Button();
            this.BtnModificarGalpon = new System.Windows.Forms.Button();
            this.BtnGuardarGalpon = new System.Windows.Forms.Button();
            this.CboEstadoGalpon = new System.Windows.Forms.ComboBox();
            this.txtIdGalpon = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapacidadMaxima = new System.Windows.Forms.TextBox();
            this.BtnBuscarGalpon = new System.Windows.Forms.PictureBox();
            this.dtgGalpon = new System.Windows.Forms.DataGridView();
            this.ClmIDGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstadoGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmfechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCapacidadGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalirGalpon = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarGalpon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGalpon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirGalpon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminarGalpon
            // 
            this.BtnEliminarGalpon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminarGalpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarGalpon.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarGalpon.Image = global::Presentacion.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.BtnEliminarGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarGalpon.Location = new System.Drawing.Point(485, 201);
            this.BtnEliminarGalpon.Name = "BtnEliminarGalpon";
            this.BtnEliminarGalpon.Size = new System.Drawing.Size(136, 38);
            this.BtnEliminarGalpon.TabIndex = 97;
            this.BtnEliminarGalpon.Text = "Eliminar";
            this.BtnEliminarGalpon.UseVisualStyleBackColor = false;
            // 
            // BtnModificarGalpon
            // 
            this.BtnModificarGalpon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarGalpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarGalpon.ForeColor = System.Drawing.Color.White;
            this.BtnModificarGalpon.Image = global::Presentacion.Properties.Resources.edit_modify_icon_149489__1_;
            this.BtnModificarGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarGalpon.Location = new System.Drawing.Point(251, 201);
            this.BtnModificarGalpon.Name = "BtnModificarGalpon";
            this.BtnModificarGalpon.Size = new System.Drawing.Size(146, 38);
            this.BtnModificarGalpon.TabIndex = 96;
            this.BtnModificarGalpon.Text = "Modificar";
            this.BtnModificarGalpon.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarGalpon
            // 
            this.BtnGuardarGalpon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardarGalpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarGalpon.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarGalpon.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnGuardarGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarGalpon.Location = new System.Drawing.Point(24, 201);
            this.BtnGuardarGalpon.Name = "BtnGuardarGalpon";
            this.BtnGuardarGalpon.Size = new System.Drawing.Size(132, 38);
            this.BtnGuardarGalpon.TabIndex = 95;
            this.BtnGuardarGalpon.Text = "Guardar";
            this.BtnGuardarGalpon.UseVisualStyleBackColor = false;
            // 
            // CboEstadoGalpon
            // 
            this.CboEstadoGalpon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoGalpon.FormattingEnabled = true;
            this.CboEstadoGalpon.Items.AddRange(new object[] {
            "En Uso",
            "Disponible",
            "Mantenimiento"});
            this.CboEstadoGalpon.Location = new System.Drawing.Point(302, 85);
            this.CboEstadoGalpon.Name = "CboEstadoGalpon";
            this.CboEstadoGalpon.Size = new System.Drawing.Size(193, 24);
            this.CboEstadoGalpon.TabIndex = 94;
            // 
            // txtIdGalpon
            // 
            this.txtIdGalpon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGalpon.Location = new System.Drawing.Point(302, 45);
            this.txtIdGalpon.Name = "txtIdGalpon";
            this.txtIdGalpon.Size = new System.Drawing.Size(193, 21);
            this.txtIdGalpon.TabIndex = 92;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(302, 123);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaCreacion.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Capacidad Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Fecha Creacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 84;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID Galpon";
            // 
            // txtCapacidadMaxima
            // 
            this.txtCapacidadMaxima.Location = new System.Drawing.Point(302, 160);
            this.txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            this.txtCapacidadMaxima.Size = new System.Drawing.Size(193, 20);
            this.txtCapacidadMaxima.TabIndex = 100;
            // 
            // BtnBuscarGalpon
            // 
            this.BtnBuscarGalpon.BackColor = System.Drawing.Color.DimGray;
            this.BtnBuscarGalpon.Image = global::Presentacion.Properties.Resources.busqueda;
            this.BtnBuscarGalpon.Location = new System.Drawing.Point(492, 45);
            this.BtnBuscarGalpon.Name = "BtnBuscarGalpon";
            this.BtnBuscarGalpon.Size = new System.Drawing.Size(27, 21);
            this.BtnBuscarGalpon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnBuscarGalpon.TabIndex = 108;
            this.BtnBuscarGalpon.TabStop = false;
            // 
            // dtgGalpon
            // 
            this.dtgGalpon.AllowUserToAddRows = false;
            this.dtgGalpon.AllowUserToDeleteRows = false;
            this.dtgGalpon.AllowUserToResizeColumns = false;
            this.dtgGalpon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgGalpon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGalpon.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgGalpon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgGalpon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgGalpon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGalpon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGalpon.ColumnHeadersHeight = 24;
            this.dtgGalpon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgGalpon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDGalpon,
            this.ClmEstadoGalpon,
            this.ClmfechaCreacion,
            this.ClmCapacidadGalpon});
            this.dtgGalpon.EnableHeadersVisualStyles = false;
            this.dtgGalpon.Location = new System.Drawing.Point(12, 245);
            this.dtgGalpon.MultiSelect = false;
            this.dtgGalpon.Name = "dtgGalpon";
            this.dtgGalpon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGalpon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGalpon.RowHeadersVisible = false;
            this.dtgGalpon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGalpon.Size = new System.Drawing.Size(652, 303);
            this.dtgGalpon.TabIndex = 110;
            // 
            // ClmIDGalpon
            // 
            this.ClmIDGalpon.FillWeight = 96.8818F;
            this.ClmIDGalpon.HeaderText = "ID Galpon";
            this.ClmIDGalpon.MinimumWidth = 6;
            this.ClmIDGalpon.Name = "ClmIDGalpon";
            this.ClmIDGalpon.ReadOnly = true;
            this.ClmIDGalpon.Width = 200;
            // 
            // ClmEstadoGalpon
            // 
            this.ClmEstadoGalpon.FillWeight = 96.8818F;
            this.ClmEstadoGalpon.HeaderText = "Estado";
            this.ClmEstadoGalpon.MinimumWidth = 6;
            this.ClmEstadoGalpon.Name = "ClmEstadoGalpon";
            this.ClmEstadoGalpon.ReadOnly = true;
            this.ClmEstadoGalpon.Width = 152;
            // 
            // ClmfechaCreacion
            // 
            this.ClmfechaCreacion.FillWeight = 96.8818F;
            this.ClmfechaCreacion.HeaderText = "Fecha Creacion";
            this.ClmfechaCreacion.MinimumWidth = 6;
            this.ClmfechaCreacion.Name = "ClmfechaCreacion";
            this.ClmfechaCreacion.ReadOnly = true;
            this.ClmfechaCreacion.Width = 200;
            // 
            // ClmCapacidadGalpon
            // 
            this.ClmCapacidadGalpon.FillWeight = 96.8818F;
            this.ClmCapacidadGalpon.HeaderText = "Capacidad";
            this.ClmCapacidadGalpon.MinimumWidth = 6;
            this.ClmCapacidadGalpon.Name = "ClmCapacidadGalpon";
            this.ClmCapacidadGalpon.ReadOnly = true;
            // 
            // BtnSalirGalpon
            // 
            this.BtnSalirGalpon.BackColor = System.Drawing.Color.Red;
            this.BtnSalirGalpon.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirGalpon.Location = new System.Drawing.Point(653, 0);
            this.BtnSalirGalpon.Name = "BtnSalirGalpon";
            this.BtnSalirGalpon.Size = new System.Drawing.Size(24, 29);
            this.BtnSalirGalpon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirGalpon.TabIndex = 121;
            this.BtnSalirGalpon.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(677, 29);
            this.label9.TabIndex = 120;
            this.label9.Text = "Información Galpon";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmrGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 560);
            this.Controls.Add(this.BtnSalirGalpon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgGalpon);
            this.Controls.Add(this.BtnBuscarGalpon);
            this.Controls.Add(this.txtCapacidadMaxima);
            this.Controls.Add(this.BtnEliminarGalpon);
            this.Controls.Add(this.BtnModificarGalpon);
            this.Controls.Add(this.BtnGuardarGalpon);
            this.Controls.Add(this.CboEstadoGalpon);
            this.Controls.Add(this.txtIdGalpon);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrGalpon";
            this.Text = "FmrGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarGalpon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGalpon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirGalpon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminarGalpon;
        private System.Windows.Forms.Button BtnModificarGalpon;
        private System.Windows.Forms.Button BtnGuardarGalpon;
        private System.Windows.Forms.ComboBox CboEstadoGalpon;
        private System.Windows.Forms.TextBox txtIdGalpon;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacidadMaxima;
        private System.Windows.Forms.PictureBox BtnBuscarGalpon;
        private System.Windows.Forms.DataGridView dtgGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmfechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCapacidadGalpon;
        private System.Windows.Forms.PictureBox BtnSalirGalpon;
        private System.Windows.Forms.Label label9;
    }
}