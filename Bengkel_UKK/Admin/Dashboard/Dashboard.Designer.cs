using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Dashboard
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3dItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Panel4 = new DhafaPanel();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            label_pendapatan = new Label();
            Panel3 = new DhafaPanel();
            label8 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            Panel2 = new DhafaPanel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label_totalygdikerjakan = new Label();
            Panel1 = new DhafaPanel();
            label3 = new Label();
            label_totalbooking = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            tableLayoutPanel1.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.Controls.Add(Panel4, 3, 0);
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
            // Panel4
            // 
            Panel4.BackColor = Color.FromArgb(47, 139, 241);
            Panel4.BorderColor = Color.PaleVioletRed;
            Panel4.BorderRadius = 5;
            Panel4.BorderSize = 0;
            Panel4.Controls.Add(label11);
            Panel4.Controls.Add(pictureBox5);
            Panel4.Controls.Add(label_pendapatan);
            Panel4.Dock = DockStyle.Fill;
            Panel4.ForeColor = Color.White;
            Panel4.Location = new Point(894, 0);
            Panel4.Margin = new Padding(0, 0, 30, 0);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(270, 197);
            Panel4.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(14, 14);
            label11.Name = "label11";
            label11.Size = new Size(153, 21);
            label11.TabIndex = 16;
            label11.Text = "TOTAL PENDAPATAN";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(186, 56);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label_pendapatan
            // 
            label_pendapatan.AutoSize = true;
            label_pendapatan.BackColor = Color.Transparent;
            label_pendapatan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_pendapatan.ForeColor = SystemColors.ControlText;
            label_pendapatan.Location = new Point(14, 81);
            label_pendapatan.Name = "label_pendapatan";
            label_pendapatan.Size = new Size(38, 45);
            label_pendapatan.TabIndex = 13;
            label_pendapatan.Text = "0";
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
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(14, 14);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 12;
            label8.Text = "PELANGGAN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(14, 81);
            label10.Name = "label10";
            label10.Size = new Size(56, 45);
            label10.TabIndex = 9;
            label10.Text = "67";
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
            Panel2.Controls.Add(label_totalygdikerjakan);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(209, 21);
            label1.TabIndex = 10;
            label1.Text = "YANG SEDANG DIKERJAKAN";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(186, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label_totalygdikerjakan
            // 
            label_totalygdikerjakan.AutoSize = true;
            label_totalygdikerjakan.BackColor = Color.Transparent;
            label_totalygdikerjakan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_totalygdikerjakan.ForeColor = SystemColors.ControlText;
            label_totalygdikerjakan.Location = new Point(14, 81);
            label_totalygdikerjakan.Name = "label_totalygdikerjakan";
            label_totalygdikerjakan.Size = new Size(56, 45);
            label_totalygdikerjakan.TabIndex = 7;
            label_totalygdikerjakan.Text = "10";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(21, 200, 161);
            Panel1.BorderColor = Color.PaleVioletRed;
            Panel1.BorderRadius = 5;
            Panel1.BorderSize = 0;
            Panel1.Controls.Add(label3);
            Panel1.Controls.Add(label_totalbooking);
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 6;
            label3.Text = "TOTAL BOOKINGS";
            // 
            // label_totalbooking
            // 
            label_totalbooking.AutoSize = true;
            label_totalbooking.BackColor = Color.Transparent;
            label_totalbooking.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_totalbooking.ForeColor = SystemColors.ControlText;
            label_totalbooking.Location = new Point(14, 81);
            label_totalbooking.Name = "label_totalbooking";
            label_totalbooking.Size = new Size(38, 45);
            label_totalbooking.TabIndex = 3;
            label_totalbooking.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 56);
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
            tableLayoutPanel2.Location = new Point(19, 297);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1194, 320);
            tableLayoutPanel2.TabIndex = 12;
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
            chartControl1.Legend.Location = new Point(291, 31);
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
            chartControl1.ToolBar.EnableDefaultItems = false;
            chartControl1.ToolBar.Items.Add(chartToolBarSaveItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarCopyItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarPrintItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarTypeItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarSeries3dItem2);
            chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 652);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Name = "Dashboard";
            Text = "Dashboard2";
            tableLayoutPanel1.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label_totalbooking;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label_totalygdikerjakan;
        private DhafaPanel Panel4;
        private Label label11;
        private PictureBox pictureBox5;
        private Label label_pendapatan;
        private TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}