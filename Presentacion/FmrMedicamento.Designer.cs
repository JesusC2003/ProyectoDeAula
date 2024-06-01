namespace Presentacion
{
    partial class FmrMedicamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicamenti = new System.Windows.Forms.DataGridView();
            this.ClmCodigoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboFiltradoM = new System.Windows.Forms.ComboBox();
            this.TxtBusquedaMedicamento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.BtnAgregarM = new System.Windows.Forms.Button();
            this.BtnEliminarM = new System.Windows.Forms.Button();
            this.BtnVerM = new System.Windows.Forms.Button();
            this.BtnEditarM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicamenti
            // 
            this.dgvMedicamenti.AllowUserToAddRows = false;
            this.dgvMedicamenti.AllowUserToDeleteRows = false;
            this.dgvMedicamenti.AllowUserToResizeColumns = false;
            this.dgvMedicamenti.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicamenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicamenti.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMedicamenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicamenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicamenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedicamenti.ColumnHeadersHeight = 24;
            this.dgvMedicamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMedicamenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigoMedicamento,
            this.ClmNombreMedicamento});
            this.dgvMedicamenti.EnableHeadersVisualStyles = false;
            this.dgvMedicamenti.Location = new System.Drawing.Point(15, 94);
            this.dgvMedicamenti.MultiSelect = false;
            this.dgvMedicamenti.Name = "dgvMedicamenti";
            this.dgvMedicamenti.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicamenti.RowHeadersVisible = false;
            this.dgvMedicamenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamenti.Size = new System.Drawing.Size(812, 485);
            this.dgvMedicamenti.TabIndex = 112;
            // 
            // ClmCodigoMedicamento
            // 
            this.ClmCodigoMedicamento.FillWeight = 96.8818F;
            this.ClmCodigoMedicamento.HeaderText = "Codigo Medicamento";
            this.ClmCodigoMedicamento.MinimumWidth = 6;
            this.ClmCodigoMedicamento.Name = "ClmCodigoMedicamento";
            this.ClmCodigoMedicamento.ReadOnly = true;
            this.ClmCodigoMedicamento.Width = 200;
            // 
            // ClmNombreMedicamento
            // 
            this.ClmNombreMedicamento.FillWeight = 96.8818F;
            this.ClmNombreMedicamento.HeaderText = "Nombre";
            this.ClmNombreMedicamento.MinimumWidth = 6;
            this.ClmNombreMedicamento.Name = "ClmNombreMedicamento";
            this.ClmNombreMedicamento.ReadOnly = true;
            this.ClmNombreMedicamento.Width = 200;
            // 
            // CboFiltradoM
            // 
            this.CboFiltradoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoM.FormattingEnabled = true;
            this.CboFiltradoM.Location = new System.Drawing.Point(689, 38);
            this.CboFiltradoM.Name = "CboFiltradoM";
            this.CboFiltradoM.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoM.TabIndex = 130;
            // 
            // TxtBusquedaMedicamento
            // 
            this.TxtBusquedaMedicamento.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaMedicamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaMedicamento.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaMedicamento.Location = new System.Drawing.Point(106, 39);
            this.TxtBusquedaMedicamento.Name = "TxtBusquedaMedicamento";
            this.TxtBusquedaMedicamento.Size = new System.Drawing.Size(579, 23);
            this.TxtBusquedaMedicamento.TabIndex = 125;
            this.TxtBusquedaMedicamento.Text = "Busqueda";
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(16, 39);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(100, 23);
            this.Controles.TabIndex = 124;
            this.Controles.Text = "Controles";
            // 
            // BtnAgregarM
            // 
            this.BtnAgregarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarM.FlatAppearance.BorderSize = 0;
            this.BtnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarM.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarM.Location = new System.Drawing.Point(12, 65);
            this.BtnAgregarM.Name = "BtnAgregarM";
            this.BtnAgregarM.Size = new System.Drawing.Size(86, 28);
            this.BtnAgregarM.TabIndex = 129;
            this.BtnAgregarM.Text = "Añadir";
            this.BtnAgregarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarM.UseVisualStyleBackColor = true;
            this.BtnAgregarM.Click += new System.EventHandler(this.BtnAgregarM_Click);
            // 
            // BtnEliminarM
            // 
            this.BtnEliminarM.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarM.FlatAppearance.BorderSize = 0;
            this.BtnEliminarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarM.Location = new System.Drawing.Point(798, 68);
            this.BtnEliminarM.Name = "BtnEliminarM";
            this.BtnEliminarM.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarM.TabIndex = 128;
            this.BtnEliminarM.UseVisualStyleBackColor = true;
            // 
            // BtnVerM
            // 
            this.BtnVerM.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver;
            this.BtnVerM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerM.FlatAppearance.BorderSize = 0;
            this.BtnVerM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerM.Location = new System.Drawing.Point(768, 68);
            this.BtnVerM.Name = "BtnVerM";
            this.BtnVerM.Size = new System.Drawing.Size(29, 25);
            this.BtnVerM.TabIndex = 127;
            this.BtnVerM.UseVisualStyleBackColor = true;
            // 
            // BtnEditarM
            // 
            this.BtnEditarM.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarM.FlatAppearance.BorderSize = 0;
            this.BtnEditarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarM.Location = new System.Drawing.Point(738, 68);
            this.BtnEditarM.Name = "BtnEditarM";
            this.BtnEditarM.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarM.TabIndex = 126;
            this.BtnEditarM.UseVisualStyleBackColor = true;
            // 
            // FmrMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.CboFiltradoM);
            this.Controls.Add(this.BtnAgregarM);
            this.Controls.Add(this.BtnEliminarM);
            this.Controls.Add(this.BtnVerM);
            this.Controls.Add(this.BtnEditarM);
            this.Controls.Add(this.TxtBusquedaMedicamento);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvMedicamenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrMedicamento";
            this.Enter += new System.EventHandler(this.FmrMedicamento_Enter);
            this.Leave += new System.EventHandler(this.FmrMedicamento_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedicamenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreMedicamento;
        private System.Windows.Forms.ComboBox CboFiltradoM;
        private System.Windows.Forms.Button BtnAgregarM;
        private System.Windows.Forms.Button BtnEliminarM;
        private System.Windows.Forms.Button BtnVerM;
        private System.Windows.Forms.Button BtnEditarM;
        private System.Windows.Forms.TextBox TxtBusquedaMedicamento;
        private System.Windows.Forms.Label Controles;
    }
}