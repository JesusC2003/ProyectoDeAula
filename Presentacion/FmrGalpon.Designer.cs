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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGalpon = new System.Windows.Forms.DataGridView();
            this.ClmIDGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstadoGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmfechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCapacidadGalpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboFiltradoG = new System.Windows.Forms.ComboBox();
            this.BtnAgregarG = new System.Windows.Forms.Button();
            this.BtnEliminarG = new System.Windows.Forms.Button();
            this.BtnVerG = new System.Windows.Forms.Button();
            this.BtnEditarG = new System.Windows.Forms.Button();
            this.TxtBusquedaGalpon = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGalpon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGalpon
            // 
            this.dgvGalpon.AllowUserToAddRows = false;
            this.dgvGalpon.AllowUserToDeleteRows = false;
            this.dgvGalpon.AllowUserToResizeColumns = false;
            this.dgvGalpon.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGalpon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGalpon.BackgroundColor = System.Drawing.Color.White;
            this.dgvGalpon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGalpon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGalpon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGalpon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGalpon.ColumnHeadersHeight = 24;
            this.dgvGalpon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGalpon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDGalpon,
            this.ClmEstadoGalpon,
            this.ClmfechaCreacion,
            this.ClmCapacidadGalpon});
            this.dgvGalpon.EnableHeadersVisualStyles = false;
            this.dgvGalpon.GridColor = System.Drawing.Color.Black;
            this.dgvGalpon.Location = new System.Drawing.Point(15, 94);
            this.dgvGalpon.MultiSelect = false;
            this.dgvGalpon.Name = "dgvGalpon";
            this.dgvGalpon.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGalpon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGalpon.RowHeadersVisible = false;
            this.dgvGalpon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGalpon.Size = new System.Drawing.Size(812, 485);
            this.dgvGalpon.TabIndex = 110;
            this.dgvGalpon.Enter += new System.EventHandler(this.dgvGalpon_Enter);
            this.dgvGalpon.Leave += new System.EventHandler(this.dgvGalpon_Leave);
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
            // CboFiltradoG
            // 
            this.CboFiltradoG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFiltradoG.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoG.FormattingEnabled = true;
            this.CboFiltradoG.Location = new System.Drawing.Point(689, 24);
            this.CboFiltradoG.Name = "CboFiltradoG";
            this.CboFiltradoG.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoG.TabIndex = 122;
            // 
            // BtnAgregarG
            // 
            this.BtnAgregarG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarG.FlatAppearance.BorderSize = 0;
            this.BtnAgregarG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarG.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarG.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarG.Location = new System.Drawing.Point(15, 60);
            this.BtnAgregarG.Name = "BtnAgregarG";
            this.BtnAgregarG.Size = new System.Drawing.Size(85, 28);
            this.BtnAgregarG.TabIndex = 121;
            this.BtnAgregarG.Text = "Añadir";
            this.BtnAgregarG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarG.UseVisualStyleBackColor = true;
            this.BtnAgregarG.Click += new System.EventHandler(this.BtnAgregarG_Click);
            // 
            // BtnEliminarG
            // 
            this.BtnEliminarG.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarG.FlatAppearance.BorderSize = 0;
            this.BtnEliminarG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarG.Location = new System.Drawing.Point(798, 68);
            this.BtnEliminarG.Name = "BtnEliminarG";
            this.BtnEliminarG.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarG.TabIndex = 120;
            this.BtnEliminarG.UseVisualStyleBackColor = true;
            // 
            // BtnVerG
            // 
            this.BtnVerG.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver;
            this.BtnVerG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerG.FlatAppearance.BorderSize = 0;
            this.BtnVerG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerG.Location = new System.Drawing.Point(768, 68);
            this.BtnVerG.Name = "BtnVerG";
            this.BtnVerG.Size = new System.Drawing.Size(29, 25);
            this.BtnVerG.TabIndex = 119;
            this.BtnVerG.UseVisualStyleBackColor = true;
            // 
            // BtnEditarG
            // 
            this.BtnEditarG.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarG.FlatAppearance.BorderSize = 0;
            this.BtnEditarG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarG.Location = new System.Drawing.Point(738, 68);
            this.BtnEditarG.Name = "BtnEditarG";
            this.BtnEditarG.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarG.TabIndex = 118;
            this.BtnEditarG.UseVisualStyleBackColor = true;
            // 
            // TxtBusquedaGalpon
            // 
            this.TxtBusquedaGalpon.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaGalpon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaGalpon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaGalpon.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaGalpon.Location = new System.Drawing.Point(106, 25);
            this.TxtBusquedaGalpon.Name = "TxtBusquedaGalpon";
            this.TxtBusquedaGalpon.Size = new System.Drawing.Size(579, 23);
            this.TxtBusquedaGalpon.TabIndex = 117;
            this.TxtBusquedaGalpon.Text = "Busqueda";
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(16, 25);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(100, 23);
            this.Controles.TabIndex = 116;
            this.Controles.Text = "Controles";
            // 
            // FmrGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.CboFiltradoG);
            this.Controls.Add(this.BtnAgregarG);
            this.Controls.Add(this.BtnEliminarG);
            this.Controls.Add(this.BtnVerG);
            this.Controls.Add(this.BtnEditarG);
            this.Controls.Add(this.TxtBusquedaGalpon);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvGalpon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrGalpon";
            this.Text = "FmrGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGalpon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoGalpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmfechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCapacidadGalpon;
        private System.Windows.Forms.ComboBox CboFiltradoG;
        private System.Windows.Forms.Button BtnAgregarG;
        private System.Windows.Forms.Button BtnEliminarG;
        private System.Windows.Forms.Button BtnVerG;
        private System.Windows.Forms.Button BtnEditarG;
        private System.Windows.Forms.TextBox TxtBusquedaGalpon;
        private System.Windows.Forms.Label Controles;
    }
}