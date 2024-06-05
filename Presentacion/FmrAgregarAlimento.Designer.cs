namespace Presentacion
{
    partial class FmrAgregarAlimento
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
            this.CboMarcaAlimento = new System.Windows.Forms.ComboBox();
            this.CboTipoAlimento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoAlimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalirAlimento = new System.Windows.Forms.PictureBox();
            this.BtnAgregarAlimento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // CboMarcaAlimento
            // 
            this.CboMarcaAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMarcaAlimento.FormattingEnabled = true;
            this.CboMarcaAlimento.Items.AddRange(new object[] {
            "Purina",
            "Avifasa",
            "Italcol"});
            this.CboMarcaAlimento.Location = new System.Drawing.Point(163, 139);
            this.CboMarcaAlimento.Name = "CboMarcaAlimento";
            this.CboMarcaAlimento.Size = new System.Drawing.Size(193, 24);
            this.CboMarcaAlimento.TabIndex = 110;
            // 
            // CboTipoAlimento
            // 
            this.CboTipoAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoAlimento.FormattingEnabled = true;
            this.CboTipoAlimento.Items.AddRange(new object[] {
            "Iniciación ",
            "Crecimiento",
            "Engorde"});
            this.CboTipoAlimento.Location = new System.Drawing.Point(163, 187);
            this.CboTipoAlimento.Name = "CboTipoAlimento";
            this.CboTipoAlimento.Size = new System.Drawing.Size(193, 24);
            this.CboTipoAlimento.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 108;
            this.label6.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Marca";
            // 
            // txtCodigoAlimento
            // 
            this.txtCodigoAlimento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAlimento.Location = new System.Drawing.Point(163, 92);
            this.txtCodigoAlimento.Name = "txtCodigoAlimento";
            this.txtCodigoAlimento.Size = new System.Drawing.Size(193, 21);
            this.txtCodigoAlimento.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Codigo";
            // 
            // BtnSalirAlimento
            // 
            this.BtnSalirAlimento.BackColor = System.Drawing.Color.Red;
            this.BtnSalirAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirAlimento.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirAlimento.Location = new System.Drawing.Point(439, 280);
            this.BtnSalirAlimento.Name = "BtnSalirAlimento";
            this.BtnSalirAlimento.Size = new System.Drawing.Size(24, 29);
            this.BtnSalirAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirAlimento.TabIndex = 124;
            this.BtnSalirAlimento.TabStop = false;
            this.BtnSalirAlimento.Click += new System.EventHandler(this.BtnSalirAlimento_Click);
            // 
            // BtnAgregarAlimento
            // 
            this.BtnAgregarAlimento.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarAlimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarAlimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarAlimento.FlatAppearance.BorderSize = 0;
            this.BtnAgregarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarAlimento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarAlimento.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnAgregarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarAlimento.Location = new System.Drawing.Point(163, 285);
            this.BtnAgregarAlimento.Name = "BtnAgregarAlimento";
            this.BtnAgregarAlimento.Size = new System.Drawing.Size(147, 23);
            this.BtnAgregarAlimento.TabIndex = 127;
            this.BtnAgregarAlimento.Text = "Agregar";
            this.BtnAgregarAlimento.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 126;
            this.label4.Text = "Datos de Alimento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmrAgregarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.BtnAgregarAlimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSalirAlimento);
            this.Controls.Add(this.CboMarcaAlimento);
            this.Controls.Add(this.CboTipoAlimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoAlimento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAgregarAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboMarcaAlimento;
        private System.Windows.Forms.ComboBox CboTipoAlimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoAlimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnSalirAlimento;
        private System.Windows.Forms.Button BtnAgregarAlimento;
        private System.Windows.Forms.Label label4;
    }
}