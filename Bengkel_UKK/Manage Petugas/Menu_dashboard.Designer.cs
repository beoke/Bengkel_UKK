using Bengkel_UKK.Admin.Dashboard;
using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Manage_Petugas
{
    partial class Menu_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_dashboard));
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Panel3 = new DhafaPanel();
            label8 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            Panel2 = new DhafaPanel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            Panel1 = new DhafaPanel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dhafapanel = new DhafaPanel();
            sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            label14 = new Label();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            yogaPanel6 = new DhafaPanel();
            label15 = new Label();
            chartControlPie = new Syncfusion.Windows.Forms.Chart.ChartControl();
            tableLayoutPanel1.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            dhafapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sfComboBox1).BeginInit();
            yogaPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 10;
            label2.Text = "DASHBOARD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(Panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(Panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(30, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1194, 197);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(244, 207, 73);
            Panel3.BorderColor = Color.PaleVioletRed;
            Panel3.BorderRadius = 5;
            Panel3.BorderSize = 0;
            Panel3.Controls.Add(label8);
            Panel3.Controls.Add(label10);
            Panel3.Controls.Add(pictureBox4);
            Panel3.Dock = DockStyle.Fill;
            Panel3.ForeColor = Color.White;
            Panel3.Location = new Point(596, 0);
            Panel3.Margin = new Padding(0, 0, 30, 0);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(268, 197);
            Panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(14, 14);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 12;
            label8.Text = "PELANGGAN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(30, 81);
            label10.Name = "label10";
            label10.Size = new Size(38, 45);
            label10.TabIndex = 9;
            label10.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(186, 56);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(232, 121, 117);
            Panel2.BorderColor = Color.PaleVioletRed;
            Panel2.BorderRadius = 5;
            Panel2.BorderSize = 0;
            Panel2.Controls.Add(label1);
            Panel2.Controls.Add(pictureBox3);
            Panel2.Controls.Add(label7);
            Panel2.Dock = DockStyle.Fill;
            Panel2.ForeColor = Color.White;
            Panel2.Location = new Point(298, 0);
            Panel2.Margin = new Padding(0, 0, 30, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(268, 197);
            Panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 10;
            label1.Text = "YANG SEDANG DIKERJAKAN";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(179, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(34, 81);
            label7.Name = "label7";
            label7.Size = new Size(38, 45);
            label7.TabIndex = 7;
            label7.Text = "0";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(21, 200, 161);
            Panel1.BorderColor = Color.PaleVioletRed;
            Panel1.BorderRadius = 5;
            Panel1.BorderSize = 0;
            Panel1.Controls.Add(label3);
            Panel1.Controls.Add(label4);
            Panel1.Controls.Add(pictureBox1);
            Panel1.Dock = DockStyle.Fill;
            Panel1.ForeColor = Color.White;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(0, 0, 30, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(268, 197);
            Panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 6;
            label3.Text = "TOTAL BOOKING";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(28, 81);
            label4.Name = "label4";
            label4.Size = new Size(38, 45);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel2.Controls.Add(dhafapanel, 0, 0);
            tableLayoutPanel2.Controls.Add(yogaPanel6, 1, 0);
            tableLayoutPanel2.Location = new Point(30, 298);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1194, 320);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // dhafapanel
            // 
            dhafapanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dhafapanel.BackColor = Color.White;
            dhafapanel.BorderColor = Color.PaleVioletRed;
            dhafapanel.BorderRadius = 5;
            dhafapanel.BorderSize = 0;
            dhafapanel.Controls.Add(sfComboBox1);
            dhafapanel.Controls.Add(label14);
            dhafapanel.Controls.Add(chartControl1);
            dhafapanel.ForeColor = Color.White;
            dhafapanel.Location = new Point(0, 0);
            dhafapanel.Margin = new Padding(0, 0, 30, 0);
            dhafapanel.Name = "dhafapanel";
            dhafapanel.Size = new Size(764, 320);
            dhafapanel.TabIndex = 0;
            // 
            // sfComboBox1
            // 
            sfComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sfComboBox1.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            sfComboBox1.Location = new Point(642, 15);
            sfComboBox1.Name = "sfComboBox1";
            sfComboBox1.Size = new Size(103, 26);
            sfComboBox1.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            sfComboBox1.TabIndex = 8;
            sfComboBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(15, 15);
            label14.Name = "label14";
            label14.Size = new Size(134, 25);
            label14.TabIndex = 7;
            label14.Text = "PENDAPATAN";
            // 
            // chartControl1
            // 
            chartControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartControl1.BorderAppearance.BaseColor = Color.FromArgb(197, 197, 197);
            chartControl1.BorderAppearance.Interior.ForeColor = Color.FromArgb(197, 197, 197);
            chartControl1.ChartArea.BorderColor = Color.Transparent;
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.DisplayChartContextMenu = false;
            chartControl1.DisplaySeriesContextMenu = false;
            chartControl1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(561, 31);
            chartControl1.Location = new Point(28, 43);
            chartControl1.Name = "chartControl1";
            chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            chartControl1.PrimaryXAxis.ForeColor = Color.FromArgb(68, 68, 68);
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryXAxis.MinorGridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryXAxis.TickColor = Color.FromArgb(221, 221, 221);
            chartControl1.PrimaryXAxis.TitleColor = Color.FromArgb(68, 68, 68);
            chartControl1.PrimaryXAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.PrimaryYAxis.ForeColor = Color.FromArgb(68, 68, 68);
            chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.PrimaryYAxis.MinorGridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryYAxis.TickColor = Color.FromArgb(221, 221, 221);
            chartControl1.PrimaryYAxis.TitleColor = Color.FromArgb(68, 68, 68);
            chartControl1.PrimaryYAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.Size = new Size(670, 272);
            chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            chartControl1.Style3D = true;
            chartControl1.TabIndex = 0;
            // 
            // 
            // 
            chartControl1.Title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.Title.Name = "Default";
            // 
            // yogaPanel6
            // 
            yogaPanel6.BackColor = Color.White;
            yogaPanel6.BorderColor = Color.PaleVioletRed;
            yogaPanel6.BorderRadius = 5;
            yogaPanel6.BorderSize = 0;
            yogaPanel6.Controls.Add(label15);
            yogaPanel6.Controls.Add(chartControlPie);
            yogaPanel6.Dock = DockStyle.Fill;
            yogaPanel6.ForeColor = Color.White;
            yogaPanel6.Location = new Point(794, 0);
            yogaPanel6.Margin = new Padding(0, 0, 30, 0);
            yogaPanel6.Name = "yogaPanel6";
            yogaPanel6.Size = new Size(370, 320);
            yogaPanel6.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(19, 16);
            label15.Name = "label15";
            label15.Size = new Size(200, 25);
            label15.TabIndex = 9;
            label15.Text = "TOP 5 PRODUCT SALE";
            // 
            // chartControlPie
            // 
            chartControlPie.ChartArea.BorderColor = Color.Transparent;
            chartControlPie.ChartArea.CursorLocation = new Point(0, 0);
            chartControlPie.ChartArea.CursorReDraw = false;
            chartControlPie.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // 
            // 
            chartControlPie.Legend.Location = new Point(227, 31);
            chartControlPie.Location = new Point(20, 42);
            chartControlPie.Name = "chartControlPie";
            chartControlPie.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            chartControlPie.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray;
            chartControlPie.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControlPie.PrimaryXAxis.Margin = true;
            chartControlPie.PrimaryXAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControlPie.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray;
            chartControlPie.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControlPie.PrimaryYAxis.Margin = true;
            chartControlPie.PrimaryYAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControlPie.Size = new Size(336, 273);
            chartControlPie.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            chartControlPie.Style3D = true;
            chartControlPie.TabIndex = 0;
            // 
            // 
            // 
            chartControlPie.Title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            chartControlPie.Title.Name = "Default";
            // 
            // Menu_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 652);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Name = "Menu_dashboard";
            Text = "Dashboard2";
            tableLayoutPanel1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            dhafapanel.ResumeLayout(false);
            dhafapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sfComboBox1).EndInit();
            yogaPanel6.ResumeLayout(false);
            yogaPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DhafaPanel Panel1;
        private DhafaPanel Panel3;
        private DhafaPanel Panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private DhafaPanel dhafapanel;
        private DhafaPanel yogaPanel6;
        private Label label14;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private Label label15;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControlPie;
    }
}