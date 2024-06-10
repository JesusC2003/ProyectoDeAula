namespace Presentacion
{
    partial class frmMedicamento
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
            this.CboFiltradoM = new System.Windows.Forms.ComboBox();
            this.TxtBusquedaMedicamento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.BtnAgregarM = new System.Windows.Forms.Button();
            this.BtnEliminarM = new System.Windows.Forms.Button();
            this.BtnVerM = new System.Windows.Forms.Button();
            this.BtnEditarM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvMedicamenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.dgvMedicamenti.EnableHeadersVisualStyles = false;
            this.dgvMedicamenti.Location = new System.Drawing.Point(20, 130);
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
            this.dgvMedicamenti.Size = new System.Drawing.Size(732, 389);
            this.dgvMedicamenti.TabIndex = 112;
            // 
            // CboFiltradoM
            // 
            this.CboFiltradoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFiltradoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoM.FormattingEnabled = true;
            this.CboFiltradoM.Location = new System.Drawing.Point(610, 48);
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
            this.TxtBusquedaMedicamento.Location = new System.Drawing.Point(126, 49);
            this.TxtBusquedaMedicamento.Name = "TxtBusquedaMedicamento";
            this.TxtBusquedaMedicamento.Size = new System.Drawing.Size(483, 23);
            this.TxtBusquedaMedicamento.TabIndex = 125;
            this.TxtBusquedaMedicamento.Text = "Busqueda";
            this.TxtBusquedaMedicamento.Enter += new System.EventHandler(this.TxtBusquedaMedicamento_Enter);
            this.TxtBusquedaMedicamento.Leave += new System.EventHandler(this.TxtBusquedaMedicamento_Leave);
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 124;
            this.Controles.Text = "Controles";
            // 
            // BtnAgregarM
            // 
            this.BtnAgregarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarM.FlatAppearance.BorderSize = 0;
            this.BtnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarM.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarM.Location = new System.Drawing.Point(21, 92);
            this.BtnAgregarM.Name = "BtnAgregarM";
            this.BtnAgregarM.Size = new System.Drawing.Size(101, 34);
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
            this.BtnEliminarM.Location = new System.Drawing.Point(724, 101);
            this.BtnEliminarM.Name = "BtnEliminarM";
            this.BtnEliminarM.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarM.TabIndex = 128;
            this.BtnEliminarM.UseVisualStyleBackColor = true;
            // 
            // BtnVerM
            // 
            this.BtnVerM.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.BtnVerM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerM.FlatAppearance.BorderSize = 0;
            this.BtnVerM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerM.Location = new System.Drawing.Point(689, 101);
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
            this.BtnEditarM.Location = new System.Drawing.Point(654, 101);
            this.BtnEditarM.Name = "BtnEditarM";
            this.BtnEditarM.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarM.TabIndex = 126;
            this.BtnEditarM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 131;
            this.label1.Text = "Formulario para  Medicamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmrMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedicamenti;
        private System.Windows.Forms.ComboBox CboFiltradoM;
        private System.Windows.Forms.Button BtnAgregarM;
        private System.Windows.Forms.Button BtnEliminarM;
        private System.Windows.Forms.Button BtnVerM;
        private System.Windows.Forms.Button BtnEditarM;
        private System.Windows.Forms.TextBox TxtBusquedaMedicamento;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}