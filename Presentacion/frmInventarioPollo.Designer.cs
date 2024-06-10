namespace Presentacion
{
    partial class frmInventarioPollo
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
            this.dgvInventarioPollo = new System.Windows.Forms.DataGridView();
            this.ClmIDPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstadoPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmRazaPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPeriodoEngorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalirInventarioPollo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioPollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioPollo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarioPollo
            // 
            this.dgvInventarioPollo.AllowUserToAddRows = false;
            this.dgvInventarioPollo.AllowUserToDeleteRows = false;
            this.dgvInventarioPollo.AllowUserToResizeColumns = false;
            this.dgvInventarioPollo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventarioPollo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarioPollo.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventarioPollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventarioPollo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventarioPollo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioPollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventarioPollo.ColumnHeadersHeight = 24;
            this.dgvInventarioPollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventarioPollo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDPollo,
            this.ClmEstadoPollo,
            this.ClmFechaIngreso,
            this.ClmFechaSalida,
            this.ClmRazaPollo,
            this.ClmPeriodoEngorde,
            this.ClmPeso});
            this.dgvInventarioPollo.EnableHeadersVisualStyles = false;
            this.dgvInventarioPollo.Location = new System.Drawing.Point(5, 61);
            this.dgvInventarioPollo.MultiSelect = false;
            this.dgvInventarioPollo.Name = "dgvInventarioPollo";
            this.dgvInventarioPollo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioPollo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventarioPollo.RowHeadersVisible = false;
            this.dgvInventarioPollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioPollo.Size = new System.Drawing.Size(666, 475);
            this.dgvInventarioPollo.TabIndex = 0;
            // 
            // ClmIDPollo
            // 
            this.ClmIDPollo.FillWeight = 96.8818F;
            this.ClmIDPollo.HeaderText = "ID Pollo";
            this.ClmIDPollo.MinimumWidth = 6;
            this.ClmIDPollo.Name = "ClmIDPollo";
            this.ClmIDPollo.ReadOnly = true;
            // 
            // ClmEstadoPollo
            // 
            this.ClmEstadoPollo.FillWeight = 96.8818F;
            this.ClmEstadoPollo.HeaderText = "Estado";
            this.ClmEstadoPollo.MinimumWidth = 6;
            this.ClmEstadoPollo.Name = "ClmEstadoPollo";
            this.ClmEstadoPollo.ReadOnly = true;
            this.ClmEstadoPollo.Width = 80;
            // 
            // ClmFechaIngreso
            // 
            this.ClmFechaIngreso.FillWeight = 96.8818F;
            this.ClmFechaIngreso.HeaderText = "Fecha Ingreso";
            this.ClmFechaIngreso.MinimumWidth = 6;
            this.ClmFechaIngreso.Name = "ClmFechaIngreso";
            this.ClmFechaIngreso.ReadOnly = true;
            this.ClmFechaIngreso.Width = 125;
            // 
            // ClmFechaSalida
            // 
            this.ClmFechaSalida.FillWeight = 96.8818F;
            this.ClmFechaSalida.HeaderText = "Fecha Salida";
            this.ClmFechaSalida.MinimumWidth = 6;
            this.ClmFechaSalida.Name = "ClmFechaSalida";
            this.ClmFechaSalida.ReadOnly = true;
            this.ClmFechaSalida.Width = 110;
            // 
            // ClmRazaPollo
            // 
            this.ClmRazaPollo.FillWeight = 96.8818F;
            this.ClmRazaPollo.HeaderText = "Raza Pollo";
            this.ClmRazaPollo.MinimumWidth = 6;
            this.ClmRazaPollo.Name = "ClmRazaPollo";
            this.ClmRazaPollo.ReadOnly = true;
            // 
            // ClmPeriodoEngorde
            // 
            this.ClmPeriodoEngorde.FillWeight = 96.8818F;
            this.ClmPeriodoEngorde.HeaderText = "Periodo Engorde";
            this.ClmPeriodoEngorde.MinimumWidth = 6;
            this.ClmPeriodoEngorde.Name = "ClmPeriodoEngorde";
            this.ClmPeriodoEngorde.ReadOnly = true;
            this.ClmPeriodoEngorde.Width = 80;
            // 
            // ClmPeso
            // 
            this.ClmPeso.FillWeight = 96.8818F;
            this.ClmPeso.HeaderText = "Peso";
            this.ClmPeso.MinimumWidth = 6;
            this.ClmPeso.Name = "ClmPeso";
            this.ClmPeso.ReadOnly = true;
            this.ClmPeso.Width = 70;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario Pollo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalirInventarioPollo
            // 
            this.BtnSalirInventarioPollo.BackColor = System.Drawing.Color.Red;
            this.BtnSalirInventarioPollo.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirInventarioPollo.Location = new System.Drawing.Point(656, -1);
            this.BtnSalirInventarioPollo.Name = "BtnSalirInventarioPollo";
            this.BtnSalirInventarioPollo.Size = new System.Drawing.Size(24, 22);
            this.BtnSalirInventarioPollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirInventarioPollo.TabIndex = 124;
            this.BtnSalirInventarioPollo.TabStop = false;
            // 
            // frmInventarioPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(678, 560);
            this.Controls.Add(this.BtnSalirInventarioPollo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventarioPollo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioPollo";
            this.Text = "FmrInventarioPollo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioPollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioPollo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventarioPollo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRazaPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPeriodoEngorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPeso;
        private System.Windows.Forms.PictureBox BtnSalirInventarioPollo;
    }
}