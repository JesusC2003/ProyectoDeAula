namespace Presentacion
{
    partial class FmrAgregarPollo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodigoPollo = new System.Windows.Forms.TextBox();
            this.CboRazaPollo = new System.Windows.Forms.ComboBox();
            this.CboEstadopollo = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPollo = new System.Windows.Forms.Button();
            this.BtnSalirpollo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirpollo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos de Pollo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoPollo
            // 
            this.TxtCodigoPollo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPollo.Location = new System.Drawing.Point(179, 81);
            this.TxtCodigoPollo.Name = "TxtCodigoPollo";
            this.TxtCodigoPollo.Size = new System.Drawing.Size(172, 22);
            this.TxtCodigoPollo.TabIndex = 4;
            // 
            // CboRazaPollo
            // 
            this.CboRazaPollo.AutoCompleteCustomSource.AddRange(new string[] {
            "Avian",
            "Arbor Acres",
            "Cobb 500",
            "Ross 308",
            "Hubbard"});
            this.CboRazaPollo.FormattingEnabled = true;
            this.CboRazaPollo.Items.AddRange(new object[] {
            "Hubbard",
            "Ross 308",
            "Cobb 500",
            "Arbor Acres",
            "Avian"});
            this.CboRazaPollo.Location = new System.Drawing.Point(179, 142);
            this.CboRazaPollo.Name = "CboRazaPollo";
            this.CboRazaPollo.Size = new System.Drawing.Size(172, 21);
            this.CboRazaPollo.TabIndex = 5;
            // 
            // CboEstadopollo
            // 
            this.CboEstadopollo.AutoCompleteCustomSource.AddRange(new string[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.CboEstadopollo.FormattingEnabled = true;
            this.CboEstadopollo.Items.AddRange(new object[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.CboEstadopollo.Location = new System.Drawing.Point(179, 200);
            this.CboEstadopollo.Name = "CboEstadopollo";
            this.CboEstadopollo.Size = new System.Drawing.Size(172, 21);
            this.CboEstadopollo.TabIndex = 6;
            // 
            // BtnAgregarPollo
            // 
            this.BtnAgregarPollo.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarPollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarPollo.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPollo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPollo.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnAgregarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarPollo.Location = new System.Drawing.Point(162, 284);
            this.BtnAgregarPollo.Name = "BtnAgregarPollo";
            this.BtnAgregarPollo.Size = new System.Drawing.Size(147, 23);
            this.BtnAgregarPollo.TabIndex = 7;
            this.BtnAgregarPollo.Text = "Agregar";
            this.BtnAgregarPollo.UseVisualStyleBackColor = false;
            // 
            // BtnSalirpollo
            // 
            this.BtnSalirpollo.BackColor = System.Drawing.Color.Red;
            this.BtnSalirpollo.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.BtnSalirpollo.Location = new System.Drawing.Point(440, 280);
            this.BtnSalirpollo.Name = "BtnSalirpollo";
            this.BtnSalirpollo.Size = new System.Drawing.Size(24, 29);
            this.BtnSalirpollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirpollo.TabIndex = 124;
            this.BtnSalirpollo.TabStop = false;
            this.BtnSalirpollo.Click += new System.EventHandler(this.BtnSalirPollo_Click);
            // 
            // FmrAgregarPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.BtnSalirpollo);
            this.Controls.Add(this.BtnAgregarPollo);
            this.Controls.Add(this.CboEstadopollo);
            this.Controls.Add(this.CboRazaPollo);
            this.Controls.Add(this.TxtCodigoPollo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAgregarPollo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarPollo";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirpollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigoPollo;
        private System.Windows.Forms.ComboBox CboRazaPollo;
        private System.Windows.Forms.ComboBox CboEstadopollo;
        private System.Windows.Forms.Button BtnAgregarPollo;
        private System.Windows.Forms.PictureBox BtnSalirpollo;
    }
}