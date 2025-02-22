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
            yogaPanel1 = new DhafaPanel();
            label2 = new Label();
            tgl2 = new DateTimePicker();
            tgl1 = new DateTimePicker();
            comboFilterWaktu = new ComboBox();
            comboFilterStatus = new ComboBox();
            btnSearch = new DhafaButton();
            txtSearch = new TextBox();
            btnAddData = new DhafaButton();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            contextMenuStrip = new ContextMenuStripEx();
            detailBookingToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            yogaPanel1.SuspendLayout();
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
            // yogaPanel1
            // 
            yogaPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yogaPanel1.BackColor = Color.White;
            yogaPanel1.BorderColor = Color.PaleVioletRed;
            yogaPanel1.BorderRadius = 0;
            yogaPanel1.BorderSize = 0;
            yogaPanel1.Controls.Add(label2);
            yogaPanel1.Controls.Add(tgl2);
            yogaPanel1.Controls.Add(tgl1);
            yogaPanel1.Controls.Add(comboFilterWaktu);
            yogaPanel1.Controls.Add(comboFilterStatus);
            yogaPanel1.Controls.Add(btnSearch);
            yogaPanel1.Controls.Add(txtSearch);
            yogaPanel1.Controls.Add(dataGridView1);
            yogaPanel1.ForeColor = Color.White;
            yogaPanel1.Location = new Point(28, 75);
            yogaPanel1.Name = "yogaPanel1";
            yogaPanel1.Size = new Size(1270, 531);
            yogaPanel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(801, 35);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 17;
            label2.Text = " ";
            // 
            // tgl2
            // 
            tgl2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tgl2.Location = new Point(822, 33);
            tgl2.Name = "tgl2";
            tgl2.Size = new Size(172, 27);
            tgl2.TabIndex = 16;
            // 
            // tgl1
            // 
            tgl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tgl1.Location = new Point(624, 33);
            tgl1.Name = "tgl1";
            tgl1.Size = new Size(172, 27);
            tgl1.TabIndex = 15;
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(230, 126, 34);
            btnSearch.BackgroundColor = Color.FromArgb(230, 126, 34);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(323, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(47, 27);
            btnSearch.TabIndex = 12;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
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
            // btnAddData
            // 
            btnAddData.BackColor = Color.FromArgb(52, 152, 219);
            btnAddData.BackgroundColor = Color.FromArgb(52, 152, 219);
            btnAddData.BorderColor = Color.PaleVioletRed;
            btnAddData.BorderRadius = 0;
            btnAddData.BorderSize = 0;
            btnAddData.FlatAppearance.BorderSize = 0;
            btnAddData.FlatStyle = FlatStyle.Flat;
            btnAddData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddData.ForeColor = Color.White;
            btnAddData.Location = new Point(28, 16);
            btnAddData.Name = "btnAddData";
            btnAddData.Padding = new Padding(10, 0, 0, 0);
            btnAddData.Size = new Size(126, 42);
            btnAddData.TabIndex = 1;
            btnAddData.Text = "Add Booking";
            btnAddData.TextColor = Color.White;
            btnAddData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddData.UseVisualStyleBackColor = false;
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
            // Booking_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1327, 635);
            Controls.Add(yogaPanel1);
            Controls.Add(btnAddData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking_form";
            Text = "Tabel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            yogaPanel1.ResumeLayout(false);
            yogaPanel1.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DhafaPanel yogaPanel1;
        private DhafaButton btnAddData;
        private TextBox txtSearch;
        private DhafaButton btnSearch;
        private ComboBox comboFilterStatus;
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