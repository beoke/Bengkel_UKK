namespace Bengkel_UKK
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Link_Registrasi = new LinkLabel();
            Text_Username = new TextBox();
            Text_Password = new TextBox();
            Button_Login = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Link_Registrasi);
            panel1.Controls.Add(Text_Username);
            panel1.Controls.Add(Text_Password);
            panel1.Controls.Add(Button_Login);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(249, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 362);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(120, 74);
            label4.Name = "label4";
            label4.Size = new Size(67, 33);
            label4.TabIndex = 11;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 186);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 130);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 302);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 5;
            label1.Text = "Belum Punya Akun?";
            // 
            // Link_Registrasi
            // 
            Link_Registrasi.AutoSize = true;
            Link_Registrasi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Link_Registrasi.Location = new Point(183, 302);
            Link_Registrasi.Name = "Link_Registrasi";
            Link_Registrasi.Size = new Size(78, 21);
            Link_Registrasi.TabIndex = 4;
            Link_Registrasi.TabStop = true;
            Link_Registrasi.Text = "Registrasi";
            // 
            // Text_Username
            // 
            Text_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Username.Location = new Point(42, 154);
            Text_Username.Name = "Text_Username";
            Text_Username.Size = new Size(219, 29);
            Text_Username.TabIndex = 3;
            // 
            // Text_Password
            // 
            Text_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text_Password.Location = new Point(42, 210);
            Text_Password.Name = "Text_Password";
            Text_Password.Size = new Size(219, 29);
            Text_Password.TabIndex = 2;
            // 
            // Button_Login
            // 
            Button_Login.Cursor = Cursors.IBeam;
            Button_Login.FlatStyle = FlatStyle.Popup;
            Button_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Login.Location = new Point(42, 272);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(219, 27);
            Button_Login.TabIndex = 1;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(120, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 51);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login_Form";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel Link_Registrasi;
        private TextBox Text_Username;
        private TextBox Text_Password;
        private Button Button_Login;
        private PictureBox pictureBox1;
    }
}
