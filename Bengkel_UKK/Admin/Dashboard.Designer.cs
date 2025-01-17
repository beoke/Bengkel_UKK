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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SideBar_Layout = new FlowLayoutPanel();
            panelDashoard = new Panel();
            Dashboard_button = new Button();
            panel2 = new Panel();
            button1 = new Button();
            Data_flowLayOut = new FlowLayoutPanel();
            panel7 = new Panel();
            button6 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SideBar_Layout.SuspendLayout();
            panelDashoard.SuspendLayout();
            panel2.SuspendLayout();
            Data_flowLayOut.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            // SideBar_Layout
            // 
            SideBar_Layout.BackColor = Color.Red;
            SideBar_Layout.Controls.Add(panelDashoard);
            SideBar_Layout.Dock = DockStyle.Left;
            SideBar_Layout.Location = new Point(0, 55);
            SideBar_Layout.Name = "SideBar_Layout";
            SideBar_Layout.Size = new Size(238, 395);
            SideBar_Layout.TabIndex = 1;
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
            panel2.Location = new Point(0, 153);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 51);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(234, 51);
            button1.TabIndex = 0;
            button1.Text = "            Sub Menu 3";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Data_flowLayOut
            // 
            Data_flowLayOut.Controls.Add(panel7);
            Data_flowLayOut.Controls.Add(panel6);
            Data_flowLayOut.Controls.Add(panel5);
            Data_flowLayOut.Controls.Add(panel2);
            Data_flowLayOut.Location = new Point(259, 61);
            Data_flowLayOut.Name = "Data_flowLayOut";
            Data_flowLayOut.Size = new Size(234, 204);
            Data_flowLayOut.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(button6);
            panel7.ForeColor = Color.Red;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 51);
            panel7.TabIndex = 8;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Red;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(234, 51);
            button6.TabIndex = 0;
            button6.Text = "            Data";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Controls.Add(button5);
            panel6.ForeColor = Color.Red;
            panel6.Location = new Point(0, 51);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 51);
            panel6.TabIndex = 7;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.Red;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(234, 51);
            button5.TabIndex = 0;
            button5.Text = "            Sub Menu 1";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(button4);
            panel5.ForeColor = Color.Red;
            panel5.Location = new Point(0, 102);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 51);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(234, 51);
            button4.TabIndex = 0;
            button4.Text = "            Sub Menu 2";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.Red;
            panel3.Location = new Point(259, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 51);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(234, 51);
            button2.TabIndex = 0;
            button2.Text = "            INFORMASI";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(button3);
            panel4.ForeColor = Color.Red;
            panel4.Location = new Point(259, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 51);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(234, 51);
            button3.TabIndex = 0;
            button3.Text = "            LOGOUT";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(Data_flowLayOut);
            Controls.Add(SideBar_Layout);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SideBar_Layout.ResumeLayout(false);
            panelDashoard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Data_flowLayOut.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel SideBar_Layout;
        private Panel panelDashoard;
        private Button Dashboard_button;
        private Panel panel2;
        private Button button1;
        private FlowLayoutPanel Data_flowLayOut;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private System.Windows.Forms.Timer MenuTransition;
    }
}