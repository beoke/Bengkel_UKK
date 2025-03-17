namespace Bengkel_UKK.Manage_Pelanggan
{
    partial class pelangganbooking
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
            btnCancel = new Custom_Component.DhafaButton();
            btnSave = new Custom_Component.DhafaButton();
            btnSearch = new Custom_Component.DhafaButton();
            lblErrorTanggal = new Label();
            TglEditSync = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            lblErrorKeluhan = new Label();
            comboKendaraan = new ComboBox();
            txtKeluhan = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label8 = new Label();
            label6 = new Label();
            txtNoPol = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            lblErrorKTP = new Label();
            label12 = new Label();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtNoKTP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label4 = new Label();
            label3 = new Label();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)txtKeluhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoPol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundColor = Color.Transparent;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 0;
            btnCancel.BorderSize = 2;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlDarkDark;
            btnCancel.Location = new Point(194, 589);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 36);
            btnCancel.TabIndex = 136;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = SystemColors.ControlDarkDark;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.BackgroundColor = Color.FromArgb(52, 152, 219);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 0;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(313, 589);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 36);
            btnSave.TabIndex = 135;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(230, 126, 34);
            btnSearch.BackgroundColor = Color.FromArgb(230, 126, 34);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(374, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 30);
            btnSearch.TabIndex = 134;
            btnSearch.Text = "🔎";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblErrorTanggal
            // 
            lblErrorTanggal.AutoSize = true;
            lblErrorTanggal.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTanggal.ForeColor = Color.Red;
            lblErrorTanggal.Location = new Point(128, 368);
            lblErrorTanggal.Name = "lblErrorTanggal";
            lblErrorTanggal.Size = new Size(268, 17);
            lblErrorTanggal.TabIndex = 133;
            lblErrorTanggal.Text = "⚠️ Antrean penuh, Mohon pilih tanggal lain!";
            lblErrorTanggal.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTanggal.Visible = false;
            // 
            // TglEditSync
            // 
            TglEditSync.DateTimeIcon = null;
            TglEditSync.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            TglEditSync.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TglEditSync.Format = "d MMMM yyyy";
            TglEditSync.Location = new Point(128, 320);
            TglEditSync.Name = "TglEditSync";
            TglEditSync.Size = new Size(293, 28);
            TglEditSync.Style.BorderColor = Color.FromArgb(64, 64, 64);
            TglEditSync.TabIndex = 132;
            TglEditSync.ToolTipText = "";
            // 
            // lblErrorKeluhan
            // 
            lblErrorKeluhan.AutoSize = true;
            lblErrorKeluhan.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKeluhan.ForeColor = Color.Red;
            lblErrorKeluhan.Location = new Point(128, 514);
            lblErrorKeluhan.Name = "lblErrorKeluhan";
            lblErrorKeluhan.Size = new Size(134, 17);
            lblErrorKeluhan.TabIndex = 131;
            lblErrorKeluhan.Text = "⚠️ Harap isi keluhan!";
            lblErrorKeluhan.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKeluhan.Visible = false;
            // 
            // comboKendaraan
            // 
            comboKendaraan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKendaraan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboKendaraan.FormattingEnabled = true;
            comboKendaraan.Location = new Point(128, 214);
            comboKendaraan.Name = "comboKendaraan";
            comboKendaraan.Size = new Size(293, 28);
            comboKendaraan.TabIndex = 130;
            // 
            // txtKeluhan
            // 
            txtKeluhan.BackColor = Color.White;
            txtKeluhan.BeforeTouchSize = new Size(240, 27);
            txtKeluhan.BorderColor = Color.FromArgb(176, 176, 176);
            txtKeluhan.BorderStyle = BorderStyle.FixedSingle;
            txtKeluhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeluhan.Location = new Point(128, 410);
            txtKeluhan.Multiline = true;
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.PlaceholderText = " Masukkan Keluhan";
            txtKeluhan.Size = new Size(293, 90);
            txtKeluhan.TabIndex = 129;
            txtKeluhan.ThemeName = "Default";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(17, 410);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 128;
            label8.Text = "Keluhan";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(17, 320);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 127;
            label6.Text = "Tanggal";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNoPol
            // 
            txtNoPol.BackColor = Color.FromArgb(230, 247, 255);
            txtNoPol.BeforeTouchSize = new Size(240, 27);
            txtNoPol.BorderColor = Color.FromArgb(176, 176, 176);
            txtNoPol.BorderStyle = BorderStyle.FixedSingle;
            txtNoPol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoPol.Location = new Point(128, 267);
            txtNoPol.Name = "txtNoPol";
            txtNoPol.ReadOnly = true;
            txtNoPol.Size = new Size(293, 27);
            txtNoPol.TabIndex = 126;
            txtNoPol.ThemeName = "Default";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(14, 267);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 125;
            label1.Text = "No Pol";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(128, 106);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(174, 17);
            lblErrorKTP.TabIndex = 124;
            lblErrorKTP.Text = "⚠️ No KTP tidak ditemukan!";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(14, 214);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 123;
            label12.Text = "Kendaraan";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(230, 247, 255);
            txtNama.BeforeTouchSize = new Size(240, 27);
            txtNama.BorderColor = Color.FromArgb(176, 176, 176);
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(128, 153);
            txtNama.Name = "txtNama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(293, 27);
            txtNama.TabIndex = 122;
            txtNama.ThemeName = "Default";
            // 
            // txtNoKTP
            // 
            txtNoKTP.BackColor = Color.White;
            txtNoKTP.BeforeTouchSize = new Size(240, 27);
            txtNoKTP.BorderColor = Color.FromArgb(176, 176, 176);
            txtNoKTP.BorderStyle = BorderStyle.FixedSingle;
            txtNoKTP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(128, 76);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.PlaceholderText = " Cari pelanggan dengan KTP";
            txtNoKTP.Size = new Size(240, 27);
            txtNoKTP.TabIndex = 121;
            txtNoKTP.ThemeName = "Default";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(14, 153);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 120;
            label4.Text = "Nama*";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(14, 76);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 119;
            label3.Text = "No KTP*";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(170, 0, 0);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(444, 43);
            lblHeader.TabIndex = 137;
            lblHeader.Text = "Input Booking";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pelangganbooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 633);
            Controls.Add(lblHeader);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(lblErrorTanggal);
            Controls.Add(TglEditSync);
            Controls.Add(lblErrorKeluhan);
            Controls.Add(comboKendaraan);
            Controls.Add(txtKeluhan);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtNoPol);
            Controls.Add(label1);
            Controls.Add(lblErrorKTP);
            Controls.Add(label12);
            Controls.Add(txtNama);
            Controls.Add(txtNoKTP);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "pelangganbooking";
            Text = "pelangganbooking";
            ((System.ComponentModel.ISupportInitialize)txtKeluhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoPol).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Component.DhafaButton btnCancel;
        private Custom_Component.DhafaButton btnSave;
        private Custom_Component.DhafaButton btnSearch;
        private Label lblErrorTanggal;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TglEditSync;
        private Label lblErrorKeluhan;
        private ComboBox comboKendaraan;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKeluhan;
        private Label label8;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoPol;
        private Label label1;
        private Label lblErrorKTP;
        private Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNama;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoKTP;
        private Label label4;
        private Label label3;
        private Label lblHeader;
    }
}