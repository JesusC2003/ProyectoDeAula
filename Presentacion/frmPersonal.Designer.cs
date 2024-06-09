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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.CboFiltradoPersonal = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPersonal = new System.Windows.Forms.Button();
            this.BtnEliminarPersonal = new System.Windows.Forms.Button();
            this.BtnVerPersonal = new System.Windows.Forms.Button();
            this.BtnEditarPersonal = new System.Windows.Forms.Button();
            this.TxtBusquedaPersonal = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonal.ColumnHeadersHeight = 24;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonal.EnableHeadersVisualStyles = false;
            this.dgvPersonal.Location = new System.Drawing.Point(20, 130);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(732, 389);
            this.dgvPersonal.TabIndex = 109;
            this.dgvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellContentClick);

            // 
            // CboFiltradoPersonal
            // 
            this.CboFiltradoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFiltradoPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoPersonal.FormattingEnabled = true;
            this.CboFiltradoPersonal.Location = new System.Drawing.Point(612, 48);
            this.CboFiltradoPersonal.Name = "CboFiltradoPersonal";
            this.CboFiltradoPersonal.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoPersonal.TabIndex = 122;
            this.CboFiltradoPersonal.SelectedIndexChanged += new System.EventHandler(this.CboFiltradoPersonal_SelectedIndexChanged);
            // 
            // BtnAgregarPersonal
            // 
            this.BtnAgregarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPersonal.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarPersonal.Location = new System.Drawing.Point(23, 92);
            this.BtnAgregarPersonal.Name = "BtnAgregarPersonal";
            this.BtnAgregarPersonal.Size = new System.Drawing.Size(101, 34);
            this.BtnAgregarPersonal.TabIndex = 121;
            this.BtnAgregarPersonal.Text = "Añadir";
            this.BtnAgregarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarPersonal.UseVisualStyleBackColor = true;
            this.BtnAgregarPersonal.Click += new System.EventHandler(this.BtnAgregarPersonal_Click);
            // 
            // BtnEliminarPersonal
            // 
            this.BtnEliminarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPersonal.Location = new System.Drawing.Point(724, 101);
            this.BtnEliminarPersonal.Name = "BtnEliminarPersonal";
            this.BtnEliminarPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarPersonal.TabIndex = 120;
            this.BtnEliminarPersonal.UseVisualStyleBackColor = true;
            this.BtnEliminarPersonal.Click += new System.EventHandler(this.BtnEliminarPersonal_Click);
            // 
            // BtnVerPersonal
            // 
            this.BtnVerPersonal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVerPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.BtnVerPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerPersonal.FlatAppearance.BorderSize = 0;
            this.BtnVerPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerPersonal.Location = new System.Drawing.Point(689, 101);
            this.BtnVerPersonal.Name = "BtnVerPersonal";
            this.BtnVerPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnVerPersonal.TabIndex = 119;
            this.BtnVerPersonal.UseVisualStyleBackColor = false;
            this.BtnVerPersonal.Click += new System.EventHandler(this.BtnVerPersonal_Click);
            // 
            // BtnEditarPersonal
            // 
            this.BtnEditarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnEditarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarPersonal.Location = new System.Drawing.Point(654, 101);
            this.BtnEditarPersonal.Name = "BtnEditarPersonal";
            this.BtnEditarPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarPersonal.TabIndex = 118;
            this.BtnEditarPersonal.UseVisualStyleBackColor = true;
            this.BtnEditarPersonal.Click += new System.EventHandler(this.BtnEditarPersonal_Click);
            // 
            // TxtBusquedaPersonal
            // 
            this.TxtBusquedaPersonal.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaPersonal.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaPersonal.Location = new System.Drawing.Point(126, 49);
            this.TxtBusquedaPersonal.Name = "TxtBusquedaPersonal";
            this.TxtBusquedaPersonal.Size = new System.Drawing.Size(483, 23);
            this.TxtBusquedaPersonal.TabIndex = 117;
            this.TxtBusquedaPersonal.Text = "Busqueda";
            this.TxtBusquedaPersonal.TextChanged += new System.EventHandler(this.TxtBusquedaPersonal_TextChanged);
            this.TxtBusquedaPersonal.Enter += new System.EventHandler(this.TxtBusquedaPersonal_Enter);
            this.TxtBusquedaPersonal.Leave += new System.EventHandler(this.TxtBusquedaPersonal_Leave);
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
            // FmrPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboFiltradoPersonal);
            this.Controls.Add(this.BtnAgregarPersonal);
            this.Controls.Add(this.BtnEliminarPersonal);
            this.Controls.Add(this.BtnVerPersonal);
            this.Controls.Add(this.BtnEditarPersonal);
            this.Controls.Add(this.TxtBusquedaPersonal);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPersonal";
            this.Load += new System.EventHandler(this.FmrPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.ComboBox CboFiltradoPersonal;
        private System.Windows.Forms.Button BtnAgregarPersonal;
        private System.Windows.Forms.Button BtnEliminarPersonal;
        private System.Windows.Forms.Button BtnVerPersonal;
        private System.Windows.Forms.Button BtnEditarPersonal;
        private System.Windows.Forms.TextBox TxtBusquedaPersonal;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}