namespace Bengkel_UKK
{
    partial class Registrasi_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrasi_Form));
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            Text_Email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Text_Username = new TextBox();
            Text_Password = new TextBox();
            Button_Registrasi = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Text_Email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Text_Username);
            panel1.Controls.Add(Text_Password);
            panel1.Controls.Add(Button_Registrasi);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(253, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 378);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 60);
            label1.Name = "label1";
            label1.Size = new Size(106, 33);
            label1.TabIndex = 10;
            label1.Text = "Registrasi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 96);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // Text_Email
            // 
            Text_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Email.Location = new Point(45, 119);
            Text_Email.Name = "Text_Email";
            Text_Email.Size = new Size(204, 27);
            Text_Email.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 214);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 155);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // Text_Username
            // 
            Text_Username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Username.Location = new Point(45, 175);
            Text_Username.Name = "Text_Username";
            Text_Username.Size = new Size(204, 27);
            Text_Username.TabIndex = 3;
            // 
            // Text_Password
            // 
            Text_Password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Password.Location = new Point(45, 237);
            Text_Password.Name = "Text_Password";
            Text_Password.Size = new Size(204, 27);
            Text_Password.TabIndex = 2;
            // 
            // Button_Registrasi
            // 
            Button_Registrasi.Cursor = Cursors.IBeam;
            Button_Registrasi.FlatStyle = FlatStyle.Popup;
            Button_Registrasi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Registrasi.Location = new Point(45, 289);
            Button_Registrasi.Name = "Button_Registrasi";
            Button_Registrasi.Size = new Size(204, 27);
            Button_Registrasi.TabIndex = 1;
            Button_Registrasi.Text = "Registrasi";
            Button_Registrasi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(124, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 43);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registrasi_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Registrasi_Form";
            Text = "Registrasi_Form";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox Text_Email;
        private Label label3;
        private Label label2;
        private TextBox Text_Username;
        private TextBox Text_Password;
        private Button Button_Registrasi;
        private PictureBox pictureBox1;
    }
}