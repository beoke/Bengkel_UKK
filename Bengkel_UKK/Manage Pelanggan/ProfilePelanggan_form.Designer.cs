namespace Bengkel_UKK.Admin.Pelanggan
{
    partial class ProfilePelanggan_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePelanggan_form));
            panel1 = new Panel();
            buttonSave = new Button();
            btn_edit = new Button();
            label1 = new Label();
            lblErrorAlamat = new Label();
            lblErrorTelepon = new Label();
            label8 = new Label();
            txtNoTelp = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            txtNoKTP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            lblErrorKTP = new Label();
            txtAlamat = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            lblErrorPassword = new Label();
            lblErrorEmail = new Label();
            label5 = new Label();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label3 = new Label();
            label2 = new Label();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            lblErrorNama = new Label();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNoTelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblErrorAlamat);
            panel1.Controls.Add(lblErrorTelepon);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtNoTelp);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtNoKTP);
            panel1.Controls.Add(lblErrorKTP);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(lblErrorPassword);
            panel1.Controls.Add(lblErrorEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(lblErrorNama);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 722);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGray;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(350, 29);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(35, 32);
            buttonSave.TabIndex = 152;
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.LightGray;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.White;
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(309, 29);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(35, 32);
            btn_edit.TabIndex = 151;
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1105, 31);
            label1.TabIndex = 150;
            label1.Text = "Profile Anda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorAlamat
            // 
            lblErrorAlamat.AutoSize = true;
            lblErrorAlamat.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorAlamat.ForeColor = Color.Red;
            lblErrorAlamat.Location = new Point(19, 551);
            lblErrorAlamat.Name = "lblErrorAlamat";
            lblErrorAlamat.Size = new Size(162, 17);
            lblErrorAlamat.TabIndex = 147;
            lblErrorAlamat.Text = "⚠️ Harap mengisi alamat!";
            lblErrorAlamat.TextAlign = ContentAlignment.MiddleRight;
            lblErrorAlamat.Visible = false;
            // 
            // lblErrorTelepon
            // 
            lblErrorTelepon.AutoSize = true;
            lblErrorTelepon.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTelepon.ForeColor = Color.Red;
            lblErrorTelepon.Location = new Point(19, 461);
            lblErrorTelepon.Name = "lblErrorTelepon";
            lblErrorTelepon.Size = new Size(218, 17);
            lblErrorTelepon.TabIndex = 146;
            lblErrorTelepon.Text = "⚠️ Nomor telepon sudah terdaftar!";
            lblErrorTelepon.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTelepon.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 403);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 145;
            label8.Text = "Nomor telepon";
            // 
            // txtNoTelp
            // 
            txtNoTelp.BeforeTouchSize = new Size(370, 31);
            txtNoTelp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoTelp.Location = new Point(19, 427);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.PlaceholderText = " Masukkan nomor telepon";
            txtNoTelp.ReadOnly = true;
            txtNoTelp.Size = new Size(370, 31);
            txtNoTelp.TabIndex = 144;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 493);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 143;
            label9.Text = "Alamat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(19, 313);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 142;
            label10.Text = "Nomor  KTP";
            // 
            // txtNoKTP
            // 
            txtNoKTP.BeforeTouchSize = new Size(370, 31);
            txtNoKTP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(19, 337);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.PlaceholderText = " Masukkan nomor KTP";
            txtNoKTP.ReadOnly = true;
            txtNoKTP.Size = new Size(370, 31);
            txtNoKTP.TabIndex = 139;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(19, 371);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(196, 17);
            lblErrorKTP.TabIndex = 141;
            lblErrorKTP.Text = "⚠️ Nomor KTP sudah terdaftar!";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // txtAlamat
            // 
            txtAlamat.BeforeTouchSize = new Size(370, 31);
            txtAlamat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(19, 517);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = " Masukkan alamat lengkap";
            txtAlamat.ReadOnly = true;
            txtAlamat.Size = new Size(370, 31);
            txtAlamat.TabIndex = 140;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(19, 281);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(374, 17);
            lblErrorPassword.TabIndex = 138;
            lblErrorPassword.Text = "⚠️ Password minimal 8 karakter, huruf besar, kecil, dan angka.";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(19, 191);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(173, 17);
            lblErrorEmail.TabIndex = 137;
            lblErrorEmail.Text = "⚠️ Format email tidak valid!";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 133);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 136;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(370, 31);
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(19, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Masukkan Email";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 135;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 223);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 134;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 133;
            label2.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.BeforeTouchSize = new Size(370, 31);
            txtNama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(19, 67);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Masukkan Nama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(370, 31);
            txtNama.TabIndex = 129;
            // 
            // lblErrorNama
            // 
            lblErrorNama.AutoSize = true;
            lblErrorNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNama.ForeColor = Color.Red;
            lblErrorNama.Location = new Point(19, 101);
            lblErrorNama.Name = "lblErrorNama";
            lblErrorNama.Size = new Size(155, 17);
            lblErrorNama.TabIndex = 132;
            lblErrorNama.Text = "⚠️ Harap mengisi nama!";
            lblErrorNama.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNama.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(370, 31);
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(19, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(370, 31);
            txtPassword.TabIndex = 130;
            // 
            // ProfilePelanggan_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 746);
            Controls.Add(panel1);
            Name = "ProfilePelanggan_form";
            Text = "PROFILE ANDA";
            Load += ProfilePelanggan_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNoTelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblErrorAlamat;
        private Label lblErrorTelepon;
        private Label label8;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoTelp;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNoKTP;
        private Label lblErrorKTP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAlamat;
        private Label lblErrorPassword;
        private Label lblErrorEmail;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Label label3;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNama;
        private Label lblErrorNama;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Button btn_edit;
        private Button buttonSave;
    }
}