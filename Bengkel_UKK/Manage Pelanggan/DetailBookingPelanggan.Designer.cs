using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Manage_Pelanggan
{
    partial class DetailBookingPelanggan
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
            comboMekanik = new ComboBox();
            label26 = new Label();
            btnSparepart = new Button();
            txtSparepart = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            comboServis = new ComboBox();
            label25 = new Label();
            label24 = new Label();
            txtCatatan = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label7 = new Label();
            txtTanggal = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtKeluhan = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label12 = new Label();
            label6 = new Label();
            txtIdBooking = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            txtNoPol = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label4 = new Label();
            txtKendaraan = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label3 = new Label();
            txtKTP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSparepart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCatatan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTanggal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKeluhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoPol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKendaraan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKTP).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboMekanik);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(btnSparepart);
            panel1.Controls.Add(txtSparepart);
            panel1.Controls.Add(comboServis);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(txtCatatan);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTanggal);
            panel1.Controls.Add(txtKeluhan);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtIdBooking);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNoPol);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtKendaraan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtKTP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 754);
            panel1.TabIndex = 13;
            // 
            // comboMekanik
            // 
            comboMekanik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMekanik.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboMekanik.FormattingEnabled = true;
            comboMekanik.Location = new Point(177, 590);
            comboMekanik.Name = "comboMekanik";
            comboMekanik.Size = new Size(257, 28);
            comboMekanik.TabIndex = 56;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ControlDarkDark;
            label26.Location = new Point(47, 590);
            label26.Name = "label26";
            label26.Size = new Size(80, 23);
            label26.TabIndex = 55;
            label26.Text = "Mekanik*";
            // 
            // btnSparepart
            // 
            btnSparepart.BackColor = Color.FromArgb(230, 126, 34);
            btnSparepart.FlatAppearance.BorderSize = 0;
            btnSparepart.FlatStyle = FlatStyle.Flat;
            btnSparepart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSparepart.ForeColor = Color.White;
            btnSparepart.Location = new Point(389, 643);
            btnSparepart.Margin = new Padding(0);
            btnSparepart.Name = "btnSparepart";
            btnSparepart.Size = new Size(45, 26);
            btnSparepart.TabIndex = 54;
            btnSparepart.Text = "🔎";
            btnSparepart.UseVisualStyleBackColor = false;
            // 
            // txtSparepart
            // 
            txtSparepart.BackColor = Color.White;
            txtSparepart.BeforeTouchSize = new Size(257, 27);
            txtSparepart.BorderColor = Color.FromArgb(209, 211, 212);
            txtSparepart.BorderStyle = BorderStyle.FixedSingle;
            txtSparepart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSparepart.ForeColor = SystemColors.ControlText;
            txtSparepart.Location = new Point(177, 642);
            txtSparepart.Name = "txtSparepart";
            txtSparepart.ReadOnly = true;
            txtSparepart.Size = new Size(206, 27);
            txtSparepart.TabIndex = 53;
            txtSparepart.ThemeName = "Default";
            // 
            // comboServis
            // 
            comboServis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboServis.FormattingEnabled = true;
            comboServis.Location = new Point(177, 538);
            comboServis.Name = "comboServis";
            comboServis.Size = new Size(257, 28);
            comboServis.TabIndex = 51;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ControlDarkDark;
            label25.Location = new Point(47, 642);
            label25.Name = "label25";
            label25.Size = new Size(84, 23);
            label25.TabIndex = 49;
            label25.Text = "Sparepart";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlDarkDark;
            label24.Location = new Point(47, 693);
            label24.Name = "label24";
            label24.Size = new Size(77, 23);
            label24.TabIndex = 47;
            label24.Text = "Catatan*";
            // 
            // txtCatatan
            // 
            txtCatatan.BackColor = Color.White;
            txtCatatan.BeforeTouchSize = new Size(257, 27);
            txtCatatan.BorderColor = Color.FromArgb(209, 211, 212);
            txtCatatan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCatatan.ForeColor = SystemColors.ControlText;
            txtCatatan.Location = new Point(177, 693);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.ReadOnly = true;
            txtCatatan.Size = new Size(257, 27);
            txtCatatan.TabIndex = 48;
            txtCatatan.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(47, 538);
            label9.Name = "label9";
            label9.Size = new Size(101, 23);
            label9.TabIndex = 42;
            label9.Text = "Jenis Servis*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(47, 364);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 40;
            label7.Text = "Tanggal";
            // 
            // txtTanggal
            // 
            txtTanggal.BackColor = Color.White;
            txtTanggal.BeforeTouchSize = new Size(257, 27);
            txtTanggal.BorderColor = Color.FromArgb(128, 128, 255);
            txtTanggal.BorderStyle = BorderStyle.FixedSingle;
            txtTanggal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTanggal.ForeColor = SystemColors.ControlText;
            txtTanggal.Location = new Point(177, 364);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.ReadOnly = true;
            txtTanggal.Size = new Size(257, 27);
            txtTanggal.TabIndex = 39;
            txtTanggal.Text = "10 November 2024";
            txtTanggal.ThemeName = "Default";
            // 
            // txtKeluhan
            // 
            txtKeluhan.BackColor = Color.White;
            txtKeluhan.BeforeTouchSize = new Size(257, 27);
            txtKeluhan.BorderColor = Color.FromArgb(128, 128, 255);
            txtKeluhan.BorderStyle = BorderStyle.FixedSingle;
            txtKeluhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeluhan.ForeColor = SystemColors.ControlText;
            txtKeluhan.Location = new Point(177, 412);
            txtKeluhan.Multiline = true;
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.ReadOnly = true;
            txtKeluhan.Size = new Size(257, 76);
            txtKeluhan.TabIndex = 33;
            txtKeluhan.Text = "Lampu injeksi nyala dan tarikan bawah loyo";
            txtKeluhan.ThemeName = "Default";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(47, 412);
            label12.Name = "label12";
            label12.Size = new Size(72, 23);
            label12.TabIndex = 38;
            label12.Text = "Keluhan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(47, 316);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 32;
            label6.Text = "No Pol";
            // 
            // txtIdBooking
            // 
            txtIdBooking.BackColor = Color.White;
            txtIdBooking.BeforeTouchSize = new Size(257, 27);
            txtIdBooking.BorderColor = Color.FromArgb(209, 211, 212);
            txtIdBooking.BorderStyle = BorderStyle.FixedSingle;
            txtIdBooking.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdBooking.ForeColor = SystemColors.ControlText;
            txtIdBooking.Location = new Point(177, 95);
            txtIdBooking.Name = "txtIdBooking";
            txtIdBooking.ReadOnly = true;
            txtIdBooking.Size = new Size(257, 27);
            txtIdBooking.TabIndex = 27;
            txtIdBooking.Text = "1277";
            txtIdBooking.ThemeName = "Default";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(47, 268);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "Kendaraan";
            // 
            // txtNoPol
            // 
            txtNoPol.BackColor = Color.White;
            txtNoPol.BeforeTouchSize = new Size(257, 27);
            txtNoPol.BorderColor = Color.FromArgb(128, 128, 255);
            txtNoPol.BorderStyle = BorderStyle.FixedSingle;
            txtNoPol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoPol.ForeColor = SystemColors.ControlText;
            txtNoPol.Location = new Point(177, 316);
            txtNoPol.Name = "txtNoPol";
            txtNoPol.ReadOnly = true;
            txtNoPol.Size = new Size(257, 27);
            txtNoPol.TabIndex = 31;
            txtNoPol.Text = "AB 8898 FC";
            txtNoPol.ThemeName = "Default";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.BeforeTouchSize = new Size(257, 27);
            txtNama.BorderColor = Color.FromArgb(209, 211, 212);
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.ForeColor = SystemColors.ControlText;
            txtNama.Location = new Point(177, 143);
            txtNama.Name = "txtNama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(257, 27);
            txtNama.TabIndex = 28;
            txtNama.Text = "Dhafa Bintang Ramadhan";
            txtNama.ThemeName = "Default";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(47, 189);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 3;
            label4.Text = "No KTP";
            // 
            // txtKendaraan
            // 
            txtKendaraan.BackColor = Color.White;
            txtKendaraan.BeforeTouchSize = new Size(257, 27);
            txtKendaraan.BorderColor = Color.FromArgb(128, 128, 255);
            txtKendaraan.BorderStyle = BorderStyle.FixedSingle;
            txtKendaraan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKendaraan.ForeColor = SystemColors.ControlText;
            txtKendaraan.Location = new Point(177, 268);
            txtKendaraan.Name = "txtKendaraan";
            txtKendaraan.ReadOnly = true;
            txtKendaraan.Size = new Size(257, 27);
            txtKendaraan.TabIndex = 30;
            txtKendaraan.Text = "Vario 160";
            txtKendaraan.ThemeName = "Default";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(47, 142);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 2;
            label3.Text = "Nama";
            // 
            // txtKTP
            // 
            txtKTP.BackColor = Color.White;
            txtKTP.BeforeTouchSize = new Size(257, 27);
            txtKTP.BorderColor = Color.FromArgb(209, 211, 212);
            txtKTP.BorderStyle = BorderStyle.FixedSingle;
            txtKTP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKTP.ForeColor = SystemColors.ControlText;
            txtKTP.Location = new Point(177, 191);
            txtKTP.Name = "txtKTP";
            txtKTP.ReadOnly = true;
            txtKTP.Size = new Size(257, 27);
            txtKTP.TabIndex = 29;
            txtKTP.Text = "0183831031831831";
            txtKTP.ThemeName = "Default";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "ID Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 26);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 0;
            label1.Text = "DETAIL BOOKING";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(509, 778);
            panel3.TabIndex = 79;
            // 
            // DetailBookingPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 778);
            Controls.Add(panel3);
            Name = "DetailBookingPelanggan";
            Text = "FormBookingDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSparepart).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCatatan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTanggal).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKeluhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoPol).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKendaraan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKTP).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKeluhan;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoPol;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKendaraan;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKTP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNama;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtIdBooking;
        private Label label12;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTanggal;
        private Label label9;
        private Label label24;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCatatan;
        private Label label25;
        private ComboBox comboServis;
        private Button btnSparepart;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSparepart;
        private ComboBox comboMekanik;
        private Label label26;
        private Panel panel3;
    }
}