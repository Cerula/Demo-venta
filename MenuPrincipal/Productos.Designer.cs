namespace MenuPrincipal
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_cargardatos = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcodprovvedor = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtCodproveedor = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Lblcodproducto = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.TxtBuscProducto = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmenos10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmenos100 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMenos25 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTcODpRO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MostrarDatos.BackgroundImage")));
            this.btn_MostrarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MostrarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(107, 140);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(100, 92);
            this.btn_MostrarDatos.TabIndex = 0;
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.BackgroundImage")));
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Location = new System.Drawing.Point(227, 140);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(100, 92);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(349, 140);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 92);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Location = new System.Drawing.Point(448, 727);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(107, 47);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_cargardatos
            // 
            this.btn_cargardatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cargardatos.BackgroundImage")));
            this.btn_cargardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cargardatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cargardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargardatos.ForeColor = System.Drawing.Color.Black;
            this.btn_cargardatos.Location = new System.Drawing.Point(470, 140);
            this.btn_cargardatos.Name = "btn_cargardatos";
            this.btn_cargardatos.Size = new System.Drawing.Size(100, 92);
            this.btn_cargardatos.TabIndex = 4;
            this.btn_cargardatos.UseVisualStyleBackColor = true;
            this.btn_cargardatos.Click += new System.EventHandler(this.btn_cargardatos_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(87, 564);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(161, 22);
            this.txtproducto.TabIndex = 6;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            this.txtproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtproducto_KeyUp);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(432, 564);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(161, 22);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProducto.Location = new System.Drawing.Point(84, 544);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(77, 17);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "*Productos";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprecio.Location = new System.Drawing.Point(430, 543);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(53, 17);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "*Precio";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.Teal;
            this.dgvProductos.Location = new System.Drawing.Point(738, 21);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1090, 807);
            this.dgvProductos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, -185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sección Productos";
            // 
            // lblcodprovvedor
            // 
            this.lblcodprovvedor.AutoSize = true;
            this.lblcodprovvedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcodprovvedor.Location = new System.Drawing.Point(263, 602);
            this.lblcodprovvedor.Name = "lblcodprovvedor";
            this.lblcodprovvedor.Size = new System.Drawing.Size(104, 17);
            this.lblcodprovvedor.TabIndex = 12;
            this.lblcodprovvedor.Text = "*CodProveedor";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstock.Location = new System.Drawing.Point(84, 602);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(48, 17);
            this.lblstock.TabIndex = 13;
            this.lblstock.Text = "*Stock";
            // 
            // txtCodproveedor
            // 
            this.txtCodproveedor.Location = new System.Drawing.Point(260, 622);
            this.txtCodproveedor.Name = "txtCodproveedor";
            this.txtCodproveedor.Size = new System.Drawing.Size(161, 22);
            this.txtCodproveedor.TabIndex = 14;
            this.txtCodproveedor.TextChanged += new System.EventHandler(this.txtCodproveedor_TextChanged);
            this.txtCodproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodproveedor_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(87, 622);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(161, 22);
            this.txtstock.TabIndex = 15;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Buscar.Location = new System.Drawing.Point(128, 727);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 47);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Rellenar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Lblcodproducto
            // 
            this.Lblcodproducto.AutoSize = true;
            this.Lblcodproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblcodproducto.Location = new System.Drawing.Point(257, 541);
            this.Lblcodproducto.Name = "Lblcodproducto";
            this.Lblcodproducto.Size = new System.Drawing.Size(102, 17);
            this.Lblcodproducto.TabIndex = 18;
            this.Lblcodproducto.Text = "*CodProductos";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(260, 564);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(161, 22);
            this.txtcodproducto.TabIndex = 17;
            this.txtcodproducto.TextChanged += new System.EventHandler(this.txtcodproducto_TextChanged);
            this.txtcodproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodproducto_KeyPress);
            // 
            // TxtBuscProducto
            // 
            this.TxtBuscProducto.Location = new System.Drawing.Point(372, 308);
            this.TxtBuscProducto.Name = "TxtBuscProducto";
            this.TxtBuscProducto.Size = new System.Drawing.Size(199, 22);
            this.TxtBuscProducto.TabIndex = 19;
            this.TxtBuscProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscProducto_KeyUp);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(372, 342);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(199, 22);
            this.textCantidad.TabIndex = 20;
            this.textCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(99, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mostar Productos con cantidad menor a:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtmenos10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtmenos100);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMenos25);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXTcODpRO);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_MostrarDatos);
            this.groupBox1.Controls.Add(this.textCantidad);
            this.groupBox1.Controls.Add(this.btn_Actualizar);
            this.groupBox1.Controls.Add(this.TxtBuscProducto);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.Lblcodproducto);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.btn_cargardatos);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtCodproveedor);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.lblstock);
            this.groupBox1.Controls.Add(this.lblprecio);
            this.groupBox1.Controls.Add(this.lblcodprovvedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1900, 834);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(167, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 44);
            this.label12.TabIndex = 79;
            this.label12.Text = "Sección Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Cargar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Actualizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mostrar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(248, 727);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 47);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(115, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Menos de 10 unidades del proveedor:";
            // 
            // txtmenos10
            // 
            this.txtmenos10.Location = new System.Drawing.Point(372, 480);
            this.txtmenos10.Name = "txtmenos10";
            this.txtmenos10.Size = new System.Drawing.Size(199, 22);
            this.txtmenos10.TabIndex = 30;
            this.txtmenos10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmenos10_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(103, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Menos de  100 unidades del proveedor:";
            // 
            // txtmenos100
            // 
            this.txtmenos100.Location = new System.Drawing.Point(372, 411);
            this.txtmenos100.Name = "txtmenos100";
            this.txtmenos100.Size = new System.Drawing.Size(199, 22);
            this.txtmenos100.TabIndex = 28;
            this.txtmenos100.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmenos100_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(115, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Menos de 25 unidades del proveedor:";
            // 
            // txtMenos25
            // 
            this.txtMenos25.Location = new System.Drawing.Point(372, 445);
            this.txtMenos25.Name = "txtMenos25";
            this.txtMenos25.Size = new System.Drawing.Size(199, 22);
            this.txtMenos25.TabIndex = 26;
            this.txtMenos25.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(161, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mostrar productor por nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(144, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mostar Productos del proveedor :";
            // 
            // TXTcODpRO
            // 
            this.TXTcODpRO.Location = new System.Drawing.Point(372, 377);
            this.TXTcODpRO.Name = "TXTcODpRO";
            this.TXTcODpRO.Size = new System.Drawing.Size(199, 22);
            this.TXTcODpRO.TabIndex = 22;
            this.TXTcODpRO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtproveedorProduc_KeyUp);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 873);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Productos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_cargardatos;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcodprovvedor;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtCodproveedor;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txtEscribe;
        private System.Windows.Forms.TextBox txtfiltroescribe;
        private System.Windows.Forms.Label Lblcodproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.TextBox TxtBuscProducto;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTcODpRO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMenos25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmenos10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmenos100;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}