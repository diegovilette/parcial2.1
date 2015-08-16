namespace WindowsFormsApplication2
{
    partial class abmProducto
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
            this.ctrlABM1 = new Controles.ctrlABM();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTalle = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGanancia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.tbPrecioCosto = new System.Windows.Forms.TextBox();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripModificP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCatModifProd = new System.Windows.Forms.ComboBox();
            this.cbTalleModificPr = new System.Windows.Forms.ComboBox();
            this.dgvProductosEdit = new System.Windows.Forms.DataGridView();
            this.pnlBuscaProducto = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEditaProducto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEdit)).BeginInit();
            this.pnlBuscaProducto.SuspendLayout();
            this.pnlEditaProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlABM1
            // 
            this.ctrlABM1.Location = new System.Drawing.Point(203, 4);
            this.ctrlABM1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlABM1.Name = "ctrlABM1";
            this.ctrlABM1.Size = new System.Drawing.Size(313, 39);
            this.ctrlABM1.TabIndex = 0;
            this.ctrlABM1.Aceptar += new Controles.ctrlABM.uctrlABMEventHandler(this.ctrlABM1_Aceptar);
            this.ctrlABM1.Cancelar += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Cancelar);
            this.ctrlABM1.Alta += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Alta);
            this.ctrlABM1.Baja += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Baja);
            this.ctrlABM1.Modificacion += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Modificacion);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(511, 164);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(187, 28);
            this.cbProveedor.TabIndex = 133;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(373, 170);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(90, 20);
            this.lblProveedor.TabIndex = 132;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.cbxEstado.Location = new System.Drawing.Point(142, 140);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(84, 24);
            this.cbxEstado.TabIndex = 131;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockMinimo.Location = new System.Drawing.Point(510, 122);
            this.nudStockMinimo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudStockMinimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(188, 26);
            this.nudStockMinimo.TabIndex = 128;
            this.nudStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStockMinimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Stock Mínimo";
            // 
            // cbTalle
            // 
            this.cbTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTalle.FormattingEnabled = true;
            this.cbTalle.Location = new System.Drawing.Point(511, 77);
            this.cbTalle.Name = "cbTalle";
            this.cbTalle.Size = new System.Drawing.Size(187, 28);
            this.cbTalle.TabIndex = 126;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(511, 31);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(187, 28);
            this.cbCategoria.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 127;
            this.label6.Text = "Talle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Categoría";
            // 
            // nudGanancia
            // 
            this.nudGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGanancia.Location = new System.Drawing.Point(142, 101);
            this.nudGanancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGanancia.Name = "nudGanancia";
            this.nudGanancia.Size = new System.Drawing.Size(188, 26);
            this.nudGanancia.TabIndex = 121;
            this.nudGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGanancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGanancia.ValueChanged += new System.EventHandler(this.nudGanancia_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 123;
            this.label9.Text = "Ganancia  %";
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPrecioVenta.Enabled = false;
            this.tbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVenta.Location = new System.Drawing.Point(142, 184);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(191, 26);
            this.tbPrecioVenta.TabIndex = 122;
            // 
            // tbPrecioCosto
            // 
            this.tbPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioCosto.Location = new System.Drawing.Point(142, 54);
            this.tbPrecioCosto.MaxLength = 5;
            this.tbPrecioCosto.Name = "tbPrecioCosto";
            this.tbPrecioCosto.Size = new System.Drawing.Size(187, 26);
            this.tbPrecioCosto.TabIndex = 119;
            this.tbPrecioCosto.TextChanged += new System.EventHandler(this.tbPrecioCosto_TextChanged);
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreProducto.Location = new System.Drawing.Point(142, 7);
            this.tbNombreProducto.MaxLength = 20;
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(187, 26);
            this.tbNombreProducto.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "Precio Venta  $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Precio Costo  $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Descripción";
            // 
            // tbDescripModificP
            // 
            this.tbDescripModificP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripModificP.Location = new System.Drawing.Point(572, 3);
            this.tbDescripModificP.MaxLength = 20;
            this.tbDescripModificP.Name = "tbDescripModificP";
            this.tbDescripModificP.Size = new System.Drawing.Size(135, 26);
            this.tbDescripModificP.TabIndex = 114;
            this.tbDescripModificP.TextChanged += new System.EventHandler(this.cbTalleModificPr_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(464, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 113;
            this.label12.Text = "Descripción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 112;
            this.label11.Text = "Categoría";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 111;
            this.label10.Text = "Talle";
            // 
            // cbCatModifProd
            // 
            this.cbCatModifProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatModifProd.FormattingEnabled = true;
            this.cbCatModifProd.Location = new System.Drawing.Point(314, 6);
            this.cbCatModifProd.Name = "cbCatModifProd";
            this.cbCatModifProd.Size = new System.Drawing.Size(113, 21);
            this.cbCatModifProd.TabIndex = 110;
            this.cbCatModifProd.SelectedIndexChanged += new System.EventHandler(this.cbTalleModificPr_SelectedIndexChanged);
            // 
            // cbTalleModificPr
            // 
            this.cbTalleModificPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalleModificPr.FormattingEnabled = true;
            this.cbTalleModificPr.Location = new System.Drawing.Point(84, 5);
            this.cbTalleModificPr.Name = "cbTalleModificPr";
            this.cbTalleModificPr.Size = new System.Drawing.Size(78, 21);
            this.cbTalleModificPr.TabIndex = 109;
            this.cbTalleModificPr.SelectedIndexChanged += new System.EventHandler(this.cbTalleModificPr_SelectedIndexChanged);
            // 
            // dgvProductosEdit
            // 
            this.dgvProductosEdit.AllowUserToAddRows = false;
            this.dgvProductosEdit.AllowUserToDeleteRows = false;
            this.dgvProductosEdit.AllowUserToResizeColumns = false;
            this.dgvProductosEdit.AllowUserToResizeRows = false;
            this.dgvProductosEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEdit.Location = new System.Drawing.Point(3, 33);
            this.dgvProductosEdit.MultiSelect = false;
            this.dgvProductosEdit.Name = "dgvProductosEdit";
            this.dgvProductosEdit.ReadOnly = true;
            this.dgvProductosEdit.RowHeadersWidth = 5;
            this.dgvProductosEdit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductosEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosEdit.Size = new System.Drawing.Size(710, 213);
            this.dgvProductosEdit.TabIndex = 108;
            this.dgvProductosEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosEdit_CellClick);
            // 
            // pnlBuscaProducto
            // 
            this.pnlBuscaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBuscaProducto.Controls.Add(this.label7);
            this.pnlBuscaProducto.Controls.Add(this.panel2);
            this.pnlBuscaProducto.Controls.Add(this.label8);
            this.pnlBuscaProducto.Controls.Add(this.panel1);
            this.pnlBuscaProducto.Controls.Add(this.label10);
            this.pnlBuscaProducto.Controls.Add(this.dgvProductosEdit);
            this.pnlBuscaProducto.Controls.Add(this.cbTalleModificPr);
            this.pnlBuscaProducto.Controls.Add(this.cbCatModifProd);
            this.pnlBuscaProducto.Controls.Add(this.label11);
            this.pnlBuscaProducto.Controls.Add(this.label12);
            this.pnlBuscaProducto.Controls.Add(this.tbDescripModificP);
            this.pnlBuscaProducto.Enabled = false;
            this.pnlBuscaProducto.Location = new System.Drawing.Point(3, 46);
            this.pnlBuscaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBuscaProducto.Name = "pnlBuscaProducto";
            this.pnlBuscaProducto.Size = new System.Drawing.Size(720, 279);
            this.pnlBuscaProducto.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(489, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 118;
            this.label7.Text = "Stock minimo alcanzado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(460, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 20);
            this.panel2.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(112, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 15);
            this.label8.TabIndex = 116;
            this.label8.Text = "No hay producto en Stock.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(82, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 20);
            this.panel1.TabIndex = 115;
            // 
            // pnlEditaProducto
            // 
            this.pnlEditaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditaProducto.Controls.Add(this.label1);
            this.pnlEditaProducto.Controls.Add(this.label2);
            this.pnlEditaProducto.Controls.Add(this.cbProveedor);
            this.pnlEditaProducto.Controls.Add(this.label3);
            this.pnlEditaProducto.Controls.Add(this.lblProveedor);
            this.pnlEditaProducto.Controls.Add(this.tbNombreProducto);
            this.pnlEditaProducto.Controls.Add(this.cbxEstado);
            this.pnlEditaProducto.Controls.Add(this.tbPrecioCosto);
            this.pnlEditaProducto.Controls.Add(this.tbPrecioVenta);
            this.pnlEditaProducto.Controls.Add(this.nudStockMinimo);
            this.pnlEditaProducto.Controls.Add(this.label9);
            this.pnlEditaProducto.Controls.Add(this.label5);
            this.pnlEditaProducto.Controls.Add(this.nudGanancia);
            this.pnlEditaProducto.Controls.Add(this.cbTalle);
            this.pnlEditaProducto.Controls.Add(this.label4);
            this.pnlEditaProducto.Controls.Add(this.cbCategoria);
            this.pnlEditaProducto.Controls.Add(this.label6);
            this.pnlEditaProducto.Enabled = false;
            this.pnlEditaProducto.Location = new System.Drawing.Point(3, 327);
            this.pnlEditaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEditaProducto.Name = "pnlEditaProducto";
            this.pnlEditaProducto.Size = new System.Drawing.Size(720, 223);
            this.pnlEditaProducto.TabIndex = 135;
            // 
            // abmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 554);
            this.Controls.Add(this.pnlEditaProducto);
            this.Controls.Add(this.pnlBuscaProducto);
            this.Controls.Add(this.ctrlABM1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "abmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Productos";
            this.Load += new System.EventHandler(this.abmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEdit)).EndInit();
            this.pnlBuscaProducto.ResumeLayout(false);
            this.pnlBuscaProducto.PerformLayout();
            this.pnlEditaProducto.ResumeLayout(false);
            this.pnlEditaProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctrlABM ctrlABM1;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTalle;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGanancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioCosto;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripModificP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCatModifProd;
        private System.Windows.Forms.ComboBox cbTalleModificPr;
        private System.Windows.Forms.DataGridView dgvProductosEdit;
        private System.Windows.Forms.Panel pnlBuscaProducto;
        private System.Windows.Forms.Panel pnlEditaProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}