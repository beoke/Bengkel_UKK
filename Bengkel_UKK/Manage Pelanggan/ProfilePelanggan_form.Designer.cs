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
            label6 = new Label();
            panel2 = new Panel();
            btn_tambah = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            buttonSave = new Button();
            btn_edit = new Button();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoTelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 100);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 176;
            label6.Text = "label6";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_tambah);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(449, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 517);
            panel2.TabIndex = 175;
            // 
            // btn_tambah
            // 
            btn_tambah.Location = new Point(553, 474);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(75, 23);
            btn_tambah.TabIndex = 2;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 424);
            dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(645, 33);
            label4.TabIndex = 0;
            label4.Text = "KENDARAAN ANDA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGray;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(366, 80);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(35, 32);
            buttonSave.TabIndex = 174;
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
            btn_edit.Location = new Point(325, 80);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(35, 32);
            btn_edit.TabIndex = 173;
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // lblErrorAlamat
            // 
            lblErrorAlamat.AutoSize = true;
            lblErrorAlamat.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorAlamat.ForeColor = Color.Red;
            lblErrorAlamat.Location = new Point(35, 602);
            lblErrorAlamat.Name = "lblErrorAlamat";
            lblErrorAlamat.Size = new Size(162, 17);
            lblErrorAlamat.TabIndex = 172;
            lblErrorAlamat.Text = "⚠️ Harap mengisi alamat!";
            lblErrorAlamat.TextAlign = ContentAlignment.MiddleRight;
            lblErrorAlamat.Visible = false;
            // 
            // lblErrorTelepon
            // 
            lblErrorTelepon.AutoSize = true;
            lblErrorTelepon.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTelepon.ForeColor = Color.Red;
            lblErrorTelepon.Location = new Point(35, 512);
            lblErrorTelepon.Name = "lblErrorTelepon";
            lblErrorTelepon.Size = new Size(218, 17);
            lblErrorTelepon.TabIndex = 171;
            lblErrorTelepon.Text = "⚠️ Nomor telepon sudah terdaftar!";
            lblErrorTelepon.TextAlign = ContentAlignment.MiddleRight;
            lblErrorTelepon.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 454);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 170;
            label8.Text = "Nomor telepon";
            // 
            // txtNoTelp
            // 
            txtNoTelp.BeforeTouchSize = new Size(370, 31);
            txtNoTelp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoTelp.Location = new Point(35, 478);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.PlaceholderText = " Masukkan nomor telepon";
            txtNoTelp.ReadOnly = true;
            txtNoTelp.Size = new Size(370, 31);
            txtNoTelp.TabIndex = 169;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 544);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 168;
            label9.Text = "Alamat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(35, 364);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 167;
            label10.Text = "Nomor  KTP";
            // 
            // txtNoKTP
            // 
            txtNoKTP.BeforeTouchSize = new Size(370, 31);
            txtNoKTP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(35, 388);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.PlaceholderText = " Masukkan nomor KTP";
            txtNoKTP.ReadOnly = true;
            txtNoKTP.Size = new Size(370, 31);
            txtNoKTP.TabIndex = 164;
            // 
            // lblErrorKTP
            // 
            lblErrorKTP.AutoSize = true;
            lblErrorKTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorKTP.ForeColor = Color.Red;
            lblErrorKTP.Location = new Point(35, 422);
            lblErrorKTP.Name = "lblErrorKTP";
            lblErrorKTP.Size = new Size(196, 17);
            lblErrorKTP.TabIndex = 166;
            lblErrorKTP.Text = "⚠️ Nomor KTP sudah terdaftar!";
            lblErrorKTP.TextAlign = ContentAlignment.MiddleRight;
            lblErrorKTP.Visible = false;
            // 
            // txtAlamat
            // 
            txtAlamat.BeforeTouchSize = new Size(370, 31);
            txtAlamat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(35, 568);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = " Masukkan alamat lengkap";
            txtAlamat.ReadOnly = true;
            txtAlamat.Size = new Size(370, 31);
            txtAlamat.TabIndex = 165;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(35, 332);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(374, 17);
            lblErrorPassword.TabIndex = 163;
            lblErrorPassword.Text = "⚠️ Password minimal 8 karakter, huruf besar, kecil, dan angka.";
            lblErrorPassword.TextAlign = ContentAlignment.MiddleRight;
            lblErrorPassword.Visible = false;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(35, 242);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(173, 17);
            lblErrorEmail.TabIndex = 162;
            lblErrorEmail.Text = "⚠️ Format email tidak valid!";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
            lblErrorEmail.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 184);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 161;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(370, 31);
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(35, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Masukkan Email";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 160;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 274);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 159;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 94);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 158;
            label2.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.BeforeTouchSize = new Size(370, 31);
            txtNama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(35, 118);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Masukkan Nama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(370, 31);
            txtNama.TabIndex = 155;
            // 
            // lblErrorNama
            // 
            lblErrorNama.AutoSize = true;
            lblErrorNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNama.ForeColor = Color.Red;
            lblErrorNama.Location = new Point(35, 152);
            lblErrorNama.Name = "lblErrorNama";
            lblErrorNama.Size = new Size(155, 17);
            lblErrorNama.TabIndex = 157;
            lblErrorNama.Text = "⚠️ Harap mengisi nama!";
            lblErrorNama.TextAlign = ContentAlignment.MiddleRight;
            lblErrorNama.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(370, 31);
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(35, 298);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(370, 31);
            txtPassword.TabIndex = 156;
            // 
            // ProfilePelanggan_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1129, 699);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(buttonSave);
            Controls.Add(btn_edit);
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
            ForeColor = Color.Black;
            Name = "ProfilePelanggan_form";
            Text = "PROFILE ANDA";
            Load += ProfilePelanggan_form_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        private Label label6;
        private Panel panel2;
        private Button btn_tambah;
        private DataGridView dataGridView1;
        private Label label4;
        private Button buttonSave;
        private Button btn_edit;
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
    }
}