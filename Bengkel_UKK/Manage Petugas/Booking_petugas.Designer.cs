﻿using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Custom_Component;
using Syncfusion.Windows.Forms.Tools;

namespace Bengkel_UKK.Manage_Petugas
{
    partial class Booking_petugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_petugas));
            dataGridView1 = new DataGridView();
            yogaPanel1 = new DhafaPanel();
            comboFilterWaktu = new ComboBox();
            lblShowingEntries = new Label();
            comboFilterStatus = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblHalaman = new Label();
            btnNext = new DhafaButton();
            btnPrevious = new DhafaButton();
            txtSearch = new TextBox();
            label3 = new Label();
            label1 = new Label();
            numericEntries = new NumericUpDown();
            btnAddData = new DhafaButton();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            contextMenuStrip = new ContextMenuStripEx();
            detailBookingToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            txtBatas = new TextBox();
            label4 = new Label();
            jamOperational1 = new TextBox();
            JamOperational2 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            yogaPanel1.SuspendLayout();
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
            dataGridView1.Location = new Point(46, 87);
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
            yogaPanel1.Controls.Add(comboFilterWaktu);
            yogaPanel1.Controls.Add(lblShowingEntries);
            yogaPanel1.Controls.Add(comboFilterStatus);
            yogaPanel1.Controls.Add(panel1);
            yogaPanel1.Controls.Add(txtSearch);
            yogaPanel1.Controls.Add(label3);
            yogaPanel1.Controls.Add(label1);
            yogaPanel1.Controls.Add(numericEntries);
            yogaPanel1.Controls.Add(dataGridView1);
            yogaPanel1.ForeColor = Color.White;
            yogaPanel1.Location = new Point(28, 75);
            yogaPanel1.Name = "yogaPanel1";
            yogaPanel1.Size = new Size(1270, 531);
            yogaPanel1.TabIndex = 11;
            // 
            // comboFilterWaktu
            // 
            comboFilterWaktu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilterWaktu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFilterWaktu.FormattingEnabled = true;
            comboFilterWaktu.Location = new Point(429, 34);
            comboFilterWaktu.Name = "comboFilterWaktu";
            comboFilterWaktu.Size = new Size(123, 28);
            comboFilterWaktu.TabIndex = 14;
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
            comboFilterStatus.Location = new Point(323, 34);
            comboFilterStatus.Name = "comboFilterStatus";
            comboFilterStatus.Size = new Size(100, 28);
            comboFilterStatus.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
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
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.BackgroundColor = Color.White;
            btnNext.BorderColor = Color.PaleVioletRed;
            btnNext.BorderRadius = 0;
            btnNext.BorderSize = 2;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ControlText;
            btnNext.Location = new Point(105, 0);
            btnNext.Margin = new Padding(0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(58, 40);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.TextColor = SystemColors.ControlText;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.BackgroundColor = Color.White;
            btnPrevious.BorderColor = Color.PaleVioletRed;
            btnPrevious.BorderRadius = 0;
            btnPrevious.BorderSize = 2;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.ForeColor = SystemColors.ControlText;
            btnPrevious.Location = new Point(0, 0);
            btnPrevious.Margin = new Padding(0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(76, 40);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "Previous";
            btnPrevious.TextColor = SystemColors.ControlText;
            btnPrevious.UseVisualStyleBackColor = false;
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
            numericEntries.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericEntries.Name = "numericEntries";
            numericEntries.Size = new Size(64, 27);
            numericEntries.TabIndex = 3;
            numericEntries.Value = new decimal(new int[] { 10, 0, 0, 0 });
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
            btnAddData.Size = new Size(132, 42);
            btnAddData.TabIndex = 1;
            btnAddData.Text = "➕ Add Data";
            btnAddData.TextAlign = ContentAlignment.MiddleLeft;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(585, 35);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 15;
            label2.Text = "Batas Booking Hari ini :";
            // 
            // txtBatas
            // 
            txtBatas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBatas.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBatas.Location = new Point(779, 30);
            txtBatas.Name = "txtBatas";
            txtBatas.Size = new Size(83, 31);
            txtBatas.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(868, 35);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 16;
            label4.Text = "Jam Operasional :";
            // 
            // jamOperational1
            // 
            jamOperational1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            jamOperational1.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            jamOperational1.Location = new Point(1020, 30);
            jamOperational1.Name = "jamOperational1";
            jamOperational1.ReadOnly = true;
            jamOperational1.Size = new Size(83, 31);
            jamOperational1.TabIndex = 17;
            // 
            // JamOperational2
            // 
            JamOperational2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JamOperational2.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            JamOperational2.Location = new Point(1130, 30);
            JamOperational2.Name = "JamOperational2";
            JamOperational2.ReadOnly = true;
            JamOperational2.Size = new Size(83, 31);
            JamOperational2.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(1109, 35);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 19;
            label5.Text = "- ";
            // 
            // Booking_petugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1327, 635);
            Controls.Add(label5);
            Controls.Add(JamOperational2);
            Controls.Add(jamOperational1);
            Controls.Add(label4);
            Controls.Add(txtBatas);
            Controls.Add(label2);
            Controls.Add(yogaPanel1);
            Controls.Add(btnAddData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking_petugas";
            Text = "Tabel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            yogaPanel1.ResumeLayout(false);
            yogaPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericEntries).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox comboFilterStatus;
        private Label lblShowingEntries;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem detailBookingToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ComboBox comboFilterWaktu;
        private Label label2;
        private TextBox txtBatas;
        private Label label4;
        private TextBox jamOperational1;
        private TextBox JamOperational2;
        private Label label5;
    }
}