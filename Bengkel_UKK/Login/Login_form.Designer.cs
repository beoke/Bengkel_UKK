namespace Bengkel_UKK.Login
{
    partial class Login_form
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
            label1 = new Label();
            Username_text = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lihat_button = new Button();
            Password_text = new TextBox();
            panel3 = new Panel();
            Sign_button = new Button();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 62);
            label1.Name = "label1";
            label1.Size = new Size(116, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // Username_text
            // 
            Username_text.BackColor = Color.FromArgb(254, 228, 216);
            Username_text.BorderStyle = BorderStyle.None;
            Username_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Username_text.ForeColor = Color.FromArgb(172, 154, 146);
            Username_text.Location = new Point(23, 16);
            Username_text.Name = "Username_text";
            Username_text.Size = new Size(213, 22);
            Username_text.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 228, 216);
            panel1.Controls.Add(Username_text);
            panel1.Location = new Point(31, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 53);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 228, 216);
            panel2.Controls.Add(lihat_button);
            panel2.Controls.Add(Password_text);
            panel2.Location = new Point(31, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 53);
            panel2.TabIndex = 2;
            // 
            // lihat_button
            // 
            lihat_button.BackColor = Color.FromArgb(254, 228, 216);
            lihat_button.BackgroundImage = Properties.Resources.eye;
            lihat_button.BackgroundImageLayout = ImageLayout.Center;
            lihat_button.FlatAppearance.BorderSize = 0;
            lihat_button.FlatStyle = FlatStyle.Flat;
            lihat_button.Location = new Point(223, 19);
            lihat_button.Name = "lihat_button";
            lihat_button.Size = new Size(34, 23);
            lihat_button.TabIndex = 1;
            lihat_button.UseVisualStyleBackColor = false;
            // 
            // Password_text
            // 
            Password_text.BackColor = Color.FromArgb(254, 228, 216);
            Password_text.BorderStyle = BorderStyle.None;
            Password_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_text.ForeColor = Color.FromArgb(172, 154, 146);
            Password_text.Location = new Point(23, 16);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(198, 22);
            Password_text.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(248, 81, 0);
            panel3.Controls.Add(Sign_button);
            panel3.Location = new Point(31, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 46);
            panel3.TabIndex = 3;
            // 
            // Sign_button
            // 
            Sign_button.BackColor = Color.FromArgb(248, 81, 0);
            Sign_button.FlatAppearance.BorderSize = 0;
            Sign_button.FlatStyle = FlatStyle.Flat;
            Sign_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Sign_button.ForeColor = SystemColors.ButtonHighlight;
            Sign_button.Location = new Point(16, 3);
            Sign_button.Name = "Sign_button";
            Sign_button.Size = new Size(230, 40);
            Sign_button.TabIndex = 5;
            Sign_button.Text = "Sign In";
            Sign_button.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 383);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 5;
            label4.Text = "Not Registered?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(260, 329);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 6;
            label5.Text = "Help";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(248, 81, 0);
            linkLabel1.Location = new Point(158, 383);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create account";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Blue;
            linkLabel2.Location = new Point(36, 329);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(332, 477);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_form";
            Load += Login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Username_text;
        private Panel panel1;
        private Panel panel2;
        private TextBox Password_text;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Button Sign_button;
        private LinkLabel linkLabel1;
        private Button lihat_button;
        private LinkLabel linkLabel2;
    }
}