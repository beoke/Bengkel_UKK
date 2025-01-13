namespace Bengkel_UKK.Admin
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelDashoard = new Panel();
            Dashboard_button = new Button();
            panel2 = new Panel();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelDashoard.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 1;
            label1.Text = "BENGKEL TECNO DB";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Red;
            flowLayoutPanel1.Controls.Add(panelDashoard);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(238, 395);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panelDashoard
            // 
            panelDashoard.BackColor = Color.Black;
            panelDashoard.BackgroundImageLayout = ImageLayout.None;
            panelDashoard.Controls.Add(Dashboard_button);
            panelDashoard.Location = new Point(3, 3);
            panelDashoard.Name = "panelDashoard";
            panelDashoard.Size = new Size(234, 51);
            panelDashoard.TabIndex = 2;
            // 
            // Dashboard_button
            // 
            Dashboard_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Dashboard_button.BackColor = Color.Red;
            Dashboard_button.FlatAppearance.BorderSize = 0;
            Dashboard_button.FlatStyle = FlatStyle.Flat;
            Dashboard_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboard_button.ForeColor = SystemColors.ActiveCaptionText;
            Dashboard_button.Image = (Image)resources.GetObject("Dashboard_button.Image");
            Dashboard_button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_button.Location = new Point(0, 0);
            Dashboard_button.Name = "Dashboard_button";
            Dashboard_button.Padding = new Padding(15, 0, 0, 0);
            Dashboard_button.Size = new Size(234, 51);
            Dashboard_button.TabIndex = 0;
            Dashboard_button.Text = "            DASHBOARD";
            Dashboard_button.TextAlign = ContentAlignment.MiddleLeft;
            Dashboard_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(356, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 51);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(234, 51);
            button1.TabIndex = 0;
            button1.Text = "            MENU\r\n";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(332, 83);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(234, 166);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelDashoard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelDashoard;
        private Button Dashboard_button;
        private Panel panel2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}