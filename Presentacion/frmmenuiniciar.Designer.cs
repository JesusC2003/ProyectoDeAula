namespace Presentacion
{
    partial class frmmenuiniciar
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
            this.picresultado = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.FechayHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // picresultado
            // 
            this.picresultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picresultado.Image = global::Presentacion.Properties.Resources.LogoHensy;
            this.picresultado.Location = new System.Drawing.Point(12, 12);
            this.picresultado.Name = "picresultado";
            this.picresultado.Size = new System.Drawing.Size(620, 427);
            this.picresultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picresultado.TabIndex = 1;
            this.picresultado.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(0, 442);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(644, 23);
            this.lblHora.TabIndex = 6;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(0, 465);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(644, 23);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FechayHora
            // 
            this.FechayHora.Tick += new System.EventHandler(this.FechayHora_Tick);
            // 
            // frmmenuiniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(644, 488);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.picresultado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmenuiniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenuiniciar";
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picresultado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer FechayHora;
    }
}