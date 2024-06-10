﻿namespace Presentacion
{
    partial class frmAlimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlimento = new System.Windows.Forms.DataGridView();
            this.CboFiltradoA = new System.Windows.Forms.ComboBox();
            this.TxtBusquedaAlimento = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            this.BtnAgregarA = new System.Windows.Forms.Button();
            this.BtnEliminarA = new System.Windows.Forms.Button();
            this.BtnVerA = new System.Windows.Forms.Button();
            this.BtnEditarA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlimento
            // 
            this.dgvAlimento.AllowUserToAddRows = false;
            this.dgvAlimento.AllowUserToDeleteRows = false;
            this.dgvAlimento.AllowUserToResizeColumns = false;
            this.dgvAlimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAlimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlimento.ColumnHeadersHeight = 24;
            this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimento.EnableHeadersVisualStyles = false;
            this.dgvAlimento.Location = new System.Drawing.Point(20, 130);
            this.dgvAlimento.MultiSelect = false;
            this.dgvAlimento.Name = "dgvAlimento";
            this.dgvAlimento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlimento.RowHeadersVisible = false;
            this.dgvAlimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlimento.Size = new System.Drawing.Size(732, 389);
            this.dgvAlimento.TabIndex = 106;
            // 
            // CboFiltradoA
            // 
            this.CboFiltradoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFiltradoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoA.FormattingEnabled = true;
            this.CboFiltradoA.Location = new System.Drawing.Point(612, 48);
            this.CboFiltradoA.Name = "CboFiltradoA";
            this.CboFiltradoA.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoA.TabIndex = 129;
            // 
            // TxtBusquedaAlimento
            // 
            this.TxtBusquedaAlimento.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaAlimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaAlimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaAlimento.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaAlimento.Location = new System.Drawing.Point(126, 49);
            this.TxtBusquedaAlimento.Name = "TxtBusquedaAlimento";
            this.TxtBusquedaAlimento.Size = new System.Drawing.Size(483, 23);
            this.TxtBusquedaAlimento.TabIndex = 124;
            this.TxtBusquedaAlimento.Text = "Busqueda";
            this.TxtBusquedaAlimento.Enter += new System.EventHandler(this.TxtBusquedaAlimento_Enter);
            this.TxtBusquedaAlimento.Leave += new System.EventHandler(this.TxtBusquedaAlimento_Leave);
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(17, 50);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(103, 23);
            this.Controles.TabIndex = 123;
            this.Controles.Text = "Controles";
            // 
            // BtnAgregarA
            // 
            this.BtnAgregarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarA.FlatAppearance.BorderSize = 0;
            this.BtnAgregarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarA.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarA.Location = new System.Drawing.Point(21, 92);
            this.BtnAgregarA.Name = "BtnAgregarA";
            this.BtnAgregarA.Size = new System.Drawing.Size(101, 34);
            this.BtnAgregarA.TabIndex = 128;
            this.BtnAgregarA.Text = "Añadir";
            this.BtnAgregarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarA.UseVisualStyleBackColor = true;
            this.BtnAgregarA.Click += new System.EventHandler(this.BtnAgregarA_Click);
            // 
            // BtnEliminarA
            // 
            this.BtnEliminarA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarA.FlatAppearance.BorderSize = 0;
            this.BtnEliminarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarA.Location = new System.Drawing.Point(724, 101);
            this.BtnEliminarA.Name = "BtnEliminarA";
            this.BtnEliminarA.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarA.TabIndex = 127;
            this.BtnEliminarA.UseVisualStyleBackColor = true;
            // 
            // BtnVerA
            // 
            this.BtnVerA.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver_24;
            this.BtnVerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerA.FlatAppearance.BorderSize = 0;
            this.BtnVerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerA.Location = new System.Drawing.Point(689, 101);
            this.BtnVerA.Name = "BtnVerA";
            this.BtnVerA.Size = new System.Drawing.Size(29, 25);
            this.BtnVerA.TabIndex = 126;
            this.BtnVerA.UseVisualStyleBackColor = true;
            // 
            // BtnEditarA
            // 
            this.BtnEditarA.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarA.FlatAppearance.BorderSize = 0;
            this.BtnEditarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarA.Location = new System.Drawing.Point(654, 101);
            this.BtnEditarA.Name = "BtnEditarA";
            this.BtnEditarA.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarA.TabIndex = 125;
            this.BtnEditarA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 22);
            this.label1.TabIndex = 130;
            this.label1.Text = "Formulario para Alimento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmrAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboFiltradoA);
            this.Controls.Add(this.BtnAgregarA);
            this.Controls.Add(this.BtnEliminarA);
            this.Controls.Add(this.BtnVerA);
            this.Controls.Add(this.BtnEditarA);
            this.Controls.Add(this.TxtBusquedaAlimento);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvAlimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlimento;
        private System.Windows.Forms.ComboBox CboFiltradoA;
        private System.Windows.Forms.Button BtnAgregarA;
        private System.Windows.Forms.Button BtnEliminarA;
        private System.Windows.Forms.Button BtnVerA;
        private System.Windows.Forms.Button BtnEditarA;
        private System.Windows.Forms.TextBox TxtBusquedaAlimento;
        private System.Windows.Forms.Label Controles;
        private System.Windows.Forms.Label label1;
    }
}