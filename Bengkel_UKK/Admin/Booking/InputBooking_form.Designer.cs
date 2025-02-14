using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Booking
{
    partial class InputBooking_form
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblHeader = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNama = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnSave = new DhafaButton();
            txtNoKTP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label12 = new Label();
            yogaButton1 = new DhafaButton();
            label16 = new Label();
            btnSearch = new DhafaButton();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label6 = new Label();
            textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            dateTimePickerAdv1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTimePickerAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTimePickerAdv1.Calendar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 42);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(52, 152, 219);
            lblHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(470, 43);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Input Booking";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(28, 74);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 15;
            label3.Text = "No KTP*";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(28, 151);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 24;
            label4.Text = "Nama*";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.BeforeTouchSize = new Size(100, 23);
            txtNama.BorderColor = Color.FromArgb(176, 176, 176);
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(142, 74);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = " Cari pelanggan dengan KTP";
            txtNama.Size = new Size(240, 27);
            txtNama.TabIndex = 26;
            txtNama.ThemeName = "Default";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.BackgroundColor = Color.FromArgb(52, 152, 219);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 0;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(350, 622);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 36);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtNoKTP
            // 
            txtNoKTP.BackColor = Color.FromArgb(230, 247, 255);
            txtNoKTP.BeforeTouchSize = new Size(100, 23);
            txtNoKTP.BorderColor = Color.FromArgb(176, 176, 176);
            txtNoKTP.BorderStyle = BorderStyle.FixedSingle;
            txtNoKTP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoKTP.Location = new Point(142, 151);
            txtNoKTP.Name = "txtNoKTP";
            txtNoKTP.ReadOnly = true;
            txtNoKTP.Size = new Size(293, 27);
            txtNoKTP.TabIndex = 39;
            txtNoKTP.ThemeName = "Default";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(28, 263);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 53;
            label12.Text = "Kendaraan";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yogaButton1
            // 
            yogaButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            yogaButton1.BackColor = Color.Transparent;
            yogaButton1.BackgroundColor = Color.Transparent;
            yogaButton1.BorderColor = Color.PaleVioletRed;
            yogaButton1.BorderRadius = 0;
            yogaButton1.BorderSize = 2;
            yogaButton1.FlatAppearance.BorderSize = 0;
            yogaButton1.FlatStyle = FlatStyle.Flat;
            yogaButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            yogaButton1.ForeColor = SystemColors.ControlDarkDark;
            yogaButton1.Location = new Point(233, 622);
            yogaButton1.Name = "yogaButton1";
            yogaButton1.Size = new Size(108, 36);
            yogaButton1.TabIndex = 62;
            yogaButton1.Text = "Cancel";
            yogaButton1.TextColor = SystemColors.ControlDarkDark;
            yogaButton1.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(142, 104);
            label16.Name = "label16";
            label16.Size = new Size(131, 17);
            label16.TabIndex = 77;
            label16.Text = "⚠️ Nama wajib diisi*";
            label16.TextAlign = ContentAlignment.MiddleRight;
            label16.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(230, 126, 34);
            btnSearch.BackgroundColor = Color.FromArgb(230, 126, 34);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(388, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(47, 27);
            btnSearch.TabIndex = 84;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxExt1
            // 
            textBoxExt1.BackColor = Color.FromArgb(230, 247, 255);
            textBoxExt1.BeforeTouchSize = new Size(100, 23);
            textBoxExt1.BorderColor = Color.FromArgb(176, 176, 176);
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt1.Location = new Point(142, 340);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.ReadOnly = true;
            textBoxExt1.Size = new Size(293, 27);
            textBoxExt1.TabIndex = 86;
            textBoxExt1.ThemeName = "Default";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(28, 340);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 85;
            label1.Text = "No Pol";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxExt2
            // 
            textBoxExt2.BackColor = Color.FromArgb(230, 247, 255);
            textBoxExt2.BeforeTouchSize = new Size(100, 23);
            textBoxExt2.BorderColor = Color.FromArgb(176, 176, 176);
            textBoxExt2.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt2.Location = new Point(142, 417);
            textBoxExt2.Name = "textBoxExt2";
            textBoxExt2.ReadOnly = true;
            textBoxExt2.Size = new Size(293, 27);
            textBoxExt2.TabIndex = 88;
            textBoxExt2.ThemeName = "Default";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(28, 417);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 87;
            label6.Text = "Tanggal";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxExt3
            // 
            textBoxExt3.BackColor = Color.White;
            textBoxExt3.BeforeTouchSize = new Size(100, 23);
            textBoxExt3.BorderColor = Color.FromArgb(176, 176, 176);
            textBoxExt3.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt3.Location = new Point(142, 494);
            textBoxExt3.Multiline = true;
            textBoxExt3.Name = "textBoxExt3";
            textBoxExt3.PlaceholderText = " Masukkan Keluhan";
            textBoxExt3.Size = new Size(293, 90);
            textBoxExt3.TabIndex = 90;
            textBoxExt3.ThemeName = "Default";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(28, 494);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 89;
            label8.Text = "Keluhan";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 28);
            comboBox1.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(142, 294);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 92;
            label2.Text = "Nama wajib diisi*";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(142, 587);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 93;
            label5.Text = "Nama wajib diisi*";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Visible = false;
            // 
            // dateTimePickerAdv1
            // 
            dateTimePickerAdv1.BorderColor = Color.Empty;
            // 
            // 
            // 
            dateTimePickerAdv1.Calendar.AllowMultipleSelection = false;
            dateTimePickerAdv1.Calendar.BottomHeight = 25;
            dateTimePickerAdv1.Calendar.DayNamesFont = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerAdv1.Calendar.DaysFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAdv1.Calendar.Dock = DockStyle.Fill;
            dateTimePickerAdv1.Calendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAdv1.Calendar.HeaderFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerAdv1.Calendar.Location = new Point(0, 0);
            dateTimePickerAdv1.Calendar.MetroColor = Color.FromArgb(22, 165, 220);
            dateTimePickerAdv1.Calendar.Name = "monthCalendar";
            // 
            // 
            // 
            dateTimePickerAdv1.Calendar.NoneButton.AutoSize = true;
            dateTimePickerAdv1.Calendar.NoneButton.Location = new Point(134, 0);
            dateTimePickerAdv1.Calendar.NoneButton.Text = "None";
            dateTimePickerAdv1.Calendar.Size = new Size(206, 174);
            dateTimePickerAdv1.Calendar.SizeToFit = true;
            dateTimePickerAdv1.Calendar.TabIndex = 0;
            // 
            // 
            // 
            dateTimePickerAdv1.Calendar.TodayButton.AutoSize = true;
            dateTimePickerAdv1.Calendar.TodayButton.Location = new Point(0, 0);
            dateTimePickerAdv1.Calendar.TodayButton.Text = "Today";
            dateTimePickerAdv1.CalendarSize = new Size(189, 176);
            dateTimePickerAdv1.DropDownImage = null;
            dateTimePickerAdv1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAdv1.Location = new Point(157, 196);
            dateTimePickerAdv1.MetroColor = Color.FromArgb(22, 165, 220);
            dateTimePickerAdv1.MinValue = new DateTime(0L);
            dateTimePickerAdv1.Name = "dateTimePickerAdv1";
            dateTimePickerAdv1.Size = new Size(232, 20);
            dateTimePickerAdv1.TabIndex = 94;
            dateTimePickerAdv1.Value = new DateTime(2025, 2, 12, 13, 21, 55, 391);
            // 
            // InputBooking_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(470, 670);
            Controls.Add(dateTimePickerAdv1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBoxExt3);
            Controls.Add(label8);
            Controls.Add(textBoxExt2);
            Controls.Add(label6);
            Controls.Add(textBoxExt1);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(label16);
            Controls.Add(yogaButton1);
            Controls.Add(label12);
            Controls.Add(txtNoKTP);
            Controls.Add(btnSave);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputBooking_form";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtNama).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNoKTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxExt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTimePickerAdv1.Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTimePickerAdv1).EndInit();
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
        private Label label12;
        private DhafaButton yogaButton1;
        private Label label16;
        private DhafaButton btnSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
        private Label label8;
        private ComboBox comboBox1;
        private Label label2;
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv1;
    }
}