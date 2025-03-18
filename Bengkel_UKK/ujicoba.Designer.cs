using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK
{
    partial class ujicoba
    {
        // </summary>
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            nNToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            InvoiceStripMenuItem = new ToolStripMenuItem();
            linkReset = new LinkLabel();
            label4 = new Label();
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
            btnRegister = new Button();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNoTelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { nNToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(188, 82);
            // 
            // nNToolStripMenuItem
            // 
            nNToolStripMenuItem.Name = "nNToolStripMenuItem";
            nNToolStripMenuItem.Size = new Size(187, 26);
            nNToolStripMenuItem.Text = "Detail Booking";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(187, 26);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(187, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.DropShadowEnabled = false;
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { InvoiceStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(134, 30);
            contextMenuStrip.ThemeName = "Office2016Colorful";
            contextMenuStrip.ThemeStyle.BackColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.DisabledForeColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.HoverBackColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.PressedBackColor = Color.FromArgb(52, 152, 219);
            // 
            // InvoiceStripMenuItem
            // 
            InvoiceStripMenuItem.Name = "InvoiceStripMenuItem";
            InvoiceStripMenuItem.Size = new Size(133, 26);
            InvoiceStripMenuItem.Text = "Invoice";
            // 
            // linkReset
            // 
            linkReset.AutoSize = true;
            linkReset.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            linkReset.Location = new Point(565, 210);
            linkReset.Name = "linkReset";
            linkReset.Size = new Size(40, 17);
            linkReset.TabIndex = 148;
            linkReset.TabStop = true;
            linkReset.Text = "Reset";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(457, 210);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 147;
            label4.Text = "Lupa password?";
            // 
            // lblErrorAlamat
            // 
            lblErrorAlamat.AutoSize = true;
            lblErrorAlamat.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorAlamat.ForeColor = Color.Red;
            lblErrorAlamat.Location = new Point(235, 535);
            lblErrorAlamat.Name = "lblErrorAlamat";
            lblErrorAlamat.Size = new Size(162, 17);
            lblErrorAlamat.TabIndex = 146;
            lblErrorAlamat.Text = "⚠️ Harap mengisi alamat!";
            lblErrorAlamat.TextAlign = ContentAlignment.MiddleRight;
            lblErrorAlamat.Visible = false;
            // 
            // lblErrorTelepon
            // 
            lblErrorTelepon.AutoSize = true;
            lblErrorTelepon.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTelepon.ForeColor = Color.Red;
            lblErrorTelepon.Location = new Point(235, 445);
            lblErrorTelepon.Name = "lblErrorTelepon";
            lblErrorTelepon.Size = new Size(218, 17);
            lblErrorTelepon.TabIndex = 145;
            lblErrorTelepon.Text = "⚠️ Nomor telepon sudah terdaftar!";
            lblErrorTelepon.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTelepon.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(235, 387);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 144;
            label8.Text = "Nomor telepon";
            // 
            // txtNoTelp
            // 
            txtNoTelp.BeforeTouchSize = new Size(370, 31);
            txtNoTelp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoTelp.Location = new Point(235, 411);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.PlaceholderText = " Masukkan nomor telepon";
            txtNoTelp.Size = new Size(370, 31);
            txtNoTelp.TabIndex = 143;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(235, 477);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 142;
            label9.Text = "Alamat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(235, 297);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 141;
            label10.Text = "Nomor  KTP";
            // 
            // txtNoKTP
            // 
            txtNoKTP.BeforeTouchSize = new Size(370, 31);
            txtNoKTP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(235, 321);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.PlaceholderText = " Masukkan nomor KTP";
            txtNoKTP.Size = new Size(370, 31);
            txtNoKTP.TabIndex = 138;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(235, 355);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(196, 17);
            lblErrorKTP.TabIndex = 140;
            lblErrorKTP.Text = "⚠️ Nomor KTP sudah terdaftar!";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // txtAlamat
            // 
            txtAlamat.BeforeTouchSize = new Size(370, 31);
            txtAlamat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(235, 501);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = " Masukkan alamat lengkap";
            txtAlamat.Size = new Size(370, 31);
            txtAlamat.TabIndex = 139;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(235, 265);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(374, 17);
            lblErrorPassword.TabIndex = 137;
            lblErrorPassword.Text = "⚠️ Password minimal 8 karakter, huruf besar, kecil, dan angka.";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(235, 175);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(173, 17);
            lblErrorEmail.TabIndex = 136;
            lblErrorEmail.Text = "⚠️ Format email tidak valid!";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(235, 117);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 135;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(370, 31);
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(235, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Masukkan Email";
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(235, 207);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 133;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(235, 27);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 132;
            label2.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.BeforeTouchSize = new Size(370, 31);
            txtNama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(235, 51);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Masukkan Nama";
            txtNama.Size = new Size(370, 31);
            txtNama.TabIndex = 129;
            // 
            // lblErrorNama
            // 
            lblErrorNama.AutoSize = true;
            lblErrorNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNama.ForeColor = Color.Red;
            lblErrorNama.Location = new Point(235, 85);
            lblErrorNama.Name = "lblErrorNama";
            lblErrorNama.Size = new Size(155, 17);
            lblErrorNama.TabIndex = 131;
            lblErrorNama.Text = "⚠️ Harap mengisi nama!";
            lblErrorNama.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNama.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(370, 31);
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(235, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(370, 31);
            txtPassword.TabIndex = 130;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(74, 92, 110);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(632, 51);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(138, 36);
            btnRegister.TabIndex = 149;
            btnRegister.Text = "Save";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // ujicoba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1397, 683);
            Controls.Add(btnRegister);
            Controls.Add(linkReset);
            Controls.Add(label4);
            Controls.Add(lblErrorAlamat);
            Controls.Add(lblErrorTelepon);
            Controls.Add(label8);
            Controls.Add(txtNoTelp);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtNoKTP);
            Controls.Add(lblErrorKTP);
            Controls.Add(txtAlamat);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorEmail);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNama);
            Controls.Add(lblErrorNama);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ujicoba";
            Text = "Tabel";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtNoTelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nNToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem InvoiceStripMenuItem;
        private LinkLabel linkReset;
        private Label label4;
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
        private Button btnRegister;
    }
}