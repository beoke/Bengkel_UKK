﻿namespace Bengkel_UKK.Login
{
    partial class Form_Login
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
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnShowPassword = new Button();
            btn_masuk = new Button();
            lblErrorEmail = new Label();
            lblErrorPassword = new Label();
            panel1 = new Panel();
            linkRegister = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(325, 31);
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(37, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Masukkan Email";
            txtEmail.Size = new Size(325, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(325, 31);
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(37, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.Size = new Size(325, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Image = Properties.Resources.view1;
            btnShowPassword.Location = new Point(323, 199);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(38, 29);
            btnShowPassword.TabIndex = 2;
            btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // btn_masuk
            // 
            btn_masuk.BackColor = Color.Red;
            btn_masuk.FlatAppearance.BorderSize = 0;
            btn_masuk.FlatStyle = FlatStyle.Flat;
            btn_masuk.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_masuk.ForeColor = Color.White;
            btn_masuk.Location = new Point(37, 280);
            btn_masuk.Name = "btn_masuk";
            btn_masuk.Size = new Size(325, 36);
            btn_masuk.TabIndex = 3;
            btn_masuk.Text = "Masuk";
            btn_masuk.UseVisualStyleBackColor = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(37, 139);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(173, 17);
            lblErrorEmail.TabIndex = 102;
            lblErrorEmail.Text = "⚠️ Format email tidak valid!";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(37, 232);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(203, 17);
            lblErrorPassword.TabIndex = 103;
            lblErrorPassword.Text = "⚠️ Password tidak diketemukan !";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_masuk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblErrorPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblErrorEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(53, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 410);
            panel1.TabIndex = 104;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.Location = new Point(227, 340);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(44, 17);
            linkRegister.TabIndex = 108;
            linkRegister.TabStop = true;
            linkRegister.Text = "Daftar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(108, 340);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 107;
            label4.Text = "Belum punya akun?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 174);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 106;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 105;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(144, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "MASUK";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(260, 260);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 17);
            linkLabel1.TabIndex = 110;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Password?";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            ClientSize = new Size(502, 505);
            Controls.Add(panel1);
            Name = "Form_Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Button btnShowPassword;
        private Button btn_masuk;
        private Label lblErrorEmail;
        private Label lblErrorPassword;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private LinkLabel linkRegister;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}