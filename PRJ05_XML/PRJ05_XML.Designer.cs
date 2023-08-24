
namespace PRJ05_XML
{
    partial class PRJ05_XML
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRJ05_XML));
            this.pic_small_one = new System.Windows.Forms.PictureBox();
            this.pic_small_two = new System.Windows.Forms.PictureBox();
            this.pic_small_three = new System.Windows.Forms.PictureBox();
            this.pic_small_four = new System.Windows.Forms.PictureBox();
            this.pic_small_five = new System.Windows.Forms.PictureBox();
            this.lv_ships = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.vid_ship = new AxWMPLib.AxWindowsMediaPlayer();
            this.dtg_stats = new System.Windows.Forms.DataGridView();
            this.Column_stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_five)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_small_one
            // 
            this.pic_small_one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_small_one.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_small_one.Location = new System.Drawing.Point(12, 563);
            this.pic_small_one.Name = "pic_small_one";
            this.pic_small_one.Size = new System.Drawing.Size(165, 145);
            this.pic_small_one.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small_one.TabIndex = 4;
            this.pic_small_one.TabStop = false;
            this.pic_small_one.Click += new System.EventHandler(this.clickImagen);
            // 
            // pic_small_two
            // 
            this.pic_small_two.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_small_two.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_small_two.Location = new System.Drawing.Point(183, 563);
            this.pic_small_two.Name = "pic_small_two";
            this.pic_small_two.Size = new System.Drawing.Size(165, 145);
            this.pic_small_two.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small_two.TabIndex = 5;
            this.pic_small_two.TabStop = false;
            this.pic_small_two.Click += new System.EventHandler(this.clickImagen);
            // 
            // pic_small_three
            // 
            this.pic_small_three.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_small_three.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_small_three.Location = new System.Drawing.Point(354, 563);
            this.pic_small_three.Name = "pic_small_three";
            this.pic_small_three.Size = new System.Drawing.Size(165, 145);
            this.pic_small_three.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small_three.TabIndex = 6;
            this.pic_small_three.TabStop = false;
            this.pic_small_three.Click += new System.EventHandler(this.clickImagen);
            // 
            // pic_small_four
            // 
            this.pic_small_four.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_small_four.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_small_four.Location = new System.Drawing.Point(525, 563);
            this.pic_small_four.Name = "pic_small_four";
            this.pic_small_four.Size = new System.Drawing.Size(165, 145);
            this.pic_small_four.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small_four.TabIndex = 7;
            this.pic_small_four.TabStop = false;
            this.pic_small_four.Click += new System.EventHandler(this.clickImagen);
            // 
            // pic_small_five
            // 
            this.pic_small_five.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_small_five.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_small_five.Location = new System.Drawing.Point(696, 563);
            this.pic_small_five.Name = "pic_small_five";
            this.pic_small_five.Size = new System.Drawing.Size(165, 145);
            this.pic_small_five.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small_five.TabIndex = 8;
            this.pic_small_five.TabStop = false;
            this.pic_small_five.Click += new System.EventHandler(this.clickVideo);
            // 
            // lv_ships
            // 
            this.lv_ships.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ships.HideSelection = false;
            this.lv_ships.Location = new System.Drawing.Point(883, 12);
            this.lv_ships.Name = "lv_ships";
            this.lv_ships.Size = new System.Drawing.Size(605, 165);
            this.lv_ships.TabIndex = 10;
            this.lv_ships.UseCompatibleStateImageBehavior = false;
            this.lv_ships.View = System.Windows.Forms.View.List;
            this.lv_ships.SelectedIndexChanged += new System.EventHandler(this.lv_ships_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_class);
            this.panel1.Location = new System.Drawing.Point(883, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 65);
            this.panel1.TabIndex = 11;
            // 
            // lbl_class
            // 
            this.lbl_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_class.Font = new System.Drawing.Font("Yu Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(3, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(600, 65);
            this.lbl_class.TabIndex = 2;
            this.lbl_class.Text = "Description";
            this.lbl_class.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(883, 255);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(603, 165);
            this.lbl_description.TabIndex = 12;
            this.lbl_description.Text = "texto";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_big
            // 
            this.pic_big.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_big.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_big.Location = new System.Drawing.Point(12, 12);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(849, 530);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_big.TabIndex = 15;
            this.pic_big.TabStop = false;
            // 
            // vid_ship
            // 
            this.vid_ship.Enabled = true;
            this.vid_ship.Location = new System.Drawing.Point(12, 12);
            this.vid_ship.Name = "vid_ship";
            this.vid_ship.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vid_ship.OcxState")));
            this.vid_ship.Size = new System.Drawing.Size(849, 530);
            this.vid_ship.TabIndex = 16;
            // 
            // dtg_stats
            // 
            this.dtg_stats.AllowUserToAddRows = false;
            this.dtg_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_stats,
            this.Column_description});
            this.dtg_stats.Location = new System.Drawing.Point(883, 494);
            this.dtg_stats.Name = "dtg_stats";
            this.dtg_stats.ReadOnly = true;
            this.dtg_stats.RowHeadersWidth = 50;
            this.dtg_stats.RowTemplate.Height = 24;
            this.dtg_stats.Size = new System.Drawing.Size(605, 214);
            this.dtg_stats.TabIndex = 17;
            // 
            // Column_stats
            // 
            this.Column_stats.HeaderText = "Stats";
            this.Column_stats.MinimumWidth = 6;
            this.Column_stats.Name = "Column_stats";
            this.Column_stats.ReadOnly = true;
            this.Column_stats.Width = 180;
            // 
            // Column_description
            // 
            this.Column_description.HeaderText = "Information";
            this.Column_description.MinimumWidth = 6;
            this.Column_description.Name = "Column_description";
            this.Column_description.ReadOnly = true;
            this.Column_description.Width = 373;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Yu Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.Black;
            this.btn_pdf.Location = new System.Drawing.Point(883, 423);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(605, 65);
            this.btn_pdf.TabIndex = 18;
            this.btn_pdf.Text = "PDF Viewer";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // PRJ05_XML
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1500, 720);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.dtg_stats);
            this.Controls.Add(this.vid_ship);
            this.Controls.Add(this.pic_big);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_ships);
            this.Controls.Add(this.pic_small_five);
            this.Controls.Add(this.pic_small_four);
            this.Controls.Add(this.pic_small_three);
            this.Controls.Add(this.pic_small_two);
            this.Controls.Add(this.pic_small_one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PRJ05_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRJ05_XML";
            this.Load += new System.EventHandler(this.PRJ05_XML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small_five)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_small_one;
        private System.Windows.Forms.PictureBox pic_small_two;
        private System.Windows.Forms.PictureBox pic_small_three;
        private System.Windows.Forms.PictureBox pic_small_four;
        private System.Windows.Forms.PictureBox pic_small_five;
        private System.Windows.Forms.ListView lv_ships;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.PictureBox pic_big;
        private AxWMPLib.AxWindowsMediaPlayer vid_ship;
        private System.Windows.Forms.DataGridView dtg_stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_description;
        private System.Windows.Forms.Button btn_pdf;
    }
}

