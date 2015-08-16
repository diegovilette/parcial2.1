namespace WindowsFormsApplication2
{
    partial class frmRegistrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFiltroTalle = new System.Windows.Forms.ComboBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.all = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lbliva = new System.Windows.Forms.Label();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.btnValidarCuit = new System.Windows.Forms.Button();
            this.btnCancelarCuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(208, 7);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(110, 33);
            this.tbTotal.TabIndex = 70;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(194, 83);
            this.tbDescripcion.MaxLength = 20;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(277, 26);
            this.tbDescripcion.TabIndex = 69;
            this.tbDescripcion.TextChanged += new System.EventHandler(this.cbFiltroTalle_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(78, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Descripción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(78, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Categoria";
            // 
            // cbFiltroCategoria
            // 
            this.cbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCategoria.FormattingEnabled = true;
            this.cbFiltroCategoria.Location = new System.Drawing.Point(194, 44);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(277, 21);
            this.cbFiltroCategoria.TabIndex = 65;
            this.cbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTalle_SelectedIndexChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(342, 455);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(86, 27);
            this.nudCantidad.TabIndex = 63;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(122, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 34);
            this.label6.TabIndex = 62;
            this.label6.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 61;
            this.label5.Text = "TOTAL $";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(31, 130);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 5;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(615, 303);
            this.dgvProductos.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1030, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 100;
            this.label4.Text = "Terminar\r\n  venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quita el producto \r\n     del carrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 40);
            this.label2.TabIndex = 56;
            this.label2.Text = "Añade el producto \r\n       al carrito";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Location = new System.Drawing.Point(1115, 578);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 112);
            this.panel3.TabIndex = 55;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Transparent;
            this.btnVender.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.baggage291;
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVender.Enabled = false;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Location = new System.Drawing.Point(3, 20);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(73, 68);
            this.btnVender.TabIndex = 4;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Location = new System.Drawing.Point(565, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 108);
            this.panel2.TabIndex = 54;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.help291;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(3, 17);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(73, 75);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnAgregarCarrito);
            this.panel1.Location = new System.Drawing.Point(293, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 108);
            this.panel1.TabIndex = 53;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCarrito.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.commerce5;
            this.btnAgregarCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCarrito.Enabled = false;
            this.btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(3, 8);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(73, 86);
            this.btnAgregarCarrito.TabIndex = 4;
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(78, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Talle";
            // 
            // cbFiltroTalle
            // 
            this.cbFiltroTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroTalle.FormattingEnabled = true;
            this.cbFiltroTalle.Location = new System.Drawing.Point(194, 12);
            this.cbFiltroTalle.Name = "cbFiltroTalle";
            this.cbFiltroTalle.Size = new System.Drawing.Size(277, 21);
            this.cbFiltroTalle.TabIndex = 71;
            this.cbFiltroTalle.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTalle_SelectedIndexChanged);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.ColumnHeadersHeight = 28;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cant,
            this.Precio,
            this.all});
            this.dgvVentas.Location = new System.Drawing.Point(747, 130);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 5;
            this.dgvVentas.Size = new System.Drawing.Size(578, 303);
            this.dgvVentas.TabIndex = 81;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle7;
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Cant
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cant.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cant.HeaderText = "Cant.";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 70;
            // 
            // Precio
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.DefaultCellStyle = dataGridViewCellStyle9;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // all
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.DefaultCellStyle = dataGridViewCellStyle10;
            this.all.HeaderText = "Total";
            this.all.Name = "all";
            this.all.ReadOnly = true;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.label5);
            this.pnlTotal.Controls.Add(this.tbTotal);
            this.pnlTotal.Location = new System.Drawing.Point(999, 433);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(331, 50);
            this.pnlTotal.TabIndex = 83;
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.BackColor = System.Drawing.Color.Transparent;
            this.lbliva.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(1151, 475);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(48, 26);
            this.lbliva.TabIndex = 20;
            this.lbliva.Text = "IVA";
            this.lbliva.Visible = false;
            // 
            // tbIva
            // 
            this.tbIva.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIva.Location = new System.Drawing.Point(1206, 472);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(110, 33);
            this.tbIva.TabIndex = 85;
            this.tbIva.Text = "21";
            this.tbIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIva.Visible = false;
            this.tbIva.TextChanged += new System.EventHandler(this.tbIva_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(840, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 40);
            this.label8.TabIndex = 87;
            this.label8.Text = "Anular \r\nVenta";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.btnAnularVenta);
            this.panel6.Location = new System.Drawing.Point(913, 578);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(82, 108);
            this.panel6.TabIndex = 86;
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAnularVenta.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.stats55;
            this.btnAnularVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnularVenta.Enabled = false;
            this.btnAnularVenta.FlatAppearance.BorderSize = 0;
            this.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularVenta.Location = new System.Drawing.Point(6, 11);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(73, 86);
            this.btnAnularVenta.TabIndex = 4;
            this.btnAnularVenta.UseVisualStyleBackColor = false;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(1074, 436);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(125, 26);
            this.lblsubtotal.TabIndex = 88;
            this.lblsubtotal.Text = "SubTotal $";
            this.lblsubtotal.Visible = false;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Enabled = false;
            this.tbSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(1207, 433);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(110, 33);
            this.tbSubTotal.TabIndex = 89;
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubTotal.Visible = false;
            this.tbSubTotal.TextChanged += new System.EventHandler(this.tbSubTotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(743, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 103;
            this.label7.Text = "CUIT";
            // 
            // tbCuit
            // 
            this.tbCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuit.Location = new System.Drawing.Point(798, 40);
            this.tbCuit.MaxLength = 20;
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(277, 26);
            this.tbCuit.TabIndex = 104;
            // 
            // btnValidarCuit
            // 
            this.btnValidarCuit.Location = new System.Drawing.Point(1103, 42);
            this.btnValidarCuit.Name = "btnValidarCuit";
            this.btnValidarCuit.Size = new System.Drawing.Size(75, 23);
            this.btnValidarCuit.TabIndex = 105;
            this.btnValidarCuit.Text = "Validar";
            this.btnValidarCuit.UseVisualStyleBackColor = true;
            this.btnValidarCuit.Click += new System.EventHandler(this.btnValidarCuit_Click);
            // 
            // btnCancelarCuit
            // 
            this.btnCancelarCuit.Enabled = false;
            this.btnCancelarCuit.Location = new System.Drawing.Point(1184, 42);
            this.btnCancelarCuit.Name = "btnCancelarCuit";
            this.btnCancelarCuit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCuit.TabIndex = 106;
            this.btnCancelarCuit.Text = "Cancelar";
            this.btnCancelarCuit.UseVisualStyleBackColor = true;
            this.btnCancelarCuit.Click += new System.EventHandler(this.btnCancelarCuit_Click);
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1336, 683);
            this.Controls.Add(this.btnCancelarCuit);
            this.Controls.Add(this.btnValidarCuit);
            this.Controls.Add(this.tbCuit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.tbIva);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFiltroTalle);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFiltroCategoria);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbFiltroCategoria;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFiltroTalle;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn all;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAnularVenta;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.Button btnValidarCuit;
        private System.Windows.Forms.Button btnCancelarCuit;

    }
}