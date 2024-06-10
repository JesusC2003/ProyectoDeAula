namespace Presentacion
{
    partial class frmInventarioGalpon
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventarioMedicamento = new System.Windows.Forms.DataGridView();
            this.ClmIDGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstadoGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCapacidadMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCodigoAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalirInventarioGalpon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioGalpon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventario Galpon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventarioMedicamento
            // 
            this.dgvInventarioMedicamento.AllowUserToAddRows = false;
            this.dgvInventarioMedicamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventarioMedicamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarioMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioMedicamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventarioMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventarioMedicamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventarioMedicamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioMedicamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventarioMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDGalpon,
            this.ClmEstadoGalpon,
            this.ClmFechaCreacion,
            this.ClmCapacidadMaxima,
            this.ClmCodigoAlimento});
            this.dgvInventarioMedicamento.EnableHeadersVisualStyles = false;
            this.dgvInventarioMedicamento.Location = new System.Drawing.Point(36, 53);
            this.dgvInventarioMedicamento.MultiSelect = false;
            this.dgvInventarioMedicamento.Name = "dgvInventarioMedicamento";
            this.dgvInventarioMedicamento.ReadOnly = true;
            this.dgvInventarioMedicamento.RowHeadersVisible = false;
            this.dgvInventarioMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioMedicamento.Size = new System.Drawing.Size(608, 495);
            this.dgvInventarioMedicamento.TabIndex = 4;
            // 
            // ClmIDGalpon
            // 
            this.ClmIDGalpon.FillWeight = 96.8818F;
            this.ClmIDGalpon.HeaderText = "ID Galpon";
            this.ClmIDGalpon.MinimumWidth = 6;
            this.ClmIDGalpon.Name = "ClmIDGalpon";
            this.ClmIDGalpon.ReadOnly = true;
            this.ClmIDGalpon.Width = 102;
            // 
            // ClmEstadoGalpon
            // 
            this.ClmEstadoGalpon.FillWeight = 96.8818F;
            this.ClmEstadoGalpon.HeaderText = "Estado";
            this.ClmEstadoGalpon.MinimumWidth = 6;
            this.ClmEstadoGalpon.Name = "ClmEstadoGalpon";
            this.ClmEstadoGalpon.ReadOnly = true;
            // 
            // ClmFechaCreacion
            // 
            this.ClmFechaCreacion.FillWeight = 96.8818F;
            this.ClmFechaCreacion.HeaderText = "Fecha Creacion";
            this.ClmFechaCreacion.MinimumWidth = 6;
            this.ClmFechaCreacion.Name = "ClmFechaCreacion";
            this.ClmFechaCreacion.ReadOnly = true;
            this.ClmFechaCreacion.Width = 130;
            // 
            // ClmCapacidadMaxima
            // 
            this.ClmCapacidadMaxima.FillWeight = 96.8818F;
            this.ClmCapacidadMaxima.HeaderText = "Capacidad Max";
            this.ClmCapacidadMaxima.MinimumWidth = 6;
            this.ClmCapacidadMaxima.Name = "ClmCapacidadMaxima";
            this.ClmCapacidadMaxima.ReadOnly = true;
            this.ClmCapacidadMaxima.Width = 130;
            // 
            // ClmCodigoAlimento
            // 
            this.ClmCodigoAlimento.FillWeight = 96.8818F;
            this.ClmCodigoAlimento.HeaderText = "Codigo Alimento";
            this.ClmCodigoAlimento.MinimumWidth = 6;
            this.ClmCodigoAlimento.Name = "ClmCodigoAlimento";
            this.ClmCodigoAlimento.ReadOnly = true;
            this.ClmCodigoAlimento.Width = 145;
            // 
            // BtnSalirInventarioGalpon
            // 
            this.BtnSalirInventarioGalpon.BackColor = System.Drawing.Color.Red;
            this.BtnSalirInventarioGalpon.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirInventarioGalpon.Location = new System.Drawing.Point(655, -1);
            this.BtnSalirInventarioGalpon.Name = "BtnSalirInventarioGalpon";
            this.BtnSalirInventarioGalpon.Size = new System.Drawing.Size(24, 22);
            this.BtnSalirInventarioGalpon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirInventarioGalpon.TabIndex = 124;
            this.BtnSalirInventarioGalpon.TabStop = false;
            // 
            // frmInventarioGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(678, 560);
            this.Controls.Add(this.BtnSalirInventarioGalpon);
            this.Controls.Add(this.dgvInventarioMedicamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioGalpon";
            this.Text = "FmrInventarioGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioGalpon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventarioMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCapacidadMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoAlimento;
        private System.Windows.Forms.PictureBox BtnSalirInventarioGalpon;
    }
}