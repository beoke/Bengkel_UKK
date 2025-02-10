namespace Bengkel_UKK.Admin.Data
{
    partial class form_Booking
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
            booking_button = new Button();
            panel1 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // booking_button
            // 
            booking_button.Location = new Point(23, 62);
            booking_button.Name = "booking_button";
            booking_button.Size = new Size(84, 29);
            booking_button.TabIndex = 10;
            booking_button.Text = "Tambah";
            booking_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(12, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 467);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 8;
            label2.Text = "Booking";
            // 
            // form_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 582);
            Controls.Add(booking_button);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "form_Booking";
            Text = "form_Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button booking_button;
        private Panel panel1;
        private Label label2;
    }
}