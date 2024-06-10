namespace Presentacion
{
    partial class frmVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoV = new System.Windows.Forms.ComboBox();
            this.txtBusquedaVentas = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.btnAgregarV = new System.Windows.Forms.Button();
            this.btnEliminarV = new System.Windows.Forms.Button();
            this.btnVerV = new System.Windows.Forms.Button();
            this.btnEditarV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeight = 24;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(20, 130);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(732, 389);
            this.dgvVentas.TabIndex = 107;
            // 
            // cmbFiltradoV
            // 
            this.cmbFiltradoV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoV.FormattingEnabled = true;
            this.cmbFiltradoV.Location = new System.Drawing.Point(612, 48);
            this.cmbFiltradoV.Name = "cmbFiltradoV";
            this.cmbFiltradoV.Size = new System.Drawing.Size(138, 25);
            this.cmbFiltradoV.TabIndex = 136;
            // 
            // txtBusquedaVentas
            // 
            this.txtBusquedaVentas.BackColor = System.Drawing.Color.Gray;
            this.txtBusquedaVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaVentas.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaVentas.Location = new System.Drawing.Point(126, 49);
            this.txtBusquedaVentas.Name = "txtBusquedaVentas";
            this.txtBusquedaVentas.Size = new System.Drawing.Size(483, 23);
            this.txtBusquedaVentas.TabIndex = 131;
            this.txtBusquedaVentas.Text = "Busqueda";
            this.txtBusquedaVentas.Enter += new System.EventHandler(this.TxtBusquedaVentas_Enter);
            this.txtBusquedaVentas.Leave += new System.EventHandler(this.TxtBusquedaVentas_Leave);
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 130;
            this.Controles.Text = "Controles";
            // 
            // btnAgregarV
            // 
            this.btnAgregarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarV.FlatAppearance.BorderSize = 0;
            this.btnAgregarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarV.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAgregarV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarV.Location = new System.Drawing.Point(21, 92);
            this.btnAgregarV.Name = "btnAgregarV";
            this.btnAgregarV.Size = new System.Drawing.Size(101, 34);
            this.btnAgregarV.TabIndex = 135;
            this.btnAgregarV.Text = "Añadir";
            this.btnAgregarV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarV.UseVisualStyleBackColor = true;
            // 
            // btnEliminarV
            // 
            this.btnEliminarV.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarV.FlatAppearance.BorderSize = 0;
            this.btnEliminarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarV.Location = new System.Drawing.Point(724, 101);
            this.btnEliminarV.Name = "btnEliminarV";
            this.btnEliminarV.Size = new System.Drawing.Size(29, 25);
            this.btnEliminarV.TabIndex = 134;
            this.btnEliminarV.UseVisualStyleBackColor = true;
            // 
            // btnVerV
            // 
            this.btnVerV.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerV.FlatAppearance.BorderSize = 0;
            this.btnVerV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerV.Location = new System.Drawing.Point(689, 101);
            this.btnVerV.Name = "btnVerV";
            this.btnVerV.Size = new System.Drawing.Size(29, 25);
            this.btnVerV.TabIndex = 133;
            this.btnVerV.UseVisualStyleBackColor = true;
            // 
            // btnEditarV
            // 
            this.btnEditarV.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarV.FlatAppearance.BorderSize = 0;
            this.btnEditarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarV.Location = new System.Drawing.Point(654, 101);
            this.btnEditarV.Name = "btnEditarV";
            this.btnEditarV.Size = new System.Drawing.Size(29, 25);
            this.btnEditarV.TabIndex = 132;
            this.btnEditarV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 137;
            this.label1.Text = "Formulario para  ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoV);
            this.Controls.Add(this.btnAgregarV);
            this.Controls.Add(this.btnEliminarV);
            this.Controls.Add(this.btnVerV);
            this.Controls.Add(this.btnEditarV);
            this.Controls.Add(this.txtBusquedaVentas);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbFiltradoV;
        private System.Windows.Forms.Button btnAgregarV;
        private System.Windows.Forms.Button btnEliminarV;
        private System.Windows.Forms.Button btnVerV;
        private System.Windows.Forms.Button btnEditarV;
        private System.Windows.Forms.TextBox txtBusquedaVentas;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}