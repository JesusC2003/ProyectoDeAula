namespace Presentacion
{
    partial class frmAlimento
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
            this.cmbFiltradoA = new System.Windows.Forms.ComboBox();
            this.txtBusquedaAlimento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.btnVerA = new System.Windows.Forms.Button();
            this.btnEditarA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvAlimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.dgvAlimento.EnableHeadersVisualStyles = false;
            this.dgvAlimento.Location = new System.Drawing.Point(20, 130);
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
            this.dgvAlimento.Size = new System.Drawing.Size(732, 389);
            this.dgvAlimento.TabIndex = 106;
            // 
            // cmbFiltradoA
            // 
            this.cmbFiltradoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltradoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoA.FormattingEnabled = true;
            this.cmbFiltradoA.Location = new System.Drawing.Point(612, 48);
            this.cmbFiltradoA.Name = "cmbFiltradoA";
            this.cmbFiltradoA.Size = new System.Drawing.Size(138, 25);
            this.cmbFiltradoA.TabIndex = 129;
            // 
            // txtBusquedaAlimento
            // 
            this.txtBusquedaAlimento.BackColor = System.Drawing.Color.Gray;
            this.txtBusquedaAlimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaAlimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaAlimento.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaAlimento.Location = new System.Drawing.Point(126, 49);
            this.txtBusquedaAlimento.Name = "txtBusquedaAlimento";
            this.txtBusquedaAlimento.Size = new System.Drawing.Size(483, 23);
            this.txtBusquedaAlimento.TabIndex = 124;
            this.txtBusquedaAlimento.Text = "Busqueda";
            this.txtBusquedaAlimento.Enter += new System.EventHandler(this.TxtBusquedaAlimento_Enter);
            this.txtBusquedaAlimento.Leave += new System.EventHandler(this.TxtBusquedaAlimento_Leave);
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 123;
            this.Controles.Text = "Controles";
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarA.FlatAppearance.BorderSize = 0;
            this.btnAgregarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarA.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAgregarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarA.Location = new System.Drawing.Point(21, 92);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(101, 34);
            this.btnAgregarA.TabIndex = 128;
            this.btnAgregarA.Text = "Añadir";
            this.btnAgregarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarA.UseVisualStyleBackColor = true;
            this.btnAgregarA.Click += new System.EventHandler(this.BtnAgregarA_Click);
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarA.FlatAppearance.BorderSize = 0;
            this.btnEliminarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarA.Location = new System.Drawing.Point(724, 101);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(29, 25);
            this.btnEliminarA.TabIndex = 127;
            this.btnEliminarA.UseVisualStyleBackColor = true;
            // 
            // btnVerA
            // 
            this.btnVerA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerA.FlatAppearance.BorderSize = 0;
            this.btnVerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerA.Location = new System.Drawing.Point(689, 101);
            this.btnVerA.Name = "btnVerA";
            this.btnVerA.Size = new System.Drawing.Size(29, 25);
            this.btnVerA.TabIndex = 126;
            this.btnVerA.UseVisualStyleBackColor = true;
            // 
            // btnEditarA
            // 
            this.btnEditarA.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarA.FlatAppearance.BorderSize = 0;
            this.btnEditarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarA.Location = new System.Drawing.Point(654, 101);
            this.btnEditarA.Name = "btnEditarA";
            this.btnEditarA.Size = new System.Drawing.Size(29, 25);
            this.btnEditarA.TabIndex = 125;
            this.btnEditarA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 130;
            this.label1.Text = "Formulario para Alimento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoA);
            this.Controls.Add(this.btnAgregarA);
            this.Controls.Add(this.btnEliminarA);
            this.Controls.Add(this.btnVerA);
            this.Controls.Add(this.btnEditarA);
            this.Controls.Add(this.txtBusquedaAlimento);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvAlimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlimento;
        private System.Windows.Forms.ComboBox cmbFiltradoA;
        private System.Windows.Forms.Button btnAgregarA;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Button btnVerA;
        private System.Windows.Forms.Button btnEditarA;
        private System.Windows.Forms.TextBox txtBusquedaAlimento;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}