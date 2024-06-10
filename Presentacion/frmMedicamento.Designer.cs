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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicamenti = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoM = new System.Windows.Forms.ComboBox();
            this.txtBusquedaMedicamento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnVerM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicamenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicamenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMedicamenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicamenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicamenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicamenti.ColumnHeadersHeight = 24;
            this.dgvMedicamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMedicamenti.EnableHeadersVisualStyles = false;
            this.dgvMedicamenti.Location = new System.Drawing.Point(20, 130);
            this.dgvMedicamenti.MultiSelect = false;
            this.dgvMedicamenti.Name = "dgvMedicamenti";
            this.dgvMedicamenti.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicamenti.RowHeadersVisible = false;
            this.dgvMedicamenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamenti.Size = new System.Drawing.Size(732, 389);
            this.dgvMedicamenti.TabIndex = 112;
            // 
            // cmbFiltradoM
            // 
            this.cmbFiltradoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltradoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoM.FormattingEnabled = true;
            this.cmbFiltradoM.Location = new System.Drawing.Point(610, 48);
            this.cmbFiltradoM.Name = "cmbFiltradoM";
            this.cmbFiltradoM.Size = new System.Drawing.Size(138, 25);
            this.cmbFiltradoM.TabIndex = 130;
            // 
            // txtBusquedaMedicamento
            // 
            this.txtBusquedaMedicamento.BackColor = System.Drawing.Color.Gray;
            this.txtBusquedaMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaMedicamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaMedicamento.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaMedicamento.Location = new System.Drawing.Point(126, 49);
            this.txtBusquedaMedicamento.Name = "txtBusquedaMedicamento";
            this.txtBusquedaMedicamento.Size = new System.Drawing.Size(483, 23);
            this.txtBusquedaMedicamento.TabIndex = 125;
            this.txtBusquedaMedicamento.Text = "Busqueda";
            this.txtBusquedaMedicamento.Enter += new System.EventHandler(this.TxtBusquedaMedicamento_Enter);
            this.txtBusquedaMedicamento.Leave += new System.EventHandler(this.TxtBusquedaMedicamento_Leave);
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
            // btnAgregarM
            // 
            this.btnAgregarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarM.FlatAppearance.BorderSize = 0;
            this.btnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAgregarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarM.Location = new System.Drawing.Point(21, 92);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(101, 34);
            this.btnAgregarM.TabIndex = 129;
            this.btnAgregarM.Text = "Añadir";
            this.btnAgregarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.BtnAgregarM_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarM.FlatAppearance.BorderSize = 0;
            this.btnEliminarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Location = new System.Drawing.Point(724, 101);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(29, 25);
            this.btnEliminarM.TabIndex = 128;
            this.btnEliminarM.UseVisualStyleBackColor = true;
            // 
            // btnVerM
            // 
            this.btnVerM.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerM.FlatAppearance.BorderSize = 0;
            this.btnVerM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerM.Location = new System.Drawing.Point(689, 101);
            this.btnVerM.Name = "btnVerM";
            this.btnVerM.Size = new System.Drawing.Size(29, 25);
            this.btnVerM.TabIndex = 127;
            this.btnVerM.UseVisualStyleBackColor = true;
            // 
            // btnEditarM
            // 
            this.btnEditarM.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarM.FlatAppearance.BorderSize = 0;
            this.btnEditarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarM.Location = new System.Drawing.Point(654, 101);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(29, 25);
            this.btnEditarM.TabIndex = 126;
            this.btnEditarM.UseVisualStyleBackColor = true;
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
            // frmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoM);
            this.Controls.Add(this.btnAgregarM);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnVerM);
            this.Controls.Add(this.btnEditarM);
            this.Controls.Add(this.txtBusquedaMedicamento);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvMedicamenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedicamenti;
        private System.Windows.Forms.ComboBox cmbFiltradoM;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnVerM;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.TextBox txtBusquedaMedicamento;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}