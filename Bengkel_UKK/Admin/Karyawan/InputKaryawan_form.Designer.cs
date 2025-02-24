using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Karyawan
{
    partial class InputKaryawan_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputKaryawan_form));
            panel1 = new Panel();
            lblHeader = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnSave = new DhafaButton();
            txtNoKTP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            txtTelepon = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label12 = new Label();
            txtKonfirPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label13 = new Label();
            label2 = new Label();
            txtAlamat = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            btnCancel = new DhafaButton();
            pictureBoxProfile = new RJCircularPictureBox();
            btnChooseFile = new DhafaButton();
            DhafaPanel1 = new DhafaPanel();
            nama_label = new Label();
            noKtp_label = new Label();
            telp_label = new Label();
            email_label = new Label();
            pass_label = new Label();
            confirm_label = new Label();
            comboPegawai = new ComboBox();
            foto_label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelepon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKonfirPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            DhafaPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 42);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(52, 152, 219);
            lblHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(937, 43);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Input Pegawai";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(25, 271);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 15;
            label3.Text = "Nama*";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(25, 348);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 24;
            label4.Text = "No KTP*";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.BeforeTouchSize = new Size(293, 90);
            txtNama.BorderColor = Color.FromArgb(209, 211, 212);
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(139, 271);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Masukkan nama";
            txtNama.Size = new Size(293, 27);
            txtNama.TabIndex = 26;
            txtNama.ThemeName = "Default";
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
            btnSave.Location = new Point(804, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 36);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtNoKTP
            // 
            txtNoKTP.BackColor = Color.White;
            txtNoKTP.BeforeTouchSize = new Size(293, 90);
            txtNoKTP.BorderColor = Color.FromArgb(209, 211, 212);
            txtNoKTP.BorderStyle = BorderStyle.FixedSingle;
            txtNoKTP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(139, 348);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.PlaceholderText = " Masukkan nomor KTP";
            txtNoKTP.Size = new Size(293, 27);
            txtNoKTP.TabIndex = 39;
            txtNoKTP.ThemeName = "Default";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BeforeTouchSize = new Size(293, 90);
            txtPassword.BorderColor = Color.FromArgb(209, 211, 212);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(619, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.Size = new Size(293, 27);
            txtPassword.TabIndex = 52;
            txtPassword.ThemeName = "Default";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BeforeTouchSize = new Size(293, 90);
            txtEmail.BorderColor = Color.FromArgb(209, 211, 212);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(619, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " ex: nama@gmail.com";
            txtEmail.Size = new Size(293, 27);
            txtEmail.TabIndex = 51;
            txtEmail.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(505, 151);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 50;
            label9.Text = "Password*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(505, 74);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 49;
            label10.Text = "Email*";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTelepon
            // 
            txtTelepon.BackColor = Color.White;
            txtTelepon.BeforeTouchSize = new Size(293, 90);
            txtTelepon.BorderColor = Color.FromArgb(209, 211, 212);
            txtTelepon.BorderStyle = BorderStyle.FixedSingle;
            txtTelepon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelepon.Location = new Point(139, 425);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.PlaceholderText = " Masukkan nomor telepon";
            txtTelepon.Size = new Size(293, 27);
            txtTelepon.TabIndex = 55;
            txtTelepon.ThemeName = "Default";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(25, 425);
            label12.Name = "label12";
            label12.Size = new Size(116, 25);
            label12.TabIndex = 53;
            label12.Text = "No Telepon*";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKonfirPassword
            // 
            txtKonfirPassword.BackColor = Color.White;
            txtKonfirPassword.BeforeTouchSize = new Size(293, 90);
            txtKonfirPassword.BorderColor = Color.FromArgb(209, 211, 212);
            txtKonfirPassword.BorderStyle = BorderStyle.FixedSingle;
            txtKonfirPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKonfirPassword.Location = new Point(619, 228);
            txtKonfirPassword.Name = "txtKonfirPassword";
            txtKonfirPassword.PlaceholderText = " Masukkan konfirmasi password";
            txtKonfirPassword.Size = new Size(293, 27);
            txtKonfirPassword.TabIndex = 58;
            txtKonfirPassword.ThemeName = "Default";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(505, 215);
            label13.Name = "label13";
            label13.Size = new Size(106, 50);
            label13.TabIndex = 57;
            label13.Text = "Konfirmasi \r\nPassword*";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(505, 419);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 59;
            label2.Text = "Jabatan*";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = Color.White;
            txtAlamat.BeforeTouchSize = new Size(293, 90);
            txtAlamat.BorderColor = Color.FromArgb(209, 211, 212);
            txtAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtAlamat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(619, 305);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = " Masukkan alamat";
            txtAlamat.Size = new Size(293, 90);
            txtAlamat.TabIndex = 61;
            txtAlamat.ThemeName = "Default";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(505, 305);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 60;
            label5.Text = "Alamat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            btnCancel.Location = new Point(687, 504);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 36);
            btnCancel.TabIndex = 62;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = SystemColors.ControlDarkDark;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureBoxProfile.BorderColor = Color.RoyalBlue;
            pictureBoxProfile.BorderColor2 = Color.HotPink;
            pictureBoxProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureBoxProfile.BorderSize = 2;
            pictureBoxProfile.GradientAngle = 50F;
            pictureBoxProfile.Image = (Image)resources.GetObject("pictureBoxProfile.Image");
            pictureBoxProfile.Location = new Point(63, 11);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(106, 106);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 63;
            pictureBoxProfile.TabStop = false;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.FromArgb(230, 126, 34);
            btnChooseFile.BackgroundColor = Color.FromArgb(230, 126, 34);
            btnChooseFile.BorderColor = Color.PaleVioletRed;
            btnChooseFile.BorderRadius = 0;
            btnChooseFile.BorderSize = 0;
            btnChooseFile.FlatAppearance.BorderSize = 0;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.ForeColor = Color.White;
            btnChooseFile.Location = new Point(76, 128);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(82, 27);
            btnChooseFile.TabIndex = 64;
            btnChooseFile.Text = "Upload Foto";
            btnChooseFile.TextColor = Color.White;
            btnChooseFile.UseVisualStyleBackColor = false;
            // 
            // DhafaPanel1
            // 
            DhafaPanel1.BackColor = Color.White;
            DhafaPanel1.BorderColor = Color.PaleVioletRed;
            DhafaPanel1.BorderRadius = 0;
            DhafaPanel1.BorderSize = 0;
            DhafaPanel1.Controls.Add(pictureBoxProfile);
            DhafaPanel1.Controls.Add(btnChooseFile);
            DhafaPanel1.ForeColor = Color.White;
            DhafaPanel1.Location = new Point(139, 61);
            DhafaPanel1.Name = "DhafaPanel1";
            DhafaPanel1.Size = new Size(232, 169);
            DhafaPanel1.TabIndex = 65;
            // 
            // nama_label
            // 
            nama_label.AutoSize = true;
            nama_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            nama_label.ForeColor = Color.Red;
            nama_label.Location = new Point(139, 301);
            nama_label.Name = "nama_label";
            nama_label.Size = new Size(109, 17);
            nama_label.TabIndex = 77;
            nama_label.Text = "Nama wajib diisi*";
            nama_label.TextAlign = ContentAlignment.MiddleRight;
            nama_label.Visible = false;
            // 
            // noKtp_label
            // 
            noKtp_label.AutoSize = true;
            noKtp_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            noKtp_label.ForeColor = Color.Red;
            noKtp_label.Location = new Point(139, 378);
            noKtp_label.Name = "noKtp_label";
            noKtp_label.Size = new Size(118, 17);
            noKtp_label.TabIndex = 78;
            noKtp_label.Text = "No KTP wajib diisi*";
            noKtp_label.TextAlign = ContentAlignment.MiddleRight;
            noKtp_label.Visible = false;
            // 
            // telp_label
            // 
            telp_label.AutoSize = true;
            telp_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            telp_label.ForeColor = Color.Red;
            telp_label.Location = new Point(139, 455);
            telp_label.Name = "telp_label";
            telp_label.Size = new Size(120, 17);
            telp_label.TabIndex = 79;
            telp_label.Text = "Telepon wajib diisi*";
            telp_label.TextAlign = ContentAlignment.MiddleRight;
            telp_label.Visible = false;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.ForeColor = Color.Red;
            email_label.Location = new Point(619, 104);
            email_label.Name = "email_label";
            email_label.Size = new Size(172, 17);
            email_label.TabIndex = 80;
            email_label.Text = "Masukkan email yang valid !";
            email_label.TextAlign = ContentAlignment.MiddleRight;
            email_label.Visible = false;
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pass_label.ForeColor = Color.Red;
            pass_label.Location = new Point(619, 181);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(130, 17);
            pass_label.TabIndex = 81;
            pass_label.Text = "Password wajib diisi*";
            pass_label.TextAlign = ContentAlignment.MiddleRight;
            pass_label.Visible = false;
            // 
            // confirm_label
            // 
            confirm_label.AutoSize = true;
            confirm_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_label.ForeColor = Color.Red;
            confirm_label.Location = new Point(619, 258);
            confirm_label.Name = "confirm_label";
            confirm_label.Size = new Size(196, 17);
            confirm_label.TabIndex = 82;
            confirm_label.Text = "Konfirmasi Password wajib diisi*";
            confirm_label.TextAlign = ContentAlignment.MiddleRight;
            confirm_label.Visible = false;
            // 
            // comboPegawai
            // 
            comboPegawai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPegawai.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboPegawai.FormattingEnabled = true;
            comboPegawai.Location = new Point(619, 419);
            comboPegawai.Name = "comboPegawai";
            comboPegawai.Size = new Size(293, 28);
            comboPegawai.TabIndex = 83;
            // 
            // foto_label
            // 
            foto_label.AutoSize = true;
            foto_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            foto_label.ForeColor = Color.Red;
            foto_label.Location = new Point(202, 233);
            foto_label.Name = "foto_label";
            foto_label.Size = new Size(124, 17);
            foto_label.TabIndex = 84;
            foto_label.Text = "Foto Diri wajib diisi*";
            foto_label.TextAlign = ContentAlignment.MiddleRight;
            foto_label.Visible = false;
            // 
            // InputKaryawan_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 561);
            Controls.Add(foto_label);
            Controls.Add(comboPegawai);
            Controls.Add(confirm_label);
            Controls.Add(pass_label);
            Controls.Add(email_label);
            Controls.Add(telp_label);
            Controls.Add(noKtp_label);
            Controls.Add(nama_label);
            Controls.Add(DhafaPanel1);
            Controls.Add(btnCancel);
            Controls.Add(txtAlamat);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtKonfirPassword);
            Controls.Add(label13);
            Controls.Add(txtTelepon);
            Controls.Add(label12);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtNoKTP);
            Controls.Add(btnSave);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputKaryawan_form";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelepon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKonfirPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            DhafaPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label label3;
        private Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNama;
        private DhafaButton btnSave;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoKTP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTelepon;
        private Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKonfirPassword;
        private Label label13;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAlamat;
        private Label label5;
        private DhafaButton btnCancel;
        private RJCircularPictureBox pictureBoxProfile;
        private DhafaButton btnChooseFile;
        private DhafaPanel DhafaPanel1;
        private Label nama_label;
        private Label noKtp_label;
        private Label telp_label;
        private Label email_label;
        private Label pass_label;
        private Label confirm_label;
        private ComboBox comboPegawai;
        private Label foto_label;
    }
}