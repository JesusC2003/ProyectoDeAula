namespace Presentacion
{
    partial class frmPersonal
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
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoPersonal = new System.Windows.Forms.ComboBox();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.btnVerPersonal = new System.Windows.Forms.Button();
            this.btnEditarPersonal = new System.Windows.Forms.Button();
            this.txtBusquedaPersonal = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AllowUserToResizeColumns = false;
            this.dgvPersonal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonal.ColumnHeadersHeight = 24;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonal.EnableHeadersVisualStyles = false;
            this.dgvPersonal.Location = new System.Drawing.Point(20, 130);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(732, 389);
            this.dgvPersonal.TabIndex = 109;
            this.dgvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellContentClick);
            // 
            // cmbFiltradoPersonal
            // 
            this.cmbFiltradoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltradoPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoPersonal.FormattingEnabled = true;
            this.cmbFiltradoPersonal.Location = new System.Drawing.Point(612, 48);
            this.cmbFiltradoPersonal.Name = "cmbFiltradoPersonal";
            this.cmbFiltradoPersonal.Size = new System.Drawing.Size(138, 25);
            this.cmbFiltradoPersonal.TabIndex = 122;
            this.cmbFiltradoPersonal.SelectedIndexChanged += new System.EventHandler(this.CboFiltradoPersonal_SelectedIndexChanged);
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.btnAgregarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonal.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAgregarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(23, 92);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(101, 34);
            this.btnAgregarPersonal.TabIndex = 121;
            this.btnAgregarPersonal.Text = "Añadir";
            this.btnAgregarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPersonal.UseVisualStyleBackColor = true;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.BtnAgregarPersonal_Click);
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPersonal.FlatAppearance.BorderSize = 0;
            this.btnEliminarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPersonal.Location = new System.Drawing.Point(724, 101);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(29, 25);
            this.btnEliminarPersonal.TabIndex = 120;
            this.btnEliminarPersonal.UseVisualStyleBackColor = true;
            this.btnEliminarPersonal.Click += new System.EventHandler(this.BtnEliminarPersonal_Click);
            // 
            // btnVerPersonal
            // 
            this.btnVerPersonal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPersonal.FlatAppearance.BorderSize = 0;
            this.btnVerPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPersonal.Location = new System.Drawing.Point(689, 101);
            this.btnVerPersonal.Name = "btnVerPersonal";
            this.btnVerPersonal.Size = new System.Drawing.Size(29, 25);
            this.btnVerPersonal.TabIndex = 119;
            this.btnVerPersonal.UseVisualStyleBackColor = false;
            this.btnVerPersonal.Click += new System.EventHandler(this.BtnVerPersonal_Click);
            // 
            // btnEditarPersonal
            // 
            this.btnEditarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPersonal.FlatAppearance.BorderSize = 0;
            this.btnEditarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPersonal.Location = new System.Drawing.Point(654, 101);
            this.btnEditarPersonal.Name = "btnEditarPersonal";
            this.btnEditarPersonal.Size = new System.Drawing.Size(29, 25);
            this.btnEditarPersonal.TabIndex = 118;
            this.btnEditarPersonal.UseVisualStyleBackColor = true;
            this.btnEditarPersonal.Click += new System.EventHandler(this.BtnEditarPersonal_Click);
            // 
            // txtBusquedaPersonal
            // 
            this.txtBusquedaPersonal.BackColor = System.Drawing.Color.Gray;
            this.txtBusquedaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPersonal.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaPersonal.Location = new System.Drawing.Point(126, 49);
            this.txtBusquedaPersonal.Name = "txtBusquedaPersonal";
            this.txtBusquedaPersonal.Size = new System.Drawing.Size(483, 23);
            this.txtBusquedaPersonal.TabIndex = 117;
            this.txtBusquedaPersonal.Text = "Busqueda";
            this.txtBusquedaPersonal.TextChanged += new System.EventHandler(this.TxtBusquedaPersonal_TextChanged);
            this.txtBusquedaPersonal.Enter += new System.EventHandler(this.TxtBusquedaPersonal_Enter);
            this.txtBusquedaPersonal.Leave += new System.EventHandler(this.TxtBusquedaPersonal_Leave);
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 116;
            this.Controles.Text = "Controles";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 123;
            this.label1.Text = "Formulario para  Personal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoPersonal);
            this.Controls.Add(this.btnAgregarPersonal);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.btnVerPersonal);
            this.Controls.Add(this.btnEditarPersonal);
            this.Controls.Add(this.txtBusquedaPersonal);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPersonal";
            this.Load += new System.EventHandler(this.FmrPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.ComboBox cmbFiltradoPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.Button btnEliminarPersonal;
        private System.Windows.Forms.Button btnVerPersonal;
        private System.Windows.Forms.Button btnEditarPersonal;
        private System.Windows.Forms.TextBox txtBusquedaPersonal;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}