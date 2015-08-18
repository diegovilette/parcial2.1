namespace WindowsFormsApplication2
{
    partial class frmCategoria
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
            this.btnEliminaCategoria = new System.Windows.Forms.Button();
            this.btnCreaCategoria = new System.Windows.Forms.Button();
            this.Cat = new System.Windows.Forms.Label();
            this.tbNuevaCategoria = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(371, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "Elimina Categoria\r\nSeleccionado";
            // 
            // btnEliminaCategoria
            // 
            this.btnEliminaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminaCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminaCategoria.Location = new System.Drawing.Point(496, 367);
            this.btnEliminaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminaCategoria.Name = "btnEliminaCategoria";
            this.btnEliminaCategoria.Size = new System.Drawing.Size(37, 32);
            this.btnEliminaCategoria.TabIndex = 32;
            this.btnEliminaCategoria.Text = "-";
            this.btnEliminaCategoria.UseVisualStyleBackColor = false;
            this.btnEliminaCategoria.Click += new System.EventHandler(this.btnEliminaCategoria_Click);
            // 
            // btnCreaCategoria
            // 
            this.btnCreaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCreaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreaCategoria.FlatAppearance.BorderSize = 0;
            this.btnCreaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaCategoria.Location = new System.Drawing.Point(279, 367);
            this.btnCreaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreaCategoria.Name = "btnCreaCategoria";
            this.btnCreaCategoria.Size = new System.Drawing.Size(55, 48);
            this.btnCreaCategoria.TabIndex = 31;
            this.btnCreaCategoria.Text = "+";
            this.btnCreaCategoria.UseVisualStyleBackColor = false;
            this.btnCreaCategoria.Click += new System.EventHandler(this.btnCreaCategoria_Click);
            // 
            // Cat
            // 
            this.Cat.AutoSize = true;
            this.Cat.BackColor = System.Drawing.Color.Transparent;
            this.Cat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cat.Location = new System.Drawing.Point(11, 363);
            this.Cat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(107, 24);
            this.Cat.TabIndex = 29;
            this.Cat.Text = "Categoria";
            // 
            // tbNuevaCategoria
            // 
            this.tbNuevaCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNuevaCategoria.Location = new System.Drawing.Point(16, 390);
            this.tbNuevaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevaCategoria.MaxLength = 15;
            this.tbNuevaCategoria.Name = "tbNuevaCategoria";
            this.tbNuevaCategoria.Size = new System.Drawing.Size(239, 22);
            this.tbNuevaCategoria.TabIndex = 28;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(16, 17);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(535, 331);
            this.dgvCategoria.TabIndex = 35;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(569, 447);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminaCategoria);
            this.Controls.Add(this.btnCreaCategoria);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.tbNuevaCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel De Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminaCategoria;
        private System.Windows.Forms.Button btnCreaCategoria;
        private System.Windows.Forms.Label Cat;
        private System.Windows.Forms.TextBox tbNuevaCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}