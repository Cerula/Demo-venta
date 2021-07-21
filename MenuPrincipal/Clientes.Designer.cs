namespace MenuPrincipal
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltel1 = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lblnombre1_clientes = new System.Windows.Forms.Label();
            this.lblDni_clientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btn_cargardatos = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBarrio = new System.Windows.Forms.TextBox();
            this.txttel2 = new System.Windows.Forms.TextBox();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lbltel2 = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.lblapellido2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtdto = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.textmza = new System.Windows.Forms.TextBox();
            this.lblmza = new System.Windows.Forms.Label();
            this.txt_lote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal_cliente = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrellenar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Buscar.Location = new System.Drawing.Point(134, 276);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(149, 30);
            this.btn_Buscar.TabIndex = 34;
            this.btn_Buscar.Text = "Rellenar por DNI";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(51, 585);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.txtdireccion.TabIndex = 29;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(51, 472);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(124, 22);
            this.txttel.TabIndex = 28;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(271, 527);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(149, 22);
            this.txtciudad.TabIndex = 27;
            this.txtciudad.TextChanged += new System.EventHandler(this.txtciudad_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(193, 421);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(124, 22);
            this.txtnombre.TabIndex = 26;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(51, 421);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(124, 22);
            this.txtdni.TabIndex = 25;
            this.txtdni.TextChanged += new System.EventHandler(this.txtdni_TextChanged);
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldireccion.Location = new System.Drawing.Point(48, 566);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(72, 17);
            this.lbldireccion.TabIndex = 24;
            this.lbldireccion.Text = "*Direccion";
            // 
            // lbltel1
            // 
            this.lbltel1.AutoSize = true;
            this.lbltel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltel1.Location = new System.Drawing.Point(48, 452);
            this.lbltel1.Name = "lbltel1";
            this.lbltel1.Size = new System.Drawing.Size(45, 17);
            this.lbltel1.TabIndex = 23;
            this.lbltel1.Text = "*Tel 1";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblciudad.Location = new System.Drawing.Point(268, 507);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(57, 17);
            this.lblciudad.TabIndex = 22;
            this.lblciudad.Text = "*Ciudad";
            // 
            // lblnombre1_clientes
            // 
            this.lblnombre1_clientes.AutoSize = true;
            this.lblnombre1_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnombre1_clientes.Location = new System.Drawing.Point(192, 401);
            this.lblnombre1_clientes.Name = "lblnombre1_clientes";
            this.lblnombre1_clientes.Size = new System.Drawing.Size(75, 17);
            this.lblnombre1_clientes.TabIndex = 21;
            this.lblnombre1_clientes.Text = "*Nombre 1";
            // 
            // lblDni_clientes
            // 
            this.lblDni_clientes.AutoSize = true;
            this.lblDni_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDni_clientes.Location = new System.Drawing.Point(48, 401);
            this.lblDni_clientes.Name = "lblDni_clientes";
            this.lblDni_clientes.Size = new System.Drawing.Size(38, 17);
            this.lblDni_clientes.TabIndex = 20;
            this.lblDni_clientes.Text = " *Dni";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(653, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1183, 735);
            this.dgvClientes.TabIndex = 19;
            this.dgvClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvClientes_KeyUp);
            // 
            // btn_cargardatos
            // 
            this.btn_cargardatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cargardatos.BackgroundImage")));
            this.btn_cargardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cargardatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cargardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargardatos.ForeColor = System.Drawing.Color.Black;
            this.btn_cargardatos.Location = new System.Drawing.Point(456, 133);
            this.btn_cargardatos.Name = "btn_cargardatos";
            this.btn_cargardatos.Size = new System.Drawing.Size(100, 92);
            this.btn_cargardatos.TabIndex = 39;
            this.btn_cargardatos.UseVisualStyleBackColor = true;
            this.btn_cargardatos.Click += new System.EventHandler(this.btn_cargardatos_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(335, 133);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 92);
            this.btn_eliminar.TabIndex = 38;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.BackgroundImage")));
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Location = new System.Drawing.Point(213, 133);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(100, 92);
            this.btn_Actualizar.TabIndex = 37;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MostrarDatos.BackgroundImage")));
            this.btn_MostrarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MostrarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(93, 133);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(100, 92);
            this.btn_MostrarDatos.TabIndex = 36;
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(163, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 44);
            this.label6.TabIndex = 40;
            this.label6.Text = "Sección Clientes";
            // 
            // textBarrio
            // 
            this.textBarrio.Location = new System.Drawing.Point(443, 527);
            this.textBarrio.Name = "textBarrio";
            this.textBarrio.Size = new System.Drawing.Size(162, 22);
            this.textBarrio.TabIndex = 50;
            this.textBarrio.TextChanged += new System.EventHandler(this.textBarrio_TextChanged);
            // 
            // txttel2
            // 
            this.txttel2.Location = new System.Drawing.Point(193, 472);
            this.txttel2.Name = "txttel2";
            this.txttel2.Size = new System.Drawing.Size(124, 22);
            this.txttel2.TabIndex = 49;
            this.txttel2.TextChanged += new System.EventHandler(this.txttel2_TextChanged);
            this.txttel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel2_KeyPress);
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(51, 527);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(197, 22);
            this.txtprovincia.TabIndex = 48;
            this.txtprovincia.TextChanged += new System.EventHandler(this.txtprovincia_TextChanged);
            // 
            // txtapellido1
            // 
            this.txtapellido1.Location = new System.Drawing.Point(337, 421);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(124, 22);
            this.txtapellido1.TabIndex = 47;
            this.txtapellido1.TextChanged += new System.EventHandler(this.txtapellido1_TextChanged);
            this.txtapellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido1_KeyPress);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarrio.Location = new System.Drawing.Point(447, 507);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(51, 17);
            this.lblBarrio.TabIndex = 45;
            this.lblBarrio.Text = "*Barrio";
            // 
            // lbltel2
            // 
            this.lbltel2.AutoSize = true;
            this.lbltel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltel2.Location = new System.Drawing.Point(199, 452);
            this.lbltel2.Name = "lbltel2";
            this.lbltel2.Size = new System.Drawing.Size(40, 17);
            this.lbltel2.TabIndex = 44;
            this.lbltel2.Text = "Tel 2";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProvincia.Location = new System.Drawing.Point(51, 507);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(71, 17);
            this.lblProvincia.TabIndex = 43;
            this.lblProvincia.Text = "*Provincia";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(334, 401);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 17);
            this.lblApellido.TabIndex = 42;
            this.lblApellido.Text = "*Apellido 1";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(481, 421);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(124, 22);
            this.txt_apellido2.TabIndex = 54;
            this.txt_apellido2.TextChanged += new System.EventHandler(this.txt_apellido2_TextChanged);
            this.txt_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido2_KeyPress);
            // 
            // lblapellido2
            // 
            this.lblapellido2.AutoSize = true;
            this.lblapellido2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblapellido2.Location = new System.Drawing.Point(478, 401);
            this.lblapellido2.Name = "lblapellido2";
            this.lblapellido2.Size = new System.Drawing.Size(70, 17);
            this.lblapellido2.TabIndex = 53;
            this.lblapellido2.Text = "Apellido 2";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(337, 472);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 22);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelemail.Location = new System.Drawing.Point(334, 452);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(52, 17);
            this.labelemail.TabIndex = 55;
            this.labelemail.Text = "*E-mail";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(170, 585);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(54, 22);
            this.txtnumero.TabIndex = 58;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumero.Location = new System.Drawing.Point(167, 564);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(63, 17);
            this.lblNumero.TabIndex = 57;
            this.lblNumero.Text = "*Numero";
            // 
            // txtdto
            // 
            this.txtdto.Location = new System.Drawing.Point(246, 585);
            this.txtdto.Name = "txtdto";
            this.txtdto.Size = new System.Drawing.Size(54, 22);
            this.txtdto.TabIndex = 60;
            this.txtdto.TextChanged += new System.EventHandler(this.txtdto_TextChanged);
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDpto.Location = new System.Drawing.Point(248, 564);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(30, 17);
            this.lblDpto.TabIndex = 59;
            this.lblDpto.Text = "Dto";
            // 
            // textmza
            // 
            this.textmza.Location = new System.Drawing.Point(320, 585);
            this.textmza.Name = "textmza";
            this.textmza.Size = new System.Drawing.Size(54, 22);
            this.textmza.TabIndex = 62;
            this.textmza.TextChanged += new System.EventHandler(this.textmza_TextChanged);
            // 
            // lblmza
            // 
            this.lblmza.AutoSize = true;
            this.lblmza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmza.Location = new System.Drawing.Point(321, 566);
            this.lblmza.Name = "lblmza";
            this.lblmza.Size = new System.Drawing.Size(34, 17);
            this.lblmza.TabIndex = 61;
            this.lblmza.Text = "Mza";
            // 
            // txt_lote
            // 
            this.txt_lote.Location = new System.Drawing.Point(394, 585);
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.Size = new System.Drawing.Size(54, 22);
            this.txt_lote.TabIndex = 64;
            this.txt_lote.TextChanged += new System.EventHandler(this.txt_lote_TextChanged);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLote.Location = new System.Drawing.Point(394, 567);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(36, 17);
            this.lblLote.TabIndex = 63;
            this.lblLote.Text = "Lote";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(463, 585);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(54, 22);
            this.txt_cp.TabIndex = 66;
            this.txt_cp.TextChanged += new System.EventHandler(this.txt_cp_TextChanged);
            this.txt_cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cp_KeyPress_1);
            // 
            // lblCodigoPostal_cliente
            // 
            this.lblCodigoPostal_cliente.AutoSize = true;
            this.lblCodigoPostal_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoPostal_cliente.Location = new System.Drawing.Point(464, 564);
            this.lblCodigoPostal_cliente.Name = "lblCodigoPostal_cliente";
            this.lblCodigoPostal_cliente.Size = new System.Drawing.Size(25, 17);
            this.lblCodigoPostal_cliente.TabIndex = 65;
            this.lblCodigoPostal_cliente.Text = "Cp";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(293, 332);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(223, 25);
            this.textBuscar.TabIndex = 67;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(145, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Buscar por Apellido1:";
            // 
            // txtrellenar
            // 
            this.txtrellenar.Location = new System.Drawing.Point(292, 280);
            this.txtrellenar.Multiline = true;
            this.txtrellenar.Name = "txtrellenar";
            this.txtrellenar.Size = new System.Drawing.Size(223, 25);
            this.txtrellenar.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.txtrellenar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBuscar);
            this.groupBox1.Controls.Add(this.txt_cp);
            this.groupBox1.Controls.Add(this.lblCodigoPostal_cliente);
            this.groupBox1.Controls.Add(this.txt_lote);
            this.groupBox1.Controls.Add(this.lblLote);
            this.groupBox1.Controls.Add(this.textmza);
            this.groupBox1.Controls.Add(this.lblmza);
            this.groupBox1.Controls.Add(this.txtdto);
            this.groupBox1.Controls.Add(this.lblDpto);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.labelemail);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.lblapellido2);
            this.groupBox1.Controls.Add(this.textBarrio);
            this.groupBox1.Controls.Add(this.txttel2);
            this.groupBox1.Controls.Add(this.txtprovincia);
            this.groupBox1.Controls.Add(this.txtapellido1);
            this.groupBox1.Controls.Add(this.lblBarrio);
            this.groupBox1.Controls.Add(this.lbltel2);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_cargardatos);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_Actualizar);
            this.groupBox1.Controls.Add(this.btn_MostrarDatos);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtciudad);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Controls.Add(this.lbltel1);
            this.groupBox1.Controls.Add(this.lblciudad);
            this.groupBox1.Controls.Add(this.lblnombre1_clientes);
            this.groupBox1.Controls.Add(this.lblDni_clientes);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1867, 762);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(378, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 75;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Cargar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Actualizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Mostrar";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnLimpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Location = new System.Drawing.Point(157, 668);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(107, 47);
            this.BtnLimpiar.TabIndex = 70;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 809);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltel1;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lblnombre1_clientes;
        private System.Windows.Forms.Label lblDni_clientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btn_cargardatos;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBarrio;
        private System.Windows.Forms.TextBox txttel2;
        private System.Windows.Forms.TextBox txtprovincia;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lbltel2;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label lblapellido2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtdto;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.TextBox textmza;
        private System.Windows.Forms.Label lblmza;
        private System.Windows.Forms.TextBox txt_lote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lblCodigoPostal_cliente;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrellenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}