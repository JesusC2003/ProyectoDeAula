namespace Presentacion
{
    partial class frmIniciarSession
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.BtnRestaurarsesion = new System.Windows.Forms.Button();
            this.BtnMaximizarSesion = new System.Windows.Forms.Button();
            this.BtnCerrarsesion = new System.Windows.Forms.Button();
            this.BtnMinimizarsesion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.piccontraseña = new System.Windows.Forms.PictureBox();
            this.picusuario = new System.Windows.Forms.PictureBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccontraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 327);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hensys";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.fondo4;
            this.pictureBox3.Location = new System.Drawing.Point(44, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnl.Controls.Add(this.BtnRestaurarsesion);
            this.pnl.Controls.Add(this.BtnMaximizarSesion);
            this.pnl.Controls.Add(this.BtnCerrarsesion);
            this.pnl.Controls.Add(this.BtnMinimizarsesion);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(250, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(524, 36);
            this.pnl.TabIndex = 7;
            this.pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BtnRestaurarsesion
            // 
            this.BtnRestaurarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurarsesion.FlatAppearance.BorderSize = 0;
            this.BtnRestaurarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnRestaurarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurarsesion.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurarsesion.Image = global::Presentacion.Properties.Resources.window_restore_icon_181231;
            this.BtnRestaurarsesion.Location = new System.Drawing.Point(450, 3);
            this.BtnRestaurarsesion.Name = "BtnRestaurarsesion";
            this.BtnRestaurarsesion.Size = new System.Drawing.Size(30, 28);
            this.BtnRestaurarsesion.TabIndex = 12;
            this.BtnRestaurarsesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRestaurarsesion.UseVisualStyleBackColor = true;
            this.BtnRestaurarsesion.Visible = false;
            this.BtnRestaurarsesion.Click += new System.EventHandler(this.BtnRestaurarsesion_Click);
            // 
            // BtnMaximizarSesion
            // 
            this.BtnMaximizarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizarSesion.FlatAppearance.BorderSize = 0;
            this.BtnMaximizarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.BtnMaximizarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximizarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnMaximizarSesion.Image = global::Presentacion.Properties.Resources.window_maximize_icon_181228;
            this.BtnMaximizarSesion.Location = new System.Drawing.Point(450, 3);
            this.BtnMaximizarSesion.Name = "BtnMaximizarSesion";
            this.BtnMaximizarSesion.Size = new System.Drawing.Size(30, 28);
            this.BtnMaximizarSesion.TabIndex = 11;
            this.BtnMaximizarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMaximizarSesion.UseVisualStyleBackColor = true;
            this.BtnMaximizarSesion.Click += new System.EventHandler(this.BtnMaximizarSesion_Click);
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
            this.BtnCerrarsesion.Location = new System.Drawing.Point(486, 2);
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
            this.BtnMinimizarsesion.Location = new System.Drawing.Point(409, 2);
            this.BtnMinimizarsesion.Name = "BtnMinimizarsesion";
            this.BtnMinimizarsesion.Size = new System.Drawing.Size(35, 31);
            this.BtnMinimizarsesion.TabIndex = 9;
            this.BtnMinimizarsesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizarsesion.UseVisualStyleBackColor = true;
            this.BtnMinimizarsesion.Click += new System.EventHandler(this.BtnMinimizarsesion_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.piccontraseña);
            this.panel3.Controls.Add(this.picusuario);
            this.panel3.Controls.Add(this.btnAcceder);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtContraseña);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 291);
            this.panel3.TabIndex = 8;
            // 
            // piccontraseña
            // 
            this.piccontraseña.Image = global::Presentacion.Properties.Resources.iconfinder_lock_4341303_120563;
            this.piccontraseña.Location = new System.Drawing.Point(42, 180);
            this.piccontraseña.Name = "piccontraseña";
            this.piccontraseña.Size = new System.Drawing.Size(29, 23);
            this.piccontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccontraseña.TabIndex = 12;
            this.piccontraseña.TabStop = false;
            // 
            // picusuario
            // 
            this.picusuario.Image = global::Presentacion.Properties.Resources.user_icon_icons_com_66546;
            this.picusuario.Location = new System.Drawing.Point(42, 104);
            this.picusuario.Name = "picusuario";
            this.picusuario.Size = new System.Drawing.Size(29, 23);
            this.picusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picusuario.TabIndex = 11;
            this.picusuario.TabStop = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(166, 232);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(203, 26);
            this.btnAcceder.TabIndex = 10;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(149, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iniciar Sessión";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(72, 180);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(411, 23);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter_1);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(72, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(411, 23);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter_1);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave_1);
            // 
            // frmIniciarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(774, 327);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIniciarSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sección";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccontraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox piccontraseña;
        private System.Windows.Forms.PictureBox picusuario;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button BtnRestaurarsesion;
        private System.Windows.Forms.Button BtnMaximizarSesion;
        private System.Windows.Forms.Button BtnCerrarsesion;
        private System.Windows.Forms.Button BtnMinimizarsesion;
    }
}

