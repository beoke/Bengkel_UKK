namespace Bengkel_UKK.Admin
{
    partial class form_DataKendaraan
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
            tambah_button = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // tambah_button
            // 
            tambah_button.Location = new Point(34, 72);
            tambah_button.Name = "tambah_button";
            tambah_button.Size = new Size(75, 23);
            tambah_button.TabIndex = 10;
            tambah_button.Text = "Tambah";
            tambah_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(34, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 542);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 8;
            label1.Text = "KENDARAAN";
            // 
            // form_DataKendaraan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1175, 684);
            Controls.Add(tambah_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_DataKendaraan";
            Text = "form_DataKendaraan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tambah_button;
        private Panel panel1;
        private Label label1;
    }
}