namespace Presentacion
{
    partial class frmIniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.BtnCerrarsesion = new System.Windows.Forms.Button();
            this.BtnMinimizarsesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btniniciarsesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnmostrarcontraseña = new Guna.UI2.WinForms.Guna2Button();
            this.btnOcultarContraseña = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLblRegistrar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnltitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltitulo
            // 
            this.pnltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnltitulo.Controls.Add(this.BtnCerrarsesion);
            this.pnltitulo.Controls.Add(this.BtnMinimizarsesion);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Size = new System.Drawing.Size(411, 36);
            this.pnltitulo.TabIndex = 7;
            this.pnltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltitulo_MouseDown);
            // 
            // BtnCerrarsesion
            // 
            this.BtnCerrarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarsesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarsesion.Image = global::Presentacion.Properties.Resources.icons8_cerrar_ventana_32;
            this.BtnCerrarsesion.Location = new System.Drawing.Point(373, 2);
            this.BtnCerrarsesion.Name = "BtnCerrarsesion";
            this.BtnCerrarsesion.Size = new System.Drawing.Size(35, 31);
            this.BtnCerrarsesion.TabIndex = 10;
            this.BtnCerrarsesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrarsesion.UseVisualStyleBackColor = true;
            this.BtnCerrarsesion.Click += new System.EventHandler(this.BtnCerrarPrograma_Click);
            // 
            // BtnMinimizarsesion
            // 
            this.BtnMinimizarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizarsesion.FlatAppearance.BorderSize = 0;
            this.BtnMinimizarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnMinimizarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizarsesion.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizarsesion.Image = global::Presentacion.Properties.Resources.window_minimize_icon_181229;
            this.BtnMinimizarsesion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimizarsesion.Location = new System.Drawing.Point(332, 3);
            this.BtnMinimizarsesion.Name = "BtnMinimizarsesion";
            this.BtnMinimizarsesion.Size = new System.Drawing.Size(35, 31);
            this.BtnMinimizarsesion.TabIndex = 9;
            this.BtnMinimizarsesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizarsesion.UseVisualStyleBackColor = true;
            this.BtnMinimizarsesion.Click += new System.EventHandler(this.BtnMinimizarsesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 21);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuario.BorderRadius = 5;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(52, 233);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(315, 28);
            this.txtUsuario.TabIndex = 134;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.BorderColor = System.Drawing.Color.Silver;
            this.txtContraseña.BorderRadius = 5;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.Location = new System.Drawing.Point(52, 324);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.Size = new System.Drawing.Size(315, 28);
            this.txtContraseña.TabIndex = 136;
            // 
            // lblContra
            // 
            this.lblContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(53, 294);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(119, 26);
            this.lblContra.TabIndex = 135;
            this.lblContra.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logohens;
            this.pictureBox1.Location = new System.Drawing.Point(22, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btniniciarsesion.BorderRadius = 12;
            this.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarsesion.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btniniciarsesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btniniciarsesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btniniciarsesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btniniciarsesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btniniciarsesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(98)))), ((int)(((byte)(238)))));
            this.btniniciarsesion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btniniciarsesion.Location = new System.Drawing.Point(52, 403);
            this.btniniciarsesion.Margin = new System.Windows.Forms.Padding(2);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(315, 40);
            this.btniniciarsesion.TabIndex = 143;
            this.btniniciarsesion.Text = "Acceder";
            this.btniniciarsesion.TextFormatNoPrefix = true;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // btnmostrarcontraseña
            // 
            this.btnmostrarcontraseña.BackColor = System.Drawing.Color.White;
            this.btnmostrarcontraseña.BorderRadius = 12;
            this.btnmostrarcontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrarcontraseña.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnmostrarcontraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmostrarcontraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmostrarcontraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmostrarcontraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmostrarcontraseña.FillColor = System.Drawing.Color.White;
            this.btnmostrarcontraseña.FocusedColor = System.Drawing.Color.White;
            this.btnmostrarcontraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnmostrarcontraseña.ForeColor = System.Drawing.Color.Transparent;
            this.btnmostrarcontraseña.Image = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.btnmostrarcontraseña.Location = new System.Drawing.Point(334, 327);
            this.btnmostrarcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnmostrarcontraseña.Name = "btnmostrarcontraseña";
            this.btnmostrarcontraseña.Size = new System.Drawing.Size(31, 21);
            this.btnmostrarcontraseña.TabIndex = 144;
            this.btnmostrarcontraseña.TextFormatNoPrefix = true;
            this.btnmostrarcontraseña.Click += new System.EventHandler(this.btnmostrarcontraseña_Click);
            // 
            // btnOcultarContraseña
            // 
            this.btnOcultarContraseña.BackColor = System.Drawing.Color.White;
            this.btnOcultarContraseña.BorderRadius = 12;
            this.btnOcultarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarContraseña.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOcultarContraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOcultarContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOcultarContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOcultarContraseña.FillColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.FocusedColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOcultarContraseña.ForeColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.Image = global::Presentacion.Properties.Resources.icons8_ocultar_24;
            this.btnOcultarContraseña.Location = new System.Drawing.Point(334, 327);
            this.btnOcultarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcultarContraseña.Name = "btnOcultarContraseña";
            this.btnOcultarContraseña.Size = new System.Drawing.Size(31, 21);
            this.btnOcultarContraseña.TabIndex = 145;
            this.btnOcultarContraseña.TextFormatNoPrefix = true;
            this.btnOcultarContraseña.Click += new System.EventHandler(this.btnOcultarContraseña_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 147;
            this.label3.Text = "¿No tienes Cuenta?";
            // 
            // linkLblRegistrar
            // 
            this.linkLblRegistrar.ActiveLinkColor = System.Drawing.Color.Green;
            this.linkLblRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrar.ForeColor = System.Drawing.Color.Coral;
            this.linkLblRegistrar.LinkColor = System.Drawing.Color.White;
            this.linkLblRegistrar.Location = new System.Drawing.Point(237, 473);
            this.linkLblRegistrar.Name = "linkLblRegistrar";
            this.linkLblRegistrar.Size = new System.Drawing.Size(89, 25);
            this.linkLblRegistrar.TabIndex = 148;
            this.linkLblRegistrar.TabStop = true;
            this.linkLblRegistrar.Text = "Registrarse";
            this.linkLblRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistrar_LinkClicked);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 21);
            this.label2.TabIndex = 148;
            this.label2.Text = "INICIAR SESION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(411, 554);
            this.Controls.Add(this.linkLblRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOcultarContraseña);
            this.Controls.Add(this.btnmostrarcontraseña);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIniciarSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIniciarSession_Load);
            this.pnltitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Button BtnCerrarsesion;
        private System.Windows.Forms.Button BtnMinimizarsesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btniniciarsesion;
        private Guna.UI2.WinForms.Guna2Button btnmostrarcontraseña;
        private Guna.UI2.WinForms.Guna2Button btnOcultarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLblRegistrar;
        private System.Windows.Forms.Label label2;
    }
}

