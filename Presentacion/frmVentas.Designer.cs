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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbFiltrado = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusquedaVentas = new Guna.UI2.WinForms.Guna2TextBox();
            this.dvgFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacturar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGraficaBarra = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle92.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle92.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle92.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle92;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle93.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle93.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle93.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle93.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle93.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle93;
            this.dgvVentas.ColumnHeadersHeight = 24;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(11, 296);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle94.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle94.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle94.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle94.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle94.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle94;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1177, 297);
            this.dgvVentas.TabIndex = 107;
            // 
            // cmbFiltrado
            // 
            this.cmbFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrado.FormattingEnabled = true;
            this.cmbFiltrado.Location = new System.Drawing.Point(499, 267);
            this.cmbFiltrado.Name = "cmbFiltrado";
            this.cmbFiltrado.Size = new System.Drawing.Size(113, 24);
            this.cmbFiltrado.TabIndex = 183;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderRadius = 12;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.FillColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnNuevo.Location = new System.Drawing.Point(696, 264);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 30);
            this.btnNuevo.TabIndex = 182;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextFormatNoPrefix = true;
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
            this.btnEliminarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarPollo.Location = new System.Drawing.Point(948, 264);
            this.btnEliminarPollo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPollo.Name = "btnEliminarPollo";
            this.btnEliminarPollo.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarPollo.TabIndex = 181;
            this.btnEliminarPollo.Text = "Eliminar";
            this.btnEliminarPollo.TextFormatNoPrefix = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.guna2Button1.Location = new System.Drawing.Point(816, 264);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 30);
            this.guna2Button1.TabIndex = 180;
            this.guna2Button1.Text = "Modificar";
            this.guna2Button1.TextFormatNoPrefix = true;
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
            // dvgFacturas
            // 
            this.dvgFacturas.AllowUserToAddRows = false;
            this.dvgFacturas.AllowUserToDeleteRows = false;
            this.dvgFacturas.AllowUserToOrderColumns = true;
            this.dvgFacturas.AllowUserToResizeColumns = false;
            this.dvgFacturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle95.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle95.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle95.SelectionBackColor = System.Drawing.Color.Black;
            this.dvgFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle95;
            this.dvgFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle96.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle96.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle96.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle96.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle96.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle96.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle96;
            this.dvgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle97.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle97.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle97.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle97.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle97.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle97.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgFacturas.DefaultCellStyle = dataGridViewCellStyle97;
            this.dvgFacturas.Location = new System.Drawing.Point(805, 29);
            this.dvgFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.dvgFacturas.Name = "dvgFacturas";
            this.dvgFacturas.ReadOnly = true;
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle98.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle98.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle98.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle98.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle98.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle98;
            this.dvgFacturas.RowHeadersVisible = false;
            this.dvgFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.Color.Black;
            this.dvgFacturas.RowsDefaultCellStyle = dataGridViewCellStyle99;
            this.dvgFacturas.RowTemplate.Height = 24;
            this.dvgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgFacturas.Size = new System.Drawing.Size(384, 223);
            this.dvgFacturas.TabIndex = 185;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 22);
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
            dataGridViewCellStyle100.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle100.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle100.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle100;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle101.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle101.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle101;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle102.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle102;
            this.dgvClientes.Location = new System.Drawing.Point(11, 29);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle103.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle103.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle103.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle103.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle103.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle103.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle103;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle104.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle104;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(363, 223);
            this.dgvClientes.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 22);
            this.label2.TabIndex = 186;
            this.label2.Text = "Clientes";
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
            this.btnFacturar.Location = new System.Drawing.Point(1072, 264);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(116, 30);
            this.btnFacturar.TabIndex = 188;
            this.btnFacturar.Text = "Factura";
            this.btnFacturar.TextFormatNoPrefix = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // pnlGraficaBarra
            // 
            this.pnlGraficaBarra.Location = new System.Drawing.Point(379, 32);
            this.pnlGraficaBarra.Name = "pnlGraficaBarra";
            this.pnlGraficaBarra.Size = new System.Drawing.Size(421, 220);
            this.pnlGraficaBarra.TabIndex = 198;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 22);
            this.label3.TabIndex = 197;
            this.label3.Text = "Ventas por Mes\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlGraficaBarra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminarPollo);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtBusquedaVentas);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "None";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbFiltrado;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPollo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaVentas;
        private System.Windows.Forms.DataGridView dvgFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnFacturar;
        private System.Windows.Forms.Panel pnlGraficaBarra;
        private System.Windows.Forms.Label label3;
    }
}