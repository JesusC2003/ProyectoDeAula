namespace Presentacion
{
    partial class FmrAgregarGalpon
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
            this.BtnSalirGalpon = new System.Windows.Forms.PictureBox();
            this.BtnAgregarGalpon = new System.Windows.Forms.Button();
            this.CboEstadoGalpon = new System.Windows.Forms.ComboBox();
            this.TxtCodigoGalpon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirGalpon)).BeginInit();
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
            // BtnSalirGalpon
            // 
            this.BtnSalirGalpon.BackColor = System.Drawing.Color.Red;
            this.BtnSalirGalpon.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirGalpon.Location = new System.Drawing.Point(441, 281);
            this.BtnSalirGalpon.Name = "BtnSalirGalpon";
            this.BtnSalirGalpon.Size = new System.Drawing.Size(24, 29);
            this.BtnSalirGalpon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirGalpon.TabIndex = 126;
            this.BtnSalirGalpon.TabStop = false;
            this.BtnSalirGalpon.Click += new System.EventHandler(this.BtnSalirGalpon_Click);
            // 
            // BtnAgregarGalpon
            // 
            this.BtnAgregarGalpon.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarGalpon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarGalpon.FlatAppearance.BorderSize = 0;
            this.BtnAgregarGalpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarGalpon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarGalpon.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnAgregarGalpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarGalpon.Location = new System.Drawing.Point(163, 285);
            this.BtnAgregarGalpon.Name = "BtnAgregarGalpon";
            this.BtnAgregarGalpon.Size = new System.Drawing.Size(147, 23);
            this.BtnAgregarGalpon.TabIndex = 125;
            this.BtnAgregarGalpon.Text = "Agregar";
            this.BtnAgregarGalpon.UseVisualStyleBackColor = false;
            // 
            // CboEstadoGalpon
            // 
            this.CboEstadoGalpon.AutoCompleteCustomSource.AddRange(new string[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.CboEstadoGalpon.FormattingEnabled = true;
            this.CboEstadoGalpon.Items.AddRange(new object[] {
            "Mantenimiento",
            "Disponible"});
            this.CboEstadoGalpon.Location = new System.Drawing.Point(185, 203);
            this.CboEstadoGalpon.Name = "CboEstadoGalpon";
            this.CboEstadoGalpon.Size = new System.Drawing.Size(172, 21);
            this.CboEstadoGalpon.TabIndex = 130;
            // 
            // TxtCodigoGalpon
            // 
            this.TxtCodigoGalpon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoGalpon.Location = new System.Drawing.Point(185, 84);
            this.TxtCodigoGalpon.Name = "TxtCodigoGalpon";
            this.TxtCodigoGalpon.Size = new System.Drawing.Size(172, 22);
            this.TxtCodigoGalpon.TabIndex = 129;
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
            // TxtArea
            // 
            this.TxtArea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.Location = new System.Drawing.Point(185, 143);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(172, 22);
            this.TxtArea.TabIndex = 132;
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
            // FmrAgregarGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboEstadoGalpon);
            this.Controls.Add(this.TxtCodigoGalpon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalirGalpon);
            this.Controls.Add(this.BtnAgregarGalpon);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAgregarGalpon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarGalpon";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirGalpon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BtnSalirGalpon;
        private System.Windows.Forms.Button BtnAgregarGalpon;
        private System.Windows.Forms.ComboBox CboEstadoGalpon;
        private System.Windows.Forms.TextBox TxtCodigoGalpon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label label3;
    }
}