
namespace PRJ05_XML
{
    partial class PDF_VIEWER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_VIEWER));
            this.pdf_ship = new AxAcroPDFLib.AxAcroPDF();
            this.lbl_ship_name = new System.Windows.Forms.Label();
            this.pnl_ship = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_ship)).BeginInit();
            this.pnl_ship.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdf_ship
            // 
            this.pdf_ship.Enabled = true;
            this.pdf_ship.Location = new System.Drawing.Point(13, 84);
            this.pdf_ship.Name = "pdf_ship";
            this.pdf_ship.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_ship.OcxState")));
            this.pdf_ship.Size = new System.Drawing.Size(487, 625);
            this.pdf_ship.TabIndex = 0;
            // 
            // lbl_ship_name
            // 
            this.lbl_ship_name.Font = new System.Drawing.Font("Yu Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ship_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_ship_name.Name = "lbl_ship_name";
            this.lbl_ship_name.Size = new System.Drawing.Size(365, 120);
            this.lbl_ship_name.TabIndex = 1;
            this.lbl_ship_name.Text = "-> Ship Name";
            this.lbl_ship_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_ship
            // 
            this.pnl_ship.Controls.Add(this.lbl_ship_name);
            this.pnl_ship.Location = new System.Drawing.Point(108, 12);
            this.pnl_ship.Name = "pnl_ship";
            this.pnl_ship.Size = new System.Drawing.Size(392, 120);
            this.pnl_ship.TabIndex = 2;
            // 
            // PDF_VIEWER
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(512, 720);
            this.Controls.Add(this.pnl_ship);
            this.Controls.Add(this.pdf_ship);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PDF_VIEWER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF_VIEWER";
            this.Load += new System.EventHandler(this.PDF_VIEWER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_ship)).EndInit();
            this.pnl_ship.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdf_ship;
        private System.Windows.Forms.Label lbl_ship_name;
        private System.Windows.Forms.Panel pnl_ship;
    }
}