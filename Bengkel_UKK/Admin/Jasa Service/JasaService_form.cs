using Bengkel_UKK.Admin.Karyawan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Jasa_Service
{
    public partial class JasaService_form : Form
    {
        private readonly JasaServiceDal _jasaServiceDal = new JasaServiceDal();
        public JasaService_form()
        {
            InitializeComponent();
            RegisterEvent();
            InitComponent();
            LoadData();
            CustomGrid();
        }

        private void RegisterEvent()
        {
            btnAddData.Click += BtnAddData_Click;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick; ;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click; ;
            hapusToolStripMenuItem.Click += HapusToolStripMenuItem_Click; ;
        }

        private void HapusToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["id_jasaServis"].Value.ToString(), out int idJasaServis))
            {
                MessageBox.Show("Gagal mendapatkan ID Jasa Servis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _jasaServiceDal.DeleteData(idJasaServis); // 🔄 Kirim ID sebagai int
                LoadData(); // 🔄 Update DataGridView setelah penghapusan
            }
        }


        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Ambil data dari DataGridView
            string namaJasa = dataGridView1.CurrentRow.Cells["nama_jasaServis"].Value?.ToString() ?? "";
            int idJasa = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_jasaServis"].Value);

            // ✅ Buka Form InputJasaService untuk Edit
            if (new InputJasaService_form(namaJasa, false, idJasa).ShowDialog() == DialogResult.OK)
            {
                LoadData(); // 🔄 Update DataGridView setelah perubahan
            }
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            InputJasaService_form form = new InputJasaService_form("", true);
            form.DataUpdated += LoadData; // 🚀 Hubungkan event ke LoadData
            form.ShowDialog();
        }

        private void LoadData()
        {
            int no = 1;
            var list = _jasaServiceDal.ListData()
                .Select(x => new JasaServiceModel
                {
                    No = no++,
                    id_jasaServis = x.id_jasaServis,
                    nama_jasaServis = x.nama_jasaServis,
                    harga = x.harga,
                    keterangan = x.keterangan
                }).ToList();

            dataGridView1.DataSource = new SortableBindingList<JasaServiceModel>(list);
        }

        private void InitComponent()
        {

        }

        private void CustomGrid()
        {
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Mengatur ukuran font header kolom
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Mengatur warna header kolom
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ForeColor = Color.DimGray;


            // Menonaktifkan warna seleksi untuk sel
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.RowTemplate.Height = 55;

            dataGridView1.RowHeadersVisible = false;

            // Mencegah penggeseran kolom
            dataGridView1.AllowUserToOrderColumns = false;

            // Mencegah pengubahan ukuran kolom
            dataGridView1.AllowUserToResizeColumns = true;

            // Mencegah pengubahan ukuran baris
            dataGridView1.AllowUserToResizeRows = false;

            // Mencegah penambahan baris baru
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 0, 0, 0);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["No"].FillWeight = 10;
            dataGridView1.Columns["id_jasaServis"].FillWeight = 6;
            dataGridView1.Columns["nama_jasaServis"].FillWeight = 30;
            dataGridView1.Columns["harga"].FillWeight = 64;
            dataGridView1.Columns["keterangan"].FillWeight = 100;

            dataGridView1.Columns["id_jasaServis"].Visible = false;

            dataGridView1.Columns["No"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["nama_jasaServis"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["harga"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["keterangan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);


            dataGridView1.Columns["No"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.Columns["nama_jasaServis"].HeaderText = "Nama Jasa";
            dataGridView1.Columns["harga"].HeaderText = "Harga";
            dataGridView1.Columns["keterangan"].HeaderText = "Keterangan";
        }
    }
}
