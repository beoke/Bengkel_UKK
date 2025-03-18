using Bengkel_UKK.Admin.Kendaraan;
using Bengkel_UKK.Custom_Component;

namespace Bengkel_UKK.Manage_Pelanggan
{
    partial class KendaraanPelanggan
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
            dataGridView1 = new DataGridView();
            yogaPanel1 = new DhafaPanel();
            btnAddData = new DhafaButton();
            contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            restoreStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            yogaPanel1.SuspendLayout();
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
            yogaPanel1.BorderRadius = 10;
            yogaPanel1.BorderSize = 0;
            yogaPanel1.Controls.Add(btnAddData);
            yogaPanel1.Controls.Add(dataGridView1);
            yogaPanel1.ForeColor = Color.White;
            yogaPanel1.Location = new Point(28, 75);
            yogaPanel1.Name = "yogaPanel1";
            yogaPanel1.Size = new Size(1086, 531);
            yogaPanel1.TabIndex = 11;
            // 
            // btnAddData
            // 
            btnAddData.AutoSize = true;
            btnAddData.BackColor = Color.FromArgb(52, 152, 219);
            btnAddData.BackgroundColor = Color.FromArgb(52, 152, 219);
            btnAddData.BorderColor = Color.PaleVioletRed;
            btnAddData.BorderRadius = 4;
            btnAddData.BorderSize = 0;
            btnAddData.FlatAppearance.BorderSize = 0;
            btnAddData.FlatStyle = FlatStyle.Flat;
            btnAddData.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddData.ForeColor = Color.White;
            btnAddData.Image = Properties.Resources.plusPutih;
            btnAddData.Location = new Point(46, 14);
            btnAddData.Name = "btnAddData";
            btnAddData.Padding = new Padding(10, 0, 0, 0);
            btnAddData.Size = new Size(165, 42);
            btnAddData.TabIndex = 1;
            btnAddData.Text = " Add Kendaraan";
            btnAddData.TextColor = Color.White;
            btnAddData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddData.UseVisualStyleBackColor = false;
            // 
            // contextMenuStripEx1
            // 
            contextMenuStripEx1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStripEx1.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStripEx1.Name = "contextMenuStripEx1";
            contextMenuStripEx1.Size = new Size(127, 60);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(126, 28);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.Image = Properties.Resources.sampahDark;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(126, 28);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // restoreStripMenuItem2
            // 
            restoreStripMenuItem2.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            restoreStripMenuItem2.Name = "restoreStripMenuItem2";
            restoreStripMenuItem2.Size = new Size(135, 28);
            restoreStripMenuItem2.Text = "Restore";
            // 
            // KendaraanPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 635);
            Controls.Add(yogaPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KendaraanPelanggan";
            Text = "Tabel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            yogaPanel1.ResumeLayout(false);
            yogaPanel1.PerformLayout();
            contextMenuStripEx1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DhafaPanel yogaPanel1;
        private DhafaButton btnAddData;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem restoreStripMenuItem2;
    }
}