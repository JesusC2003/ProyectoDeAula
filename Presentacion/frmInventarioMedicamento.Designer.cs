﻿namespace Presentacion
{
    partial class frmInventarioMedicamento
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
            this.ClmCodigoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPolloMedicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalirInventarioMedicamento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario Medicamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventarioMedicamento
            // 
            this.dgvInventarioMedicamento.AllowUserToAddRows = false;
            this.dgvInventarioMedicamento.AllowUserToDeleteRows = false;
            this.dgvInventarioMedicamento.AllowUserToResizeColumns = false;
            this.dgvInventarioMedicamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventarioMedicamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvInventarioMedicamento.ColumnHeadersHeight = 29;
            this.dgvInventarioMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventarioMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigoMedicamento,
            this.ClmNombreMedicamento,
            this.ClmPolloMedicado});
            this.dgvInventarioMedicamento.EnableHeadersVisualStyles = false;
            this.dgvInventarioMedicamento.Location = new System.Drawing.Point(32, 53);
            this.dgvInventarioMedicamento.MultiSelect = false;
            this.dgvInventarioMedicamento.Name = "dgvInventarioMedicamento";
            this.dgvInventarioMedicamento.ReadOnly = true;
            this.dgvInventarioMedicamento.RowHeadersVisible = false;
            this.dgvInventarioMedicamento.RowHeadersWidth = 51;
            this.dgvInventarioMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioMedicamento.Size = new System.Drawing.Size(607, 479);
            this.dgvInventarioMedicamento.TabIndex = 3;
            // 
            // ClmCodigoMedicamento
            // 
            this.ClmCodigoMedicamento.FillWeight = 96.8818F;
            this.ClmCodigoMedicamento.HeaderText = "Codigo Medicamento";
            this.ClmCodigoMedicamento.MinimumWidth = 6;
            this.ClmCodigoMedicamento.Name = "ClmCodigoMedicamento";
            this.ClmCodigoMedicamento.ReadOnly = true;
            this.ClmCodigoMedicamento.Width = 206;
            // 
            // ClmNombreMedicamento
            // 
            this.ClmNombreMedicamento.FillWeight = 96.8818F;
            this.ClmNombreMedicamento.HeaderText = "Nombre Medicamento";
            this.ClmNombreMedicamento.MinimumWidth = 6;
            this.ClmNombreMedicamento.Name = "ClmNombreMedicamento";
            this.ClmNombreMedicamento.ReadOnly = true;
            this.ClmNombreMedicamento.Width = 205;
            // 
            // ClmPolloMedicado
            // 
            this.ClmPolloMedicado.FillWeight = 96.8818F;
            this.ClmPolloMedicado.HeaderText = "Pollo Medicado";
            this.ClmPolloMedicado.MinimumWidth = 6;
            this.ClmPolloMedicado.Name = "ClmPolloMedicado";
            this.ClmPolloMedicado.ReadOnly = true;
            this.ClmPolloMedicado.Width = 195;
            // 
            // BtnSalirInventarioMedicamento
            // 
            this.BtnSalirInventarioMedicamento.BackColor = System.Drawing.Color.Red;
            this.BtnSalirInventarioMedicamento.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirInventarioMedicamento.Location = new System.Drawing.Point(655, 0);
            this.BtnSalirInventarioMedicamento.Name = "BtnSalirInventarioMedicamento";
            this.BtnSalirInventarioMedicamento.Size = new System.Drawing.Size(24, 22);
            this.BtnSalirInventarioMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirInventarioMedicamento.TabIndex = 124;
            this.BtnSalirInventarioMedicamento.TabStop = false;
            // 
            // frmInventarioMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(678, 560);
            this.Controls.Add(this.BtnSalirInventarioMedicamento);
            this.Controls.Add(this.dgvInventarioMedicamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioMedicamento";
            this.Text = "FmrInventarioMedicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioMedicamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventarioMedicamento;
        private System.Windows.Forms.PictureBox BtnSalirInventarioMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPolloMedicado;
    }
}