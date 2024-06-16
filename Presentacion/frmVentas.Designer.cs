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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFacturaRealizada = new System.Windows.Forms.DataGridView();
            this.cmbFiltrado = new System.Windows.Forms.ComboBox();
            this.btnEliminarFactura = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusquedaVentas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacturar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGraficaBarra = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlGraficaPastel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaRealizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturaRealizada
            // 
            this.dgvFacturaRealizada.AllowUserToAddRows = false;
            this.dgvFacturaRealizada.AllowUserToDeleteRows = false;
            this.dgvFacturaRealizada.AllowUserToResizeColumns = false;
            this.dgvFacturaRealizada.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturaRealizada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFacturaRealizada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturaRealizada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFacturaRealizada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturaRealizada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturaRealizada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturaRealizada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFacturaRealizada.ColumnHeadersHeight = 24;
            this.dgvFacturaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFacturaRealizada.EnableHeadersVisualStyles = false;
            this.dgvFacturaRealizada.Location = new System.Drawing.Point(11, 331);
            this.dgvFacturaRealizada.MultiSelect = false;
            this.dgvFacturaRealizada.Name = "dgvFacturaRealizada";
            this.dgvFacturaRealizada.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturaRealizada.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFacturaRealizada.RowHeadersVisible = false;
            this.dgvFacturaRealizada.RowHeadersWidth = 51;
            this.dgvFacturaRealizada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturaRealizada.Size = new System.Drawing.Size(626, 262);
            this.dgvFacturaRealizada.TabIndex = 107;
            // 
            // cmbFiltrado
            // 
            this.cmbFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrado.FormattingEnabled = true;
            this.cmbFiltrado.Location = new System.Drawing.Point(500, 267);
            this.cmbFiltrado.Name = "cmbFiltrado";
            this.cmbFiltrado.Size = new System.Drawing.Size(137, 26);
            this.cmbFiltrado.TabIndex = 183;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarFactura.BorderRadius = 12;
            this.btnEliminarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFactura.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarFactura.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarFactura.Location = new System.Drawing.Point(667, 465);
            this.btnEliminarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarFactura.TabIndex = 181;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.TextFormatNoPrefix = true;
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
            this.txtBusquedaVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaVentas.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaVentas.Location = new System.Drawing.Point(12, 267);
            this.txtBusquedaVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusquedaVentas.Name = "txtBusquedaVentas";
            this.txtBusquedaVentas.PasswordChar = '\0';
            this.txtBusquedaVentas.PlaceholderText = "";
            this.txtBusquedaVentas.SelectedText = "";
            this.txtBusquedaVentas.Size = new System.Drawing.Size(482, 27);
            this.txtBusquedaVentas.TabIndex = 178;
            this.txtBusquedaVentas.Enter += new System.EventHandler(this.txtBusquedaVentas_Enter);
            this.txtBusquedaVentas.Leave += new System.EventHandler(this.txtBusquedaVentas_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 22);
            this.label1.TabIndex = 184;
            this.label1.Text = "Factura Realizadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvClientes.Location = new System.Drawing.Point(11, 29);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(465, 223);
            this.dgvClientes.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 22);
            this.label2.TabIndex = 186;
            this.label2.Text = "Historial de Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturar.BorderRadius = 12;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFacturar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFacturar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFacturar.FillColor = System.Drawing.Color.LightBlue;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnFacturar.Location = new System.Drawing.Point(667, 364);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(116, 30);
            this.btnFacturar.TabIndex = 188;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextFormatNoPrefix = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // pnlGraficaBarra
            // 
            this.pnlGraficaBarra.Location = new System.Drawing.Point(708, 26);
            this.pnlGraficaBarra.Name = "pnlGraficaBarra";
            this.pnlGraficaBarra.Size = new System.Drawing.Size(480, 231);
            this.pnlGraficaBarra.TabIndex = 198;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(708, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 22);
            this.label3.TabIndex = 197;
            this.label3.Text = "Ventas por Mes\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficaPastel
            // 
            this.pnlGraficaPastel.Location = new System.Drawing.Point(804, 290);
            this.pnlGraficaPastel.Name = "pnlGraficaPastel";
            this.pnlGraficaPastel.Size = new System.Drawing.Size(384, 298);
            this.pnlGraficaPastel.TabIndex = 199;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 22);
            this.label4.TabIndex = 198;
            this.label4.Text = "Grafica Pastel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlGraficaPastel);
            this.Controls.Add(this.pnlGraficaBarra);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrado);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.txtBusquedaVentas);
            this.Controls.Add(this.dgvFacturaRealizada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "None";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaRealizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturaRealizada;
        private System.Windows.Forms.ComboBox cmbFiltrado;
        private Guna.UI2.WinForms.Guna2Button btnEliminarFactura;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnFacturar;
        private System.Windows.Forms.Panel pnlGraficaBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlGraficaPastel;
        private System.Windows.Forms.Label label4;
    }
}