namespace Bengkel_UKK.Admin.Jasa_Service
{
    partial class InputJasaService_form
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
            pass_label = new Label();
            email_label = new Label();
            btnCancel = new Custom_Component.DhafaButton();
            txtAlamat = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            btnSave = new Custom_Component.DhafaButton();
            ((System.ComponentModel.ISupportInitialize)txtAlamat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            SuspendLayout();
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pass_label.ForeColor = Color.Red;
            pass_label.Location = new Point(148, 103);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(110, 17);
            pass_label.TabIndex = 96;
            pass_label.Text = "Harga wajib diisi*";
            pass_label.TextAlign = ContentAlignment.MiddleRight;
            pass_label.Visible = false;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.ForeColor = Color.Red;
            email_label.Location = new Point(148, 42);
            email_label.Name = "email_label";
            email_label.Size = new Size(146, 17);
            email_label.TabIndex = 95;
            email_label.Text = "Masukkan nama paket !";
            email_label.TextAlign = ContentAlignment.MiddleRight;
            email_label.Visible = false;
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
            btnCancel.Location = new Point(198, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 36);
            btnCancel.TabIndex = 94;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = SystemColors.ControlDarkDark;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = Color.White;
            txtAlamat.BeforeTouchSize = new Size(275, 90);
            txtAlamat.BorderColor = Color.FromArgb(209, 211, 212);
            txtAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtAlamat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(148, 136);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = " Masukkan keterangan Paket";
            txtAlamat.Size = new Size(275, 90);
            txtAlamat.TabIndex = 93;
            txtAlamat.ThemeName = "Default";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(16, 136);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 92;
            label5.Text = "Keterangan";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BeforeTouchSize = new Size(275, 90);
            txtPassword.BorderColor = Color.FromArgb(209, 211, 212);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(148, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Masukkan password";
            txtPassword.Size = new Size(275, 27);
            txtPassword.TabIndex = 88;
            txtPassword.ThemeName = "Default";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BeforeTouchSize = new Size(275, 90);
            txtEmail.BorderColor = Color.FromArgb(209, 211, 212);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(148, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " ex: promo ringan";
            txtEmail.Size = new Size(275, 27);
            txtEmail.TabIndex = 87;
            txtEmail.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(17, 75);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 86;
            label9.Text = "Harga*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(12, 12);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 85;
            label10.Text = "Paket Service*";
            label10.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSave.Location = new Point(315, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 36);
            btnSave.TabIndex = 84;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // InputJasaService_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 324);
            Controls.Add(pass_label);
            Controls.Add(email_label);
            Controls.Add(btnCancel);
            Controls.Add(txtAlamat);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnSave);
            Name = "InputJasaService_form";
            Text = "InputJasaService_form";
            ((System.ComponentModel.ISupportInitialize)txtAlamat).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pass_label;
        private Label email_label;
        private Custom_Component.DhafaButton btnCancel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAlamat;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Label label9;
        private Label label10;
        private Custom_Component.DhafaButton btnSave;
    }
}