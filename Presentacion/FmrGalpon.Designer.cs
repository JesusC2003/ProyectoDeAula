namespace Presentacion
{
    partial class FmrGalpon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnGuardarG = new System.Windows.Forms.Button();
            this.BtnModificarP = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnModificarP);
            this.tabPage1.Controls.Add(this.BtnGuardarG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarG
            // 
            this.BtnGuardarG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardarG.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarG.Image = global::Presentacion.Properties.Resources.disk1;
            this.BtnGuardarG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarG.Location = new System.Drawing.Point(4, 352);
            this.BtnGuardarG.Name = "BtnGuardarG";
            this.BtnGuardarG.Size = new System.Drawing.Size(132, 38);
            this.BtnGuardarG.TabIndex = 62;
            this.BtnGuardarG.Text = "Guardar";
            this.BtnGuardarG.UseVisualStyleBackColor = false;
            // 
            // BtnModificarP
            // 
            this.BtnModificarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificarP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarP.ForeColor = System.Drawing.Color.White;
            this.BtnModificarP.Image = global::Presentacion.Properties.Resources.edit_modify_icon_149489__1_;
            this.BtnModificarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarP.Location = new System.Drawing.Point(176, 353);
            this.BtnModificarP.Name = "BtnModificarP";
            this.BtnModificarP.Size = new System.Drawing.Size(146, 38);
            this.BtnModificarP.TabIndex = 63;
            this.BtnModificarP.Text = "Modificar";
            this.BtnModificarP.UseVisualStyleBackColor = false;
            // 
            // FmrGalpon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FmrGalpon";
            this.Text = "FmrGalpon";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnGuardarG;
        private System.Windows.Forms.Button BtnModificarP;
    }
}