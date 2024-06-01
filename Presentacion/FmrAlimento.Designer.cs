namespace Presentacion
{
    partial class FmrAlimento
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
            this.dgvAlimento = new System.Windows.Forms.DataGridView();
            this.ClmCodigoAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecioAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTipoAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidadAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFrecuenciaAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboFiltradoA = new System.Windows.Forms.ComboBox();
            this.BtnAgregarA = new System.Windows.Forms.Button();
            this.BtnEliminarA = new System.Windows.Forms.Button();
            this.BtnVerA = new System.Windows.Forms.Button();
            this.BtnEditarA = new System.Windows.Forms.Button();
            this.TxtBusquedaAlimento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlimento
            // 
            this.dgvAlimento.AllowUserToAddRows = false;
            this.dgvAlimento.AllowUserToDeleteRows = false;
            this.dgvAlimento.AllowUserToResizeColumns = false;
            this.dgvAlimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAlimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlimento.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAlimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlimento.ColumnHeadersHeight = 24;
            this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigoAlimento,
            this.ClmMarca,
            this.ClmPrecioAlimento,
            this.ClmTipoAlimento,
            this.ClmCantidadAlimento,
            this.ClmFrecuenciaAlimento});
            this.dgvAlimento.EnableHeadersVisualStyles = false;
            this.dgvAlimento.Location = new System.Drawing.Point(15, 96);
            this.dgvAlimento.MultiSelect = false;
            this.dgvAlimento.Name = "dgvAlimento";
            this.dgvAlimento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlimento.RowHeadersVisible = false;
            this.dgvAlimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlimento.Size = new System.Drawing.Size(812, 485);
            this.dgvAlimento.TabIndex = 106;
            this.dgvAlimento.Enter += new System.EventHandler(this.dgvAlimento_Enter);
            this.dgvAlimento.Leave += new System.EventHandler(this.dgvAlimento_Leave);
            // 
            // ClmCodigoAlimento
            // 
            this.ClmCodigoAlimento.FillWeight = 96.8818F;
            this.ClmCodigoAlimento.HeaderText = "Codigo Alimento";
            this.ClmCodigoAlimento.MinimumWidth = 6;
            this.ClmCodigoAlimento.Name = "ClmCodigoAlimento";
            this.ClmCodigoAlimento.ReadOnly = true;
            this.ClmCodigoAlimento.Width = 142;
            // 
            // ClmMarca
            // 
            this.ClmMarca.FillWeight = 96.8818F;
            this.ClmMarca.HeaderText = "Marca";
            this.ClmMarca.MinimumWidth = 6;
            this.ClmMarca.Name = "ClmMarca";
            this.ClmMarca.ReadOnly = true;
            this.ClmMarca.Width = 120;
            // 
            // ClmPrecioAlimento
            // 
            this.ClmPrecioAlimento.FillWeight = 96.8818F;
            this.ClmPrecioAlimento.HeaderText = "Precio";
            this.ClmPrecioAlimento.MinimumWidth = 6;
            this.ClmPrecioAlimento.Name = "ClmPrecioAlimento";
            this.ClmPrecioAlimento.ReadOnly = true;
            this.ClmPrecioAlimento.Width = 80;
            // 
            // ClmTipoAlimento
            // 
            this.ClmTipoAlimento.FillWeight = 96.8818F;
            this.ClmTipoAlimento.HeaderText = "Tipo ";
            this.ClmTipoAlimento.MinimumWidth = 6;
            this.ClmTipoAlimento.Name = "ClmTipoAlimento";
            this.ClmTipoAlimento.ReadOnly = true;
            this.ClmTipoAlimento.Width = 150;
            // 
            // ClmCantidadAlimento
            // 
            this.ClmCantidadAlimento.FillWeight = 96.8818F;
            this.ClmCantidadAlimento.HeaderText = "Cantidad";
            this.ClmCantidadAlimento.MinimumWidth = 6;
            this.ClmCantidadAlimento.Name = "ClmCantidadAlimento";
            this.ClmCantidadAlimento.ReadOnly = true;
            this.ClmCantidadAlimento.Width = 80;
            // 
            // ClmFrecuenciaAlimento
            // 
            this.ClmFrecuenciaAlimento.FillWeight = 96.8818F;
            this.ClmFrecuenciaAlimento.HeaderText = "Frecuencia";
            this.ClmFrecuenciaAlimento.MinimumWidth = 6;
            this.ClmFrecuenciaAlimento.Name = "ClmFrecuenciaAlimento";
            this.ClmFrecuenciaAlimento.ReadOnly = true;
            this.ClmFrecuenciaAlimento.Width = 80;
            // 
            // CboFiltradoA
            // 
            this.CboFiltradoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoA.FormattingEnabled = true;
            this.CboFiltradoA.Location = new System.Drawing.Point(690, 41);
            this.CboFiltradoA.Name = "CboFiltradoA";
            this.CboFiltradoA.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoA.TabIndex = 129;
            // 
            // BtnAgregarA
            // 
            this.BtnAgregarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarA.FlatAppearance.BorderSize = 0;
            this.BtnAgregarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarA.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarA.Location = new System.Drawing.Point(15, 67);
            this.BtnAgregarA.Name = "BtnAgregarA";
            this.BtnAgregarA.Size = new System.Drawing.Size(85, 28);
            this.BtnAgregarA.TabIndex = 128;
            this.BtnAgregarA.Text = "Añadir";
            this.BtnAgregarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarA.UseVisualStyleBackColor = true;
            this.BtnAgregarA.Click += new System.EventHandler(this.BtnAgregarA_Click);
            // 
            // BtnEliminarA
            // 
            this.BtnEliminarA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarA.FlatAppearance.BorderSize = 0;
            this.BtnEliminarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarA.Location = new System.Drawing.Point(799, 71);
            this.BtnEliminarA.Name = "BtnEliminarA";
            this.BtnEliminarA.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarA.TabIndex = 127;
            this.BtnEliminarA.UseVisualStyleBackColor = true;
            // 
            // BtnVerA
            // 
            this.BtnVerA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver;
            this.BtnVerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerA.FlatAppearance.BorderSize = 0;
            this.BtnVerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerA.Location = new System.Drawing.Point(769, 71);
            this.BtnVerA.Name = "BtnVerA";
            this.BtnVerA.Size = new System.Drawing.Size(29, 25);
            this.BtnVerA.TabIndex = 126;
            this.BtnVerA.UseVisualStyleBackColor = true;
            // 
            // BtnEditarA
            // 
            this.BtnEditarA.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarA.FlatAppearance.BorderSize = 0;
            this.BtnEditarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarA.Location = new System.Drawing.Point(739, 71);
            this.BtnEditarA.Name = "BtnEditarA";
            this.BtnEditarA.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarA.TabIndex = 125;
            this.BtnEditarA.UseVisualStyleBackColor = true;
            // 
            // TxtBusquedaAlimento
            // 
            this.TxtBusquedaAlimento.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaAlimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaAlimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaAlimento.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaAlimento.Location = new System.Drawing.Point(107, 42);
            this.TxtBusquedaAlimento.Name = "TxtBusquedaAlimento";
            this.TxtBusquedaAlimento.Size = new System.Drawing.Size(579, 23);
            this.TxtBusquedaAlimento.TabIndex = 124;
            this.TxtBusquedaAlimento.Text = "Busqueda";
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 42);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(100, 23);
            this.Controles.TabIndex = 123;
            this.Controles.Text = "Controles";
            // 
            // FmrAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.CboFiltradoA);
            this.Controls.Add(this.BtnAgregarA);
            this.Controls.Add(this.BtnEliminarA);
            this.Controls.Add(this.BtnVerA);
            this.Controls.Add(this.BtnEditarA);
            this.Controls.Add(this.TxtBusquedaAlimento);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvAlimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAlimento";
            this.Text = "FmrAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigoAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecioAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTipoAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidadAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFrecuenciaAlimento;
        private System.Windows.Forms.ComboBox CboFiltradoA;
        private System.Windows.Forms.Button BtnAgregarA;
        private System.Windows.Forms.Button BtnEliminarA;
        private System.Windows.Forms.Button BtnVerA;
        private System.Windows.Forms.Button BtnEditarA;
        private System.Windows.Forms.TextBox TxtBusquedaAlimento;
        private System.Windows.Forms.Label Controles;
    }
}