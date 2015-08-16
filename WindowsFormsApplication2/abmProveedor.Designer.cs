namespace WindowsFormsApplication2
{
    partial class abmProveedor
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
            this.pnlEditaProducto = new System.Windows.Forms.Panel();
            this.ntbTelefono2 = new Controles.NumberTextBox();
            this.ntbTelefono = new Controles.NumberTextBox();
            this.tbTelefono2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBuscaProducto = new System.Windows.Forms.Panel();
            this.dgvClientesEdit = new System.Windows.Forms.DataGridView();
            this.ctrlABM1 = new Controles.ctrlABM();
            this.pnlEditaProducto.SuspendLayout();
            this.pnlBuscaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditaProducto
            // 
            this.pnlEditaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditaProducto.Controls.Add(this.ntbTelefono2);
            this.pnlEditaProducto.Controls.Add(this.ntbTelefono);
            this.pnlEditaProducto.Controls.Add(this.tbTelefono2);
            this.pnlEditaProducto.Controls.Add(this.label1);
            this.pnlEditaProducto.Controls.Add(this.tbTelefono);
            this.pnlEditaProducto.Controls.Add(this.tbCuit);
            this.pnlEditaProducto.Controls.Add(this.label6);
            this.pnlEditaProducto.Controls.Add(this.label7);
            this.pnlEditaProducto.Controls.Add(this.cbxEstado);
            this.pnlEditaProducto.Controls.Add(this.tbNombre);
            this.pnlEditaProducto.Controls.Add(this.label4);
            this.pnlEditaProducto.Enabled = false;
            this.pnlEditaProducto.Location = new System.Drawing.Point(12, 390);
            this.pnlEditaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEditaProducto.Name = "pnlEditaProducto";
            this.pnlEditaProducto.Size = new System.Drawing.Size(477, 274);
            this.pnlEditaProducto.TabIndex = 140;
            // 
            // ntbTelefono2
            // 
            this.ntbTelefono2.Location = new System.Drawing.Point(175, 227);
            this.ntbTelefono2.Name = "ntbTelefono2";
            this.ntbTelefono2.Size = new System.Drawing.Size(236, 22);
            this.ntbTelefono2.TabIndex = 140;
            // 
            // ntbTelefono
            // 
            this.ntbTelefono.Location = new System.Drawing.Point(175, 172);
            this.ntbTelefono.Name = "ntbTelefono";
            this.ntbTelefono.Size = new System.Drawing.Size(236, 22);
            this.ntbTelefono.TabIndex = 139;
            // 
            // tbTelefono2
            // 
            this.tbTelefono2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTelefono2.Location = new System.Drawing.Point(414, 233);
            this.tbTelefono2.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono2.MaxLength = 20;
            this.tbTelefono2.Name = "tbTelefono2";
            this.tbTelefono2.Size = new System.Drawing.Size(236, 22);
            this.tbTelefono2.TabIndex = 138;
            this.tbTelefono2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 137;
            this.label1.Text = "Telefono 2";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTelefono.Location = new System.Drawing.Point(414, 181);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.MaxLength = 20;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(236, 22);
            this.tbTelefono.TabIndex = 136;
            this.tbTelefono.Visible = false;
            // 
            // tbCuit
            // 
            this.tbCuit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCuit.Location = new System.Drawing.Point(175, 65);
            this.tbCuit.Margin = new System.Windows.Forms.Padding(4);
            this.tbCuit.MaxLength = 18;
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(236, 22);
            this.tbCuit.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 134;
            this.label6.Text = "Cuit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 26);
            this.label7.TabIndex = 135;
            this.label7.Text = "Telefono 1";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.cbxEstado.Location = new System.Drawing.Point(243, 112);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(101, 30);
            this.cbxEstado.TabIndex = 132;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNombre.Location = new System.Drawing.Point(175, 21);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.MaxLength = 18;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(236, 22);
            this.tbNombre.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "Nombre";
            // 
            // pnlBuscaProducto
            // 
            this.pnlBuscaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBuscaProducto.Controls.Add(this.dgvClientesEdit);
            this.pnlBuscaProducto.Enabled = false;
            this.pnlBuscaProducto.Location = new System.Drawing.Point(12, 62);
            this.pnlBuscaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBuscaProducto.Name = "pnlBuscaProducto";
            this.pnlBuscaProducto.Size = new System.Drawing.Size(477, 323);
            this.pnlBuscaProducto.TabIndex = 139;
            // 
            // dgvClientesEdit
            // 
            this.dgvClientesEdit.AllowUserToAddRows = false;
            this.dgvClientesEdit.AllowUserToDeleteRows = false;
            this.dgvClientesEdit.AllowUserToResizeColumns = false;
            this.dgvClientesEdit.AllowUserToResizeRows = false;
            this.dgvClientesEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesEdit.Location = new System.Drawing.Point(5, 4);
            this.dgvClientesEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientesEdit.MultiSelect = false;
            this.dgvClientesEdit.Name = "dgvClientesEdit";
            this.dgvClientesEdit.ReadOnly = true;
            this.dgvClientesEdit.RowHeadersWidth = 5;
            this.dgvClientesEdit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientesEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesEdit.Size = new System.Drawing.Size(463, 311);
            this.dgvClientesEdit.TabIndex = 93;
            this.dgvClientesEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosEdit_CellClick);
            // 
            // ctrlABM1
            // 
            this.ctrlABM1.Location = new System.Drawing.Point(43, 7);
            this.ctrlABM1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlABM1.Name = "ctrlABM1";
            this.ctrlABM1.Size = new System.Drawing.Size(417, 48);
            this.ctrlABM1.TabIndex = 138;
            this.ctrlABM1.Aceptar += new Controles.ctrlABM.uctrlABMEventHandler(this.ctrlABM1_Aceptar);
            this.ctrlABM1.Cancelar += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Cancelar);
            this.ctrlABM1.Alta += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Alta);
            this.ctrlABM1.Baja += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Baja);
            this.ctrlABM1.Modificacion += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Modificacion);
            // 
            // abmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 673);
            this.Controls.Add(this.pnlEditaProducto);
            this.Controls.Add(this.pnlBuscaProducto);
            this.Controls.Add(this.ctrlABM1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "abmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administra Proveedores";
            this.Load += new System.EventHandler(this.abmProveedor_Load);
            this.pnlEditaProducto.ResumeLayout(false);
            this.pnlEditaProducto.PerformLayout();
            this.pnlBuscaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditaProducto;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlBuscaProducto;
        private System.Windows.Forms.DataGridView dgvClientesEdit;
        private Controles.ctrlABM ctrlABM1;
        private System.Windows.Forms.TextBox tbTelefono2;
        private System.Windows.Forms.Label label1;
        private Controles.NumberTextBox ntbTelefono2;
        private Controles.NumberTextBox ntbTelefono;
    }
}