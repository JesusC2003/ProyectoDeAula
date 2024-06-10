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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpDetalleProducto = new System.Windows.Forms.GroupBox();
            this.cmbRazaPollo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioUnitarioF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadPollo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoPollo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtApellidosClientes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpDetalleProducto.SuspendLayout();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.grpDetalleProducto);
            this.panel1.Controls.Add(this.grpDatosCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnEliminarFactura);
            this.panel1.Controls.Add(this.btnAgregarFactura);
            this.panel1.Controls.Add(this.dgvFactura);
            this.panel1.Location = new System.Drawing.Point(65, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 461);
            this.panel1.TabIndex = 0;
            // 
            // grpDetalleProducto
            // 
            this.grpDetalleProducto.BackColor = System.Drawing.Color.White;
            this.grpDetalleProducto.Controls.Add(this.cmbRazaPollo);
            this.grpDetalleProducto.Controls.Add(this.label10);
            this.grpDetalleProducto.Controls.Add(this.txtPrecioUnitarioF);
            this.grpDetalleProducto.Controls.Add(this.label9);
            this.grpDetalleProducto.Controls.Add(this.txtCantidadPollo);
            this.grpDetalleProducto.Controls.Add(this.label8);
            this.grpDetalleProducto.Controls.Add(this.txtCodigoPollo);
            this.grpDetalleProducto.Controls.Add(this.label7);
            this.grpDetalleProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalleProducto.Location = new System.Drawing.Point(3, 137);
            this.grpDetalleProducto.Name = "grpDetalleProducto";
            this.grpDetalleProducto.Size = new System.Drawing.Size(648, 123);
            this.grpDetalleProducto.TabIndex = 24;
            this.grpDetalleProducto.TabStop = false;
            this.grpDetalleProducto.Text = "Detalle Producto";
            // 
            // cmbRazaPollo
            // 
            this.cmbRazaPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRazaPollo.FormattingEnabled = true;
            this.cmbRazaPollo.Items.AddRange(new object[] {
            "Cobb 500",
            "Ross 308",
            "Hubbard",
            "Arbor Acres"});
            this.cmbRazaPollo.Location = new System.Drawing.Point(504, 27);
            this.cmbRazaPollo.Name = "cmbRazaPollo";
            this.cmbRazaPollo.Size = new System.Drawing.Size(119, 21);
            this.cmbRazaPollo.TabIndex = 31;
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
            // txtPrecioUnitarioF
            // 
            this.txtPrecioUnitarioF.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitarioF.Location = new System.Drawing.Point(118, 72);
            this.txtPrecioUnitarioF.Name = "txtPrecioUnitarioF";
            this.txtPrecioUnitarioF.Size = new System.Drawing.Size(71, 19);
            this.txtPrecioUnitarioF.TabIndex = 29;
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
            // txtCantidadPollo
            // 
            this.txtCantidadPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPollo.Location = new System.Drawing.Point(375, 27);
            this.txtCantidadPollo.Name = "txtCantidadPollo";
            this.txtCantidadPollo.Size = new System.Drawing.Size(34, 19);
            this.txtCantidadPollo.TabIndex = 27;
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
            // txtCodigoPollo
            // 
            this.txtCodigoPollo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPollo.Location = new System.Drawing.Point(93, 30);
            this.txtCodigoPollo.Name = "txtCodigoPollo";
            this.txtCodigoPollo.Size = new System.Drawing.Size(182, 19);
            this.txtCodigoPollo.TabIndex = 25;
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
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.Color.White;
            this.grpDatosCliente.Controls.Add(this.txtApellidosClientes);
            this.grpDatosCliente.Controls.Add(this.label6);
            this.grpDatosCliente.Controls.Add(this.txtCorreoCliente);
            this.grpDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grpDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.grpDatosCliente.Controls.Add(this.cmbTipoCliente);
            this.grpDatosCliente.Controls.Add(this.txtCodigoCliente);
            this.grpDatosCliente.Controls.Add(this.label4);
            this.grpDatosCliente.Controls.Add(this.label5);
            this.grpDatosCliente.Controls.Add(this.label2);
            this.grpDatosCliente.Controls.Add(this.label13);
            this.grpDatosCliente.Controls.Add(this.label3);
            this.grpDatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCliente.Location = new System.Drawing.Point(3, 3);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(648, 131);
            this.grpDatosCliente.TabIndex = 23;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos Cliente";
            // 
            // txtApellidosClientes
            // 
            this.txtApellidosClientes.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosClientes.Location = new System.Drawing.Point(445, 53);
            this.txtApellidosClientes.Name = "txtApellidosClientes";
            this.txtApellidosClientes.Size = new System.Drawing.Size(171, 19);
            this.txtApellidosClientes.TabIndex = 28;
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
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(445, 86);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(171, 19);
            this.txtCorreoCliente.TabIndex = 26;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(111, 53);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(182, 19);
            this.txtNombreCliente.TabIndex = 25;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(111, 86);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(182, 19);
            this.txtTelefonoCliente.TabIndex = 24;
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Persona Juridica",
            "Persona Natural"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(445, 17);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoCliente.TabIndex = 23;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(111, 22);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(182, 19);
            this.txtCodigoCliente.TabIndex = 22;
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
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.Color.Silver;
            this.btnEliminarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.btnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFactura.Image = global::Presentacion.Properties.Resources.icons8_eliminar_archivo_24;
            this.btnEliminarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFactura.Location = new System.Drawing.Point(519, 265);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(125, 28);
            this.btnEliminarFactura.TabIndex = 13;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFactura.UseVisualStyleBackColor = false;
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFactura.FlatAppearance.BorderSize = 0;
            this.btnAgregarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFactura.Image = global::Presentacion.Properties.Resources.receipt_add_icon_177414;
            this.btnAgregarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFactura.Location = new System.Drawing.Point(3, 265);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(127, 28);
            this.btnAgregarFactura.TabIndex = 12;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFactura.UseVisualStyleBackColor = false;
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
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Silver;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::Presentacion.Properties.Resources.icons8_factura_28;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(323, 496);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(125, 30);
            this.btnFacturar.TabIndex = 13;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrFactura";
            this.panel1.ResumeLayout(false);
            this.grpDetalleProducto.ResumeLayout(false);
            this.grpDetalleProducto.PerformLayout();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
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
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpDetalleProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadPollo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoPollo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidosClientes;
        private System.Windows.Forms.TextBox txtPrecioUnitarioF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRazaPollo;
        private System.Windows.Forms.Label label10;
    }
}