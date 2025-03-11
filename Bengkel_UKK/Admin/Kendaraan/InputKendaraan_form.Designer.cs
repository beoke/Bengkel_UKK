using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Kendaraan
{
    partial class InputKendaraan_form
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
            panel1 = new Panel();
            lblHeader = new Label();
            button_simpan = new DhafaButton();
            button_batal = new DhafaButton();
            lblErrorTahunMotor = new Label();
            lblErrorKapasitas = new Label();
            lblErrorEmail = new Label();
            lblErrorTipe = new Label();
            lblErrorKTP = new Label();
            lblErrorNopol = new Label();
            tahun_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label13 = new Label();
            label12 = new Label();
            kapasitas_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            Transmisi_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            merk_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            noPolisi_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label4 = new Label();
            label3 = new Label();
            noKtp_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pemilik_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            label2 = new Label();
            tipe_combo = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tahun_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kapasitas_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Transmisi_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)merk_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noPolisi_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noKtp_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pemilik_text).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 42);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(52, 152, 219);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(893, 43);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Input Kendaraan";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_simpan
            // 
            button_simpan.BackColor = Color.FromArgb(52, 152, 219);
            button_simpan.BackgroundColor = Color.FromArgb(52, 152, 219);
            button_simpan.BorderColor = Color.PaleVioletRed;
            button_simpan.BorderRadius = 0;
            button_simpan.BorderSize = 0;
            button_simpan.FlatAppearance.BorderSize = 0;
            button_simpan.FlatStyle = FlatStyle.Flat;
            button_simpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_simpan.ForeColor = Color.White;
            button_simpan.Location = new Point(766, 370);
            button_simpan.Name = "button_simpan";
            button_simpan.Size = new Size(108, 36);
            button_simpan.TabIndex = 37;
            button_simpan.Text = "Simpan";
            button_simpan.TextColor = Color.White;
            button_simpan.UseVisualStyleBackColor = false;
            // 
            // button_batal
            // 
            button_batal.BackColor = Color.Transparent;
            button_batal.BackgroundColor = Color.Transparent;
            button_batal.BorderColor = Color.PaleVioletRed;
            button_batal.BorderRadius = 0;
            button_batal.BorderSize = 2;
            button_batal.FlatAppearance.BorderSize = 0;
            button_batal.FlatStyle = FlatStyle.Flat;
            button_batal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_batal.ForeColor = SystemColors.ControlDarkDark;
            button_batal.Location = new Point(639, 370);
            button_batal.Name = "button_batal";
            button_batal.Size = new Size(108, 36);
            button_batal.TabIndex = 62;
            button_batal.Text = "Batal";
            button_batal.TextColor = SystemColors.ControlDarkDark;
            button_batal.UseVisualStyleBackColor = false;
            // 
            // lblErrorTahunMotor
            // 
            lblErrorTahunMotor.AutoSize = true;
            lblErrorTahunMotor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTahunMotor.ForeColor = Color.Red;
            lblErrorTahunMotor.Location = new Point(588, 314);
            lblErrorTahunMotor.Name = "lblErrorTahunMotor";
            lblErrorTahunMotor.Size = new Size(199, 17);
            lblErrorTahunMotor.TabIndex = 111;
            lblErrorTahunMotor.Text = "⚠️ Harap mengisi tahun motor !";
            lblErrorTahunMotor.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTahunMotor.Visible = false;
            // 
            // lblErrorKapasitas
            // 
            lblErrorKapasitas.AutoSize = true;
            lblErrorKapasitas.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKapasitas.ForeColor = Color.Red;
            lblErrorKapasitas.Location = new Point(581, 237);
            lblErrorKapasitas.Name = "lblErrorKapasitas";
            lblErrorKapasitas.Size = new Size(221, 17);
            lblErrorKapasitas.TabIndex = 110;
            lblErrorKapasitas.Text = "⚠️ Harap mengisi kapasitas motor !";
            lblErrorKapasitas.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKapasitas.Visible = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(581, 162);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(194, 17);
            lblErrorEmail.TabIndex = 109;
            lblErrorEmail.Text = "⚠️ Masukkan email yang valid !";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // lblErrorTipe
            // 
            lblErrorTipe.AutoSize = true;
            lblErrorTipe.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTipe.ForeColor = Color.Red;
            lblErrorTipe.Location = new Point(581, 94);
            lblErrorTipe.Name = "lblErrorTipe";
            lblErrorTipe.Size = new Size(185, 17);
            lblErrorTipe.TabIndex = 108;
            lblErrorTipe.Text = "⚠️ Harap mengisi tipe motor!";
            lblErrorTipe.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTipe.Visible = false;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(136, 314);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(192, 17);
            lblErrorKTP.TabIndex = 107;
            lblErrorKTP.Text = "⚠️ Harap mengisi merk motor!";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // lblErrorNopol
            // 
            lblErrorNopol.AutoSize = true;
            lblErrorNopol.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNopol.ForeColor = Color.Red;
            lblErrorNopol.Location = new Point(136, 237);
            lblErrorNopol.Name = "lblErrorNopol";
            lblErrorNopol.Size = new Size(177, 17);
            lblErrorNopol.TabIndex = 106;
            lblErrorNopol.Text = "⚠️ Harap mengisi no polisi !";
            lblErrorNopol.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNopol.Visible = false;
            // 
            // tahun_text
            // 
            tahun_text.BackColor = Color.White;
            tahun_text.BeforeTouchSize = new Size(286, 27);
            tahun_text.BorderColor = Color.FromArgb(209, 211, 212);
            tahun_text.BorderStyle = BorderStyle.FixedSingle;
            tahun_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tahun_text.Location = new Point(581, 284);
            tahun_text.Name = "tahun_text";
            tahun_text.PlaceholderText = " Masukkan konfirmasi password";
            tahun_text.Size = new Size(293, 27);
            tahun_text.TabIndex = 103;
            tahun_text.ThemeName = "Default";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(460, 271);
            label13.Name = "label13";
            label13.Size = new Size(61, 25);
            label13.TabIndex = 102;
            label13.Text = "Tahun";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(460, 70);
            label12.Name = "label12";
            label12.Size = new Size(48, 25);
            label12.TabIndex = 100;
            label12.Text = "Tipe";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kapasitas_text
            // 
            kapasitas_text.BackColor = Color.White;
            kapasitas_text.BeforeTouchSize = new Size(286, 27);
            kapasitas_text.BorderColor = Color.FromArgb(209, 211, 212);
            kapasitas_text.BorderStyle = BorderStyle.FixedSingle;
            kapasitas_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kapasitas_text.Location = new Point(581, 207);
            kapasitas_text.Name = "kapasitas_text";
            kapasitas_text.PlaceholderText = " Masukkan password";
            kapasitas_text.Size = new Size(293, 27);
            kapasitas_text.TabIndex = 99;
            kapasitas_text.ThemeName = "Default";
            // 
            // Transmisi_text
            // 
            Transmisi_text.BackColor = Color.White;
            Transmisi_text.BeforeTouchSize = new Size(286, 27);
            Transmisi_text.BorderColor = Color.FromArgb(209, 211, 212);
            Transmisi_text.BorderStyle = BorderStyle.FixedSingle;
            Transmisi_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Transmisi_text.Location = new Point(581, 132);
            Transmisi_text.Name = "Transmisi_text";
            Transmisi_text.PlaceholderText = " Masukkan nama";
            Transmisi_text.Size = new Size(286, 27);
            Transmisi_text.TabIndex = 98;
            Transmisi_text.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(460, 207);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 97;
            label9.Text = "Kapasitas";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(459, 132);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 96;
            label10.Text = "Transmisi";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // merk_text
            // 
            merk_text.BackColor = Color.White;
            merk_text.BeforeTouchSize = new Size(286, 27);
            merk_text.BorderColor = Color.FromArgb(209, 211, 212);
            merk_text.BorderStyle = BorderStyle.FixedSingle;
            merk_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            merk_text.Location = new Point(136, 284);
            merk_text.Name = "merk_text";
            merk_text.PlaceholderText = " Masukkan Merk Motor";
            merk_text.Size = new Size(293, 27);
            merk_text.TabIndex = 95;
            merk_text.ThemeName = "Default";
            // 
            // noPolisi_text
            // 
            noPolisi_text.BackColor = Color.White;
            noPolisi_text.BeforeTouchSize = new Size(286, 27);
            noPolisi_text.BorderColor = Color.FromArgb(209, 211, 212);
            noPolisi_text.BorderStyle = BorderStyle.FixedSingle;
            noPolisi_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            noPolisi_text.Location = new Point(136, 207);
            noPolisi_text.Name = "noPolisi_text";
            noPolisi_text.PlaceholderText = " Masukkan No Polisi";
            noPolisi_text.Size = new Size(293, 27);
            noPolisi_text.TabIndex = 94;
            noPolisi_text.ThemeName = "Default";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(22, 284);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 93;
            label4.Text = "Merk";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(22, 207);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 92;
            label3.Text = "No Polisi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noKtp_text
            // 
            noKtp_text.BackColor = Color.White;
            noKtp_text.BeforeTouchSize = new Size(286, 27);
            noKtp_text.BorderColor = Color.FromArgb(209, 211, 212);
            noKtp_text.BorderStyle = BorderStyle.FixedSingle;
            noKtp_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            noKtp_text.Location = new Point(136, 66);
            noKtp_text.Name = "noKtp_text";
            noKtp_text.PlaceholderText = " Masukkan No Ktp";
            noKtp_text.Size = new Size(293, 27);
            noKtp_text.TabIndex = 112;
            noKtp_text.ThemeName = "Default";
            // 
            // pemilik_text
            // 
            pemilik_text.BackColor = Color.White;
            pemilik_text.BeforeTouchSize = new Size(286, 27);
            pemilik_text.BorderColor = Color.FromArgb(209, 211, 212);
            pemilik_text.BorderStyle = BorderStyle.FixedSingle;
            pemilik_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pemilik_text.Location = new Point(136, 130);
            pemilik_text.Name = "pemilik_text";
            pemilik_text.PlaceholderText = " Masukkan Nama Pemilik";
            pemilik_text.Size = new Size(293, 27);
            pemilik_text.TabIndex = 113;
            pemilik_text.ThemeName = "Default";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 114;
            label1.Text = "No ktp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 115;
            label2.Text = "Pemilik";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipe_combo
            // 
            tipe_combo.FormattingEnabled = true;
            tipe_combo.Location = new Point(581, 68);
            tipe_combo.Name = "tipe_combo";
            tipe_combo.Size = new Size(286, 23);
            tipe_combo.TabIndex = 116;
            // 
            // InputKendaraan_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 423);
            Controls.Add(tipe_combo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pemilik_text);
            Controls.Add(noKtp_text);
            Controls.Add(lblErrorTahunMotor);
            Controls.Add(lblErrorKapasitas);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorTipe);
            Controls.Add(lblErrorKTP);
            Controls.Add(lblErrorNopol);
            Controls.Add(tahun_text);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(kapasitas_text);
            Controls.Add(Transmisi_text);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(merk_text);
            Controls.Add(noPolisi_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_batal);
            Controls.Add(button_simpan);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputKendaraan_form";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tahun_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)kapasitas_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)Transmisi_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)merk_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)noPolisi_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)noKtp_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)pemilik_text).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private DhafaButton button_simpan;
        private DhafaButton button_batal;
        private Label lblErrorTahunMotor;
        private Label lblErrorKapasitas;
        private Label lblErrorEmail;
        private Label lblErrorTipe;
        private Label lblErrorKTP;
        private Label lblErrorNopol;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tahun_text;
        private Label label13;
        private Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt kapasitas_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Transmisi_text;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt merk_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt noPolisi_text;
        private Label label4;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt noKtp_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt pemilik_text;
        private Label label1;
        private Label label2;
        private ComboBox tipe_combo;
    }
}