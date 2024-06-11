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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlimento = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoA = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaAlimento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerAlimento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarAlimento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarAlimento = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirAlimento = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlimento
            // 
            this.dgvAlimento.AllowUserToAddRows = false;
            this.dgvAlimento.AllowUserToDeleteRows = false;
            this.dgvAlimento.AllowUserToResizeColumns = false;
            this.dgvAlimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAlimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAlimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAlimento.ColumnHeadersHeight = 24;
            this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimento.EnableHeadersVisualStyles = false;
            this.dgvAlimento.Location = new System.Drawing.Point(20, 130);
            this.dgvAlimento.MultiSelect = false;
            this.dgvAlimento.Name = "dgvAlimento";
            this.dgvAlimento.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(18, 48);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 123;
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
            this.label1.TabIndex = 130;
            this.label1.Text = "Formulario para Alimento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaAlimento
            // 
            this.txtBusquedaAlimento.AutoSize = true;
            this.txtBusquedaAlimento.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaAlimento.BorderRadius = 5;
            this.txtBusquedaAlimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaAlimento.DefaultText = "Busqueda";
            this.txtBusquedaAlimento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaAlimento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaAlimento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaAlimento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaAlimento.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaAlimento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaAlimento.Location = new System.Drawing.Point(126, 48);
            this.txtBusquedaAlimento.Name = "txtBusquedaAlimento";
            this.txtBusquedaAlimento.PasswordChar = '\0';
            this.txtBusquedaAlimento.PlaceholderText = "";
            this.txtBusquedaAlimento.SelectedText = "";
            this.txtBusquedaAlimento.Size = new System.Drawing.Size(480, 25);
            this.txtBusquedaAlimento.TabIndex = 150;
            this.txtBusquedaAlimento.Enter += new System.EventHandler(this.txtBusquedaAlimento_Enter_1);
            this.txtBusquedaAlimento.Leave += new System.EventHandler(this.txtBusquedaAlimento_Leave_1);
            // 
            // btnVerAlimento
            // 
            this.btnVerAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnVerAlimento.BorderRadius = 12;
            this.btnVerAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerAlimento.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerAlimento.Location = new System.Drawing.Point(670, 101);
            this.btnVerAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerAlimento.Name = "btnVerAlimento";
            this.btnVerAlimento.Size = new System.Drawing.Size(39, 25);
            this.btnVerAlimento.TabIndex = 149;
            this.btnVerAlimento.TextFormatNoPrefix = true;
            // 
            // btnEditarAlimento
            // 
            this.btnEditarAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAlimento.BorderRadius = 12;
            this.btnEditarAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarAlimento.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarAlimento.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarAlimento.Location = new System.Drawing.Point(620, 101);
            this.btnEditarAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarAlimento.Name = "btnEditarAlimento";
            this.btnEditarAlimento.Size = new System.Drawing.Size(44, 25);
            this.btnEditarAlimento.TabIndex = 148;
            this.btnEditarAlimento.TextFormatNoPrefix = true;
            // 
            // btnEliminarAlimento
            // 
            this.btnEliminarAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarAlimento.BorderRadius = 12;
            this.btnEliminarAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarAlimento.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarAlimento.Location = new System.Drawing.Point(713, 101);
            this.btnEliminarAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarAlimento.Name = "btnEliminarAlimento";
            this.btnEliminarAlimento.Size = new System.Drawing.Size(39, 25);
            this.btnEliminarAlimento.TabIndex = 147;
            this.btnEliminarAlimento.TextFormatNoPrefix = true;
            // 
            // btnAñadirAlimento
            // 
            this.btnAñadirAlimento.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirAlimento.BorderRadius = 12;
            this.btnAñadirAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirAlimento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirAlimento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirAlimento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirAlimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirAlimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirAlimento.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirAlimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirAlimento.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirAlimento.Location = new System.Drawing.Point(21, 86);
            this.btnAñadirAlimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirAlimento.Name = "btnAñadirAlimento";
            this.btnAñadirAlimento.Size = new System.Drawing.Size(100, 40);
            this.btnAñadirAlimento.TabIndex = 146;
            this.btnAñadirAlimento.Text = "Añadir";
            this.btnAñadirAlimento.TextFormatNoPrefix = true;
            this.btnAñadirAlimento.Click += new System.EventHandler(this.btnAñadirAlimento_Click);
            // 
            // frmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.txtBusquedaAlimento);
            this.Controls.Add(this.btnVerAlimento);
            this.Controls.Add(this.btnEditarAlimento);
            this.Controls.Add(this.btnEliminarAlimento);
            this.Controls.Add(this.btnAñadirAlimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoA);
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
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaAlimento;
        private Guna.UI2.WinForms.Guna2Button btnVerAlimento;
        private Guna.UI2.WinForms.Guna2Button btnEditarAlimento;
        private Guna.UI2.WinForms.Guna2Button btnEliminarAlimento;
        private Guna.UI2.WinForms.Guna2Button btnAñadirAlimento;
    }
}