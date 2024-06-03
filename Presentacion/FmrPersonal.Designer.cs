namespace Presentacion
{
    partial class FmrPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.ClmIDPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmsegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboFiltradoPersonal = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPersonal = new System.Windows.Forms.Button();
            this.BtnEliminarPersonal = new System.Windows.Forms.Button();
            this.BtnVerPersonal = new System.Windows.Forms.Button();
            this.BtnEditarPersonal = new System.Windows.Forms.Button();
            this.TxtBusquedaPersonal = new System.Windows.Forms.TextBox();
            this.Controles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AllowUserToResizeColumns = false;
            this.dgvPersonal.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonal.ColumnHeadersHeight = 24;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIDPersonal,
            this.ClmNombres,
            this.ClmPrimerApellido,
            this.ClmsegundoApellido,
            this.ClmTelefono,
            this.ClmRol,
            this.ClmEmail,
            this.ClmFechaNacimiento});
            this.dgvPersonal.EnableHeadersVisualStyles = false;
            this.dgvPersonal.Location = new System.Drawing.Point(15, 96);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(812, 485);
            this.dgvPersonal.TabIndex = 109;
            this.dgvPersonal.Enter += new System.EventHandler(this.dgvPersonal_Enter);
            this.dgvPersonal.Leave += new System.EventHandler(this.dgvPersonal_Leave);
            // 
            // ClmIDPersonal
            // 
            this.ClmIDPersonal.FillWeight = 96.8818F;
            this.ClmIDPersonal.HeaderText = "ID Persona";
            this.ClmIDPersonal.MinimumWidth = 6;
            this.ClmIDPersonal.Name = "ClmIDPersonal";
            this.ClmIDPersonal.ReadOnly = true;
            // 
            // ClmNombres
            // 
            this.ClmNombres.FillWeight = 96.8818F;
            this.ClmNombres.HeaderText = "Nombres";
            this.ClmNombres.MinimumWidth = 6;
            this.ClmNombres.Name = "ClmNombres";
            this.ClmNombres.ReadOnly = true;
            this.ClmNombres.Width = 150;
            // 
            // ClmPrimerApellido
            // 
            this.ClmPrimerApellido.FillWeight = 96.8818F;
            this.ClmPrimerApellido.HeaderText = "Apellido1";
            this.ClmPrimerApellido.MinimumWidth = 6;
            this.ClmPrimerApellido.Name = "ClmPrimerApellido";
            this.ClmPrimerApellido.ReadOnly = true;
            this.ClmPrimerApellido.Width = 150;
            // 
            // ClmsegundoApellido
            // 
            this.ClmsegundoApellido.FillWeight = 96.8818F;
            this.ClmsegundoApellido.HeaderText = "Apellido2";
            this.ClmsegundoApellido.MinimumWidth = 6;
            this.ClmsegundoApellido.Name = "ClmsegundoApellido";
            this.ClmsegundoApellido.ReadOnly = true;
            this.ClmsegundoApellido.Width = 150;
            // 
            // ClmTelefono
            // 
            this.ClmTelefono.FillWeight = 96.8818F;
            this.ClmTelefono.HeaderText = "Telefono";
            this.ClmTelefono.MinimumWidth = 6;
            this.ClmTelefono.Name = "ClmTelefono";
            this.ClmTelefono.ReadOnly = true;
            this.ClmTelefono.Width = 125;
            // 
            // ClmRol
            // 
            this.ClmRol.FillWeight = 96.8818F;
            this.ClmRol.HeaderText = "Rol";
            this.ClmRol.MinimumWidth = 6;
            this.ClmRol.Name = "ClmRol";
            this.ClmRol.ReadOnly = true;
            // 
            // ClmEmail
            // 
            this.ClmEmail.HeaderText = "Email";
            this.ClmEmail.Name = "ClmEmail";
            this.ClmEmail.ReadOnly = true;
            this.ClmEmail.Width = 180;
            // 
            // ClmFechaNacimiento
            // 
            this.ClmFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.ClmFechaNacimiento.MinimumWidth = 6;
            this.ClmFechaNacimiento.Name = "ClmFechaNacimiento";
            this.ClmFechaNacimiento.ReadOnly = true;
            this.ClmFechaNacimiento.Width = 180;
            // 
            // CboFiltradoPersonal
            // 
            this.CboFiltradoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFiltradoPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFiltradoPersonal.FormattingEnabled = true;
            this.CboFiltradoPersonal.Location = new System.Drawing.Point(689, 28);
            this.CboFiltradoPersonal.Name = "CboFiltradoPersonal";
            this.CboFiltradoPersonal.Size = new System.Drawing.Size(138, 25);
            this.CboFiltradoPersonal.TabIndex = 122;
            // 
            // BtnAgregarPersonal
            // 
            this.BtnAgregarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPersonal.Image = global::Presentacion.Properties.Resources.icons8_añadir_32;
            this.BtnAgregarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarPersonal.Location = new System.Drawing.Point(15, 64);
            this.BtnAgregarPersonal.Name = "BtnAgregarPersonal";
            this.BtnAgregarPersonal.Size = new System.Drawing.Size(88, 28);
            this.BtnAgregarPersonal.TabIndex = 121;
            this.BtnAgregarPersonal.Text = "Añadir";
            this.BtnAgregarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarPersonal.UseVisualStyleBackColor = true;
            this.BtnAgregarPersonal.Click += new System.EventHandler(this.BtnAgregarPersonal_Click);
            // 
            // BtnEliminarPersonal
            // 
            this.BtnEliminarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_eliminar_32__1_;
            this.BtnEliminarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEliminarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPersonal.Location = new System.Drawing.Point(798, 71);
            this.BtnEliminarPersonal.Name = "BtnEliminarPersonal";
            this.BtnEliminarPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminarPersonal.TabIndex = 120;
            this.BtnEliminarPersonal.UseVisualStyleBackColor = true;
            // 
            // BtnVerPersonal
            // 
            this.BtnVerPersonal.BackgroundImage = global::Presentacion.Properties.Resources.icons8_ver;
            this.BtnVerPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVerPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerPersonal.FlatAppearance.BorderSize = 0;
            this.BtnVerPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerPersonal.Location = new System.Drawing.Point(768, 71);
            this.BtnVerPersonal.Name = "BtnVerPersonal";
            this.BtnVerPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnVerPersonal.TabIndex = 119;
            this.BtnVerPersonal.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPersonal
            // 
            this.BtnEditarPersonal.BackgroundImage = global::Presentacion.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.BtnEditarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarPersonal.FlatAppearance.BorderSize = 0;
            this.BtnEditarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarPersonal.Location = new System.Drawing.Point(738, 71);
            this.BtnEditarPersonal.Name = "BtnEditarPersonal";
            this.BtnEditarPersonal.Size = new System.Drawing.Size(29, 25);
            this.BtnEditarPersonal.TabIndex = 118;
            this.BtnEditarPersonal.UseVisualStyleBackColor = true;
            // 
            // TxtBusquedaPersonal
            // 
            this.TxtBusquedaPersonal.BackColor = System.Drawing.Color.Gray;
            this.TxtBusquedaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusquedaPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaPersonal.ForeColor = System.Drawing.Color.White;
            this.TxtBusquedaPersonal.Location = new System.Drawing.Point(106, 29);
            this.TxtBusquedaPersonal.Name = "TxtBusquedaPersonal";
            this.TxtBusquedaPersonal.Size = new System.Drawing.Size(579, 23);
            this.TxtBusquedaPersonal.TabIndex = 117;
            this.TxtBusquedaPersonal.Text = "Busqueda";
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(16, 29);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(100, 23);
            this.Controles.TabIndex = 116;
            this.Controles.Text = "Controles";
            // 
            // FmrPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.CboFiltradoPersonal);
            this.Controls.Add(this.BtnAgregarPersonal);
            this.Controls.Add(this.BtnEliminarPersonal);
            this.Controls.Add(this.BtnVerPersonal);
            this.Controls.Add(this.BtnEditarPersonal);
            this.Controls.Add(this.TxtBusquedaPersonal);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.dgvPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrPersonal";
            this.Text = "FmrPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIDPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmsegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaNacimiento;
        private System.Windows.Forms.ComboBox CboFiltradoPersonal;
        private System.Windows.Forms.Button BtnAgregarPersonal;
        private System.Windows.Forms.Button BtnEliminarPersonal;
        private System.Windows.Forms.Button BtnVerPersonal;
        private System.Windows.Forms.Button BtnEditarPersonal;
        private System.Windows.Forms.TextBox TxtBusquedaPersonal;
        private System.Windows.Forms.Label Controles;
    }
}