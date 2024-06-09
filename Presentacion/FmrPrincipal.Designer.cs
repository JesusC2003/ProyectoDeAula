namespace Presentacion
{
    partial class FmrPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.BtnCerrarPrograma = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAlimento = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnMedicamento = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnGalpon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPollo = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.Hora = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.panelsubconfiguracion = new System.Windows.Forms.Panel();
            this.BtnDatosEmpresa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.Horayfecha = new System.Windows.Forms.Timer(this.components);
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panelsubconfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panelBarra.Controls.Add(this.BtnConfiguracion);
            this.panelBarra.Controls.Add(this.BtnCerrarPrograma);
            this.panelBarra.Controls.Add(this.BtnMinimizar);
            this.panelBarra.Controls.Add(this.label1);
            this.panelBarra.Controls.Add(this.pictureBox1);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(780, 35);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.Image = global::Presentacion.Properties.Resources.icons8_configuración_de_datos_20;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfiguracion.Location = new System.Drawing.Point(661, 3);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(35, 29);
            this.BtnConfiguracion.TabIndex = 7;
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // BtnCerrarPrograma
            // 
            this.BtnCerrarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.BtnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarPrograma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarPrograma.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarPrograma.Image = global::Presentacion.Properties.Resources.icons8_cerrar_ventana_16;
            this.BtnCerrarPrograma.Location = new System.Drawing.Point(741, 5);
            this.BtnCerrarPrograma.Name = "BtnCerrarPrograma";
            this.BtnCerrarPrograma.Size = new System.Drawing.Size(35, 26);
            this.BtnCerrarPrograma.TabIndex = 6;
            this.BtnCerrarPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrarPrograma.UseVisualStyleBackColor = true;
            this.BtnCerrarPrograma.Click += new System.EventHandler(this.BtnCerrarPrograma_Click_1);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.Image = global::Presentacion.Properties.Resources.window_minimize_icon_181229;
            this.BtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimizar.Location = new System.Drawing.Point(700, 1);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(35, 31);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hensys";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.fondo4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panelMenuVertical.Controls.Add(this.panel1);
            this.panelMenuVertical.Controls.Add(this.BtnPersonal);
            this.panelMenuVertical.Controls.Add(this.BtnMenu);
            this.panelMenuVertical.Controls.Add(this.panel8);
            this.panelMenuVertical.Controls.Add(this.BtnFactura);
            this.panelMenuVertical.Controls.Add(this.panel7);
            this.panelMenuVertical.Controls.Add(this.BtnVentas);
            this.panelMenuVertical.Controls.Add(this.panel5);
            this.panelMenuVertical.Controls.Add(this.BtnAlimento);
            this.panelMenuVertical.Controls.Add(this.panel4);
            this.panelMenuVertical.Controls.Add(this.BtnMedicamento);
            this.panelMenuVertical.Controls.Add(this.panel3);
            this.panelMenuVertical.Controls.Add(this.BtnGalpon);
            this.panelMenuVertical.Controls.Add(this.panel2);
            this.panelMenuVertical.Controls.Add(this.BtnPollo);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(136, 488);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 40);
            this.panel1.TabIndex = 11;
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnPersonal.Image = global::Presentacion.Properties.Resources.icons8_empleado_30;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(3, 264);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(128, 40);
            this.BtnPersonal.TabIndex = 10;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackgroundImage = global::Presentacion.Properties.Resources.icons8_menú_16;
            this.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(36, 30);
            this.BtnMenu.TabIndex = 15;
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(-6, 358);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 40);
            this.panel8.TabIndex = 13;
            // 
            // BtnFactura
            // 
            this.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFactura.FlatAppearance.BorderSize = 0;
            this.BtnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactura.ForeColor = System.Drawing.Color.White;
            this.BtnFactura.Image = global::Presentacion.Properties.Resources.invoice_document_bill_delivery_note_icon_225179;
            this.BtnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.Location = new System.Drawing.Point(3, 358);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(128, 40);
            this.BtnFactura.TabIndex = 12;
            this.BtnFactura.Text = "Factura";
            this.BtnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFactura.UseVisualStyleBackColor = true;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(0, 312);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 40);
            this.panel7.TabIndex = 11;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = global::Presentacion.Properties.Resources.icons8_ventas_32;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 312);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(131, 40);
            this.BtnVentas.TabIndex = 10;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(0, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 40);
            this.panel5.TabIndex = 7;
            // 
            // BtnAlimento
            // 
            this.BtnAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlimento.FlatAppearance.BorderSize = 0;
            this.BtnAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlimento.ForeColor = System.Drawing.Color.White;
            this.BtnAlimento.Image = global::Presentacion.Properties.Resources.food_gardening_grading_sack_grain_wheat_icon_255203;
            this.BtnAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlimento.Location = new System.Drawing.Point(3, 217);
            this.BtnAlimento.Name = "BtnAlimento";
            this.BtnAlimento.Size = new System.Drawing.Size(128, 40);
            this.BtnAlimento.TabIndex = 6;
            this.BtnAlimento.Text = "Alimento";
            this.BtnAlimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlimento.UseVisualStyleBackColor = true;
            this.BtnAlimento.Click += new System.EventHandler(this.BtnAlimento_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 40);
            this.panel4.TabIndex = 5;
            // 
            // BtnMedicamento
            // 
            this.BtnMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMedicamento.FlatAppearance.BorderSize = 0;
            this.BtnMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicamento.ForeColor = System.Drawing.Color.White;
            this.BtnMedicamento.Image = global::Presentacion.Properties.Resources.treatment_drug_medication_capsules_drugs_medicine_pill_capsule_pills_icon_210667;
            this.BtnMedicamento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMedicamento.Location = new System.Drawing.Point(3, 170);
            this.BtnMedicamento.Name = "BtnMedicamento";
            this.BtnMedicamento.Size = new System.Drawing.Size(128, 40);
            this.BtnMedicamento.TabIndex = 4;
            this.BtnMedicamento.Text = "Salud";
            this.BtnMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedicamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMedicamento.UseVisualStyleBackColor = true;
            this.BtnMedicamento.Click += new System.EventHandler(this.BtnMedicamento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 40);
            this.panel3.TabIndex = 3;
            // 
            // BtnGalpon
            // 
            this.BtnGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGalpon.FlatAppearance.BorderSize = 0;
            this.BtnGalpon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGalpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGalpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGalpon.ForeColor = System.Drawing.Color.White;
            this.BtnGalpon.Image = global::Presentacion.Properties.Resources.icons8_shed_32__3_;
            this.BtnGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalpon.Location = new System.Drawing.Point(3, 123);
            this.BtnGalpon.Name = "BtnGalpon";
            this.BtnGalpon.Size = new System.Drawing.Size(128, 40);
            this.BtnGalpon.TabIndex = 2;
            this.BtnGalpon.Text = "Galpon";
            this.BtnGalpon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalpon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGalpon.UseVisualStyleBackColor = true;
            this.BtnGalpon.Click += new System.EventHandler(this.BtnGalpon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 40);
            this.panel2.TabIndex = 1;
            // 
            // BtnPollo
            // 
            this.BtnPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPollo.FlatAppearance.BorderSize = 0;
            this.BtnPollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPollo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPollo.ForeColor = System.Drawing.Color.White;
            this.BtnPollo.Image = global::Presentacion.Properties.Resources.icons8_pollo_32;
            this.BtnPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPollo.Location = new System.Drawing.Point(3, 77);
            this.BtnPollo.Name = "BtnPollo";
            this.BtnPollo.Size = new System.Drawing.Size(128, 40);
            this.BtnPollo.TabIndex = 0;
            this.BtnPollo.Text = "Pollo";
            this.BtnPollo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPollo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPollo.UseVisualStyleBackColor = true;
            this.BtnPollo.Click += new System.EventHandler(this.BtnPollo_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Controls.Add(this.Hora);
            this.PanelContenedor.Controls.Add(this.Fecha);
            this.PanelContenedor.Controls.Add(this.panelsubconfiguracion);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContenedor.Location = new System.Drawing.Point(136, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(644, 488);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Hora
            // 
            this.Hora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Hora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(0, 442);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(644, 23);
            this.Hora.TabIndex = 4;
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fecha
            // 
            this.Fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(0, 465);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(644, 23);
            this.Fecha.TabIndex = 3;
            this.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelsubconfiguracion
            // 
            this.panelsubconfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panelsubconfiguracion.Controls.Add(this.BtnDatosEmpresa);
            this.panelsubconfiguracion.Controls.Add(this.button2);
            this.panelsubconfiguracion.Controls.Add(this.BtnCerrarSesion);
            this.panelsubconfiguracion.Location = new System.Drawing.Point(526, -1);
            this.panelsubconfiguracion.Name = "panelsubconfiguracion";
            this.panelsubconfiguracion.Size = new System.Drawing.Size(86, 72);
            this.panelsubconfiguracion.TabIndex = 2;
            this.panelsubconfiguracion.Visible = false;
            // 
            // BtnDatosEmpresa
            // 
            this.BtnDatosEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnDatosEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDatosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosEmpresa.ForeColor = System.Drawing.Color.White;
            this.BtnDatosEmpresa.Image = global::Presentacion.Properties.Resources.icons8_documento_20;
            this.BtnDatosEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDatosEmpresa.Location = new System.Drawing.Point(0, 25);
            this.BtnDatosEmpresa.Name = "BtnDatosEmpresa";
            this.BtnDatosEmpresa.Size = new System.Drawing.Size(86, 18);
            this.BtnDatosEmpresa.TabIndex = 2;
            this.BtnDatosEmpresa.Text = "Datos Empresa";
            this.BtnDatosEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDatosEmpresa.UseVisualStyleBackColor = true;
            this.BtnDatosEmpresa.Click += new System.EventHandler(this.BtnDatosEmpresa_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Presentacion.Properties.Resources.icons8_añadir_usuario_masculino_20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "New Usuario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Image = global::Presentacion.Properties.Resources.icons8_salida_20;
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 49);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(86, 23);
            this.BtnCerrarSesion.TabIndex = 0;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // Horayfecha
            // 
            this.Horayfecha.Tick += new System.EventHandler(this.Horayfecha_Tick);
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 523);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPrincipal";
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.panelsubconfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPollo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnGalpon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAlimento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnMedicamento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Timer Horayfecha;
        private System.Windows.Forms.Button BtnCerrarPrograma;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Panel panelsubconfiguracion;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDatosEmpresa;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Fecha;
    }
}