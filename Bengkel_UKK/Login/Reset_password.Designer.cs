namespace Bengkel_UKK.Login
{
    partial class Reset_password
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
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            lblErrorNama = new Label();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            btn_daftar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLogin = new LinkLabel();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            txtCPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label6 = new Label();
            lblErrorEmail = new Label();
            lblErrorPassword = new Label();
            lblErrorCPassword = new Label();
            txt_noKtp = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label8 = new Label();
            lblEror_ktp = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_noKtp).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(370, 31);
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(37, 377);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.Size = new Size(370, 31);
            txtPassword.TabIndex = 1;
            // 
            // lblErrorNama
            // 
            lblErrorNama.AutoSize = true;
            lblErrorNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNama.ForeColor = Color.Red;
            lblErrorNama.Location = new Point(37, 147);
            lblErrorNama.Name = "lblErrorNama";
            lblErrorNama.Size = new Size(177, 17);
            lblErrorNama.TabIndex = 102;
            lblErrorNama.Text = "⚠️ Format Nama tidak valid!";
            lblErrorNama.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNama.Visible = false;
            // 
            // txtNama
            // 
            txtNama.BeforeTouchSize = new Size(370, 31);
            txtNama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(37, 113);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Masukkan Nama";
            txtNama.Size = new Size(370, 31);
            txtNama.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(437, 37);
            label1.TabIndex = 0;
            label1.Text = "RESET PASSWORD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_daftar
            // 
            btn_daftar.BackColor = Color.Red;
            btn_daftar.FlatAppearance.BorderSize = 0;
            btn_daftar.FlatStyle = FlatStyle.Flat;
            btn_daftar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_daftar.ForeColor = Color.White;
            btn_daftar.Location = new Point(37, 565);
            btn_daftar.Name = "btn_daftar";
            btn_daftar.Size = new Size(370, 36);
            btn_daftar.TabIndex = 3;
            btn_daftar.Text = "Daftar";
            btn_daftar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 105;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 353);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 106;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 618);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 107;
            label4.Text = "Sudah punya akun?";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            linkLogin.Location = new Point(254, 618);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 17);
            linkLogin.TabIndex = 108;
            linkLogin.TabStop = true;
            linkLogin.Text = "Masuk";
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(370, 31);
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(37, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Masukkan Email";
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 109;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 179);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 111;
            label5.Text = "Email";
            // 
            // txtCPassword
            // 
            txtCPassword.BeforeTouchSize = new Size(370, 31);
            txtCPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPassword.Location = new Point(37, 467);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.PlaceholderText = " Masukkan Email";
            txtCPassword.Size = new Size(370, 31);
            txtCPassword.TabIndex = 114;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 443);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 115;
            label6.Text = "Konfirmasi Password";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(37, 237);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(173, 17);
            lblErrorEmail.TabIndex = 116;
            lblErrorEmail.Text = "⚠️ Format email tidak valid!";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(37, 411);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(374, 17);
            lblErrorPassword.TabIndex = 117;
            lblErrorPassword.Text = "⚠️ Password minimal 8 karakter, huruf besar, kecil, dan angka.";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // lblErrorCPassword
            // 
            lblErrorCPassword.AutoSize = true;
            lblErrorCPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCPassword.ForeColor = Color.Red;
            lblErrorCPassword.Location = new Point(37, 501);
            lblErrorCPassword.Name = "lblErrorCPassword";
            lblErrorCPassword.Size = new Size(173, 17);
            lblErrorCPassword.TabIndex = 118;
            lblErrorCPassword.Text = "⚠️ Format email tidak valid!";
            lblErrorCPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorCPassword.Visible = false;
            // 
            // txt_noKtp
            // 
            txt_noKtp.BeforeTouchSize = new Size(370, 31);
            txt_noKtp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_noKtp.Location = new Point(37, 289);
            txt_noKtp.Name = "txt_noKtp";
            txt_noKtp.PlaceholderText = "Masukkan No ktp";
            txt_noKtp.Size = new Size(370, 31);
            txt_noKtp.TabIndex = 119;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(37, 265);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 120;
            label8.Text = "No Ktp";
            // 
            // lblEror_ktp
            // 
            lblEror_ktp.AutoSize = true;
            lblEror_ktp.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblEror_ktp.ForeColor = Color.Red;
            lblEror_ktp.Location = new Point(37, 323);
            lblEror_ktp.Name = "lblEror_ktp";
            lblEror_ktp.Size = new Size(160, 17);
            lblEror_ktp.TabIndex = 121;
            lblEror_ktp.Text = "⚠️ Format ktp tidak valid!";
            lblEror_ktp.TextAlign = ContentAlignment.MiddleRight;
            lblEror_ktp.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblEror_ktp);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_noKtp);
            panel1.Controls.Add(lblErrorCPassword);
            panel1.Controls.Add(lblErrorPassword);
            panel1.Controls.Add(lblErrorEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(linkLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_daftar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(lblErrorNama);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(37, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 660);
            panel1.TabIndex = 105;
            // 
            // Reset_password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            ClientSize = new Size(528, 702);
            Controls.Add(panel1);
            Name = "Reset_password";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_noKtp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Label lblErrorNama;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNama;
        private Label label1;
        private Button btn_daftar;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCPassword;
        private Label label6;
        private Label lblErrorEmail;
        private Label lblErrorPassword;
        private Label lblErrorCPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_noKtp;
        private Label label8;
        private Label lblEror_ktp;
        private Panel panel1;
    }
}