namespace Presentacion
{
    partial class frmAgregarGalpon
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalirGalpon = new System.Windows.Forms.PictureBox();
            this.btnAgregarGalpon = new System.Windows.Forms.Button();
            this.cmbEstadoGalpon = new System.Windows.Forms.ComboBox();
            this.txtCodigoGalpon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirGalpon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datos de Galpon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalirGalpon
            // 
            this.btnSalirGalpon.BackColor = System.Drawing.Color.Red;
            this.btnSalirGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirGalpon.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnSalirGalpon.Location = new System.Drawing.Point(441, 281);
            this.btnSalirGalpon.Name = "btnSalirGalpon";
            this.btnSalirGalpon.Size = new System.Drawing.Size(24, 29);
            this.btnSalirGalpon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalirGalpon.TabIndex = 126;
            this.btnSalirGalpon.TabStop = false;
            this.btnSalirGalpon.Click += new System.EventHandler(this.BtnSalirGalpon_Click);
            // 
            // btnAgregarGalpon
            // 
            this.btnAgregarGalpon.BackColor = System.Drawing.Color.Green;
            this.btnAgregarGalpon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarGalpon.FlatAppearance.BorderSize = 0;
            this.btnAgregarGalpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGalpon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGalpon.Image = global::Presentacion.Properties.Resources.disk1;
            this.btnAgregarGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarGalpon.Location = new System.Drawing.Point(164, 282);
            this.btnAgregarGalpon.Name = "btnAgregarGalpon";
            this.btnAgregarGalpon.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarGalpon.TabIndex = 125;
            this.btnAgregarGalpon.Text = "Agregar";
            this.btnAgregarGalpon.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoGalpon
            // 
            this.cmbEstadoGalpon.AutoCompleteCustomSource.AddRange(new string[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.cmbEstadoGalpon.FormattingEnabled = true;
            this.cmbEstadoGalpon.Items.AddRange(new object[] {
            "Mantenimiento",
            "Disponible"});
            this.cmbEstadoGalpon.Location = new System.Drawing.Point(185, 203);
            this.cmbEstadoGalpon.Name = "cmbEstadoGalpon";
            this.cmbEstadoGalpon.Size = new System.Drawing.Size(172, 21);
            this.cmbEstadoGalpon.TabIndex = 130;
            // 
            // txtCodigoGalpon
            // 
            this.txtCodigoGalpon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoGalpon.Location = new System.Drawing.Point(185, 84);
            this.txtCodigoGalpon.Name = "txtCodigoGalpon";
            this.txtCodigoGalpon.Size = new System.Drawing.Size(172, 22);
            this.txtCodigoGalpon.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 127;
            this.label1.Text = "Codigo";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(185, 143);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(172, 22);
            this.txtArea.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 131;
            this.label3.Text = "Area";
            // 
            // frmAgregarGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEstadoGalpon);
            this.Controls.Add(this.txtCodigoGalpon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirGalpon);
            this.Controls.Add(this.btnAgregarGalpon);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarGalpon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirGalpon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSalirGalpon;
        private System.Windows.Forms.Button btnAgregarGalpon;
        private System.Windows.Forms.ComboBox cmbEstadoGalpon;
        private System.Windows.Forms.TextBox txtCodigoGalpon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
    }
}