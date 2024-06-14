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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoV = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerVentas = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusquedaVentas = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeight = 24;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(27, 160);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(976, 479);
            this.dgvVentas.TabIndex = 107;
            // 
            // cmbFiltradoV
            // 
            this.cmbFiltradoV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltradoV.FormattingEnabled = true;
            this.cmbFiltradoV.Location = new System.Drawing.Point(816, 59);
            this.cmbFiltradoV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltradoV.Name = "cmbFiltradoV";
            this.cmbFiltradoV.Size = new System.Drawing.Size(183, 28);
            this.cmbFiltradoV.TabIndex = 136;
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(24, 59);
            this.Controles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(137, 28);
            this.Controles.TabIndex = 130;
            this.Controles.Text = "Controles";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 27);
            this.label1.TabIndex = 137;
            this.label1.Text = "Formulario para  ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAñadirVentas
            // 
            this.btnAñadirVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirVentas.BorderRadius = 12;
            this.btnAñadirVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirVentas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirVentas.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirVentas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirVentas.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirVentas.Location = new System.Drawing.Point(28, 106);
            this.btnAñadirVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirVentas.Name = "btnAñadirVentas";
            this.btnAñadirVentas.Size = new System.Drawing.Size(133, 49);
            this.btnAñadirVentas.TabIndex = 141;
            this.btnAñadirVentas.Text = "Añadir";
            this.btnAñadirVentas.TextFormatNoPrefix = true;
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarVentas.BorderRadius = 12;
            this.btnEliminarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarVentas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarVentas.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarVentas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarVentas.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarVentas.Location = new System.Drawing.Point(951, 124);
            this.btnEliminarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(52, 31);
            this.btnEliminarVentas.TabIndex = 142;
            this.btnEliminarVentas.TextFormatNoPrefix = true;
            // 
            // btnEditarVentas
            // 
            this.btnEditarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarVentas.BorderRadius = 12;
            this.btnEditarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarVentas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarVentas.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarVentas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarVentas.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarVentas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarVentas.Location = new System.Drawing.Point(827, 124);
            this.btnEditarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarVentas.Name = "btnEditarVentas";
            this.btnEditarVentas.Size = new System.Drawing.Size(59, 31);
            this.btnEditarVentas.TabIndex = 143;
            this.btnEditarVentas.TextFormatNoPrefix = true;
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BorderRadius = 12;
            this.btnVerVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerVentas.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerVentas.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerVentas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerVentas.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerVentas.Location = new System.Drawing.Point(893, 124);
            this.btnVerVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(52, 31);
            this.btnVerVentas.TabIndex = 144;
            this.btnVerVentas.TextFormatNoPrefix = true;
            // 
            // txtBusquedaVentas
            // 
            this.txtBusquedaVentas.AutoSize = true;
            this.txtBusquedaVentas.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaVentas.BorderRadius = 5;
            this.txtBusquedaVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaVentas.DefaultText = "Busqueda";
            this.txtBusquedaVentas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaVentas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaVentas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaVentas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaVentas.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaVentas.Location = new System.Drawing.Point(168, 59);
            this.txtBusquedaVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusquedaVentas.Name = "txtBusquedaVentas";
            this.txtBusquedaVentas.PasswordChar = '\0';
            this.txtBusquedaVentas.PlaceholderText = "";
            this.txtBusquedaVentas.SelectedText = "";
            this.txtBusquedaVentas.Size = new System.Drawing.Size(849, 31);
            this.txtBusquedaVentas.TabIndex = 145;
            this.txtBusquedaVentas.Enter += new System.EventHandler(this.txtBusquedaVentas_Enter_1);
            this.txtBusquedaVentas.Leave += new System.EventHandler(this.txtBusquedaVentas_Leave_1);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.txtBusquedaVentas);
            this.Controls.Add(this.btnVerVentas);
            this.Controls.Add(this.btnEditarVentas);
            this.Controls.Add(this.btnEliminarVentas);
            this.Controls.Add(this.btnAñadirVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoV);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbFiltradoV;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAñadirVentas;
        private Guna.UI2.WinForms.Guna2Button btnEliminarVentas;
        private Guna.UI2.WinForms.Guna2Button btnEditarVentas;
        private Guna.UI2.WinForms.Guna2Button btnVerVentas;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaVentas;
    }
}