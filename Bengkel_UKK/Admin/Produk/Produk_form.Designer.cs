﻿using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Admin.Produk
{
    partial class Produk_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produk_form));
            dataGridView1 = new DataGridView();
            yogaPanel1 = new DhafaPanel();
            lblShowingEntries = new Label();
            comboFilter = new ComboBox();
            btnSearch = new DhafaButton();
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
            contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            editToolStripMenuItem = new ToolStripMenuItem();
            hapusToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            yogaPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEntries).BeginInit();
            contextMenuStripEx1.SuspendLayout();
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
            dataGridView1.Size = new Size(995, 374);
            dataGridView1.TabIndex = 0;
            // 
            // yogaPanel1
            // 
            yogaPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yogaPanel1.BackColor = Color.White;
            yogaPanel1.BorderColor = Color.PaleVioletRed;
            yogaPanel1.BorderRadius = 0;
            yogaPanel1.BorderSize = 0;
            yogaPanel1.Controls.Add(lblShowingEntries);
            yogaPanel1.Controls.Add(comboFilter);
            yogaPanel1.Controls.Add(btnSearch);
            yogaPanel1.Controls.Add(panel1);
            yogaPanel1.Controls.Add(txtSearch);
            yogaPanel1.Controls.Add(label3);
            yogaPanel1.Controls.Add(label1);
            yogaPanel1.Controls.Add(numericEntries);
            yogaPanel1.Controls.Add(dataGridView1);
            yogaPanel1.ForeColor = Color.White;
            yogaPanel1.Location = new Point(28, 75);
            yogaPanel1.Name = "yogaPanel1";
            yogaPanel1.Size = new Size(1086, 531);
            yogaPanel1.TabIndex = 11;
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
            // comboFilter
            // 
            comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFilter.FormattingEnabled = true;
            comboFilter.Location = new Point(376, 33);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(154, 28);
            comboFilter.TabIndex = 12;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
            panel1.Location = new Point(878, 467);
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
            label3.Location = new Point(978, 33);
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
            label1.Location = new Point(860, 33);
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
            numericEntries.Location = new Point(912, 32);
            numericEntries.Name = "numericEntries";
            numericEntries.Size = new Size(64, 27);
            numericEntries.TabIndex = 3;
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
            btnAddData.Text = " Add Data";
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
            // contextMenuStripEx1
            // 
            contextMenuStripEx1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, hapusToolStripMenuItem });
            contextMenuStripEx1.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStripEx1.Name = "contextMenuStripEx1";
            contextMenuStripEx1.Size = new Size(124, 56);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(123, 26);
            editToolStripMenuItem.Text = "Edit";
            // 
            // hapusToolStripMenuItem
            // 
            hapusToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            hapusToolStripMenuItem.Size = new Size(123, 26);
            hapusToolStripMenuItem.Text = "Hapus";
            // 
            // Produk_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 635);
            Controls.Add(yogaPanel1);
            Controls.Add(btnAddData);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Produk_form";
            Text = "Tabel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            yogaPanel1.ResumeLayout(false);
            yogaPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericEntries).EndInit();
            contextMenuStripEx1.ResumeLayout(false);
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
        private ComboBox comboFilter;
        private Label lblShowingEntries;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem hapusToolStripMenuItem;
    }
}