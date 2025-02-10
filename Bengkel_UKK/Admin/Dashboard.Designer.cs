namespace Bengkel_UKK.Admin
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            logout_button = new Button();
            label1 = new Label();
            Hamburger_button = new PictureBox();
            SideBar_Layout = new FlowLayoutPanel();
            Dashboard_button = new Button();
            karyawan_button = new Button();
            pelanggan_button = new Button();
            kendaraan_button = new Button();
            booking_button = new Button();
            riwayat_button = new Button();
            invoice_button = new Button();
            laporan_button = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelmdi = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hamburger_button).BeginInit();
            SideBar_Layout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Hamburger_button);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 55);
            panel1.TabIndex = 0;
            // 
            // logout_button
            // 
            logout_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout_button.BackColor = SystemColors.ButtonHighlight;
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button.ForeColor = SystemColors.ActiveCaptionText;
            logout_button.Image = (Image)resources.GetObject("logout_button.Image");
            logout_button.ImageAlign = ContentAlignment.MiddleLeft;
            logout_button.Location = new Point(1146, 2);
            logout_button.Name = "logout_button";
            logout_button.Padding = new Padding(15, 0, 0, 0);
            logout_button.Size = new Size(146, 51);
            logout_button.TabIndex = 0;
            logout_button.Text = "           LOGOUT";
            logout_button.TextAlign = ContentAlignment.MiddleLeft;
            logout_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 1;
            label1.Text = "BENGKEL TECNO DB";
            // 
            // Hamburger_button
            // 
            Hamburger_button.Image = (Image)resources.GetObject("Hamburger_button.Image");
            Hamburger_button.Location = new Point(3, 2);
            Hamburger_button.Name = "Hamburger_button";
            Hamburger_button.Size = new Size(63, 53);
            Hamburger_button.SizeMode = PictureBoxSizeMode.CenterImage;
            Hamburger_button.TabIndex = 0;
            Hamburger_button.TabStop = false;
            // 
            // SideBar_Layout
            // 
            SideBar_Layout.BackColor = Color.White;
            SideBar_Layout.Controls.Add(Dashboard_button);
            SideBar_Layout.Controls.Add(karyawan_button);
            SideBar_Layout.Controls.Add(pelanggan_button);
            SideBar_Layout.Controls.Add(kendaraan_button);
            SideBar_Layout.Controls.Add(booking_button);
            SideBar_Layout.Controls.Add(riwayat_button);
            SideBar_Layout.Controls.Add(invoice_button);
            SideBar_Layout.Controls.Add(laporan_button);
            SideBar_Layout.Dock = DockStyle.Left;
            SideBar_Layout.Location = new Point(0, 55);
            SideBar_Layout.Margin = new Padding(0);
            SideBar_Layout.Name = "SideBar_Layout";
            SideBar_Layout.Size = new Size(234, 496);
            SideBar_Layout.TabIndex = 1;
            // 
            // Dashboard_button
            // 
            Dashboard_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Dashboard_button.BackColor = Color.White;
            Dashboard_button.FlatAppearance.BorderSize = 0;
            Dashboard_button.FlatStyle = FlatStyle.Flat;
            Dashboard_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboard_button.ForeColor = SystemColors.ActiveCaptionText;
            Dashboard_button.Image = (Image)resources.GetObject("Dashboard_button.Image");
            Dashboard_button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_button.Location = new Point(3, 3);
            Dashboard_button.Name = "Dashboard_button";
            Dashboard_button.Padding = new Padding(15, 0, 0, 0);
            Dashboard_button.Size = new Size(231, 51);
            Dashboard_button.TabIndex = 0;
            Dashboard_button.Text = "            DASHBOARD";
            Dashboard_button.TextAlign = ContentAlignment.MiddleLeft;
            Dashboard_button.UseVisualStyleBackColor = false;
            // 
            // karyawan_button
            // 
            karyawan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            karyawan_button.BackColor = Color.Transparent;
            karyawan_button.FlatAppearance.BorderSize = 0;
            karyawan_button.FlatStyle = FlatStyle.Flat;
            karyawan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            karyawan_button.ForeColor = SystemColors.ActiveCaptionText;
            karyawan_button.Image = (Image)resources.GetObject("karyawan_button.Image");
            karyawan_button.ImageAlign = ContentAlignment.MiddleLeft;
            karyawan_button.Location = new Point(3, 60);
            karyawan_button.Name = "karyawan_button";
            karyawan_button.Padding = new Padding(15, 0, 0, 0);
            karyawan_button.Size = new Size(231, 51);
            karyawan_button.TabIndex = 0;
            karyawan_button.Text = "            Karyawan";
            karyawan_button.TextAlign = ContentAlignment.MiddleLeft;
            karyawan_button.UseVisualStyleBackColor = false;
            // 
            // pelanggan_button
            // 
            pelanggan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pelanggan_button.BackColor = Color.Transparent;
            pelanggan_button.FlatAppearance.BorderSize = 0;
            pelanggan_button.FlatStyle = FlatStyle.Flat;
            pelanggan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pelanggan_button.ForeColor = SystemColors.ActiveCaptionText;
            pelanggan_button.Image = (Image)resources.GetObject("pelanggan_button.Image");
            pelanggan_button.ImageAlign = ContentAlignment.MiddleLeft;
            pelanggan_button.Location = new Point(3, 117);
            pelanggan_button.Name = "pelanggan_button";
            pelanggan_button.Padding = new Padding(15, 0, 0, 0);
            pelanggan_button.Size = new Size(231, 51);
            pelanggan_button.TabIndex = 0;
            pelanggan_button.Text = "            Pelanggan";
            pelanggan_button.TextAlign = ContentAlignment.MiddleLeft;
            pelanggan_button.UseVisualStyleBackColor = false;
            // 
            // kendaraan_button
            // 
            kendaraan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kendaraan_button.BackColor = Color.Transparent;
            kendaraan_button.FlatAppearance.BorderSize = 0;
            kendaraan_button.FlatStyle = FlatStyle.Flat;
            kendaraan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kendaraan_button.ForeColor = SystemColors.ActiveCaptionText;
            kendaraan_button.Image = (Image)resources.GetObject("kendaraan_button.Image");
            kendaraan_button.ImageAlign = ContentAlignment.MiddleLeft;
            kendaraan_button.Location = new Point(3, 174);
            kendaraan_button.Name = "kendaraan_button";
            kendaraan_button.Padding = new Padding(15, 0, 0, 0);
            kendaraan_button.Size = new Size(228, 51);
            kendaraan_button.TabIndex = 0;
            kendaraan_button.Text = "            Kendaraan";
            kendaraan_button.TextAlign = ContentAlignment.MiddleLeft;
            kendaraan_button.UseVisualStyleBackColor = false;
            // 
            // booking_button
            // 
            booking_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            booking_button.BackColor = Color.White;
            booking_button.FlatAppearance.BorderSize = 0;
            booking_button.FlatStyle = FlatStyle.Flat;
            booking_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            booking_button.ForeColor = SystemColors.ActiveCaptionText;
            booking_button.Image = (Image)resources.GetObject("booking_button.Image");
            booking_button.ImageAlign = ContentAlignment.MiddleLeft;
            booking_button.Location = new Point(3, 231);
            booking_button.Name = "booking_button";
            booking_button.Padding = new Padding(15, 0, 0, 0);
            booking_button.Size = new Size(231, 51);
            booking_button.TabIndex = 1;
            booking_button.Text = "            BOOKING";
            booking_button.TextAlign = ContentAlignment.MiddleLeft;
            booking_button.UseVisualStyleBackColor = false;
            // 
            // riwayat_button
            // 
            riwayat_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            riwayat_button.BackColor = Color.White;
            riwayat_button.FlatAppearance.BorderSize = 0;
            riwayat_button.FlatStyle = FlatStyle.Flat;
            riwayat_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            riwayat_button.ForeColor = SystemColors.ActiveCaptionText;
            riwayat_button.Image = (Image)resources.GetObject("riwayat_button.Image");
            riwayat_button.ImageAlign = ContentAlignment.MiddleLeft;
            riwayat_button.Location = new Point(0, 285);
            riwayat_button.Margin = new Padding(0);
            riwayat_button.Name = "riwayat_button";
            riwayat_button.Padding = new Padding(15, 0, 0, 0);
            riwayat_button.Size = new Size(231, 51);
            riwayat_button.TabIndex = 0;
            riwayat_button.Text = "            RIWAYAT";
            riwayat_button.TextAlign = ContentAlignment.MiddleLeft;
            riwayat_button.UseVisualStyleBackColor = false;
            // 
            // invoice_button
            // 
            invoice_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            invoice_button.BackColor = Color.White;
            invoice_button.FlatAppearance.BorderSize = 0;
            invoice_button.FlatStyle = FlatStyle.Flat;
            invoice_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            invoice_button.ForeColor = SystemColors.ActiveCaptionText;
            invoice_button.Image = (Image)resources.GetObject("invoice_button.Image");
            invoice_button.ImageAlign = ContentAlignment.MiddleLeft;
            invoice_button.Location = new Point(3, 339);
            invoice_button.Name = "invoice_button";
            invoice_button.Padding = new Padding(15, 0, 0, 0);
            invoice_button.Size = new Size(231, 51);
            invoice_button.TabIndex = 0;
            invoice_button.Text = "            INVOICE";
            invoice_button.TextAlign = ContentAlignment.MiddleLeft;
            invoice_button.UseVisualStyleBackColor = false;
            // 
            // laporan_button
            // 
            laporan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            laporan_button.BackColor = Color.White;
            laporan_button.FlatAppearance.BorderSize = 0;
            laporan_button.FlatStyle = FlatStyle.Flat;
            laporan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laporan_button.ForeColor = SystemColors.ActiveCaptionText;
            laporan_button.Image = (Image)resources.GetObject("laporan_button.Image");
            laporan_button.ImageAlign = ContentAlignment.MiddleLeft;
            laporan_button.Location = new Point(3, 396);
            laporan_button.Name = "laporan_button";
            laporan_button.Padding = new Padding(15, 0, 0, 0);
            laporan_button.Size = new Size(231, 51);
            laporan_button.TabIndex = 0;
            laporan_button.Text = "            LAPORAN ";
            laporan_button.TextAlign = ContentAlignment.MiddleLeft;
            laporan_button.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            // 
            // panelmdi
            // 
            panelmdi.BackColor = SystemColors.Control;
            panelmdi.Dock = DockStyle.Fill;
            panelmdi.Location = new Point(234, 55);
            panelmdi.Name = "panelmdi";
            panelmdi.Size = new Size(1058, 496);
            panelmdi.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 551);
            Controls.Add(panelmdi);
            Controls.Add(SideBar_Layout);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Hamburger_button).EndInit();
            SideBar_Layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox Hamburger_button;
        private FlowLayoutPanel SideBar_Layout;
        private Button Dashboard_button;
        private Button kendaraan_button;
        private Button riwayat_button;
        private Button pelanggan_button;
        private Button karyawan_button;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panelmdi;
        private Button laporan_button;
        private Button invoice_button;
        private Button logout_button;
        private Button booking_button;
    }
}