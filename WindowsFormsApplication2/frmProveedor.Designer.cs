namespace WindowsFormsApplication2
{
    partial class frmProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.tbNombreMarcaNuevo = new System.Windows.Forms.TextBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.dgvTelefonoProveedor = new System.Windows.Forms.DataGridView();
            this.btnCargaTelefono = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminaTel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(458, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Elimina Proveedor \r\n  Seleccionado";
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(408, 12);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(33, 27);
            this.btnEliminarProveedor.TabIndex = 25;
            this.btnEliminarProveedor.Text = "-";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearProveedor.FlatAppearance.BorderSize = 0;
            this.btnCrearProveedor.Location = new System.Drawing.Point(183, 320);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new System.Drawing.Size(33, 28);
            this.btnCrearProveedor.TabIndex = 24;
            this.btnCrearProveedor.Text = "+";
            this.btnCrearProveedor.UseVisualStyleBackColor = false;
            this.btnCrearProveedor.Click += new System.EventHandler(this.btnCrearProveedor_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Transparent;
            this.lbMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMarca.Location = new System.Drawing.Point(12, 306);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(93, 19);
            this.lbMarca.TabIndex = 22;
            this.lbMarca.Text = "Proveedor";
            // 
            // tbNombreMarcaNuevo
            // 
            this.tbNombreMarcaNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNombreMarcaNuevo.Location = new System.Drawing.Point(16, 328);
            this.tbNombreMarcaNuevo.MaxLength = 15;
            this.tbNombreMarcaNuevo.Name = "tbNombreMarcaNuevo";
            this.tbNombreMarcaNuevo.Size = new System.Drawing.Size(161, 20);
            this.tbNombreMarcaNuevo.TabIndex = 21;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(12, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(229, 273);
            this.dgvProveedor.TabIndex = 28;
            this.dgvProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellClick);
            // 
            // dgvTelefonoProveedor
            // 
            this.dgvTelefonoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonoProveedor.Location = new System.Drawing.Point(259, 12);
            this.dgvTelefonoProveedor.Name = "dgvTelefonoProveedor";
            this.dgvTelefonoProveedor.Size = new System.Drawing.Size(143, 273);
            this.dgvTelefonoProveedor.TabIndex = 29;
            // 
            // btnCargaTelefono
            // 
            this.btnCargaTelefono.BackColor = System.Drawing.Color.Transparent;
            this.btnCargaTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargaTelefono.FlatAppearance.BorderSize = 0;
            this.btnCargaTelefono.Location = new System.Drawing.Point(432, 320);
            this.btnCargaTelefono.Name = "btnCargaTelefono";
            this.btnCargaTelefono.Size = new System.Drawing.Size(33, 28);
            this.btnCargaTelefono.TabIndex = 32;
            this.btnCargaTelefono.Text = "+";
            this.btnCargaTelefono.UseVisualStyleBackColor = false;
            this.btnCargaTelefono.Click += new System.EventHandler(this.btnCargaTelefono_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(255, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Teléfono";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTelefono.Location = new System.Drawing.Point(259, 328);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(161, 20);
            this.tbTelefono.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(458, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Elimina Telefono \r\n  Seleccionado";
            // 
            // btnEliminaTel
            // 
            this.btnEliminaTel.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminaTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminaTel.FlatAppearance.BorderSize = 0;
            this.btnEliminaTel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminaTel.Location = new System.Drawing.Point(408, 60);
            this.btnEliminaTel.Name = "btnEliminaTel";
            this.btnEliminaTel.Size = new System.Drawing.Size(33, 27);
            this.btnEliminaTel.TabIndex = 33;
            this.btnEliminaTel.Text = "-";
            this.btnEliminaTel.UseVisualStyleBackColor = false;
            this.btnEliminaTel.Click += new System.EventHandler(this.btnEliminaTel_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(565, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminaTel);
            this.Controls.Add(this.btnCargaTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.dgvTelefonoProveedor);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnCrearProveedor);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.tbNombreMarcaNuevo);
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel De Proveedores";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonoProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox tbNombreMarcaNuevo;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.DataGridView dgvTelefonoProveedor;
        private System.Windows.Forms.Button btnCargaTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminaTel;
    }
}