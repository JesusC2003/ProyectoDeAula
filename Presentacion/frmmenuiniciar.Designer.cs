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
            this.picoriginal = new System.Windows.Forms.PictureBox();
            this.picresultado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picoriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // picoriginal
            // 
            this.picoriginal.Location = new System.Drawing.Point(178, 116);
            this.picoriginal.Name = "picoriginal";
            this.picoriginal.Size = new System.Drawing.Size(237, 175);
            this.picoriginal.TabIndex = 0;
            this.picoriginal.TabStop = false;
            // 
            // picresultado
            // 
            this.picresultado.Location = new System.Drawing.Point(178, 116);
            this.picresultado.Name = "picresultado";
            this.picresultado.Size = new System.Drawing.Size(237, 175);
            this.picresultado.TabIndex = 1;
            this.picresultado.TabStop = false;
            // 
            // frmmenuiniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(628, 449);
            this.Controls.Add(this.picresultado);
            this.Controls.Add(this.picoriginal);
            this.DoubleBuffered = true;
            this.Name = "frmmenuiniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenuiniciar";
            this.Load += new System.EventHandler(this.frmmenuiniciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picoriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picoriginal;
        private System.Windows.Forms.PictureBox picresultado;
    }
}