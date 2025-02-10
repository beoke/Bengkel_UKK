namespace Bengkel_UKK.Admin
{
    partial class form_DataPelanggan
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
            button_tambah = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_tambah
            // 
            button_tambah.Location = new Point(36, 67);
            button_tambah.Name = "button_tambah";
            button_tambah.Size = new Size(83, 23);
            button_tambah.TabIndex = 7;
            button_tambah.Text = "Tambah";
            button_tambah.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(25, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 535);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 5;
            label1.Text = "Pelanggan";
            // 
            // form_DataPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 677);
            Controls.Add(button_tambah);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_DataPelanggan";
            Text = "form_DataPelanggan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_tambah;
        private Panel panel1;
        private Label label1;
    }
}