using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Dashboard
{
    partial class Dashboard_User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_User));
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnBooking = new DhafaButton();
            btnProduk = new DhafaButton();
            btnRiwayat = new DhafaButton();
            btnService = new DhafaButton();
            btn_kendaraan = new DhafaButton();
            btnProfile = new DhafaButton();
            panelLeft = new Panel();
            panelLogOut = new Panel();
            btnLogout = new DhafaButton();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            rjCircularPictureBox1 = new RJCircularPictureBox();
            panelMain = new Panel();
            panelTop = new Panel();
            lblDisplay = new Label();
            flowLayoutPanel2.SuspendLayout();
            panelLeft.SuspendLayout();
            panelLogOut.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(170, 0, 0);
            flowLayoutPanel2.Controls.Add(btnBooking);
            flowLayoutPanel2.Controls.Add(btnProduk);
            flowLayoutPanel2.Controls.Add(btnRiwayat);
            flowLayoutPanel2.Controls.Add(btnService);
            flowLayoutPanel2.Controls.Add(btn_kendaraan);
            flowLayoutPanel2.Controls.Add(btnProfile);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.ForeColor = SystemColors.ControlText;
            flowLayoutPanel2.Location = new Point(0, 139);
            flowLayoutPanel2.MaximumSize = new Size(290, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(15, 0, 10, 0);
            flowLayoutPanel2.Size = new Size(290, 535);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.FromArgb(170, 0, 0);
            btnBooking.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnBooking.BorderColor = Color.PaleVioletRed;
            btnBooking.BorderRadius = 7;
            btnBooking.BorderSize = 0;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooking.ForeColor = Color.White;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(18, 3);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(20, 0, 0, 0);
            btnBooking.Size = new Size(255, 60);
            btnBooking.TabIndex = 15;
            btnBooking.Text = "    Booking";
            btnBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking.TextColor = Color.White;
            btnBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnProduk
            // 
            btnProduk.BackColor = Color.FromArgb(170, 0, 0);
            btnProduk.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnProduk.BorderColor = Color.PaleVioletRed;
            btnProduk.BorderRadius = 7;
            btnProduk.BorderSize = 0;
            btnProduk.FlatAppearance.BorderSize = 0;
            btnProduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduk.ForeColor = Color.White;
            btnProduk.Image = (Image)resources.GetObject("btnProduk.Image");
            btnProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduk.Location = new Point(18, 69);
            btnProduk.Name = "btnProduk";
            btnProduk.Padding = new Padding(20, 0, 0, 0);
            btnProduk.Size = new Size(255, 60);
            btnProduk.TabIndex = 16;
            btnProduk.Text = "    Sparepart";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.TextColor = Color.White;
            btnProduk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduk.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(170, 0, 0);
            btnRiwayat.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnRiwayat.BorderColor = Color.PaleVioletRed;
            btnRiwayat.BorderRadius = 7;
            btnRiwayat.BorderSize = 0;
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Image = (Image)resources.GetObject("btnRiwayat.Image");
            btnRiwayat.ImageAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.Location = new Point(18, 135);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Padding = new Padding(20, 0, 0, 0);
            btnRiwayat.Size = new Size(255, 60);
            btnRiwayat.TabIndex = 17;
            btnRiwayat.Text = "    Riwayat";
            btnRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.TextColor = Color.White;
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnService
            // 
            btnService.BackColor = Color.FromArgb(170, 0, 0);
            btnService.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnService.BorderColor = Color.PaleVioletRed;
            btnService.BorderRadius = 7;
            btnService.BorderSize = 0;
            btnService.FlatAppearance.BorderSize = 0;
            btnService.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnService.FlatStyle = FlatStyle.Flat;
            btnService.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnService.ForeColor = Color.White;
            btnService.Image = (Image)resources.GetObject("btnService.Image");
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(18, 201);
            btnService.Name = "btnService";
            btnService.Padding = new Padding(20, 0, 0, 0);
            btnService.Size = new Size(255, 60);
            btnService.TabIndex = 18;
            btnService.Text = "    Jasa Servis";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.TextColor = Color.White;
            btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnService.UseVisualStyleBackColor = false;
            // 
            // btn_kendaraan
            // 
            btn_kendaraan.BackColor = Color.FromArgb(170, 0, 0);
            btn_kendaraan.BackgroundColor = Color.FromArgb(170, 0, 0);
            btn_kendaraan.BorderColor = Color.PaleVioletRed;
            btn_kendaraan.BorderRadius = 7;
            btn_kendaraan.BorderSize = 0;
            btn_kendaraan.FlatAppearance.BorderSize = 0;
            btn_kendaraan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_kendaraan.FlatStyle = FlatStyle.Flat;
            btn_kendaraan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kendaraan.ForeColor = Color.White;
            btn_kendaraan.Image = (Image)resources.GetObject("btn_kendaraan.Image");
            btn_kendaraan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_kendaraan.Location = new Point(18, 267);
            btn_kendaraan.Name = "btn_kendaraan";
            btn_kendaraan.Padding = new Padding(20, 0, 0, 0);
            btn_kendaraan.Size = new Size(255, 62);
            btn_kendaraan.TabIndex = 21;
            btn_kendaraan.Text = "   Kendaraan";
            btn_kendaraan.TextAlign = ContentAlignment.MiddleLeft;
            btn_kendaraan.TextColor = Color.White;
            btn_kendaraan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_kendaraan.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(170, 0, 0);
            btnProfile.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnProfile.BorderColor = Color.PaleVioletRed;
            btnProfile.BorderRadius = 7;
            btnProfile.BorderSize = 0;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 150, 50);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(18, 335);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(20, 0, 0, 0);
            btnProfile.Size = new Size(255, 60);
            btnProfile.TabIndex = 14;
            btnProfile.Text = "    Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextColor = Color.White;
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(flowLayoutPanel2);
            panelLeft.Controls.Add(panelLogOut);
            panelLeft.Controls.Add(panel2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(290, 756);
            panelLeft.TabIndex = 7;
            // 
            // panelLogOut
            // 
            panelLogOut.BackColor = Color.FromArgb(170, 0, 0);
            panelLogOut.Controls.Add(btnLogout);
            panelLogOut.Dock = DockStyle.Bottom;
            panelLogOut.Location = new Point(0, 674);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Padding = new Padding(15, 0, 10, 0);
            panelLogOut.Size = new Size(290, 82);
            panelLogOut.TabIndex = 13;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(170, 0, 0);
            btnLogout.BackgroundColor = Color.FromArgb(170, 0, 0);
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 7;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(18, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(255, 60);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "    Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextColor = Color.White;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(170, 0, 0);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rjCircularPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 139);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(97, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Pelanggan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 47);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 1;
            label1.Text = "Dhafa Bintang Ramadhan";
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = Color.White;
            rjCircularPictureBox1.BorderColor2 = Color.White;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 2;
            rjCircularPictureBox1.GradientAngle = 50F;
            rjCircularPictureBox1.Location = new Point(18, 30);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(70, 70);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 0;
            rjCircularPictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Gainsboro;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(290, 67);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(913, 689);
            panelMain.TabIndex = 6;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblDisplay);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(290, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(913, 67);
            panelTop.TabIndex = 9;
            // 
            // lblDisplay
            // 
            lblDisplay.Anchor = AnchorStyles.Top;
            lblDisplay.BackColor = Color.Transparent;
            lblDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplay.ForeColor = Color.FromArgb(44, 62, 80);
            lblDisplay.Location = new Point(297, 18);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(318, 32);
            lblDisplay.TabIndex = 19;
            lblDisplay.Text = "BOOKING";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 0, 0);
            ClientSize = new Size(1203, 756);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            ForeColor = Color.White;
            Name = "Dashboard_User";
            Padding = new Padding(0);
            Style.BackColor = Color.FromArgb(160, 0, 0);
            Style.ForeColor = Color.White;
            Style.InactiveShadowOpacity = 0;
            Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
            Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            Text = "Application Management";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel2.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private DhafaButton btnBooking;
        private DhafaButton btnProduk;
        private DhafaButton btnService;
        private Panel panelLeft;
        private Panel panelLogOut;
        private DhafaButton btnLogout;
        private Panel panelMain;
        private Panel panelTop;
        private Panel panel2;
        private Label label1;
        private RJCircularPictureBox rjCircularPictureBox1;
        private Label label2;
        private Label lblDisplay;
        private DhafaButton btn_kendaraan;
        private DhafaButton btnRiwayat;
        private DhafaButton btnProfile;
    }
}