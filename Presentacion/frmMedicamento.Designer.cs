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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicamenti = new System.Windows.Forms.DataGridView();
            this.cmbFiltradoM = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaMedicamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerMedicamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarMedicamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarMedicamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnAñadirMedicamento = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicamenti
            // 
            this.dgvMedicamenti.AllowUserToAddRows = false;
            this.dgvMedicamenti.AllowUserToDeleteRows = false;
            this.dgvMedicamenti.AllowUserToResizeColumns = false;
            this.dgvMedicamenti.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicamenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicamenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMedicamenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicamenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicamenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedicamenti.ColumnHeadersHeight = 24;
            this.dgvMedicamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMedicamenti.EnableHeadersVisualStyles = false;
            this.dgvMedicamenti.Location = new System.Drawing.Point(20, 130);
            this.dgvMedicamenti.MultiSelect = false;
            this.dgvMedicamenti.Name = "dgvMedicamenti";
            this.dgvMedicamenti.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(18, 48);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 124;
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
            this.label1.TabIndex = 131;
            this.label1.Text = "Formulario para  Medicamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaMedicamento
            // 
            this.txtBusquedaMedicamento.AutoSize = true;
            this.txtBusquedaMedicamento.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaMedicamento.BorderRadius = 5;
            this.txtBusquedaMedicamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaMedicamento.DefaultText = "Busqueda";
            this.txtBusquedaMedicamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaMedicamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaMedicamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaMedicamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaMedicamento.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaMedicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaMedicamento.Location = new System.Drawing.Point(126, 48);
            this.txtBusquedaMedicamento.Name = "txtBusquedaMedicamento";
            this.txtBusquedaMedicamento.PasswordChar = '\0';
            this.txtBusquedaMedicamento.PlaceholderText = "";
            this.txtBusquedaMedicamento.SelectedText = "";
            this.txtBusquedaMedicamento.Size = new System.Drawing.Size(480, 25);
            this.txtBusquedaMedicamento.TabIndex = 155;
            this.txtBusquedaMedicamento.Enter += new System.EventHandler(this.txtBusquedaMedicamento_Enter_1);
            this.txtBusquedaMedicamento.Leave += new System.EventHandler(this.txtBusquedaMedicamento_Leave_1);
            // 
            // btnVerMedicamento
            // 
            this.btnVerMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.btnVerMedicamento.BorderRadius = 12;
            this.btnVerMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerMedicamento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnVerMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerMedicamento.FillColor = System.Drawing.Color.LightBlue;
            this.btnVerMedicamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnVerMedicamento.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnVerMedicamento.Location = new System.Drawing.Point(670, 101);
            this.btnVerMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerMedicamento.Name = "btnVerMedicamento";
            this.btnVerMedicamento.Size = new System.Drawing.Size(39, 25);
            this.btnVerMedicamento.TabIndex = 154;
            this.btnVerMedicamento.TextFormatNoPrefix = true;
            // 
            // btnEditarMedicamento
            // 
            this.btnEditarMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarMedicamento.BorderRadius = 12;
            this.btnEditarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMedicamento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEditarMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarMedicamento.FillColor = System.Drawing.Color.LightBlue;
            this.btnEditarMedicamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEditarMedicamento.Image = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditarMedicamento.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditarMedicamento.Location = new System.Drawing.Point(620, 101);
            this.btnEditarMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarMedicamento.Name = "btnEditarMedicamento";
            this.btnEditarMedicamento.Size = new System.Drawing.Size(44, 25);
            this.btnEditarMedicamento.TabIndex = 153;
            this.btnEditarMedicamento.TextFormatNoPrefix = true;
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarMedicamento.BorderRadius = 12;
            this.btnEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMedicamento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMedicamento.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarMedicamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarMedicamento.Image = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(713, 101);
            this.btnEliminarMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(39, 25);
            this.btnEliminarMedicamento.TabIndex = 152;
            this.btnEliminarMedicamento.TextFormatNoPrefix = true;
            // 
            // btnAñadirMedicamento
            // 
            this.btnAñadirMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirMedicamento.BorderRadius = 12;
            this.btnAñadirMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirMedicamento.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadirMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadirMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadirMedicamento.FillColor = System.Drawing.Color.LightBlue;
            this.btnAñadirMedicamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAñadirMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAñadirMedicamento.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.btnAñadirMedicamento.Location = new System.Drawing.Point(21, 86);
            this.btnAñadirMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirMedicamento.Name = "btnAñadirMedicamento";
            this.btnAñadirMedicamento.Size = new System.Drawing.Size(100, 40);
            this.btnAñadirMedicamento.TabIndex = 151;
            this.btnAñadirMedicamento.Text = "Añadir";
            this.btnAñadirMedicamento.TextFormatNoPrefix = true;
            this.btnAñadirMedicamento.Click += new System.EventHandler(this.btnAñadirMedicamento_Click);
            // 
            // frmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.txtBusquedaMedicamento);
            this.Controls.Add(this.btnVerMedicamento);
            this.Controls.Add(this.btnEditarMedicamento);
            this.Controls.Add(this.btnEliminarMedicamento);
            this.Controls.Add(this.btnAñadirMedicamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltradoM);
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
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnVerMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnEditarMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnAñadirMedicamento;
    }
}