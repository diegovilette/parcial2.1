namespace WindowsFormsApplication2
{
    partial class frmDetallesVenta
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
            this.dgvFecha = new System.Windows.Forms.DataGridView();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFecha
            // 
            this.dgvFecha.AllowUserToAddRows = false;
            this.dgvFecha.AllowUserToDeleteRows = false;
            this.dgvFecha.AllowUserToResizeRows = false;
            this.dgvFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFecha.Location = new System.Drawing.Point(37, 121);
            this.dgvFecha.Name = "dgvFecha";
            this.dgvFecha.ReadOnly = true;
            this.dgvFecha.RowHeadersWidth = 5;
            this.dgvFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFecha.Size = new System.Drawing.Size(126, 253);
            this.dgvFecha.TabIndex = 2;
            this.dgvFecha.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFecha_CellDoubleClick);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(206, 120);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 5;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(388, 253);
            this.dgvVentas.TabIndex = 3;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(36, 428);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 5;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(558, 196);
            this.dgvDetalleVenta.TabIndex = 4;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(112, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(233, 21);
            this.dtpDesde.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(112, 55);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(233, 21);
            this.dtpHasta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(396, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 27);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Busqueda";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Detalles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Presiona doble click en la fila para obtener más información.";
            // 
            // frmDetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(622, 636);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvFecha);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDetallesVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmDetallesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFecha;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}