namespace WindowsFormsApplication2
{
    partial class frmPedido
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescripcionStock = new System.Windows.Forms.TextBox();
            this.cbTalleStcok = new System.Windows.Forms.ComboBox();
            this.cbCategoriaStock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeroDato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalDato = new System.Windows.Forms.TextBox();
            this.btnPedir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(353, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(320, 37);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(157, 24);
            this.cbProveedor.TabIndex = 66;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(15, 361);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(968, 222);
            this.dgvPedido.TabIndex = 65;
            this.dgvPedido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedido_CellMouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(845, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Talle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Categoria";
            // 
            // tbDescripcionStock
            // 
            this.tbDescripcionStock.Location = new System.Drawing.Point(816, 39);
            this.tbDescripcionStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcionStock.MaxLength = 20;
            this.tbDescripcionStock.Name = "tbDescripcionStock";
            this.tbDescripcionStock.Size = new System.Drawing.Size(157, 22);
            this.tbDescripcionStock.TabIndex = 61;
            this.tbDescripcionStock.TextChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // cbTalleStcok
            // 
            this.cbTalleStcok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalleStcok.FormattingEnabled = true;
            this.cbTalleStcok.Items.AddRange(new object[] {
            "Todo"});
            this.cbTalleStcok.Location = new System.Drawing.Point(651, 37);
            this.cbTalleStcok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTalleStcok.Name = "cbTalleStcok";
            this.cbTalleStcok.Size = new System.Drawing.Size(157, 24);
            this.cbTalleStcok.TabIndex = 60;
            this.cbTalleStcok.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // cbCategoriaStock
            // 
            this.cbCategoriaStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaStock.FormattingEnabled = true;
            this.cbCategoriaStock.Items.AddRange(new object[] {
            "Todo"});
            this.cbCategoriaStock.Location = new System.Drawing.Point(485, 37);
            this.cbCategoriaStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoriaStock.Name = "cbCategoriaStock";
            this.cbCategoriaStock.Size = new System.Drawing.Size(157, 24);
            this.cbCategoriaStock.TabIndex = 59;
            this.cbCategoriaStock.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Productos";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(16, 69);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 5;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.RowTemplate.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(968, 222);
            this.dgvStock.TabIndex = 56;
            this.dgvStock.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 588);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 34);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cantidad de\r\nProductos";
            // 
            // tbNumeroDato
            // 
            this.tbNumeroDato.Enabled = false;
            this.tbNumeroDato.Location = new System.Drawing.Point(105, 592);
            this.tbNumeroDato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumeroDato.Name = "tbNumeroDato";
            this.tbNumeroDato.Size = new System.Drawing.Size(132, 22);
            this.tbNumeroDato.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "TOTAL";
            // 
            // tbTotalDato
            // 
            this.tbTotalDato.Enabled = false;
            this.tbTotalDato.Location = new System.Drawing.Point(357, 592);
            this.tbTotalDato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotalDato.Name = "tbTotalDato";
            this.tbTotalDato.Size = new System.Drawing.Size(132, 22);
            this.tbTotalDato.TabIndex = 52;
            // 
            // btnPedir
            // 
            this.btnPedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.Location = new System.Drawing.Point(857, 590);
            this.btnPedir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(125, 55);
            this.btnPedir.TabIndex = 51;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 592);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Haz doble click para quitar producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(912, 297);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(71, 28);
            this.nudCantidad.TabIndex = 49;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Haz doble click para pedir producto";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1031, 655);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescripcionStock);
            this.Controls.Add(this.cbTalleStcok);
            this.Controls.Add(this.cbCategoriaStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumeroDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalDato);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescripcionStock;
        private System.Windows.Forms.ComboBox cbTalleStcok;
        private System.Windows.Forms.ComboBox cbCategoriaStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumeroDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalDato;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label1;

    }
}