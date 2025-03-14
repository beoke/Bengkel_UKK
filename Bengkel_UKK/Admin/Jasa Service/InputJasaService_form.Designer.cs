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
            harga_label = new Label();
            promo_label = new Label();
            cancel_button = new Custom_Component.DhafaButton();
            keterangan_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            harga_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            promo_text = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label9 = new Label();
            label10 = new Label();
            save_button = new Custom_Component.DhafaButton();
            keterangan_label = new Label();
            header_label = new Label();
            ((System.ComponentModel.ISupportInitialize)keterangan_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)harga_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promo_text).BeginInit();
            SuspendLayout();
            // 
            // harga_label
            // 
            harga_label.AutoSize = true;
            harga_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            harga_label.ForeColor = Color.Red;
            harga_label.Location = new Point(149, 153);
            harga_label.Name = "harga_label";
            harga_label.Size = new Size(110, 17);
            harga_label.TabIndex = 96;
            harga_label.Text = "Harga wajib diisi*";
            harga_label.TextAlign = ContentAlignment.MiddleRight;
            harga_label.Visible = false;
            // 
            // promo_label
            // 
            promo_label.AutoSize = true;
            promo_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            promo_label.ForeColor = Color.Red;
            promo_label.Location = new Point(149, 92);
            promo_label.Name = "promo_label";
            promo_label.Size = new Size(146, 17);
            promo_label.TabIndex = 95;
            promo_label.Text = "Masukkan nama paket !";
            promo_label.TextAlign = ContentAlignment.MiddleRight;
            promo_label.Visible = false;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.Transparent;
            cancel_button.BackgroundColor = Color.Transparent;
            cancel_button.BorderColor = Color.PaleVioletRed;
            cancel_button.BorderRadius = 0;
            cancel_button.BorderSize = 2;
            cancel_button.FlatAppearance.BorderSize = 0;
            cancel_button.FlatStyle = FlatStyle.Flat;
            cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_button.ForeColor = SystemColors.ControlDarkDark;
            cancel_button.Location = new Point(199, 310);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(108, 36);
            cancel_button.TabIndex = 94;
            cancel_button.Text = "Cancel";
            cancel_button.TextColor = SystemColors.ControlDarkDark;
            cancel_button.UseVisualStyleBackColor = false;
            // 
            // keterangan_text
            // 
            keterangan_text.BackColor = Color.White;
            keterangan_text.BeforeTouchSize = new Size(275, 27);
            keterangan_text.BorderColor = Color.FromArgb(209, 211, 212);
            keterangan_text.BorderStyle = BorderStyle.FixedSingle;
            keterangan_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            keterangan_text.Location = new Point(149, 186);
            keterangan_text.Multiline = true;
            keterangan_text.Name = "keterangan_text";
            keterangan_text.PlaceholderText = " Masukkan keterangan ";
            keterangan_text.Size = new Size(275, 90);
            keterangan_text.TabIndex = 93;
            keterangan_text.ThemeName = "Default";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(17, 186);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 92;
            label5.Text = "Keterangan";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // harga_text
            // 
            harga_text.BackColor = Color.White;
            harga_text.BeforeTouchSize = new Size(275, 27);
            harga_text.BorderColor = Color.FromArgb(209, 211, 212);
            harga_text.BorderStyle = BorderStyle.FixedSingle;
            harga_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            harga_text.Location = new Point(149, 123);
            harga_text.Name = "harga_text";
            harga_text.PlaceholderText = " Masukkan harga";
            harga_text.Size = new Size(275, 27);
            harga_text.TabIndex = 88;
            harga_text.ThemeName = "Default";
            // 
            // promo_text
            // 
            promo_text.BackColor = Color.White;
            promo_text.BeforeTouchSize = new Size(275, 27);
            promo_text.BorderColor = Color.FromArgb(209, 211, 212);
            promo_text.BorderStyle = BorderStyle.FixedSingle;
            promo_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            promo_text.Location = new Point(149, 62);
            promo_text.Name = "promo_text";
            promo_text.PlaceholderText = "Contoh : promo ulang tahun";
            promo_text.Size = new Size(275, 27);
            promo_text.TabIndex = 87;
            promo_text.ThemeName = "Default";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(18, 125);
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
            label10.Location = new Point(13, 62);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 85;
            label10.Text = "Paket Service*";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // save_button
            // 
            save_button.BackColor = Color.FromArgb(52, 152, 219);
            save_button.BackgroundColor = Color.FromArgb(52, 152, 219);
            save_button.BorderColor = Color.PaleVioletRed;
            save_button.BorderRadius = 0;
            save_button.BorderSize = 0;
            save_button.FlatAppearance.BorderSize = 0;
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save_button.ForeColor = Color.White;
            save_button.Location = new Point(316, 310);
            save_button.Name = "save_button";
            save_button.Size = new Size(108, 36);
            save_button.TabIndex = 84;
            save_button.Text = "Save";
            save_button.TextColor = Color.White;
            save_button.UseVisualStyleBackColor = false;
            // 
            // keterangan_label
            // 
            keterangan_label.AutoSize = true;
            keterangan_label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            keterangan_label.ForeColor = Color.Red;
            keterangan_label.Location = new Point(149, 279);
            keterangan_label.Name = "keterangan_label";
            keterangan_label.Size = new Size(141, 17);
            keterangan_label.TabIndex = 97;
            keterangan_label.Text = "Keternagan wajib diisi*";
            keterangan_label.TextAlign = ContentAlignment.MiddleRight;
            keterangan_label.Visible = false;
            // 
            // header_label
            // 
            header_label.BackColor = Color.FromArgb(170, 0, 0);
            header_label.Dock = DockStyle.Top;
            header_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            header_label.ForeColor = Color.White;
            header_label.Location = new Point(0, 0);
            header_label.Name = "header_label";
            header_label.Size = new Size(448, 43);
            header_label.TabIndex = 98;
            header_label.Text = "Input Jasa Servis";
            header_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputJasaService_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 371);
            Controls.Add(header_label);
            Controls.Add(keterangan_label);
            Controls.Add(harga_label);
            Controls.Add(promo_label);
            Controls.Add(cancel_button);
            Controls.Add(keterangan_text);
            Controls.Add(label5);
            Controls.Add(harga_text);
            Controls.Add(promo_text);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(save_button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "InputJasaService_form";
            Text = "InputJasaService_form";
            ((System.ComponentModel.ISupportInitialize)keterangan_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)harga_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)promo_text).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label harga_label;
        private Label promo_label;
        private Custom_Component.DhafaButton cancel_button;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt keterangan_text;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt harga_text;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt promo_text;
        private Label label9;
        private Label label10;
        private Custom_Component.DhafaButton save_button;
        private Label keterangan_label;
        private Label header_label;
    }
}