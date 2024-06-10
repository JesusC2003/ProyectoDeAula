namespace Presentacion
{
    partial class frmPollo
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
            this.dgvPollo = new System.Windows.Forms.DataGridView();
            this.Controles = new System.Windows.Forms.Label();
            this.txtBusquedapollo = new System.Windows.Forms.TextBox();
            this.cmbFiltradoP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarP = new System.Windows.Forms.Button();
            this.BtnVerP = new System.Windows.Forms.Button();
            this.BtnEditarP = new System.Windows.Forms.Button();
            this.btnAgregarpollo = new System.Windows.Forms.Button();
            this.btnEliminarPollo = new System.Windows.Forms.Button();
            this.btnVerpollo = new System.Windows.Forms.Button();
            this.btnEditarpollo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPollo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPollo
            // 
            this.dgvPollo.AllowUserToAddRows = false;
            this.dgvPollo.AllowUserToDeleteRows = false;
            this.dgvPollo.AllowUserToResizeColumns = false;
            this.dgvPollo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPollo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPollo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPollo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPollo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPollo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPollo.ColumnHeadersHeight = 24;
            this.dgvPollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPollo.EnableHeadersVisualStyles = false;
            this.dgvPollo.Location = new System.Drawing.Point(20, 130);
            this.dgvPollo.MultiSelect = false;
            this.dgvPollo.Name = "dgvPollo";
            this.dgvPollo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPollo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPollo.RowHeadersVisible = false;
            this.dgvPollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPollo.Size = new System.Drawing.Size(732, 389);
            this.dgvPollo.TabIndex = 108;
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 109;
            this.Controles.Text = "Controles";
            // 
            // txtBusquedapollo
            // 
            this.txtBusquedapollo.BackColor = System.Drawing.Color.Gray;
            this.txtBusquedapollo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedapollo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedapollo.ForeColor = System.Drawing.Color.White;
            this.txtBusquedapollo.Location = new System.Drawing.Point(126, 49);
            this.txtBusquedapollo.Name = "txtBusquedapollo";
            this.txtBusquedapollo.Size = new System.Drawing.Size(483, 23);
            this.txtBusquedapollo.TabIndex = 110;
            this.txtBusquedapollo.Text = "Busqueda";
            this.txtBusquedapollo.Enter += new System.EventHandler(this.TxtBusquedapollo_Enter);
            this.txtBusquedapollo.Leave += new System.EventHandler(this.TxtBusquedapollo_Leave);
            // 
            // cmbFiltradoP
            // 
            this.cmbFiltradoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltradoP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoP.FormattingEnabled = true;
            this.cmbFiltradoP.Location = new System.Drawing.Point(612, 48);
            this.cmbFiltradoP.Name = "cmbFiltradoP";
            this.cmbFiltradoP.Size = new System.Drawing.Size(135, 25);
            this.cmbFiltradoP.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 124;
            this.label1.Text = "Formulario para  Pollo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEliminarP
            // 
            this.BtnEliminarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarP.FlatAppearance.BorderSize = 0;
            this.BtnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarP.Location = new System.Drawing.Point(723, 101);
            this.BtnEliminarP.Name = "BtnEliminarP";
            this.BtnEliminarP.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarP.TabIndex = 113;
            this.BtnEliminarP.UseVisualStyleBackColor = true;
            // 
            // BtnVerP
            // 
            this.BtnVerP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerP.FlatAppearance.BorderSize = 0;
            this.BtnVerP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerP.Location = new System.Drawing.Point(689, 101);
            this.BtnVerP.Name = "BtnVerP";
            this.BtnVerP.Size = new System.Drawing.Size(29, 25);
            this.BtnVerP.TabIndex = 112;
            this.BtnVerP.UseVisualStyleBackColor = true;
            // 
            // BtnEditarP
            // 
            this.BtnEditarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarP.FlatAppearance.BorderSize = 0;
            this.BtnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarP.Location = new System.Drawing.Point(654, 101);
            this.BtnEditarP.Name = "BtnEditarP";
            this.BtnEditarP.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarP.TabIndex = 111;
            this.BtnEditarP.UseVisualStyleBackColor = true;
            // 
            // btnAgregarpollo
            // 
            this.btnAgregarpollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarpollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarpollo.FlatAppearance.BorderSize = 0;
            this.btnAgregarpollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarpollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarpollo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarpollo.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAgregarpollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarpollo.Location = new System.Drawing.Point(21, 92);
            this.btnAgregarpollo.Name = "btnAgregarpollo";
            this.btnAgregarpollo.Size = new System.Drawing.Size(101, 34);
            this.btnAgregarpollo.TabIndex = 128;
            this.btnAgregarpollo.Text = "Añadir";
            this.btnAgregarpollo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarpollo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPollo
            // 
            this.btnEliminarPollo.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarPollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPollo.FlatAppearance.BorderSize = 0;
            this.btnEliminarPollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarPollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPollo.Location = new System.Drawing.Point(724, 101);
            this.btnEliminarPollo.Name = "btnEliminarPollo";
            this.btnEliminarPollo.Size = new System.Drawing.Size(29, 25);
            this.btnEliminarPollo.TabIndex = 127;
            this.btnEliminarPollo.UseVisualStyleBackColor = true;
            // 
            // btnVerpollo
            // 
            this.btnVerpollo.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerpollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerpollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerpollo.FlatAppearance.BorderSize = 0;
            this.btnVerpollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerpollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerpollo.Location = new System.Drawing.Point(689, 101);
            this.btnVerpollo.Name = "btnVerpollo";
            this.btnVerpollo.Size = new System.Drawing.Size(29, 25);
            this.btnVerpollo.TabIndex = 126;
            this.btnVerpollo.UseVisualStyleBackColor = true;
            // 
            // btnEditarpollo
            // 
            this.btnEditarpollo.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarpollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarpollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarpollo.FlatAppearance.BorderSize = 0;
            this.btnEditarpollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarpollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarpollo.Location = new System.Drawing.Point(654, 101);
            this.btnEditarpollo.Name = "btnEditarpollo";
            this.btnEditarpollo.Size = new System.Drawing.Size(29, 25);
            this.btnEditarpollo.TabIndex = 125;
            this.btnEditarpollo.UseVisualStyleBackColor = true;
            // 
            // frmPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.btnAgregarpollo);
            this.Controls.Add(this.btnEliminarPollo);
            this.Controls.Add(this.btnVerpollo);
            this.Controls.Add(this.btnEditarpollo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoP);
            this.Controls.Add(this.BtnEliminarP);
            this.Controls.Add(this.BtnVerP);
            this.Controls.Add(this.BtnEditarP);
            this.Controls.Add(this.txtBusquedapollo);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvPollo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPollo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPollo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPollo;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.TextBox txtBusquedapollo;
        private System.Windows.Forms.Button BtnEditarP;
        private System.Windows.Forms.Button BtnVerP;
        private System.Windows.Forms.Button BtnEliminarP;
        private System.Windows.Forms.ComboBox cmbFiltradoP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarpollo;
        private System.Windows.Forms.Button btnEliminarPollo;
        private System.Windows.Forms.Button btnVerpollo;
        private System.Windows.Forms.Button btnEditarpollo;
    }
}