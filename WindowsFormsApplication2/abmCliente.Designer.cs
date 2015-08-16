namespace WindowsFormsApplication2
{
    partial class abmCliente
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
            this.dgvClientesEdit = new System.Windows.Forms.DataGridView();
            this.pnlEditaProducto = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.dtFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBuscaProducto = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlABM1 = new Controles.ctrlABM();
            this.ntbTelefono = new Controles.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEdit)).BeginInit();
            this.pnlEditaProducto.SuspendLayout();
            this.pnlBuscaProducto.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvClientesEdit.Size = new System.Drawing.Size(972, 311);
            this.dgvClientesEdit.TabIndex = 93;
            this.dgvClientesEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosEdit_CellClick);
            // 
            // pnlEditaProducto
            // 
            this.pnlEditaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditaProducto.Controls.Add(this.ntbTelefono);
            this.pnlEditaProducto.Controls.Add(this.label8);
            this.pnlEditaProducto.Controls.Add(this.cbTipo);
            this.pnlEditaProducto.Controls.Add(this.tbTelefono);
            this.pnlEditaProducto.Controls.Add(this.label7);
            this.pnlEditaProducto.Controls.Add(this.tbCuit);
            this.pnlEditaProducto.Controls.Add(this.label6);
            this.pnlEditaProducto.Controls.Add(this.cbxEstado);
            this.pnlEditaProducto.Controls.Add(this.dtFechaAlta);
            this.pnlEditaProducto.Controls.Add(this.tbNombre);
            this.pnlEditaProducto.Controls.Add(this.label4);
            this.pnlEditaProducto.Controls.Add(this.tbApellido);
            this.pnlEditaProducto.Controls.Add(this.label2);
            this.pnlEditaProducto.Controls.Add(this.label1);
            this.pnlEditaProducto.Controls.Add(this.tbEmail);
            this.pnlEditaProducto.Controls.Add(this.label3);
            this.pnlEditaProducto.Controls.Add(this.tbDomicilio);
            this.pnlEditaProducto.Controls.Add(this.label5);
            this.pnlEditaProducto.Enabled = false;
            this.pnlEditaProducto.Location = new System.Drawing.Point(5, 444);
            this.pnlEditaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEditaProducto.Name = "pnlEditaProducto";
            this.pnlEditaProducto.Size = new System.Drawing.Size(985, 225);
            this.pnlEditaProducto.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 139;
            this.label8.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Monotributista",
            "Responsable Inscripto"});
            this.cbTipo.Location = new System.Drawing.Point(684, 188);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(236, 24);
            this.cbTipo.TabIndex = 138;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTelefono.Location = new System.Drawing.Point(430, 158);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.MaxLength = 20;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(236, 22);
            this.tbTelefono.TabIndex = 136;
            this.tbTelefono.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 135;
            this.label7.Text = "Telefono";
            // 
            // tbCuit
            // 
            this.tbCuit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCuit.Location = new System.Drawing.Point(684, 71);
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
            this.label6.Location = new System.Drawing.Point(563, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 134;
            this.label6.Text = "Cuit";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.cbxEstado.Location = new System.Drawing.Point(438, 91);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(101, 30);
            this.cbxEstado.TabIndex = 132;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // dtFechaAlta
            // 
            this.dtFechaAlta.Location = new System.Drawing.Point(161, 126);
            this.dtFechaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaAlta.Name = "dtFechaAlta";
            this.dtFechaAlta.Size = new System.Drawing.Size(236, 22);
            this.dtFechaAlta.TabIndex = 105;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNombre.Location = new System.Drawing.Point(161, 10);
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
            this.label4.Location = new System.Drawing.Point(25, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "Nombre";
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbApellido.Location = new System.Drawing.Point(161, 71);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.MaxLength = 20;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(236, 22);
            this.tbApellido.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 103;
            this.label2.Text = "Fecha Alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "Apellido";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEmail.Location = new System.Drawing.Point(684, 10);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.MaxLength = 18;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(236, 22);
            this.tbEmail.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 98;
            this.label3.Text = "Email";
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDomicilio.Location = new System.Drawing.Point(684, 128);
            this.tbDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.tbDomicilio.MaxLength = 20;
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(236, 22);
            this.tbDomicilio.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 96;
            this.label5.Text = "Domicilio";
            // 
            // pnlBuscaProducto
            // 
            this.pnlBuscaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBuscaProducto.Controls.Add(this.label9);
            this.pnlBuscaProducto.Controls.Add(this.panel2);
            this.pnlBuscaProducto.Controls.Add(this.label10);
            this.pnlBuscaProducto.Controls.Add(this.panel1);
            this.pnlBuscaProducto.Controls.Add(this.dgvClientesEdit);
            this.pnlBuscaProducto.Enabled = false;
            this.pnlBuscaProducto.Location = new System.Drawing.Point(5, 66);
            this.pnlBuscaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBuscaProducto.Name = "pnlBuscaProducto";
            this.pnlBuscaProducto.Size = new System.Drawing.Size(985, 374);
            this.pnlBuscaProducto.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(674, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 18);
            this.label9.TabIndex = 122;
            this.label9.Text = "Responsable Inscripto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(635, 329);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 25);
            this.panel2.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(171, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 120;
            this.label10.Text = "Monotrisbutista";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(131, 329);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 25);
            this.panel1.TabIndex = 119;
            // 
            // ctrlABM1
            // 
            this.ctrlABM1.Location = new System.Drawing.Point(289, 12);
            this.ctrlABM1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlABM1.Name = "ctrlABM1";
            this.ctrlABM1.Size = new System.Drawing.Size(417, 48);
            this.ctrlABM1.TabIndex = 94;
            this.ctrlABM1.Aceptar += new Controles.ctrlABM.uctrlABMEventHandler(this.ctrlABM1_Aceptar);
            this.ctrlABM1.Cancelar += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Cancelar);
            this.ctrlABM1.Alta += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Alta);
            this.ctrlABM1.Baja += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Baja);
            this.ctrlABM1.Modificacion += new Controles.ctrlABM.uctrlABMEventHandler2(this.ctrlABM1_Modificacion);
            this.ctrlABM1.Load += new System.EventHandler(this.ctrlABM1_Load);
            // 
            // ntbTelefono
            // 
            this.ntbTelefono.Location = new System.Drawing.Point(161, 187);
            this.ntbTelefono.Name = "ntbTelefono";
            this.ntbTelefono.Size = new System.Drawing.Size(236, 22);
            this.ntbTelefono.TabIndex = 140;
            // 
            // abmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 674);
            this.Controls.Add(this.pnlEditaProducto);
            this.Controls.Add(this.pnlBuscaProducto);
            this.Controls.Add(this.ctrlABM1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "abmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.abmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEdit)).EndInit();
            this.pnlEditaProducto.ResumeLayout(false);
            this.pnlEditaProducto.PerformLayout();
            this.pnlBuscaProducto.ResumeLayout(false);
            this.pnlBuscaProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesEdit;
        private Controles.ctrlABM ctrlABM1;
        private System.Windows.Forms.Panel pnlEditaProducto;
        private System.Windows.Forms.Panel pnlBuscaProducto;
        private System.Windows.Forms.DateTimePicker dtFechaAlta;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private Controles.NumberTextBox ntbTelefono;
    }
}