namespace Bengkel_UKK.Admin
{
    partial class Dashboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            flowLayoutPanel1 = new FlowLayoutPanel();
            DataSet_Button = new Button();
            DataKendaraan_button = new Button();
            DataPelanggan_button = new Button();
            DataKaryawan_button = new Button();
            Riwayat_button = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            PanelMenu_panel = new Panel();
            Dashboard_Button = new Button();
            PanelForm_panel = new Panel();
            panel1 = new Panel();
            Menu_label = new Label();
            flowLayoutPanel1.SuspendLayout();
            PanelMenu_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(DataSet_Button);
            flowLayoutPanel1.Controls.Add(DataKendaraan_button);
            flowLayoutPanel1.Controls.Add(DataPelanggan_button);
            flowLayoutPanel1.Controls.Add(DataKaryawan_button);
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(284, 52);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // DataSet_Button
            // 
            DataSet_Button.BackColor = SystemColors.ActiveCaption;
            DataSet_Button.FlatAppearance.BorderSize = 0;
            DataSet_Button.FlatStyle = FlatStyle.Flat;
            DataSet_Button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DataSet_Button.Location = new Point(0, 0);
            DataSet_Button.Margin = new Padding(0);
            DataSet_Button.Name = "DataSet_Button";
            DataSet_Button.Size = new Size(282, 52);
            DataSet_Button.TabIndex = 5;
            DataSet_Button.Text = "Data Set";
            DataSet_Button.TextAlign = ContentAlignment.MiddleLeft;
            DataSet_Button.UseVisualStyleBackColor = false;
            // 
            // DataKendaraan_button
            // 
            DataKendaraan_button.BackColor = SystemColors.ActiveBorder;
            DataKendaraan_button.BackgroundImage = (Image)resources.GetObject("DataKendaraan_button.BackgroundImage");
            DataKendaraan_button.BackgroundImageLayout = ImageLayout.None;
            DataKendaraan_button.FlatAppearance.BorderSize = 0;
            DataKendaraan_button.FlatStyle = FlatStyle.Flat;
            DataKendaraan_button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DataKendaraan_button.Location = new Point(0, 52);
            DataKendaraan_button.Margin = new Padding(0);
            DataKendaraan_button.Name = "DataKendaraan_button";
            DataKendaraan_button.Size = new Size(282, 50);
            DataKendaraan_button.TabIndex = 4;
            DataKendaraan_button.Text = "kendaraan";
            DataKendaraan_button.UseVisualStyleBackColor = false;
            // 
            // DataPelanggan_button
            // 
            DataPelanggan_button.BackColor = SystemColors.ActiveBorder;
            DataPelanggan_button.FlatAppearance.BorderSize = 0;
            DataPelanggan_button.FlatStyle = FlatStyle.Flat;
            DataPelanggan_button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DataPelanggan_button.Location = new Point(0, 102);
            DataPelanggan_button.Margin = new Padding(0);
            DataPelanggan_button.Name = "DataPelanggan_button";
            DataPelanggan_button.Size = new Size(282, 50);
            DataPelanggan_button.TabIndex = 3;
            DataPelanggan_button.Text = "Pelanggan";
            DataPelanggan_button.UseVisualStyleBackColor = false;
            // 
            // DataKaryawan_button
            // 
            DataKaryawan_button.BackColor = SystemColors.ActiveBorder;
            DataKaryawan_button.FlatAppearance.BorderSize = 0;
            DataKaryawan_button.FlatStyle = FlatStyle.Flat;
            DataKaryawan_button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DataKaryawan_button.Location = new Point(0, 152);
            DataKaryawan_button.Margin = new Padding(0);
            DataKaryawan_button.Name = "DataKaryawan_button";
            DataKaryawan_button.Size = new Size(282, 50);
            DataKaryawan_button.TabIndex = 2;
            DataKaryawan_button.Text = " Karyawan";
            DataKaryawan_button.UseVisualStyleBackColor = false;
            // 
            // Riwayat_button
            // 
            Riwayat_button.BackColor = SystemColors.ControlDarkDark;
            Riwayat_button.FlatAppearance.BorderSize = 0;
            Riwayat_button.FlatStyle = FlatStyle.Flat;
            Riwayat_button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Riwayat_button.Location = new Point(0, 102);
            Riwayat_button.Name = "Riwayat_button";
            Riwayat_button.Size = new Size(284, 50);
            Riwayat_button.TabIndex = 6;
            Riwayat_button.Text = "Riwayat ";
            Riwayat_button.UseVisualStyleBackColor = false;
            // 
            // PanelMenu_panel
            // 
            PanelMenu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelMenu_panel.BackColor = SystemColors.HighlightText;
            PanelMenu_panel.Controls.Add(Riwayat_button);
            PanelMenu_panel.Controls.Add(Dashboard_Button);
            PanelMenu_panel.Controls.Add(flowLayoutPanel1);
            PanelMenu_panel.Location = new Point(0, 77);
            PanelMenu_panel.Name = "PanelMenu_panel";
            PanelMenu_panel.Size = new Size(282, 510);
            PanelMenu_panel.TabIndex = 1;
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.BackColor = SystemColors.AppWorkspace;
            Dashboard_Button.FlatAppearance.BorderSize = 0;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("DFGothic-EB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboard_Button.Location = new Point(1, 0);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Size = new Size(283, 50);
            Dashboard_Button.TabIndex = 1;
            Dashboard_Button.Text = "Dashboard";
            Dashboard_Button.TextAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.UseVisualStyleBackColor = false;
            // 
            // PanelForm_panel
            // 
            PanelForm_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelForm_panel.BackColor = SystemColors.HotTrack;
            PanelForm_panel.Location = new Point(283, 77);
            PanelForm_panel.Name = "PanelForm_panel";
            PanelForm_panel.Size = new Size(795, 515);
            PanelForm_panel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Menu_label);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 77);
            panel1.TabIndex = 2;
            // 
            // Menu_label
            // 
            Menu_label.AutoSize = true;
            Menu_label.Font = new Font("DFGothic-EB", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_label.Location = new Point(67, 24);
            Menu_label.Name = "Menu_label";
            Menu_label.Size = new Size(109, 29);
            Menu_label.TabIndex = 0;
            Menu_label.Text = "label1";
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 590);
            Controls.Add(PanelForm_panel);
            Controls.Add(PanelMenu_panel);
            Controls.Add(panel1);
            Name = "Dashboard_Admin";
            Text = "Dashboard_Admin";
            flowLayoutPanel1.ResumeLayout(false);
            PanelMenu_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button DataPelanggan_button;
        private Button DataKaryawan_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button DataSet_Button;
        private Button DataKendaraan_button;
        private Panel PanelMenu_panel;
        private Button Dashboard_Button;
        private Panel PanelForm_panel;
        private Panel panel1;
        private Label Menu_label;
        private Button Riwayat_button;
    }
}