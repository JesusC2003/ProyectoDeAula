namespace Presentacion
{
    partial class frmGalpon
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
            this.cmbFiltradoG = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaGalpon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerGalpon = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarGalpon = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarGalpon = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirGalpon = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGalpon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGalpon
            // 
            this.dgvGalpon.AllowUserToAddRows = false;
            this.dgvGalpon.AllowUserToDeleteRows = false;
            this.dgvGalpon.AllowUserToResizeColumns = false;
            this.dgvGalpon.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGalpon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGalpon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGalpon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.dgvGalpon.EnableHeadersVisualStyles = false;
            this.dgvGalpon.GridColor = System.Drawing.Color.Black;
            this.dgvGalpon.Location = new System.Drawing.Point(20, 130);
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
            this.dgvGalpon.Size = new System.Drawing.Size(732, 389);
            this.dgvGalpon.TabIndex = 110;
            // 
            // cmbFiltradoG
            // 
            this.cmbFiltradoG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltradoG.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoG.FormattingEnabled = true;
            this.cmbFiltradoG.Location = new System.Drawing.Point(612, 48);
            this.cmbFiltradoG.Name = "cmbFiltradoG";
            this.cmbFiltradoG.Size = new System.Drawing.Size(138, 24);
            this.cmbFiltradoG.TabIndex = 122;
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
            this.label1.TabIndex = 124;
            this.label1.Text = "Formulario para  Galpon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaGalpon
            // 
            this.txtBusquedaGalpon.AutoSize = true;
            this.txtBusquedaGalpon.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaGalpon.BorderRadius = 5;
            this.txtBusquedaGalpon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaGalpon.DefaultText = "Busqueda";
            this.txtBusquedaGalpon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaGalpon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaGalpon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaGalpon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaGalpon.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaGalpon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaGalpon.Location = new System.Drawing.Point(126, 48);
            this.txtBusquedaGalpon.Name = "txtBusquedaGalpon";
            this.txtBusquedaGalpon.PasswordChar = '\0';
            this.txtBusquedaGalpon.PlaceholderText = "";
            this.txtBusquedaGalpon.SelectedText = "";
            this.txtBusquedaGalpon.Size = new System.Drawing.Size(480, 25);
            this.txtBusquedaGalpon.TabIndex = 160;
            this.txtBusquedaGalpon.Enter += new System.EventHandler(this.txtBusquedaGalpon_Enter_1);
            this.txtBusquedaGalpon.Leave += new System.EventHandler(this.txtBusquedaGalpon_Leave_1);
            // 
            // btnVerGalpon
            // 
            this.btnVerGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnVerGalpon.BorderRadius = 12;
            this.btnVerGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerGalpon.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerGalpon.Location = new System.Drawing.Point(670, 101);
            this.btnVerGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerGalpon.Name = "btnVerGalpon";
            this.btnVerGalpon.Size = new System.Drawing.Size(39, 25);
            this.btnVerGalpon.TabIndex = 159;
            this.btnVerGalpon.TextFormatNoPrefix = true;
            // 
            // btnEditarGalpon
            // 
            this.btnEditarGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarGalpon.BorderRadius = 12;
            this.btnEditarGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarGalpon.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarGalpon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarGalpon.Location = new System.Drawing.Point(620, 101);
            this.btnEditarGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarGalpon.Name = "btnEditarGalpon";
            this.btnEditarGalpon.Size = new System.Drawing.Size(44, 25);
            this.btnEditarGalpon.TabIndex = 158;
            this.btnEditarGalpon.TextFormatNoPrefix = true;
            // 
            // btnEliminarGalpon
            // 
            this.btnEliminarGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGalpon.BorderRadius = 12;
            this.btnEliminarGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarGalpon.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarGalpon.Location = new System.Drawing.Point(713, 101);
            this.btnEliminarGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarGalpon.Name = "btnEliminarGalpon";
            this.btnEliminarGalpon.Size = new System.Drawing.Size(39, 25);
            this.btnEliminarGalpon.TabIndex = 157;
            this.btnEliminarGalpon.TextFormatNoPrefix = true;
            // 
            // btnAñadirGalpon
            // 
            this.btnAñadirGalpon.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirGalpon.BorderRadius = 12;
            this.btnAñadirGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirGalpon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirGalpon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirGalpon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirGalpon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirGalpon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirGalpon.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirGalpon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirGalpon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirGalpon.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirGalpon.Location = new System.Drawing.Point(21, 86);
            this.btnAñadirGalpon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirGalpon.Name = "btnAñadirGalpon";
            this.btnAñadirGalpon.Size = new System.Drawing.Size(100, 40);
            this.btnAñadirGalpon.TabIndex = 156;
            this.btnAñadirGalpon.Text = "Añadir";
            this.btnAñadirGalpon.TextFormatNoPrefix = true;
            this.btnAñadirGalpon.Click += new System.EventHandler(this.btnAñadirGalpon_Click);
            // 
            // frmGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.txtBusquedaGalpon);
            this.Controls.Add(this.btnVerGalpon);
            this.Controls.Add(this.btnEditarGalpon);
            this.Controls.Add(this.btnEliminarGalpon);
            this.Controls.Add(this.btnAñadirGalpon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoG);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvGalpon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGalpon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGalpon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGalpon;
        private System.Windows.Forms.ComboBox cmbFiltradoG;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaGalpon;
        private Guna.UI2.WinForms.Guna2Button btnVerGalpon;
        private Guna.UI2.WinForms.Guna2Button btnEditarGalpon;
        private Guna.UI2.WinForms.Guna2Button btnEliminarGalpon;
        private Guna.UI2.WinForms.Guna2Button btnAñadirGalpon;
    }
}