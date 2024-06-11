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
            this.cmbFiltradoPersonal = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaPersonal = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirPersonal = new Guna.UI2.WinForms.Guna2Button();
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
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(18, 48);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 116;
            this.Controles.Text = "Controles";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 123;
            this.label1.Text = "Formulario para  Personal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaPersonal
            // 
            this.txtBusquedaPersonal.AutoSize = true;
            this.txtBusquedaPersonal.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaPersonal.BorderRadius = 5;
            this.txtBusquedaPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaPersonal.DefaultText = "Busqueda";
            this.txtBusquedaPersonal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaPersonal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaPersonal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaPersonal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPersonal.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaPersonal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaPersonal.Location = new System.Drawing.Point(126, 48);
            this.txtBusquedaPersonal.Name = "txtBusquedaPersonal";
            this.txtBusquedaPersonal.PasswordChar = '\0';
            this.txtBusquedaPersonal.PlaceholderText = "";
            this.txtBusquedaPersonal.SelectedText = "";
            this.txtBusquedaPersonal.Size = new System.Drawing.Size(480, 25);
            this.txtBusquedaPersonal.TabIndex = 150;
            this.txtBusquedaPersonal.Enter += new System.EventHandler(this.txtBusquedaPersonal_Enter_1);
            this.txtBusquedaPersonal.Leave += new System.EventHandler(this.txtBusquedaPersonal_Leave_1);
            // 
            // btnVerPersonal
            // 
            this.btnVerPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPersonal.BorderRadius = 12;
            this.btnVerPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPersonal.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerPersonal.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerPersonal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerPersonal.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerPersonal.Location = new System.Drawing.Point(670, 101);
            this.btnVerPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPersonal.Name = "btnVerPersonal";
            this.btnVerPersonal.Size = new System.Drawing.Size(39, 25);
            this.btnVerPersonal.TabIndex = 149;
            this.btnVerPersonal.TextFormatNoPrefix = true;
            // 
            // btnEditarPersonal
            // 
            this.btnEditarPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarPersonal.BorderRadius = 12;
            this.btnEditarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPersonal.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarPersonal.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarPersonal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarPersonal.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarPersonal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarPersonal.Location = new System.Drawing.Point(620, 101);
            this.btnEditarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPersonal.Name = "btnEditarPersonal";
            this.btnEditarPersonal.Size = new System.Drawing.Size(44, 25);
            this.btnEditarPersonal.TabIndex = 148;
            this.btnEditarPersonal.TextFormatNoPrefix = true;
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPersonal.BorderRadius = 12;
            this.btnEliminarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPersonal.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPersonal.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarPersonal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarPersonal.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarPersonal.Location = new System.Drawing.Point(713, 101);
            this.btnEliminarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(39, 25);
            this.btnEliminarPersonal.TabIndex = 147;
            this.btnEliminarPersonal.TextFormatNoPrefix = true;
            // 
            // btnAñadirPersonal
            // 
            this.btnAñadirPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirPersonal.BorderRadius = 12;
            this.btnAñadirPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirPersonal.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirPersonal.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirPersonal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirPersonal.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirPersonal.Location = new System.Drawing.Point(21, 86);
            this.btnAñadirPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirPersonal.Name = "btnAñadirPersonal";
            this.btnAñadirPersonal.Size = new System.Drawing.Size(100, 40);
            this.btnAñadirPersonal.TabIndex = 146;
            this.btnAñadirPersonal.Text = "Añadir";
            this.btnAñadirPersonal.TextFormatNoPrefix = true;
            this.btnAñadirPersonal.Click += new System.EventHandler(this.btnAñadirPersonal_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.txtBusquedaPersonal);
            this.Controls.Add(this.btnVerPersonal);
            this.Controls.Add(this.btnEditarPersonal);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.btnAñadirPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoPersonal);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.ComboBox cmbFiltradoPersonal;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaPersonal;
        private Guna.UI2.WinForms.Guna2Button btnVerPersonal;
        private Guna.UI2.WinForms.Guna2Button btnEditarPersonal;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPersonal;
        private Guna.UI2.WinForms.Guna2Button btnAñadirPersonal;
    }
}