namespace Presentacion
{
    partial class FmrInventarioMedicamento
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
            this.dtgInventarioMedicamento = new System.Windows.Forms.DataGridView();
            this.BtnSalirInventarioMedicamento = new System.Windows.Forms.PictureBox();
            this.ClmCodigoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPolloMedicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventarioMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario Medicamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgInventarioMedicamento
            // 
            this.dtgInventarioMedicamento.AllowUserToAddRows = false;
            this.dtgInventarioMedicamento.AllowUserToDeleteRows = false;
            this.dtgInventarioMedicamento.AllowUserToResizeColumns = false;
            this.dtgInventarioMedicamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgInventarioMedicamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInventarioMedicamento.BackgroundColor = System.Drawing.Color.White;
            this.dtgInventarioMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInventarioMedicamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgInventarioMedicamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventarioMedicamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInventarioMedicamento.ColumnHeadersHeight = 29;
            this.dtgInventarioMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgInventarioMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigoMedicamento,
            this.ClmNombreMedicamento,
            this.ClmPolloMedicado});
            this.dtgInventarioMedicamento.EnableHeadersVisualStyles = false;
            this.dtgInventarioMedicamento.Location = new System.Drawing.Point(43, 65);
            this.dtgInventarioMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.dtgInventarioMedicamento.MultiSelect = false;
            this.dtgInventarioMedicamento.Name = "dtgInventarioMedicamento";
            this.dtgInventarioMedicamento.ReadOnly = true;
            this.dtgInventarioMedicamento.RowHeadersVisible = false;
            this.dtgInventarioMedicamento.RowHeadersWidth = 51;
            this.dtgInventarioMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventarioMedicamento.Size = new System.Drawing.Size(809, 590);
            this.dtgInventarioMedicamento.TabIndex = 3;
            // 
            // BtnSalirInventarioMedicamento
            // 
            this.BtnSalirInventarioMedicamento.BackColor = System.Drawing.Color.Red;
            this.BtnSalirInventarioMedicamento.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirInventarioMedicamento.Location = new System.Drawing.Point(873, 0);
            this.BtnSalirInventarioMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalirInventarioMedicamento.Name = "BtnSalirInventarioMedicamento";
            this.BtnSalirInventarioMedicamento.Size = new System.Drawing.Size(32, 27);
            this.BtnSalirInventarioMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirInventarioMedicamento.TabIndex = 124;
            this.BtnSalirInventarioMedicamento.TabStop = false;
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
            // FmrInventarioMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(904, 689);
            this.Controls.Add(this.BtnSalirInventarioMedicamento);
            this.Controls.Add(this.dtgInventarioMedicamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmrInventarioMedicamento";
            this.Text = "FmrInventarioMedicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventarioMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirInventarioMedicamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgInventarioMedicamento;
        private System.Windows.Forms.PictureBox BtnSalirInventarioMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPolloMedicado;
    }
}