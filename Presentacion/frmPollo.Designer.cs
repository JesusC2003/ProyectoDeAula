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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarP = new System.Windows.Forms.Button();
            this.BtnVerP = new System.Windows.Forms.Button();
            this.BtnEditarP = new System.Windows.Forms.Button();
            this.txtBusquedapollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirPollo = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVista = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).BeginInit();
            this.SuspendLayout();
            // 
            // Controles
            // 
            this.Controles.BackColor = System.Drawing.Color.Transparent;
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(22, 48);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(94, 33);
            this.Controles.TabIndex = 109;
            this.Controles.Text = "Controles";
            this.Controles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtBusquedapollo
            // 
            this.txtBusquedapollo.AutoSize = true;
            this.txtBusquedapollo.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedapollo.BorderRadius = 5;
            this.txtBusquedapollo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtBusquedapollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedapollo.DefaultText = "Busqueda";
            this.txtBusquedapollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedapollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedapollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedapollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedapollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedapollo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedapollo.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedapollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedapollo.Location = new System.Drawing.Point(118, 48);
            this.txtBusquedapollo.Name = "txtBusquedapollo";
            this.txtBusquedapollo.PasswordChar = '\0';
            this.txtBusquedapollo.PlaceholderText = "";
            this.txtBusquedapollo.SelectedText = "";
            this.txtBusquedapollo.Size = new System.Drawing.Size(496, 36);
            this.txtBusquedapollo.TabIndex = 134;
            this.txtBusquedapollo.Enter += new System.EventHandler(this.txtBusquedapollo_Enter_1);
            this.txtBusquedapollo.Leave += new System.EventHandler(this.txtBusquedapollo_Leave_1);
            // 
            // btnVerPollo
            // 
            this.btnVerPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPollo.BorderRadius = 12;
            this.btnVerPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerPollo.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerPollo.Location = new System.Drawing.Point(670, 101);
            this.btnVerPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPollo.Name = "btnVerPollo";
            this.btnVerPollo.Size = new System.Drawing.Size(39, 25);
            this.btnVerPollo.TabIndex = 148;
            this.btnVerPollo.TextFormatNoPrefix = true;
            // 
            // btnEditarPollo
            // 
            this.btnEditarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarPollo.BorderRadius = 12;
            this.btnEditarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarPollo.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarPollo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarPollo.Location = new System.Drawing.Point(620, 101);
            this.btnEditarPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPollo.Name = "btnEditarPollo";
            this.btnEditarPollo.Size = new System.Drawing.Size(44, 25);
            this.btnEditarPollo.TabIndex = 147;
            this.btnEditarPollo.TextFormatNoPrefix = true;
            // 
            // btnEliminarPollo
            // 
            this.btnEliminarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPollo.BorderRadius = 12;
            this.btnEliminarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarPollo.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarPollo.Location = new System.Drawing.Point(713, 101);
            this.btnEliminarPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPollo.Name = "btnEliminarPollo";
            this.btnEliminarPollo.Size = new System.Drawing.Size(39, 25);
            this.btnEliminarPollo.TabIndex = 146;
            this.btnEliminarPollo.TextFormatNoPrefix = true;
            // 
            // btnAñadirPollo
            // 
            this.btnAñadirPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirPollo.BorderRadius = 12;
            this.btnAñadirPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirPollo.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirPollo.Location = new System.Drawing.Point(21, 101);
            this.btnAñadirPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirPollo.Name = "btnAñadirPollo";
            this.btnAñadirPollo.Size = new System.Drawing.Size(100, 25);
            this.btnAñadirPollo.TabIndex = 145;
            this.btnAñadirPollo.Text = "Añadir";
            this.btnAñadirPollo.TextFormatNoPrefix = true;
            this.btnAñadirPollo.Click += new System.EventHandler(this.btnAñadirPollo_Click);
            // 
            // dgvVista
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvVista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvVista.Location = new System.Drawing.Point(12, 131);
            this.dgvVista.Name = "dgvVista";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVista.RowHeadersVisible = false;
            this.dgvVista.Size = new System.Drawing.Size(738, 388);
            this.dgvVista.TabIndex = 149;
            this.dgvVista.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvVista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvVista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvVista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvVista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVista.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvVista.ThemeStyle.ReadOnly = false;
            this.dgvVista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvVista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVista.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvVista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltro.BorderRadius = 5;
            this.cmbFiltro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cmbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFiltro.ItemHeight = 30;
            this.cmbFiltro.Location = new System.Drawing.Point(620, 48);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(132, 36);
            this.cmbFiltro.TabIndex = 150;
            // 
            // frmPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.dgvVista);
            this.Controls.Add(this.btnVerPollo);
            this.Controls.Add(this.btnEditarPollo);
            this.Controls.Add(this.btnEliminarPollo);
            this.Controls.Add(this.btnAñadirPollo);
            this.Controls.Add(this.txtBusquedapollo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarP);
            this.Controls.Add(this.BtnVerP);
            this.Controls.Add(this.BtnEditarP);
            this.Controls.Add(this.Controles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPollo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPollo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Button BtnEditarP;
        private System.Windows.Forms.Button BtnVerP;
        private System.Windows.Forms.Button BtnEliminarP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedapollo;
        private Guna.UI2.WinForms.Guna2Button btnVerPollo;
        private Guna.UI2.WinForms.Guna2Button btnEditarPollo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPollo;
        private Guna.UI2.WinForms.Guna2Button btnAñadirPollo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVista;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltro;
    }
}