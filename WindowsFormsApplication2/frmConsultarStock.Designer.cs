namespace WindowsFormsApplication2
{
    partial class frmConsultarStock
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcionStock = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbTalleStcok = new System.Windows.Forms.ComboBox();
            this.cbCategoriaStock = new System.Windows.Forms.ComboBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(485, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Stock minimo alcanzado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(456, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 20);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(108, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "No hay producto en Stock.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(79, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 20);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(673, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(415, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Talle";
            // 
            // tbDescripcionStock
            // 
            this.tbDescripcionStock.Location = new System.Drawing.Point(629, 43);
            this.tbDescripcionStock.MaxLength = 20;
            this.tbDescripcionStock.Name = "tbDescripcionStock";
            this.tbDescripcionStock.Size = new System.Drawing.Size(180, 20);
            this.tbDescripcionStock.TabIndex = 28;
            this.tbDescripcionStock.TextChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Transparent;
            this.lbMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMarca.Location = new System.Drawing.Point(122, 17);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(89, 19);
            this.lbMarca.TabIndex = 27;
            this.lbMarca.Text = "Categoría";
            // 
            // cbTalleStcok
            // 
            this.cbTalleStcok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalleStcok.FormattingEnabled = true;
            this.cbTalleStcok.Items.AddRange(new object[] {
            "Todo"});
            this.cbTalleStcok.Location = new System.Drawing.Point(369, 42);
            this.cbTalleStcok.Name = "cbTalleStcok";
            this.cbTalleStcok.Size = new System.Drawing.Size(174, 21);
            this.cbTalleStcok.TabIndex = 26;
            this.cbTalleStcok.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // cbCategoriaStock
            // 
            this.cbCategoriaStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaStock.FormattingEnabled = true;
            this.cbCategoriaStock.Items.AddRange(new object[] {
            "Todo"});
            this.cbCategoriaStock.Location = new System.Drawing.Point(79, 43);
            this.cbCategoriaStock.Name = "cbCategoriaStock";
            this.cbCategoriaStock.Size = new System.Drawing.Size(174, 21);
            this.cbCategoriaStock.TabIndex = 25;
            this.cbCategoriaStock.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaStock_SelectedIndexChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(51, 109);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 5;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.RowTemplate.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(726, 433);
            this.dgvStock.TabIndex = 24;
            // 
            // frmConsultarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(860, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcionStock);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cbTalleStcok);
            this.Controls.Add(this.cbCategoriaStock);
            this.Controls.Add(this.dgvStock);
            this.Name = "frmConsultarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarStock";
            this.Load += new System.EventHandler(this.frmConsultarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcionStock;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbTalleStcok;
        private System.Windows.Forms.ComboBox cbCategoriaStock;
        private System.Windows.Forms.DataGridView dgvStock;

    }
}