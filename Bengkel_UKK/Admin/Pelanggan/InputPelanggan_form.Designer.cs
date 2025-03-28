﻿using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Pelanggan
{
    partial class InputPelanggan_form
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
            button_save = new DhafaButton();
            button_cancel = new DhafaButton();
            lblErrorAlamat = new Label();
            lblErrorCPassword = new Label();
            lblErrorPassword = new Label();
            lblErrorEmail = new Label();
            lblErrorTelepon = new Label();
            lblErrorKTP = new Label();
            lblErrorNama = new Label();
            alamat_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            konfirm_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label13 = new Label();
            telepon_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label12 = new Label();
            password_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            email_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            ktp_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            nama_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alamat_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)konfirm_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)telepon_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)password_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)email_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ktp_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nama_text).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 42);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(170, 0, 0);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(454, 43);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Input Pelanggan";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_save
            // 
            button_save.BackColor = Color.FromArgb(52, 152, 219);
            button_save.BackgroundColor = Color.FromArgb(52, 152, 219);
            button_save.BorderColor = Color.PaleVioletRed;
            button_save.BorderRadius = 0;
            button_save.BorderSize = 0;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_save.ForeColor = Color.White;
            button_save.Location = new Point(320, 668);
            button_save.Name = "button_save";
            button_save.Size = new Size(108, 36);
            button_save.TabIndex = 37;
            button_save.Text = "Save";
            button_save.TextColor = Color.White;
            button_save.UseVisualStyleBackColor = false;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.Transparent;
            button_cancel.BackgroundColor = Color.Transparent;
            button_cancel.BorderColor = Color.PaleVioletRed;
            button_cancel.BorderRadius = 0;
            button_cancel.BorderSize = 2;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_cancel.ForeColor = SystemColors.ControlDarkDark;
            button_cancel.Location = new Point(193, 668);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(108, 36);
            button_cancel.TabIndex = 62;
            button_cancel.Text = "Cancel";
            button_cancel.TextColor = SystemColors.ControlDarkDark;
            button_cancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorAlamat
            // 
            lblErrorAlamat.AutoSize = true;
            lblErrorAlamat.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorAlamat.ForeColor = Color.Red;
            lblErrorAlamat.Location = new Point(135, 584);
            lblErrorAlamat.Name = "lblErrorAlamat";
            lblErrorAlamat.Size = new Size(166, 17);
            lblErrorAlamat.TabIndex = 112;
            lblErrorAlamat.Text = "⚠️ Harap mengisi alamat !";
            lblErrorAlamat.TextAlign = ContentAlignment.MiddleRight;
            lblErrorAlamat.Visible = false;
            // 
            // lblErrorCPassword
            // 
            lblErrorCPassword.AutoSize = true;
            lblErrorCPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCPassword.ForeColor = Color.Red;
            lblErrorCPassword.Location = new Point(135, 464);
            lblErrorCPassword.Name = "lblErrorCPassword";
            lblErrorCPassword.Size = new Size(248, 17);
            lblErrorCPassword.TabIndex = 111;
            lblErrorCPassword.Text = "⚠️ Harap mengisi konfirmasi password !";
            lblErrorCPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorCPassword.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(135, 387);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(184, 17);
            lblErrorPassword.TabIndex = 110;
            lblErrorPassword.Text = "⚠️ Harap mengisi password !";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(135, 320);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(194, 17);
            lblErrorEmail.TabIndex = 109;
            lblErrorEmail.Text = "⚠️ Masukkan email yang valid !";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // lblErrorTelepon
            // 
            lblErrorTelepon.AutoSize = true;
            lblErrorTelepon.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTelepon.ForeColor = Color.Red;
            lblErrorTelepon.Location = new Point(135, 243);
            lblErrorTelepon.Name = "lblErrorTelepon";
            lblErrorTelepon.Size = new Size(214, 17);
            lblErrorTelepon.TabIndex = 108;
            lblErrorTelepon.Text = "⚠️ Harap mengisi nomor telepon !";
            lblErrorTelepon.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTelepon.Visible = false;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(135, 166);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(171, 17);
            lblErrorKTP.TabIndex = 107;
            lblErrorKTP.Text = "⚠️ Harap mengisi No KTP !";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // lblErrorNama
            // 
            lblErrorNama.AutoSize = true;
            lblErrorNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNama.ForeColor = Color.Red;
            lblErrorNama.Location = new Point(135, 89);
            lblErrorNama.Name = "lblErrorNama";
            lblErrorNama.Size = new Size(159, 17);
            lblErrorNama.TabIndex = 106;
            lblErrorNama.Text = "⚠️ Harap mengisi nama !";
            lblErrorNama.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNama.Visible = false;
            // 
            // alamat_text
            // 
            alamat_text.BackColor = Color.White;
            alamat_text.BeforeTouchSize = new Size(293, 27);
            alamat_text.BorderColor = Color.FromArgb(209, 211, 212);
            alamat_text.BorderStyle = BorderStyle.FixedSingle;
            alamat_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            alamat_text.Location = new Point(135, 511);
            alamat_text.Multiline = true;
            alamat_text.Name = "alamat_text";
            alamat_text.PlaceholderText = " Masukkan alamat";
            alamat_text.Size = new Size(293, 70);
            alamat_text.TabIndex = 105;
            alamat_text.ThemeName = "Default";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(21, 511);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 104;
            label5.Text = "Alamat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // konfirm_text
            // 
            konfirm_text.BackColor = Color.White;
            konfirm_text.BeforeTouchSize = new Size(293, 27);
            konfirm_text.BorderColor = Color.FromArgb(209, 211, 212);
            konfirm_text.BorderStyle = BorderStyle.FixedSingle;
            konfirm_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            konfirm_text.Location = new Point(135, 434);
            konfirm_text.Name = "konfirm_text";
            konfirm_text.PlaceholderText = " Masukkan konfirmasi password";
            konfirm_text.Size = new Size(293, 27);
            konfirm_text.TabIndex = 103;
            konfirm_text.ThemeName = "Default";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(21, 421);
            label13.Name = "label13";
            label13.Size = new Size(106, 50);
            label13.TabIndex = 102;
            label13.Text = "Konfirmasi \r\nPassword";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // telepon_text
            // 
            telepon_text.BackColor = Color.White;
            telepon_text.BeforeTouchSize = new Size(293, 27);
            telepon_text.BorderColor = Color.FromArgb(209, 211, 212);
            telepon_text.BorderStyle = BorderStyle.FixedSingle;
            telepon_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            telepon_text.Location = new Point(135, 213);
            telepon_text.Name = "telepon_text";
            telepon_text.PlaceholderText = " Masukkan nomor telepon";
            telepon_text.Size = new Size(293, 27);
            telepon_text.TabIndex = 101;
            telepon_text.ThemeName = "Default";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(21, 213);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 100;
            label12.Text = "No Telepon";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password_text
            // 
            password_text.BackColor = Color.White;
            password_text.BeforeTouchSize = new Size(293, 27);
            password_text.BorderColor = Color.FromArgb(209, 211, 212);
            password_text.BorderStyle = BorderStyle.FixedSingle;
            password_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_text.Location = new Point(135, 357);
            password_text.Name = "password_text";
            password_text.PlaceholderText = " Masukkan password";
            password_text.Size = new Size(293, 27);
            password_text.TabIndex = 99;
            password_text.ThemeName = "Default";
            // 
            // email_text
            // 
            email_text.BackColor = Color.White;
            email_text.BeforeTouchSize = new Size(293, 27);
            email_text.BorderColor = Color.FromArgb(209, 211, 212);
            email_text.BorderStyle = BorderStyle.FixedSingle;
            email_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            email_text.Location = new Point(135, 290);
            email_text.Name = "email_text";
            email_text.PlaceholderText = " Masukkan nama";
            email_text.Size = new Size(293, 27);
            email_text.TabIndex = 98;
            email_text.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(21, 357);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 97;
            label9.Text = "Password";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(21, 290);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 96;
            label10.Text = "Email";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ktp_text
            // 
            ktp_text.BackColor = Color.White;
            ktp_text.BeforeTouchSize = new Size(293, 27);
            ktp_text.BorderColor = Color.FromArgb(209, 211, 212);
            ktp_text.BorderStyle = BorderStyle.FixedSingle;
            ktp_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ktp_text.Location = new Point(135, 136);
            ktp_text.Name = "ktp_text";
            ktp_text.PlaceholderText = " Masukkan nomor KTP";
            ktp_text.Size = new Size(293, 27);
            ktp_text.TabIndex = 95;
            ktp_text.ThemeName = "Default";
            // 
            // nama_text
            // 
            nama_text.BackColor = Color.White;
            nama_text.BeforeTouchSize = new Size(293, 27);
            nama_text.BorderColor = Color.FromArgb(209, 211, 212);
            nama_text.BorderStyle = BorderStyle.FixedSingle;
            nama_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nama_text.Location = new Point(135, 59);
            nama_text.Name = "nama_text";
            nama_text.PlaceholderText = " Masukkan nama";
            nama_text.Size = new Size(293, 27);
            nama_text.TabIndex = 94;
            nama_text.ThemeName = "Default";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(21, 136);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 93;
            label4.Text = "No KTP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(21, 59);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 92;
            label3.Text = "Nama";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputPelanggan_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 719);
            Controls.Add(lblErrorAlamat);
            Controls.Add(lblErrorCPassword);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorTelepon);
            Controls.Add(lblErrorKTP);
            Controls.Add(lblErrorNama);
            Controls.Add(alamat_text);
            Controls.Add(label5);
            Controls.Add(konfirm_text);
            Controls.Add(label13);
            Controls.Add(telepon_text);
            Controls.Add(label12);
            Controls.Add(password_text);
            Controls.Add(email_text);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(ktp_text);
            Controls.Add(nama_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputPelanggan_form";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)alamat_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)konfirm_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)telepon_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)password_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)email_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)ktp_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)nama_text).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private DhafaButton button_save;
        private DhafaButton button_cancel;
        private Label lblErrorAlamat;
        private Label lblErrorCPassword;
        private Label lblErrorPassword;
        private Label lblErrorEmail;
        private Label lblErrorTelepon;
        private Label lblErrorKTP;
        private Label lblErrorNama;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt alamat_text;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt konfirm_text;
        private Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt telepon_text;
        private Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt password_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt email_text;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ktp_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt nama_text;
        private Label label4;
        private Label label3;
    }
}