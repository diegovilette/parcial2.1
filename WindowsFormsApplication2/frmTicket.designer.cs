namespace WindowsFormsApplication2
{
    partial class frmTicket
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
            this.crFacturaA = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crFacturaA
            // 
            this.crFacturaA.ActiveViewIndex = -1;
            this.crFacturaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crFacturaA.Cursor = System.Windows.Forms.Cursors.Default;
            this.crFacturaA.DisplayStatusBar = false;
            this.crFacturaA.DisplayToolbar = false;
            this.crFacturaA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crFacturaA.Location = new System.Drawing.Point(0, 0);
            this.crFacturaA.Name = "crFacturaA";
            this.crFacturaA.Size = new System.Drawing.Size(698, 506);
            this.crFacturaA.TabIndex = 0;
            this.crFacturaA.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmTicket
            // 
            this.ClientSize = new System.Drawing.Size(698, 506);
            this.Controls.Add(this.crFacturaA);
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmTicket_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crFactuA;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crFacturaA;
    }
}