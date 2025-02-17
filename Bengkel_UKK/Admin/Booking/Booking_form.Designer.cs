using Bengkel_UKK.Custom_Component;
using Syncfusion.Windows.Forms.Tools;

namespace Bengkel_UKK.Admin.Booking
{
    partial class Booking_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_form));
            dataGridView1 = new DataGridView();
            lblShowingEntries = new Label();
            comboFilterStatus = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblHalaman = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            label1 = new Label();
            numericEntries = new NumericUpDown();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            contextMenuStrip = new ContextMenuStripEx();
            detailBookingToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            comboFilterWaktu = new ComboBox();
            tgl1 = new DateTimePicker();
            tgl2 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEntries).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(46, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1179, 374);
            dataGridView1.TabIndex = 0;
            // 
            // lblShowingEntries
            // 
            lblShowingEntries.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblShowingEntries.AutoSize = true;
            lblShowingEntries.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowingEntries.ForeColor = Color.DimGray;
            lblShowingEntries.Location = new Point(46, 474);
            lblShowingEntries.Name = "lblShowingEntries";
            lblShowingEntries.Size = new Size(238, 23);
            lblShowingEntries.TabIndex = 13;
            lblShowingEntries.Text = "Showing 1 to 14 of 120 entries";
            // 
            // comboFilterStatus
            // 
            comboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilterStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFilterStatus.FormattingEnabled = true;
            comboFilterStatus.Location = new Point(376, 33);
            comboFilterStatus.Name = "comboFilterStatus";
            comboFilterStatus.Size = new Size(100, 28);
            comboFilterStatus.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1062, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 40);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(lblHalaman);
            panel2.Location = new Point(67, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 39);
            panel2.TabIndex = 10;
            // 
            // lblHalaman
            // 
            lblHalaman.BackColor = Color.FromArgb(230, 126, 34);
            lblHalaman.Dock = DockStyle.Fill;
            lblHalaman.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHalaman.ForeColor = Color.White;
            lblHalaman.Location = new Point(0, 0);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new Size(45, 39);
            lblHalaman.TabIndex = 10;
            lblHalaman.Text = "1";
            lblHalaman.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(46, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search";
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(1162, 33);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 5;
            label3.Text = "entries";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(1044, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 4;
            label1.Text = "Show";
            // 
            // numericEntries
            // 
            numericEntries.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericEntries.BackColor = Color.White;
            numericEntries.BorderStyle = BorderStyle.FixedSingle;
            numericEntries.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericEntries.Location = new Point(1096, 32);
            numericEntries.Name = "numericEntries";
            numericEntries.Size = new Size(64, 27);
            numericEntries.TabIndex = 3;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.DropShadowEnabled = false;
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { detailBookingToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(188, 56);
            contextMenuStrip.ThemeName = "Office2016Colorful";
            contextMenuStrip.ThemeStyle.BackColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.DisabledForeColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.HoverBackColor = Color.FromArgb(52, 152, 219);
            contextMenuStrip.ThemeStyle.PressedBackColor = Color.FromArgb(52, 152, 219);
            // 
            // detailBookingToolStripMenuItem
            // 
            detailBookingToolStripMenuItem.Name = "detailBookingToolStripMenuItem";
            detailBookingToolStripMenuItem.Size = new Size(187, 26);
            detailBookingToolStripMenuItem.Text = "Detail Booking";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(187, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // comboFilterWaktu
            // 
            comboFilterWaktu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilterWaktu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFilterWaktu.FormattingEnabled = true;
            comboFilterWaktu.Location = new Point(482, 33);
            comboFilterWaktu.Name = "comboFilterWaktu";
            comboFilterWaktu.Size = new Size(123, 28);
            comboFilterWaktu.TabIndex = 14;
            // 
            // tgl1
            // 
            tgl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tgl1.Location = new Point(624, 33);
            tgl1.Name = "tgl1";
            tgl1.Size = new Size(172, 27);
            tgl1.TabIndex = 15;
            // 
            // tgl2
            // 
            tgl2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tgl2.Location = new Point(822, 33);
            tgl2.Name = "tgl2";
            tgl2.Size = new Size(172, 27);
            tgl2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(801, 35);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 17;
            label2.Text = "━";
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1327, 635);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBooking";
            Text = "Tabel";
            Load += Booking_form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericEntries).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DhafaPanel yogaPanel1;
        private DhafaButton btnAddData;
        private NumericUpDown numericEntries;
        private Label label1;
        private TextBox txtSearch;
        private Label label3;
        private Panel panel1;
        private DhafaButton btnNext;
        private DhafaButton btnPrevious;
        private Panel panel2;
        private Label lblHalaman;
        private DhafaButton btnSearch;
        private ComboBox comboFilterStatus;
        private Label lblShowingEntries;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem detailBookingToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label2;
        private DateTimePicker tgl2;
        private DateTimePicker tgl1;
        private ComboBox comboFilterWaktu;

    }
}