namespace Presentacion
{
    partial class frmAgregarPollo
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
            this.txtCodigoPollo = new System.Windows.Forms.TextBox();
            this.cmbRazaPollo = new System.Windows.Forms.ComboBox();
            this.cmbEstadopollo = new System.Windows.Forms.ComboBox();
            this.btnAgregarPollo = new System.Windows.Forms.Button();
            this.btnSalirpollo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirpollo)).BeginInit();
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
            // txtCodigoPollo
            // 
            this.txtCodigoPollo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPollo.Location = new System.Drawing.Point(179, 81);
            this.txtCodigoPollo.Name = "txtCodigoPollo";
            this.txtCodigoPollo.Size = new System.Drawing.Size(172, 22);
            this.txtCodigoPollo.TabIndex = 4;
            // 
            // cmbRazaPollo
            // 
            this.cmbRazaPollo.AutoCompleteCustomSource.AddRange(new string[] {
            "Avian",
            "Arbor Acres",
            "Cobb 500",
            "Ross 308",
            "Hubbard"});
            this.cmbRazaPollo.FormattingEnabled = true;
            this.cmbRazaPollo.Items.AddRange(new object[] {
            "Hubbard",
            "Ross 308",
            "Cobb 500",
            "Arbor Acres",
            "Avian"});
            this.cmbRazaPollo.Location = new System.Drawing.Point(179, 142);
            this.cmbRazaPollo.Name = "cmbRazaPollo";
            this.cmbRazaPollo.Size = new System.Drawing.Size(172, 21);
            this.cmbRazaPollo.TabIndex = 5;
            // 
            // cmbEstadopollo
            // 
            this.cmbEstadopollo.AutoCompleteCustomSource.AddRange(new string[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.cmbEstadopollo.FormattingEnabled = true;
            this.cmbEstadopollo.Items.AddRange(new object[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.cmbEstadopollo.Location = new System.Drawing.Point(179, 200);
            this.cmbEstadopollo.Name = "cmbEstadopollo";
            this.cmbEstadopollo.Size = new System.Drawing.Size(172, 21);
            this.cmbEstadopollo.TabIndex = 6;
            // 
            // btnAgregarPollo
            // 
            this.btnAgregarPollo.BackColor = System.Drawing.Color.Green;
            this.btnAgregarPollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPollo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPollo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPollo.Image = global::Presentacion.Properties.Resources.disk1;
            this.btnAgregarPollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPollo.Location = new System.Drawing.Point(162, 283);
            this.btnAgregarPollo.Name = "btnAgregarPollo";
            this.btnAgregarPollo.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarPollo.TabIndex = 7;
            this.btnAgregarPollo.Text = "Agregar";
            this.btnAgregarPollo.UseVisualStyleBackColor = false;
            // 
            // btnSalirpollo
            // 
            this.btnSalirpollo.BackColor = System.Drawing.Color.Red;
            this.btnSalirpollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirpollo.Image = global::Presentacion.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnSalirpollo.Location = new System.Drawing.Point(440, 280);
            this.btnSalirpollo.Name = "btnSalirpollo";
            this.btnSalirpollo.Size = new System.Drawing.Size(24, 29);
            this.btnSalirpollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalirpollo.TabIndex = 124;
            this.btnSalirpollo.TabStop = false;
            this.btnSalirpollo.Click += new System.EventHandler(this.BtnSalirPollo_Click);
            // 
            // frmAgregarPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnSalirpollo);
            this.Controls.Add(this.btnAgregarPollo);
            this.Controls.Add(this.cmbEstadopollo);
            this.Controls.Add(this.cmbRazaPollo);
            this.Controls.Add(this.txtCodigoPollo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarPollo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAgregarPollo";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirpollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoPollo;
        private System.Windows.Forms.ComboBox cmbRazaPollo;
        private System.Windows.Forms.ComboBox cmbEstadopollo;
        private System.Windows.Forms.Button btnAgregarPollo;
        private System.Windows.Forms.PictureBox btnSalirpollo;
    }
}