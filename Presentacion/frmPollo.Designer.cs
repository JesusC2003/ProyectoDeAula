namespace Presentacion
{
    partial class frmPollo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFiltrado = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGestionPollo = new System.Windows.Forms.Panel();
            this.cmbGalpon = new System.Windows.Forms.ComboBox();
            this.txtFechaIngreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitarPollo = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEdadPollo = new System.Windows.Forms.ComboBox();
            this.txtLote = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbEstadoPollo = new System.Windows.Forms.ComboBox();
            this.txtRazaPollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcodigoPollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Controles = new System.Windows.Forms.Label();
            this.txtBusquedaPollo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPollo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlGestionPollo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPollo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbFiltrado);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnEliminarPollo);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.pnlGestionPollo);
            this.panel1.Controls.Add(this.txtBusquedaPollo);
            this.panel1.Controls.Add(this.dgvPollo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 738);
            this.panel1.TabIndex = 0;
            // 
            // cmbFiltrado
            // 
            this.cmbFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrado.FormattingEnabled = true;
            this.cmbFiltrado.Location = new System.Drawing.Point(700, 324);
            this.cmbFiltrado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltrado.Name = "cmbFiltrado";
            this.cmbFiltrado.Size = new System.Drawing.Size(256, 27);
            this.cmbFiltrado.TabIndex = 177;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderRadius = 12;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.FillColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnNuevo.Location = new System.Drawing.Point(1075, 316);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 37);
            this.btnNuevo.TabIndex = 176;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextFormatNoPrefix = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminarPollo
            // 
            this.btnEliminarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPollo.BorderRadius = 12;
            this.btnEliminarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnEliminarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnEliminarPollo.Location = new System.Drawing.Point(1393, 316);
            this.btnEliminarPollo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPollo.Name = "btnEliminarPollo";
            this.btnEliminarPollo.Size = new System.Drawing.Size(160, 37);
            this.btnEliminarPollo.TabIndex = 175;
            this.btnEliminarPollo.Text = "Eliminar";
            this.btnEliminarPollo.TextFormatNoPrefix = true;
            this.btnEliminarPollo.Click += new System.EventHandler(this.btnEliminarPollo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 12;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.LightBlue;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnModificar.Location = new System.Drawing.Point(1235, 316);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 37);
            this.btnModificar.TabIndex = 174;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextFormatNoPrefix = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlGestionPollo
            // 
            this.pnlGestionPollo.Controls.Add(this.cmbGalpon);
            this.pnlGestionPollo.Controls.Add(this.txtFechaIngreso);
            this.pnlGestionPollo.Controls.Add(this.btnAgregarPollo);
            this.pnlGestionPollo.Controls.Add(this.btnCancelarPollo);
            this.pnlGestionPollo.Controls.Add(this.btnQuitarPollo);
            this.pnlGestionPollo.Controls.Add(this.cmbEdadPollo);
            this.pnlGestionPollo.Controls.Add(this.txtLote);
            this.pnlGestionPollo.Controls.Add(this.cmbEstadoPollo);
            this.pnlGestionPollo.Controls.Add(this.txtRazaPollo);
            this.pnlGestionPollo.Controls.Add(this.txtcodigoPollo);
            this.pnlGestionPollo.Controls.Add(this.label6);
            this.pnlGestionPollo.Controls.Add(this.label5);
            this.pnlGestionPollo.Controls.Add(this.label4);
            this.pnlGestionPollo.Controls.Add(this.label3);
            this.pnlGestionPollo.Controls.Add(this.label2);
            this.pnlGestionPollo.Controls.Add(this.label1);
            this.pnlGestionPollo.Controls.Add(this.Controles);
            this.pnlGestionPollo.Location = new System.Drawing.Point(75, 38);
            this.pnlGestionPollo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGestionPollo.Name = "pnlGestionPollo";
            this.pnlGestionPollo.Size = new System.Drawing.Size(1477, 220);
            this.pnlGestionPollo.TabIndex = 173;
            // 
            // cmbGalpon
            // 
            this.cmbGalpon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGalpon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGalpon.FormattingEnabled = true;
            this.cmbGalpon.Location = new System.Drawing.Point(427, 160);
            this.cmbGalpon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGalpon.Name = "cmbGalpon";
            this.cmbGalpon.Size = new System.Drawing.Size(189, 27);
            this.cmbGalpon.TabIndex = 145;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.AutoSize = true;
            this.txtFechaIngreso.BorderColor = System.Drawing.Color.Silver;
            this.txtFechaIngreso.BorderRadius = 5;
            this.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaIngreso.DefaultText = "";
            this.txtFechaIngreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFechaIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFechaIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaIngreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFechaIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaIngreso.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtFechaIngreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFechaIngreso.Location = new System.Drawing.Point(61, 166);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.PasswordChar = '\0';
            this.txtFechaIngreso.PlaceholderText = "";
            this.txtFechaIngreso.SelectedText = "";
            this.txtFechaIngreso.Size = new System.Drawing.Size(237, 30);
            this.txtFechaIngreso.TabIndex = 144;
            // 
            // btnAgregarPollo
            // 
            this.btnAgregarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPollo.BorderRadius = 12;
            this.btnAgregarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnAgregarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnAgregarPollo.Image = global::Presentacion.Properties.Resources.new_file_40454;
            this.btnAgregarPollo.Location = new System.Drawing.Point(1293, 49);
            this.btnAgregarPollo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPollo.Name = "btnAgregarPollo";
            this.btnAgregarPollo.Size = new System.Drawing.Size(144, 37);
            this.btnAgregarPollo.TabIndex = 143;
            this.btnAgregarPollo.Text = "Agregar";
            this.btnAgregarPollo.TextFormatNoPrefix = true;
            this.btnAgregarPollo.Click += new System.EventHandler(this.btnAgregarPollo_Click);
            // 
            // btnCancelarPollo
            // 
            this.btnCancelarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPollo.BorderRadius = 12;
            this.btnCancelarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancelarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnCancelarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnCancelarPollo.Location = new System.Drawing.Point(1293, 153);
            this.btnCancelarPollo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarPollo.Name = "btnCancelarPollo";
            this.btnCancelarPollo.Size = new System.Drawing.Size(144, 37);
            this.btnCancelarPollo.TabIndex = 142;
            this.btnCancelarPollo.Text = "Cancelar";
            this.btnCancelarPollo.TextFormatNoPrefix = true;
            this.btnCancelarPollo.Click += new System.EventHandler(this.btnCancelarPollo_Click);
            // 
            // btnQuitarPollo
            // 
            this.btnQuitarPollo.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarPollo.BorderRadius = 12;
            this.btnQuitarPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPollo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnQuitarPollo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitarPollo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitarPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitarPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitarPollo.FillColor = System.Drawing.Color.LightBlue;
            this.btnQuitarPollo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPollo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.btnQuitarPollo.Image = global::Presentacion.Properties.Resources.file_delete_114438;
            this.btnQuitarPollo.Location = new System.Drawing.Point(1293, 102);
            this.btnQuitarPollo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPollo.Name = "btnQuitarPollo";
            this.btnQuitarPollo.Size = new System.Drawing.Size(144, 37);
            this.btnQuitarPollo.TabIndex = 141;
            this.btnQuitarPollo.Text = "Quitar";
            this.btnQuitarPollo.TextFormatNoPrefix = true;
            this.btnQuitarPollo.Click += new System.EventHandler(this.btnQuitarPollo_Click);
            // 
            // cmbEdadPollo
            // 
            this.cmbEdadPollo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEdadPollo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdadPollo.FormattingEnabled = true;
            this.cmbEdadPollo.Location = new System.Drawing.Point(927, 57);
            this.cmbEdadPollo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEdadPollo.Name = "cmbEdadPollo";
            this.cmbEdadPollo.Size = new System.Drawing.Size(159, 27);
            this.cmbEdadPollo.TabIndex = 139;
            // 
            // txtLote
            // 
            this.txtLote.AutoSize = true;
            this.txtLote.BorderColor = System.Drawing.Color.Silver;
            this.txtLote.BorderRadius = 5;
            this.txtLote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLote.DefaultText = "";
            this.txtLote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLote.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.ForeColor = System.Drawing.Color.Black;
            this.txtLote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLote.Location = new System.Drawing.Point(723, 160);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLote.Name = "txtLote";
            this.txtLote.PasswordChar = '\0';
            this.txtLote.PlaceholderText = "";
            this.txtLote.SelectedText = "";
            this.txtLote.Size = new System.Drawing.Size(192, 30);
            this.txtLote.TabIndex = 138;
            // 
            // cmbEstadoPollo
            // 
            this.cmbEstadoPollo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoPollo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoPollo.FormattingEnabled = true;
            this.cmbEstadoPollo.Items.AddRange(new object[] {
            "Vivo",
            "Muerto",
            "Enfermo"});
            this.cmbEstadoPollo.Location = new System.Drawing.Point(609, 58);
            this.cmbEstadoPollo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoPollo.Name = "cmbEstadoPollo";
            this.cmbEstadoPollo.Size = new System.Drawing.Size(180, 27);
            this.cmbEstadoPollo.TabIndex = 136;
            // 
            // txtRazaPollo
            // 
            this.txtRazaPollo.AutoSize = true;
            this.txtRazaPollo.BorderColor = System.Drawing.Color.Silver;
            this.txtRazaPollo.BorderRadius = 5;
            this.txtRazaPollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazaPollo.DefaultText = "";
            this.txtRazaPollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRazaPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRazaPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazaPollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazaPollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazaPollo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaPollo.ForeColor = System.Drawing.Color.Black;
            this.txtRazaPollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazaPollo.Location = new System.Drawing.Point(339, 63);
            this.txtRazaPollo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRazaPollo.Name = "txtRazaPollo";
            this.txtRazaPollo.PasswordChar = '\0';
            this.txtRazaPollo.PlaceholderText = "";
            this.txtRazaPollo.SelectedText = "";
            this.txtRazaPollo.Size = new System.Drawing.Size(185, 30);
            this.txtRazaPollo.TabIndex = 135;
            // 
            // txtcodigoPollo
            // 
            this.txtcodigoPollo.AutoSize = true;
            this.txtcodigoPollo.BorderColor = System.Drawing.Color.Silver;
            this.txtcodigoPollo.BorderRadius = 5;
            this.txtcodigoPollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigoPollo.DefaultText = "";
            this.txtcodigoPollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigoPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigoPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigoPollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigoPollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigoPollo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoPollo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigoPollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigoPollo.Location = new System.Drawing.Point(61, 63);
            this.txtcodigoPollo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigoPollo.Name = "txtcodigoPollo";
            this.txtcodigoPollo.PasswordChar = '\0';
            this.txtcodigoPollo.PlaceholderText = "";
            this.txtcodigoPollo.SelectedText = "";
            this.txtcodigoPollo.Size = new System.Drawing.Size(204, 30);
            this.txtcodigoPollo.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 28);
            this.label6.TabIndex = 123;
            this.label6.Text = "Fecha Ingreso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 28);
            this.label5.TabIndex = 122;
            this.label5.Text = "Galpon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(333, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 121;
            this.label4.Text = "Raza";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(921, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 120;
            this.label3.Text = "Edad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(604, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 119;
            this.label2.Text = "Estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(717, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 118;
            this.label1.Text = "Lote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Controles
            // 
            this.Controles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.ForeColor = System.Drawing.Color.White;
            this.Controles.Location = new System.Drawing.Point(81, 27);
            this.Controles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(141, 28);
            this.Controles.TabIndex = 117;
            this.Controles.Text = "Codigo";
            this.Controles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBusquedaPollo
            // 
            this.txtBusquedaPollo.AutoSize = true;
            this.txtBusquedaPollo.BorderColor = System.Drawing.Color.Silver;
            this.txtBusquedaPollo.BorderRadius = 5;
            this.txtBusquedaPollo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaPollo.DefaultText = "Busqueda";
            this.txtBusquedaPollo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaPollo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaPollo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaPollo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaPollo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaPollo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPollo.ForeColor = System.Drawing.Color.Black;
            this.txtBusquedaPollo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaPollo.Location = new System.Drawing.Point(49, 321);
            this.txtBusquedaPollo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusquedaPollo.Name = "txtBusquedaPollo";
            this.txtBusquedaPollo.PasswordChar = '\0';
            this.txtBusquedaPollo.PlaceholderText = "";
            this.txtBusquedaPollo.SelectedText = "";
            this.txtBusquedaPollo.Size = new System.Drawing.Size(643, 33);
            this.txtBusquedaPollo.TabIndex = 172;
            this.txtBusquedaPollo.Enter += new System.EventHandler(this.txtBusquedaPollo_Enter);
            this.txtBusquedaPollo.Leave += new System.EventHandler(this.txtBusquedaPollo_Leave);
            // 
            // dgvPollo
            // 
            this.dgvPollo.AllowUserToAddRows = false;
            this.dgvPollo.AllowUserToDeleteRows = false;
            this.dgvPollo.AllowUserToOrderColumns = true;
            this.dgvPollo.AllowUserToResizeColumns = false;
            this.dgvPollo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvPollo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPollo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPollo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPollo.Location = new System.Drawing.Point(49, 362);
            this.dgvPollo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPollo.Name = "dgvPollo";
            this.dgvPollo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPollo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPollo.RowHeadersVisible = false;
            this.dgvPollo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvPollo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPollo.RowTemplate.Height = 24;
            this.dgvPollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPollo.Size = new System.Drawing.Size(1504, 338);
            this.dgvPollo.TabIndex = 171;
            // 
            // frmPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1600, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPollo";
            this.Text = "frmPollo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGestionPollo.ResumeLayout(false);
            this.pnlGestionPollo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPollo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltrado;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPollo;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private System.Windows.Forms.Panel pnlGestionPollo;
        private System.Windows.Forms.ComboBox cmbGalpon;
        private Guna.UI2.WinForms.Guna2TextBox txtFechaIngreso;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPollo;
        private Guna.UI2.WinForms.Guna2Button btnCancelarPollo;
        private Guna.UI2.WinForms.Guna2Button btnQuitarPollo;
        private System.Windows.Forms.ComboBox cmbEdadPollo;
        private Guna.UI2.WinForms.Guna2TextBox txtLote;
        private System.Windows.Forms.ComboBox cmbEstadoPollo;
        private Guna.UI2.WinForms.Guna2TextBox txtRazaPollo;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigoPollo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Controles;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaPollo;
        private System.Windows.Forms.DataGridView dgvPollo;
    }
}