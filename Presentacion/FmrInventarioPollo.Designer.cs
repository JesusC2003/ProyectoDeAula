﻿namespace Presentacion
{
    partial class FmrInventarioPollo
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
            this.dtgInventarioPollo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClmIDPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstadoPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmRazaPollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPeriodoEngorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventarioPollo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInventarioPollo
            // 
            this.dtgInventarioPollo.AllowUserToAddRows = false;
            this.dtgInventarioPollo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgInventarioPollo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInventarioPollo.BackgroundColor = System.Drawing.Color.White;
            this.dtgInventarioPollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInventarioPollo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgInventarioPollo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventarioPollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInventarioPollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventarioPollo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDPollo,
            this.ClmEstadoPollo,
            this.ClmFechaIngreso,
            this.ClmFechaSalida,
            this.ClmRazaPollo,
            this.ClmPeriodoEngorde,
            this.ClmPeso});
            this.dtgInventarioPollo.Location = new System.Drawing.Point(12, 67);
            this.dtgInventarioPollo.Name = "dtgInventarioPollo";
            this.dtgInventarioPollo.ReadOnly = true;
            this.dtgInventarioPollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventarioPollo.Size = new System.Drawing.Size(608, 440);
            this.dtgInventarioPollo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario Pollo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FmrInventarioPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgInventarioPollo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrInventarioPollo";
            this.Text = "FmrInventarioPollo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventarioPollo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInventarioPollo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRazaPollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPeriodoEngorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPeso;
    }
}