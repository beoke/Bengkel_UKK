using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Custom_Component;
using Syncfusion.Windows.Forms.Tools;

namespace Bengkel_UKK.Manage_Pelanggan
{
    partial class BookingFormPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingFormPelanggan));
            dataGridView1 = new DataGridView();
            yogaPanel1 = new DhafaPanel();
            label5 = new Label();
            JamOperational2 = new TextBox();
            jamOperational1 = new TextBox();
            label4 = new Label();
            txtSearch = new TextBox();
            btnAddData = new DhafaButton();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            detailBookingToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            txtBatas = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            detailBookingToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            yogaPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            yogaPanel1.Controls.Add(txtSearch);
            yogaPanel1.Controls.Add(dataGridView1);
            yogaPanel1.ForeColor = Color.White;
            yogaPanel1.Location = new Point(28, 75);
            yogaPanel1.Name = "yogaPanel1";
            yogaPanel1.Size = new Size(1270, 531);
            yogaPanel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(1153, 25);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 23;
            label5.Text = "- ";
            // 
            // JamOperational2
            // 
            JamOperational2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JamOperational2.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            JamOperational2.Location = new Point(1174, 20);
            JamOperational2.Name = "JamOperational2";
            JamOperational2.ReadOnly = true;
            JamOperational2.Size = new Size(83, 31);
            JamOperational2.TabIndex = 22;
            // 
            // jamOperational1
            // 
            jamOperational1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            jamOperational1.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            jamOperational1.Location = new Point(1064, 20);
            jamOperational1.Name = "jamOperational1";
            jamOperational1.ReadOnly = true;
            jamOperational1.Size = new Size(83, 31);
            jamOperational1.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(912, 25);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 20;
            label4.Text = "Jam Operasional :";
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
            btnAddData.Size = new Size(132, 42);
            btnAddData.TabIndex = 1;
            btnAddData.Text = "➕ Booking";
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
            label2.Location = new Point(618, 24);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 15;
            label2.Text = "Batas Booking Hari ini :";
            // 
            // txtBatas
            // 
            txtBatas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBatas.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBatas.Location = new Point(812, 20);
            txtBatas.Name = "txtBatas";
            txtBatas.Size = new Size(83, 31);
            txtBatas.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { detailBookingToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(195, 30);
            // 
            // detailBookingToolStripMenuItem1
            // 
            detailBookingToolStripMenuItem1.Name = "detailBookingToolStripMenuItem1";
            detailBookingToolStripMenuItem1.Size = new Size(194, 26);
            detailBookingToolStripMenuItem1.Text = "Detail Booking";
            // 
            // BookingFormPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1327, 635);
            Controls.Add(label5);
            Controls.Add(JamOperational2);
            Controls.Add(txtBatas);
            Controls.Add(label2);
            Controls.Add(jamOperational1);
            Controls.Add(label4);
            Controls.Add(yogaPanel1);
            Controls.Add(btnAddData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingFormPelanggan";
            Text = "Tabel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            yogaPanel1.ResumeLayout(false);
            yogaPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DhafaPanel yogaPanel1;
        private DhafaButton btnAddData;
        private TextBox txtSearch;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripMenuItem detailBookingToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label2;
        private TextBox txtBatas;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem detailBookingToolStripMenuItem1;
        private Label label5;
        private TextBox JamOperational2;
        private TextBox jamOperational1;
        private Label label4;
    }
}