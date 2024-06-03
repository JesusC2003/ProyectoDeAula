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
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrarPrograma = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnDeslizar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAlimento = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnMedicamento = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnGalpon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPollo = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.laHora = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Horayfecha = new System.Windows.Forms.Timer(this.components);
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelBarra.Controls.Add(this.BtnRestaurar);
            this.panelBarra.Controls.Add(this.BtnMaximizar);
            this.panelBarra.Controls.Add(this.BtnCerrarPrograma);
            this.panelBarra.Controls.Add(this.BtnMinimizar);
            this.panelBarra.Controls.Add(this.label1);
            this.panelBarra.Controls.Add(this.pictureBox1);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1027, 35);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurar.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurar.Image = global::Presentacion.Properties.Resources.window_restore_icon_181231;
            this.BtnRestaurar.Location = new System.Drawing.Point(943, 1);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(30, 28);
            this.BtnRestaurar.TabIndex = 8;
            this.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRestaurar.UseVisualStyleBackColor = true;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximizar.ForeColor = System.Drawing.Color.White;
            this.BtnMaximizar.Image = global::Presentacion.Properties.Resources.window_maximize_icon_181228;
            this.BtnMaximizar.Location = new System.Drawing.Point(943, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(30, 28);
            this.BtnMaximizar.TabIndex = 7;
            this.BtnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrarPrograma
            // 
            this.BtnCerrarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.BtnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarPrograma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarPrograma.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarPrograma.Image = global::Presentacion.Properties.Resources.icons8_cerrar_ventana_32;
            this.BtnCerrarPrograma.Location = new System.Drawing.Point(992, 1);
            this.BtnCerrarPrograma.Name = "BtnCerrarPrograma";
            this.BtnCerrarPrograma.Size = new System.Drawing.Size(35, 31);
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
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.Image = global::Presentacion.Properties.Resources.window_minimize_icon_181229;
            this.BtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimizar.Location = new System.Drawing.Point(889, 1);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(35, 31);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hensys";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.fondo4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.panel1);
            this.panelMenuVertical.Controls.Add(this.BtnSalir);
            this.panelMenuVertical.Controls.Add(this.BtnPersonal);
            this.panelMenuVertical.Controls.Add(this.BtnDeslizar);
            this.panelMenuVertical.Controls.Add(this.panel8);
            this.panelMenuVertical.Controls.Add(this.BtnFactura);
            this.panelMenuVertical.Controls.Add(this.panel7);
            this.panelMenuVertical.Controls.Add(this.BtnVentas);
            this.panelMenuVertical.Controls.Add(this.panel6);
            this.panelMenuVertical.Controls.Add(this.BtnEmpresa);
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
            this.panelMenuVertical.Size = new System.Drawing.Size(186, 596);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 31);
            this.panel1.TabIndex = 11;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Presentacion.Properties.Resources.icons8_botón_de_apagado;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 565);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(186, 31);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnPersonal.Image = global::Presentacion.Properties.Resources.icons8_empleado_30;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(5, 295);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(173, 31);
            this.BtnPersonal.TabIndex = 10;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnDeslizar
            // 
            this.BtnDeslizar.BackgroundImage = global::Presentacion.Properties.Resources.icons8_menú_16;
            this.BtnDeslizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeslizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeslizar.FlatAppearance.BorderSize = 0;
            this.BtnDeslizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeslizar.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslizar.ForeColor = System.Drawing.Color.White;
            this.BtnDeslizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeslizar.Location = new System.Drawing.Point(6, 7);
            this.BtnDeslizar.Name = "BtnDeslizar";
            this.BtnDeslizar.Size = new System.Drawing.Size(36, 30);
            this.BtnDeslizar.TabIndex = 15;
            this.BtnDeslizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDeslizar.UseVisualStyleBackColor = true;
            this.BtnDeslizar.Click += new System.EventHandler(this.BtnDeslizar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(0, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 31);
            this.panel8.TabIndex = 13;
            // 
            // BtnFactura
            // 
            this.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFactura.FlatAppearance.BorderSize = 0;
            this.BtnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactura.ForeColor = System.Drawing.Color.White;
            this.BtnFactura.Image = global::Presentacion.Properties.Resources.invoice_document_bill_delivery_note_icon_225179;
            this.BtnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.Location = new System.Drawing.Point(5, 388);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(173, 31);
            this.BtnFactura.TabIndex = 12;
            this.BtnFactura.Text = "Factura";
            this.BtnFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFactura.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 341);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 31);
            this.panel7.TabIndex = 11;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = global::Presentacion.Properties.Resources.icons8_ventas_32;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(5, 341);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(173, 31);
            this.BtnVentas.TabIndex = 10;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 253);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 31);
            this.panel6.TabIndex = 9;
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresa.ForeColor = System.Drawing.Color.White;
            this.BtnEmpresa.Image = global::Presentacion.Properties.Resources.icons8_empresa_32;
            this.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpresa.Location = new System.Drawing.Point(5, 253);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(173, 31);
            this.BtnEmpresa.TabIndex = 8;
            this.BtnEmpresa.Text = "Empresa";
            this.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 31);
            this.panel5.TabIndex = 7;
            // 
            // BtnAlimento
            // 
            this.BtnAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlimento.FlatAppearance.BorderSize = 0;
            this.BtnAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlimento.ForeColor = System.Drawing.Color.White;
            this.BtnAlimento.Image = global::Presentacion.Properties.Resources.food_gardening_grading_sack_grain_wheat_icon_255203;
            this.BtnAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlimento.Location = new System.Drawing.Point(5, 212);
            this.BtnAlimento.Name = "BtnAlimento";
            this.BtnAlimento.Size = new System.Drawing.Size(173, 31);
            this.BtnAlimento.TabIndex = 6;
            this.BtnAlimento.Text = "Alimento";
            this.BtnAlimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAlimento.UseVisualStyleBackColor = true;
            this.BtnAlimento.Click += new System.EventHandler(this.BtnAlimento_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 31);
            this.panel4.TabIndex = 5;
            // 
            // BtnMedicamento
            // 
            this.BtnMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMedicamento.FlatAppearance.BorderSize = 0;
            this.BtnMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicamento.ForeColor = System.Drawing.Color.White;
            this.BtnMedicamento.Image = global::Presentacion.Properties.Resources.treatment_drug_medication_capsules_drugs_medicine_pill_capsule_pills_icon_210667;
            this.BtnMedicamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedicamento.Location = new System.Drawing.Point(5, 170);
            this.BtnMedicamento.Name = "BtnMedicamento";
            this.BtnMedicamento.Size = new System.Drawing.Size(173, 31);
            this.BtnMedicamento.TabIndex = 4;
            this.BtnMedicamento.Text = "Medicamento";
            this.BtnMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMedicamento.UseVisualStyleBackColor = true;
            this.BtnMedicamento.Click += new System.EventHandler(this.BtnMedicamento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 31);
            this.panel3.TabIndex = 3;
            // 
            // BtnGalpon
            // 
            this.BtnGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGalpon.FlatAppearance.BorderSize = 0;
            this.BtnGalpon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnGalpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGalpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGalpon.ForeColor = System.Drawing.Color.White;
            this.BtnGalpon.Image = global::Presentacion.Properties.Resources.icons8_shed_32__3_;
            this.BtnGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalpon.Location = new System.Drawing.Point(5, 122);
            this.BtnGalpon.Name = "BtnGalpon";
            this.BtnGalpon.Size = new System.Drawing.Size(173, 31);
            this.BtnGalpon.TabIndex = 2;
            this.BtnGalpon.Text = "Galpon";
            this.BtnGalpon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGalpon.UseVisualStyleBackColor = true;
            this.BtnGalpon.Click += new System.EventHandler(this.BtnGalpon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 31);
            this.panel2.TabIndex = 1;
            // 
            // BtnPollo
            // 
            this.BtnPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPollo.FlatAppearance.BorderSize = 0;
            this.BtnPollo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnPollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPollo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPollo.ForeColor = System.Drawing.Color.White;
            this.BtnPollo.Image = global::Presentacion.Properties.Resources.icons8_pollo_32;
            this.BtnPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPollo.Location = new System.Drawing.Point(5, 76);
            this.BtnPollo.Name = "BtnPollo";
            this.BtnPollo.Size = new System.Drawing.Size(173, 31);
            this.BtnPollo.TabIndex = 0;
            this.BtnPollo.Text = "Pollo";
            this.BtnPollo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPollo.UseVisualStyleBackColor = true;
            this.BtnPollo.Click += new System.EventHandler(this.BtnPollo_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.PanelContenedor.Controls.Add(this.laHora);
            this.PanelContenedor.Controls.Add(this.Fecha);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(186, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(841, 596);
            this.PanelContenedor.TabIndex = 2;
            // 
            // laHora
            // 
            this.laHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.laHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHora.ForeColor = System.Drawing.Color.White;
            this.laHora.Location = new System.Drawing.Point(0, 546);
            this.laHora.Name = "laHora";
            this.laHora.Size = new System.Drawing.Size(841, 28);
            this.laHora.TabIndex = 1;
            this.laHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fecha
            // 
            this.Fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(0, 574);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(841, 22);
            this.Fecha.TabIndex = 0;
            this.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Horayfecha
            // 
            this.Horayfecha.Tick += new System.EventHandler(this.Horayfecha_Tick);
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 631);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPrincipal";
            this.Text = "FmrPrincipal";
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAlimento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnMedicamento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnDeslizar;
        private System.Windows.Forms.Timer Horayfecha;
        private System.Windows.Forms.Button BtnCerrarPrograma;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label laHora;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPersonal;
    }
}