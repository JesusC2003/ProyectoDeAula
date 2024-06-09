namespace Presentacion
{
    partial class FmrFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GpbDetalleProducto = new System.Windows.Forms.GroupBox();
            this.CboRazaPollo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitarioF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCantidadPollo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigoPollo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GpbDatosCliente = new System.Windows.Forms.GroupBox();
            this.TxtApellidosClientes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorreoCliente = new System.Windows.Forms.TextBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEliminarFactura = new System.Windows.Forms.Button();
            this.BtnAgregarFactura = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GpbDetalleProducto.SuspendLayout();
            this.GpbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.GpbDetalleProducto);
            this.panel1.Controls.Add(this.GpbDatosCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnEliminarFactura);
            this.panel1.Controls.Add(this.BtnAgregarFactura);
            this.panel1.Controls.Add(this.dgvFactura);
            this.panel1.Location = new System.Drawing.Point(65, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 461);
            this.panel1.TabIndex = 0;
            // 
            // GpbDetalleProducto
            // 
            this.GpbDetalleProducto.BackColor = System.Drawing.Color.White;
            this.GpbDetalleProducto.Controls.Add(this.CboRazaPollo);
            this.GpbDetalleProducto.Controls.Add(this.label10);
            this.GpbDetalleProducto.Controls.Add(this.TxtPrecioUnitarioF);
            this.GpbDetalleProducto.Controls.Add(this.label9);
            this.GpbDetalleProducto.Controls.Add(this.TxtCantidadPollo);
            this.GpbDetalleProducto.Controls.Add(this.label8);
            this.GpbDetalleProducto.Controls.Add(this.TxtCodigoPollo);
            this.GpbDetalleProducto.Controls.Add(this.label7);
            this.GpbDetalleProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbDetalleProducto.Location = new System.Drawing.Point(3, 137);
            this.GpbDetalleProducto.Name = "GpbDetalleProducto";
            this.GpbDetalleProducto.Size = new System.Drawing.Size(648, 123);
            this.GpbDetalleProducto.TabIndex = 24;
            this.GpbDetalleProducto.TabStop = false;
            this.GpbDetalleProducto.Text = "Detalle Producto";
            // 
            // CboRazaPollo
            // 
            this.CboRazaPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRazaPollo.FormattingEnabled = true;
            this.CboRazaPollo.Items.AddRange(new object[] {
            "Cobb 500",
            "Ross 308",
            "Hubbard",
            "Arbor Acres"});
            this.CboRazaPollo.Location = new System.Drawing.Point(504, 27);
            this.CboRazaPollo.Name = "CboRazaPollo";
            this.CboRazaPollo.Size = new System.Drawing.Size(119, 21);
            this.CboRazaPollo.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(424, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Raza";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecioUnitarioF
            // 
            this.TxtPrecioUnitarioF.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitarioF.Location = new System.Drawing.Point(118, 72);
            this.TxtPrecioUnitarioF.Name = "TxtPrecioUnitarioF";
            this.TxtPrecioUnitarioF.Size = new System.Drawing.Size(71, 19);
            this.TxtPrecioUnitarioF.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio Unitario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCantidadPollo
            // 
            this.TxtCantidadPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadPollo.Location = new System.Drawing.Point(375, 27);
            this.TxtCantidadPollo.Name = "TxtCantidadPollo";
            this.TxtCantidadPollo.Size = new System.Drawing.Size(34, 19);
            this.TxtCantidadPollo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cantidad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoPollo
            // 
            this.TxtCodigoPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPollo.Location = new System.Drawing.Point(93, 30);
            this.TxtCodigoPollo.Name = "TxtCodigoPollo";
            this.TxtCodigoPollo.Size = new System.Drawing.Size(182, 19);
            this.TxtCodigoPollo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Codigo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GpbDatosCliente
            // 
            this.GpbDatosCliente.BackColor = System.Drawing.Color.White;
            this.GpbDatosCliente.Controls.Add(this.TxtApellidosClientes);
            this.GpbDatosCliente.Controls.Add(this.label6);
            this.GpbDatosCliente.Controls.Add(this.TxtCorreoCliente);
            this.GpbDatosCliente.Controls.Add(this.TxtNombreCliente);
            this.GpbDatosCliente.Controls.Add(this.TxtTelefonoCliente);
            this.GpbDatosCliente.Controls.Add(this.CboTipoCliente);
            this.GpbDatosCliente.Controls.Add(this.TxtCodigoCliente);
            this.GpbDatosCliente.Controls.Add(this.label4);
            this.GpbDatosCliente.Controls.Add(this.label5);
            this.GpbDatosCliente.Controls.Add(this.label2);
            this.GpbDatosCliente.Controls.Add(this.label13);
            this.GpbDatosCliente.Controls.Add(this.label3);
            this.GpbDatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbDatosCliente.Location = new System.Drawing.Point(3, 3);
            this.GpbDatosCliente.Name = "GpbDatosCliente";
            this.GpbDatosCliente.Size = new System.Drawing.Size(648, 131);
            this.GpbDatosCliente.TabIndex = 23;
            this.GpbDatosCliente.TabStop = false;
            this.GpbDatosCliente.Text = "Datos Cliente";
            // 
            // TxtApellidosClientes
            // 
            this.TxtApellidosClientes.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidosClientes.Location = new System.Drawing.Point(445, 53);
            this.TxtApellidosClientes.Name = "TxtApellidosClientes";
            this.TxtApellidosClientes.Size = new System.Drawing.Size(171, 19);
            this.TxtApellidosClientes.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCorreoCliente
            // 
            this.TxtCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoCliente.Location = new System.Drawing.Point(445, 86);
            this.TxtCorreoCliente.Name = "TxtCorreoCliente";
            this.TxtCorreoCliente.Size = new System.Drawing.Size(171, 19);
            this.TxtCorreoCliente.TabIndex = 26;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(111, 53);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(182, 19);
            this.TxtNombreCliente.TabIndex = 25;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(111, 86);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(182, 19);
            this.TxtTelefonoCliente.TabIndex = 24;
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Items.AddRange(new object[] {
            "Persona Juridica",
            "Persona Natural"});
            this.CboTipoCliente.Location = new System.Drawing.Point(445, 17);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(171, 21);
            this.CboTipoCliente.TabIndex = 23;
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(111, 22);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(182, 19);
            this.TxtCodigoCliente.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Nombres";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BtnEliminarFactura
            // 
            this.BtnEliminarFactura.BackColor = System.Drawing.Color.Silver;
            this.BtnEliminarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.BtnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFactura.Image = global::Presentacion.Properties.Resources.icons8_eliminar_archivo_24;
            this.BtnEliminarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarFactura.Location = new System.Drawing.Point(519, 265);
            this.BtnEliminarFactura.Name = "BtnEliminarFactura";
            this.BtnEliminarFactura.Size = new System.Drawing.Size(125, 28);
            this.BtnEliminarFactura.TabIndex = 13;
            this.BtnEliminarFactura.Text = "Eliminar";
            this.BtnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarFactura.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarFactura
            // 
            this.BtnAgregarFactura.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarFactura.FlatAppearance.BorderSize = 0;
            this.BtnAgregarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarFactura.Image = global::Presentacion.Properties.Resources.receipt_add_icon_177414;
            this.BtnAgregarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarFactura.Location = new System.Drawing.Point(3, 265);
            this.BtnAgregarFactura.Name = "BtnAgregarFactura";
            this.BtnAgregarFactura.Size = new System.Drawing.Size(127, 28);
            this.BtnAgregarFactura.TabIndex = 12;
            this.BtnAgregarFactura.Text = "Agregar";
            this.BtnAgregarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarFactura.UseVisualStyleBackColor = false;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(2, 300);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(648, 157);
            this.dgvFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.BackColor = System.Drawing.Color.Silver;
            this.BtnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturar.FlatAppearance.BorderSize = 0;
            this.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Image = global::Presentacion.Properties.Resources.icons8_factura_28;
            this.BtnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturar.Location = new System.Drawing.Point(324, 497);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(125, 30);
            this.BtnFacturar.TabIndex = 13;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFacturar.UseVisualStyleBackColor = false;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // FmrFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrFactura";
            this.panel1.ResumeLayout(false);
            this.GpbDetalleProducto.ResumeLayout(false);
            this.GpbDetalleProducto.PerformLayout();
            this.GpbDatosCliente.ResumeLayout(false);
            this.GpbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregarFactura;
        private System.Windows.Forms.Button BtnEliminarFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.GroupBox GpbDatosCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GpbDetalleProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCorreoCliente;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCantidadPollo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigoPollo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtApellidosClientes;
        private System.Windows.Forms.TextBox TxtPrecioUnitarioF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboRazaPollo;
        private System.Windows.Forms.Label label10;
    }
}