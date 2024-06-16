namespace Presentacion
{
    partial class frmFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDetalleProducto = new System.Windows.Forms.GroupBox();
            this.txtlote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioUnitario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.panelTipoCliente = new System.Windows.Forms.Panel();
            this.rdonatural = new System.Windows.Forms.RadioButton();
            this.rdojuridica = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombresCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidentificacionCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreoCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidosCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefonoCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnEliminarFactura = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarFactura = new Guna.UI2.WinForms.Guna2Button();
            this.btnFacturar = new Guna.UI2.WinForms.Guna2Button();
            this.btnbusquedaidentificacion = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtRaza = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnbusquedacodigo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtedad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodificarfactura = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelaroperacion = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.grpDetalleProducto.SuspendLayout();
            this.grpDatosCliente.SuspendLayout();
            this.panelTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnCancelaroperacion);
            this.panel1.Controls.Add(this.btnFacturar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMontoTotal);
            this.panel1.Controls.Add(this.grpDetalleProducto);
            this.panel1.Controls.Add(this.grpDatosCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvFactura);
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 582);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(425, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 19);
            this.label12.TabIndex = 171;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.AutoSize = true;
            this.txtMontoTotal.BorderColor = System.Drawing.Color.Silver;
            this.txtMontoTotal.BorderRadius = 5;
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoTotal.DefaultText = "";
            this.txtMontoTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontoTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontoTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontoTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontoTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontoTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtMontoTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontoTotal.Location = new System.Drawing.Point(537, 477);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.PasswordChar = '\0';
            this.txtMontoTotal.PlaceholderText = "";
            this.txtMontoTotal.SelectedText = "";
            this.txtMontoTotal.Size = new System.Drawing.Size(105, 25);
            this.txtMontoTotal.TabIndex = 170;
            // 
            // grpDetalleProducto
            // 
            this.grpDetalleProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.grpDetalleProducto.Controls.Add(this.txtedad);
            this.grpDetalleProducto.Controls.Add(this.label1);
            this.grpDetalleProducto.Controls.Add(this.btnbusquedacodigo);
            this.grpDetalleProducto.Controls.Add(this.txtRaza);
            this.grpDetalleProducto.Controls.Add(this.btnAgregarFactura);
            this.grpDetalleProducto.Controls.Add(this.btnEliminarFactura);
            this.grpDetalleProducto.Controls.Add(this.txtlote);
            this.grpDetalleProducto.Controls.Add(this.txtPrecioUnitario);
            this.grpDetalleProducto.Controls.Add(this.txtCodigo);
            this.grpDetalleProducto.Controls.Add(this.label10);
            this.grpDetalleProducto.Controls.Add(this.label9);
            this.grpDetalleProducto.Controls.Add(this.label8);
            this.grpDetalleProducto.Controls.Add(this.label7);
            this.grpDetalleProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalleProducto.ForeColor = System.Drawing.Color.White;
            this.grpDetalleProducto.Location = new System.Drawing.Point(3, 191);
            this.grpDetalleProducto.Name = "grpDetalleProducto";
            this.grpDetalleProducto.Size = new System.Drawing.Size(648, 150);
            this.grpDetalleProducto.TabIndex = 24;
            this.grpDetalleProducto.TabStop = false;
            this.grpDetalleProducto.Text = "Detalle Producto";
            // 
            // txtlote
            // 
            this.txtlote.AutoSize = true;
            this.txtlote.BorderColor = System.Drawing.Color.Silver;
            this.txtlote.BorderRadius = 5;
            this.txtlote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlote.DefaultText = "";
            this.txtlote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlote.ForeColor = System.Drawing.Color.Black;
            this.txtlote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlote.Location = new System.Drawing.Point(448, 34);
            this.txtlote.Margin = new System.Windows.Forms.Padding(2);
            this.txtlote.Name = "txtlote";
            this.txtlote.PasswordChar = '\0';
            this.txtlote.PlaceholderText = "";
            this.txtlote.SelectedText = "";
            this.txtlote.Size = new System.Drawing.Size(124, 25);
            this.txtlote.TabIndex = 167;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AutoSize = true;
            this.txtPrecioUnitario.BorderColor = System.Drawing.Color.Silver;
            this.txtPrecioUnitario.BorderRadius = 5;
            this.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioUnitario.DefaultText = "";
            this.txtPrecioUnitario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioUnitario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioUnitario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioUnitario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(11, 103);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PasswordChar = '\0';
            this.txtPrecioUnitario.PlaceholderText = "";
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(158, 25);
            this.txtPrecioUnitario.TabIndex = 168;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.BorderColor = System.Drawing.Color.Silver;
            this.txtCodigo.BorderRadius = 5;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Location = new System.Drawing.Point(9, 37);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(161, 25);
            this.txtCodigo.TabIndex = 169;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Raza";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio Unitario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Lote";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Codigo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.grpDatosCliente.Controls.Add(this.btnmodificarfactura);
            this.grpDatosCliente.Controls.Add(this.btnbusquedaidentificacion);
            this.grpDatosCliente.Controls.Add(this.panelTipoCliente);
            this.grpDatosCliente.Controls.Add(this.label11);
            this.grpDatosCliente.Controls.Add(this.txtNombresCliente);
            this.grpDatosCliente.Controls.Add(this.txtidentificacionCliente);
            this.grpDatosCliente.Controls.Add(this.txtCorreoCliente);
            this.grpDatosCliente.Controls.Add(this.txtApellidosCliente);
            this.grpDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.grpDatosCliente.Controls.Add(this.label6);
            this.grpDatosCliente.Controls.Add(this.cmbTipoCliente);
            this.grpDatosCliente.Controls.Add(this.label4);
            this.grpDatosCliente.Controls.Add(this.label5);
            this.grpDatosCliente.Controls.Add(this.label2);
            this.grpDatosCliente.Controls.Add(this.label13);
            this.grpDatosCliente.Controls.Add(this.label3);
            this.grpDatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCliente.ForeColor = System.Drawing.Color.White;
            this.grpDatosCliente.Location = new System.Drawing.Point(3, 3);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(648, 166);
            this.grpDatosCliente.TabIndex = 23;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos Cliente";
            // 
            // panelTipoCliente
            // 
            this.panelTipoCliente.Controls.Add(this.rdonatural);
            this.panelTipoCliente.Controls.Add(this.rdojuridica);
            this.panelTipoCliente.Location = new System.Drawing.Point(418, 36);
            this.panelTipoCliente.Name = "panelTipoCliente";
            this.panelTipoCliente.Size = new System.Drawing.Size(224, 31);
            this.panelTipoCliente.TabIndex = 168;
            // 
            // rdonatural
            // 
            this.rdonatural.AutoSize = true;
            this.rdonatural.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdonatural.Location = new System.Drawing.Point(123, 8);
            this.rdonatural.Name = "rdonatural";
            this.rdonatural.Size = new System.Drawing.Size(84, 16);
            this.rdonatural.TabIndex = 1;
            this.rdonatural.TabStop = true;
            this.rdonatural.Text = "Persona Natural";
            this.rdonatural.UseVisualStyleBackColor = true;
            // 
            // rdojuridica
            // 
            this.rdojuridica.AutoSize = true;
            this.rdojuridica.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdojuridica.Location = new System.Drawing.Point(8, 8);
            this.rdojuridica.Name = "rdojuridica";
            this.rdojuridica.Size = new System.Drawing.Size(87, 16);
            this.rdojuridica.TabIndex = 0;
            this.rdojuridica.TabStop = true;
            this.rdojuridica.Text = "Persona Juridica";
            this.rdojuridica.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(467, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 167;
            this.label11.Text = "Tipo de Cliente";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.AutoSize = true;
            this.txtNombresCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtNombresCliente.BorderRadius = 5;
            this.txtNombresCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombresCliente.DefaultText = "";
            this.txtNombresCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombresCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombresCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombresCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombresCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombresCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombresCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombresCliente.Location = new System.Drawing.Point(11, 100);
            this.txtNombresCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.PasswordChar = '\0';
            this.txtNombresCliente.PlaceholderText = "";
            this.txtNombresCliente.SelectedText = "";
            this.txtNombresCliente.Size = new System.Drawing.Size(169, 23);
            this.txtNombresCliente.TabIndex = 166;
            // 
            // txtidentificacionCliente
            // 
            this.txtidentificacionCliente.AutoSize = true;
            this.txtidentificacionCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtidentificacionCliente.BorderRadius = 5;
            this.txtidentificacionCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidentificacionCliente.DefaultText = "";
            this.txtidentificacionCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidentificacionCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidentificacionCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidentificacionCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidentificacionCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidentificacionCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacionCliente.ForeColor = System.Drawing.Color.Black;
            this.txtidentificacionCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidentificacionCliente.Location = new System.Drawing.Point(11, 42);
            this.txtidentificacionCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtidentificacionCliente.Name = "txtidentificacionCliente";
            this.txtidentificacionCliente.PasswordChar = '\0';
            this.txtidentificacionCliente.PlaceholderText = "";
            this.txtidentificacionCliente.SelectedText = "";
            this.txtidentificacionCliente.Size = new System.Drawing.Size(169, 23);
            this.txtidentificacionCliente.TabIndex = 165;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.AutoSize = true;
            this.txtCorreoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreoCliente.BorderRadius = 5;
            this.txtCorreoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoCliente.DefaultText = "";
            this.txtCorreoCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoCliente.Location = new System.Drawing.Point(93, 138);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.PasswordChar = '\0';
            this.txtCorreoCliente.PlaceholderText = "";
            this.txtCorreoCliente.SelectedText = "";
            this.txtCorreoCliente.Size = new System.Drawing.Size(222, 22);
            this.txtCorreoCliente.TabIndex = 163;
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.AutoSize = true;
            this.txtApellidosCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtApellidosCliente.BorderRadius = 5;
            this.txtApellidosCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidosCliente.DefaultText = "";
            this.txtApellidosCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidosCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidosCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidosCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidosCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidosCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCliente.ForeColor = System.Drawing.Color.Black;
            this.txtApellidosCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidosCliente.Location = new System.Drawing.Point(218, 99);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.PasswordChar = '\0';
            this.txtApellidosCliente.PlaceholderText = "";
            this.txtApellidosCliente.SelectedText = "";
            this.txtApellidosCliente.Size = new System.Drawing.Size(185, 23);
            this.txtApellidosCliente.TabIndex = 162;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.AutoSize = true;
            this.txtTelefonoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtTelefonoCliente.BorderRadius = 5;
            this.txtTelefonoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoCliente.DefaultText = "";
            this.txtTelefonoCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefonoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefonoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(437, 99);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.PasswordChar = '\0';
            this.txtTelefonoCliente.PlaceholderText = "";
            this.txtTelefonoCliente.SelectedText = "";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(175, 23);
            this.txtTelefonoCliente.TabIndex = 161;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Cedula de Extranjeria",
            "Cedula de Ciudadania",
            "Nit"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(266, 41);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(115, 21);
            this.cmbTipoCliente.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Identificacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Identificacion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Nombres";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(13, 347);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(630, 125);
            this.dgvFactura.TabIndex = 0;
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
            this.btnEliminarFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarFactura.Location = new System.Drawing.Point(550, 124);
            this.btnEliminarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(89, 21);
            this.btnEliminarFactura.TabIndex = 159;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.TextFormatNoPrefix = true;
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarFactura.BorderRadius = 12;
            this.btnAgregarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFactura.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarFactura.FillColor = System.Drawing.Color.LightBlue;
            this.btnAgregarFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAgregarFactura.Location = new System.Drawing.Point(448, 124);
            this.btnAgregarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(89, 21);
            this.btnAgregarFactura.TabIndex = 157;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.TextFormatNoPrefix = true;
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
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnFacturar.Image = global::Presentacion.Properties.Resources.icons8_factura_28;
            this.btnFacturar.Location = new System.Drawing.Point(188, 523);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(123, 25);
            this.btnFacturar.TabIndex = 158;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextFormatNoPrefix = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // btnbusquedaidentificacion
            // 
            this.btnbusquedaidentificacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbusquedaidentificacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbusquedaidentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbusquedaidentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbusquedaidentificacion.FillColor = System.Drawing.Color.LightBlue;
            this.btnbusquedaidentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbusquedaidentificacion.ForeColor = System.Drawing.Color.White;
            this.btnbusquedaidentificacion.Image = global::Presentacion.Properties.Resources.busqueda;
            this.btnbusquedaidentificacion.Location = new System.Drawing.Point(185, 38);
            this.btnbusquedaidentificacion.Name = "btnbusquedaidentificacion";
            this.btnbusquedaidentificacion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnbusquedaidentificacion.Size = new System.Drawing.Size(30, 28);
            this.btnbusquedaidentificacion.TabIndex = 169;
            // 
            // txtRaza
            // 
            this.txtRaza.AutoSize = true;
            this.txtRaza.BorderColor = System.Drawing.Color.Silver;
            this.txtRaza.BorderRadius = 5;
            this.txtRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaza.DefaultText = "";
            this.txtRaza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.ForeColor = System.Drawing.Color.Black;
            this.txtRaza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.Location = new System.Drawing.Point(234, 37);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.PasswordChar = '\0';
            this.txtRaza.PlaceholderText = "";
            this.txtRaza.SelectedText = "";
            this.txtRaza.Size = new System.Drawing.Size(118, 20);
            this.txtRaza.TabIndex = 170;
            // 
            // btnbusquedacodigo
            // 
            this.btnbusquedacodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbusquedacodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbusquedacodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbusquedacodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbusquedacodigo.FillColor = System.Drawing.Color.LightBlue;
            this.btnbusquedacodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbusquedacodigo.ForeColor = System.Drawing.Color.White;
            this.btnbusquedacodigo.Image = global::Presentacion.Properties.Resources.busqueda;
            this.btnbusquedacodigo.Location = new System.Drawing.Point(173, 34);
            this.btnbusquedacodigo.Name = "btnbusquedacodigo";
            this.btnbusquedacodigo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnbusquedacodigo.Size = new System.Drawing.Size(30, 28);
            this.btnbusquedacodigo.TabIndex = 171;
            // 
            // txtedad
            // 
            this.txtedad.AutoSize = true;
            this.txtedad.BorderColor = System.Drawing.Color.Silver;
            this.txtedad.BorderRadius = 5;
            this.txtedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtedad.DefaultText = "";
            this.txtedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtedad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.ForeColor = System.Drawing.Color.Black;
            this.txtedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtedad.Location = new System.Drawing.Point(234, 103);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtedad.Name = "txtedad";
            this.txtedad.PasswordChar = '\0';
            this.txtedad.PlaceholderText = "";
            this.txtedad.SelectedText = "";
            this.txtedad.Size = new System.Drawing.Size(118, 20);
            this.txtedad.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 172;
            this.label1.Text = "Edad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnmodificarfactura
            // 
            this.btnmodificarfactura.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificarfactura.BorderRadius = 12;
            this.btnmodificarfactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificarfactura.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnmodificarfactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmodificarfactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmodificarfactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmodificarfactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmodificarfactura.FillColor = System.Drawing.Color.LightBlue;
            this.btnmodificarfactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnmodificarfactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnmodificarfactura.Location = new System.Drawing.Point(534, 140);
            this.btnmodificarfactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificarfactura.Name = "btnmodificarfactura";
            this.btnmodificarfactura.Size = new System.Drawing.Size(105, 21);
            this.btnmodificarfactura.TabIndex = 170;
            this.btnmodificarfactura.Text = "Modificar";
            this.btnmodificarfactura.TextFormatNoPrefix = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(698, 31);
            this.label14.TabIndex = 6;
            this.label14.Text = "Formulario de Facturacion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelaroperacion
            // 
            this.btnCancelaroperacion.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelaroperacion.BorderRadius = 12;
            this.btnCancelaroperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaroperacion.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancelaroperacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelaroperacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelaroperacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelaroperacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelaroperacion.FillColor = System.Drawing.Color.LightBlue;
            this.btnCancelaroperacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelaroperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnCancelaroperacion.Location = new System.Drawing.Point(359, 523);
            this.btnCancelaroperacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelaroperacion.Name = "btnCancelaroperacion";
            this.btnCancelaroperacion.Size = new System.Drawing.Size(193, 25);
            this.btnCancelaroperacion.TabIndex = 172;
            this.btnCancelaroperacion.Text = "Cancelar Operacion";
            this.btnCancelaroperacion.TextFormatNoPrefix = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(698, 626);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDetalleProducto.ResumeLayout(false);
            this.grpDetalleProducto.PerformLayout();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.panelTipoCliente.ResumeLayout(false);
            this.panelTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpDetalleProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAgregarFactura;
        private Guna.UI2.WinForms.Guna2TextBox txtlote;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioUnitario;
        private Guna.UI2.WinForms.Guna2TextBox txtNombresCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtidentificacionCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreoCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidosCliente;
        private Guna.UI2.WinForms.Guna2Button btnEliminarFactura;
        private Guna.UI2.WinForms.Guna2Button btnFacturar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelTipoCliente;
        private System.Windows.Forms.RadioButton rdonatural;
        private System.Windows.Forms.RadioButton rdojuridica;
        private Guna.UI2.WinForms.Guna2TextBox txtMontoTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtRaza;
        private Guna.UI2.WinForms.Guna2CircleButton btnbusquedaidentificacion;
        private Guna.UI2.WinForms.Guna2TextBox txtedad;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnbusquedacodigo;
        private Guna.UI2.WinForms.Guna2Button btnmodificarfactura;
        private Guna.UI2.WinForms.Guna2Button btnCancelaroperacion;
        private System.Windows.Forms.Label label14;
    }
}