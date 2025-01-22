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
            laporan_button = new Button();
            Data_flowLayOut = new FlowLayoutPanel();
            Data_panel = new Panel();
            data_button = new Button();
            sub1_panel = new Panel();
            karyawan_button = new Button();
            sub2_panel = new Panel();
            pelanggan_button = new Button();
            sub3_panel = new Panel();
            kendaraan_button = new Button();
            riwayat_button = new Button();
            invoice_button = new Button();
            Dashboard_button = new Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelmdi = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hamburger_button).BeginInit();
            SideBar_Layout.SuspendLayout();
            Data_flowLayOut.SuspendLayout();
            Data_panel.SuspendLayout();
            sub1_panel.SuspendLayout();
            sub2_panel.SuspendLayout();
            sub3_panel.SuspendLayout();
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
            panel1.Size = new Size(897, 55);
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
            logout_button.Location = new Point(751, 2);
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
            SideBar_Layout.AutoScroll = true;
            SideBar_Layout.BackColor = Color.White;
            SideBar_Layout.Controls.Add(Dashboard_button);
            SideBar_Layout.Controls.Add(Data_flowLayOut);
            SideBar_Layout.Controls.Add(riwayat_button);
            SideBar_Layout.Controls.Add(invoice_button);
            SideBar_Layout.Controls.Add(laporan_button);
            SideBar_Layout.Dock = DockStyle.Left;
            SideBar_Layout.Location = new Point(0, 55);
            SideBar_Layout.Margin = new Padding(0);
            SideBar_Layout.Name = "SideBar_Layout";
            SideBar_Layout.Size = new Size(234, 530);
            SideBar_Layout.TabIndex = 1;
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
            laporan_button.Location = new Point(3, 225);
            laporan_button.Name = "laporan_button";
            laporan_button.Padding = new Padding(15, 0, 0, 0);
            laporan_button.Size = new Size(231, 51);
            laporan_button.TabIndex = 0;
            laporan_button.Text = "            LAPORAN ";
            laporan_button.TextAlign = ContentAlignment.MiddleLeft;
            laporan_button.UseVisualStyleBackColor = false;
            // 
            // Data_flowLayOut
            // 
            Data_flowLayOut.Controls.Add(Data_panel);
            Data_flowLayOut.Controls.Add(sub1_panel);
            Data_flowLayOut.Controls.Add(sub2_panel);
            Data_flowLayOut.Controls.Add(sub3_panel);
            Data_flowLayOut.Location = new Point(3, 60);
            Data_flowLayOut.Name = "Data_flowLayOut";
            Data_flowLayOut.Size = new Size(231, 51);
            Data_flowLayOut.TabIndex = 6;
            // 
            // Data_panel
            // 
            Data_panel.BackColor = Color.Black;
            Data_panel.BackgroundImageLayout = ImageLayout.None;
            Data_panel.Controls.Add(data_button);
            Data_panel.ForeColor = Color.Red;
            Data_panel.Location = new Point(0, 0);
            Data_panel.Margin = new Padding(0);
            Data_panel.Name = "Data_panel";
            Data_panel.Size = new Size(234, 51);
            Data_panel.TabIndex = 8;
            // 
            // data_button
            // 
            data_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            data_button.BackColor = Color.White;
            data_button.FlatAppearance.BorderSize = 0;
            data_button.FlatStyle = FlatStyle.Flat;
            data_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            data_button.ForeColor = SystemColors.ActiveCaptionText;
            data_button.Image = (Image)resources.GetObject("data_button.Image");
            data_button.ImageAlign = ContentAlignment.MiddleLeft;
            data_button.Location = new Point(0, 0);
            data_button.Margin = new Padding(0);
            data_button.Name = "data_button";
            data_button.Padding = new Padding(15, 0, 0, 0);
            data_button.Size = new Size(234, 51);
            data_button.TabIndex = 0;
            data_button.Text = "            Data";
            data_button.TextAlign = ContentAlignment.MiddleLeft;
            data_button.UseVisualStyleBackColor = false;
            // 
            // sub1_panel
            // 
            sub1_panel.BackColor = Color.Black;
            sub1_panel.BackgroundImageLayout = ImageLayout.None;
            sub1_panel.Controls.Add(karyawan_button);
            sub1_panel.ForeColor = Color.Red;
            sub1_panel.Location = new Point(0, 51);
            sub1_panel.Margin = new Padding(0);
            sub1_panel.Name = "sub1_panel";
            sub1_panel.Size = new Size(234, 51);
            sub1_panel.TabIndex = 7;
            // 
            // karyawan_button
            // 
            karyawan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            karyawan_button.BackColor = Color.IndianRed;
            karyawan_button.FlatAppearance.BorderSize = 0;
            karyawan_button.FlatStyle = FlatStyle.Flat;
            karyawan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            karyawan_button.ForeColor = SystemColors.ActiveCaptionText;
            karyawan_button.Image = (Image)resources.GetObject("karyawan_button.Image");
            karyawan_button.ImageAlign = ContentAlignment.MiddleLeft;
            karyawan_button.Location = new Point(0, 0);
            karyawan_button.Name = "karyawan_button";
            karyawan_button.Padding = new Padding(15, 0, 0, 0);
            karyawan_button.Size = new Size(234, 51);
            karyawan_button.TabIndex = 0;
            karyawan_button.Text = "            Karyawan";
            karyawan_button.TextAlign = ContentAlignment.MiddleLeft;
            karyawan_button.UseVisualStyleBackColor = false;
            // 
            // sub2_panel
            // 
            sub2_panel.BackColor = Color.Black;
            sub2_panel.BackgroundImageLayout = ImageLayout.None;
            sub2_panel.Controls.Add(pelanggan_button);
            sub2_panel.ForeColor = Color.Red;
            sub2_panel.Location = new Point(0, 102);
            sub2_panel.Margin = new Padding(0);
            sub2_panel.Name = "sub2_panel";
            sub2_panel.Size = new Size(234, 51);
            sub2_panel.TabIndex = 5;
            // 
            // pelanggan_button
            // 
            pelanggan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pelanggan_button.BackColor = Color.IndianRed;
            pelanggan_button.FlatAppearance.BorderSize = 0;
            pelanggan_button.FlatStyle = FlatStyle.Flat;
            pelanggan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pelanggan_button.ForeColor = SystemColors.ActiveCaptionText;
            pelanggan_button.Image = (Image)resources.GetObject("pelanggan_button.Image");
            pelanggan_button.ImageAlign = ContentAlignment.MiddleLeft;
            pelanggan_button.Location = new Point(0, 0);
            pelanggan_button.Name = "pelanggan_button";
            pelanggan_button.Padding = new Padding(15, 0, 0, 0);
            pelanggan_button.Size = new Size(234, 51);
            pelanggan_button.TabIndex = 0;
            pelanggan_button.Text = "            Pelanggan";
            pelanggan_button.TextAlign = ContentAlignment.MiddleLeft;
            pelanggan_button.UseVisualStyleBackColor = false;
            // 
            // sub3_panel
            // 
            sub3_panel.BackColor = Color.Black;
            sub3_panel.BackgroundImageLayout = ImageLayout.None;
            sub3_panel.Controls.Add(kendaraan_button);
            sub3_panel.Location = new Point(0, 153);
            sub3_panel.Margin = new Padding(0);
            sub3_panel.Name = "sub3_panel";
            sub3_panel.Size = new Size(234, 51);
            sub3_panel.TabIndex = 3;
            // 
            // kendaraan_button
            // 
            kendaraan_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kendaraan_button.BackColor = Color.IndianRed;
            kendaraan_button.FlatAppearance.BorderSize = 0;
            kendaraan_button.FlatStyle = FlatStyle.Flat;
            kendaraan_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kendaraan_button.ForeColor = SystemColors.ActiveCaptionText;
            kendaraan_button.Image = (Image)resources.GetObject("kendaraan_button.Image");
            kendaraan_button.ImageAlign = ContentAlignment.MiddleLeft;
            kendaraan_button.Location = new Point(0, 0);
            kendaraan_button.Name = "kendaraan_button";
            kendaraan_button.Padding = new Padding(15, 0, 0, 0);
            kendaraan_button.Size = new Size(234, 51);
            kendaraan_button.TabIndex = 0;
            kendaraan_button.Text = "            Kendaraan";
            kendaraan_button.TextAlign = ContentAlignment.MiddleLeft;
            kendaraan_button.UseVisualStyleBackColor = false;
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
            riwayat_button.Location = new Point(0, 114);
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
            invoice_button.Location = new Point(3, 168);
            invoice_button.Name = "invoice_button";
            invoice_button.Padding = new Padding(15, 0, 0, 0);
            invoice_button.Size = new Size(231, 51);
            invoice_button.TabIndex = 0;
            invoice_button.Text = "            INVOICE";
            invoice_button.TextAlign = ContentAlignment.MiddleLeft;
            invoice_button.UseVisualStyleBackColor = false;
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
            // MenuTransition
            // 
            MenuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            // 
            // panelmdi
            // 
            panelmdi.BackColor = SystemColors.Highlight;
            panelmdi.Dock = DockStyle.Fill;
            panelmdi.Location = new Point(234, 55);
            panelmdi.Name = "panelmdi";
            panelmdi.Size = new Size(663, 530);
            panelmdi.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 585);
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
            Data_flowLayOut.ResumeLayout(false);
            Data_panel.ResumeLayout(false);
            sub1_panel.ResumeLayout(false);
            sub2_panel.ResumeLayout(false);
            sub3_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox Hamburger_button;
        private FlowLayoutPanel SideBar_Layout;
        private Button Dashboard_button;
        private Panel sub3_panel;
        private Button kendaraan_button;
        private FlowLayoutPanel Data_flowLayOut;
        private Button riwayat_button;
        private Panel sub2_panel;
        private Button pelanggan_button;
        private Panel sub1_panel;
        private Button karyawan_button;
        private Panel Data_panel;
        private Button data_button;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panelmdi;
        private Button laporan_button;
        private Button invoice_button;
        private Button logout_button;
    }
}