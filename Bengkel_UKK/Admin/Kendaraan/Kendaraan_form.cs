using Bengkel_UKK.Admin.Jasa_Service;
using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Helper;
using Dapper;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Kendaraan
{
    public partial class Kendaraan_form : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        private int _page = 1;
        private int _Totalpage = 1;
        private bool _btnMain = true;
        public Kendaraan_form()
        {
            InitializeComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
        }
        private void RegisterEvent()
        {
            btnAddData.Click += BtnAddData_Click;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            HapusToolStripMenuItem.Click += HapusToolStripMenuItem_Click;
        }

        private void HapusToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["id_kendaraan"].Value.ToString(), out int idkendaraan))
            {
                MessageBox.Show("Gagal mendapatkan ID Kendaraan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _kendaraanDal.SoftDeleteData(idkendaraan);
                LoadData();
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string ktp = dataGridView1.CurrentRow.Cells["ktp_pelanggan"].Value?.ToString() ?? string.Empty;
            if (new InputKendaraan_form(ktp, false).ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                contextMenuStripEx1.Show(Cursor.Position);
            }
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new InputKendaraan_form("", true).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private FilterDto? Filter()
        {
            string search = txtSearch.Text.Trim();

            string sql = "";
            var dp = new DynamicParameters();
            List<string> fltr = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                fltr.Add("(no_pol LIKE '%' + @search + '%' OR merk LIKE '%' + @search + '%' OR tipe LIKE '%' + @search + '%' OR transmisi LIKE '%' + @search + '%' OR tahun LIKE '%' + @search + '%')");
                dp.Add("@search", search);
            }

            if (fltr.Count > 0)
                sql = " WHERE " + string.Join(" AND ", fltr);

            return new FilterDto
            {
                sql = sql,
                param = dp
            };
        }
        private void LoadData()
        {
            var sqlFilter = Filter() ?? new FilterDto();
            var totalRows = _kendaraanDal.GetTotalRows(sqlFilter);

            int showData = (int)numericEntries.Value;
            _Totalpage = (int)Math.Ceiling((double)totalRows / showData);
            int offset = (_page - 1) * showData;

            // Periksa apakah sqlFilter.param null, jika ya, buat objek baru
            if (sqlFilter.param == null)
                sqlFilter.param = new DynamicParameters();

            // Gunakan .Add() untuk menambahkan parameter ke DynamicParameters
            sqlFilter.param.Add("@offset", offset);
            sqlFilter.param.Add("@fetch", showData);

            lblHalaman.Text = _page.ToString();
            int toValue = Math.Min(offset + showData, totalRows);
            lblShowingEntries.Text = $"Showing {offset + 1} to {toValue} of {totalRows} entries";

            var list = _kendaraanDal.ListData(sqlFilter)
                .Select((x, index) => new KendaraanDto()
                {
                    No = index +1,
                    id_kendaraan = x.id_kendaraan,
                    nama_kendaraan = x.merk,
                    no_pol = x.no_pol,
                    tipe = x.tipe,
                    transmisi = x.transmisi,
                    kapasitas = x.kapasitas,
                    tahun = x.tahun,
                    total_servis = x.total_servis,
                    ktp_pelanggan =x.ktp_pelanggan,
                    nama_pelanggan = x.nama_pelanggan,
                }).ToList();

            dataGridView1.DataSource = new SortableBindingList<KendaraanDto>(list);
        }

        #region CUSTOM DATAGRID
        private void CustomGrid()
        {
            DataGridView dgv = dataGridView1;
            CustomGrids.CustomDataGrid(dgv);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgv.Columns["id_kendaraan"].HeaderText = "ID Kendaraan";
            dgv.Columns["No"].HeaderText = "No";
            dgv.Columns["nama_kendaraan"].HeaderText = "Merk";
            dgv.Columns["no_pol"].HeaderText = "Nomor Polisi";
            dgv.Columns["tipe"].HeaderText = "Tipe";
            dgv.Columns["transmisi"].HeaderText = "Transmisi";
            dgv.Columns["kapasitas"].HeaderText = "Kapasitas";
            dgv.Columns["tahun"].HeaderText = "Tahun";
            dgv.Columns["ktp_pelanggan"].HeaderText = "No KTP";
            dgv.Columns["total_servis"].HeaderText = "Total Servis";


            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 5;                 // Nomor urut (lebih kecil)
            dgv.Columns["nama_kendaraan"].FillWeight = 18;    // Nama Kendaraan / Merk
            dgv.Columns["no_pol"].FillWeight = 18;            // Nomor Polisi
            dgv.Columns["tipe"].FillWeight = 15;              // Tipe Kendaraan
            dgv.Columns["transmisi"].FillWeight = 15;         // Jenis Transmisi
            dgv.Columns["kapasitas"].FillWeight = 13;          // Kapasitas Mesin (cc)
            dgv.Columns["tahun"].FillWeight = 13;              // Tahun Pembuatan
            dgv.Columns["ktp_pelanggan"].FillWeight = 15;     // KTP Pelanggan
            dgv.Columns["total_servis"].FillWeight = 13;      // Total Servis
            dgv.Columns["nama_pelanggan"].FillWeight = 16;      // Total Servis


            dgv.Columns["id_kendaraan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["nama_kendaraan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["no_pol"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["tipe"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["transmisi"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["kapasitas"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["tahun"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["ktp_pelanggan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["total_servis"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);



            dgv.Columns["No"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns["ktp_pelanggan"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns["no_pol"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv.Columns["id_kendaraan"].Visible = false;
        }

        private void DataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hanya proses header kolom
            {
                // Gambar latar belakang header default
                e.PaintBackground(e.CellBounds, true);

                // Tambahkan padding ke teks header
                Rectangle paddedBounds = e.CellBounds;
                paddedBounds.X += 20; // Padding kiri 20 piksel
                paddedBounds.Width -= 20; // Sesuaikan lebar setelah padding

                // Gambar teks header dengan padding
                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, paddedBounds, e.CellStyle.ForeColor, flags);

                // Jika kolom sedang diurutkan, gambar panah
                if (dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    int arrowWidth = 10; // Lebar panah (ukuran kecil)
                    int arrowHeight = 10; // Tinggi panah (ukuran kecil)
                    int textWidth = TextRenderer.MeasureText(e.FormattedValue.ToString(), e.CellStyle.Font).Width;
                    int arrowX = paddedBounds.Left + textWidth + 2; // Jarak antara teks dan panah (gunakan paddedBounds)
                    int arrowY = e.CellBounds.Top + (e.CellBounds.Height - arrowHeight) / 2; // Posisi vertikal tengah

                    using (var sortGlyph = CreateSortGlyph(dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection))
                    {
                        // Aktifkan interpolasi berkualitas tinggi
                        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        // Gambar panah dengan ukuran yang disesuaikan
                        e.Graphics.DrawImage(sortGlyph, arrowX, arrowY, arrowWidth, arrowHeight);
                    }
                }

                if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hanya proses header kolom
                {
                    // Daftar kolom yang ingin diterapkan CellPainting
                    string[] targetColumns = { };

                    // Periksa apakah kolom saat ini termasuk dalam daftar target
                    if (targetColumns.Contains(dataGridView1.Columns[e.ColumnIndex].Name))
                    {
                        // Gambar latar belakang header default
                        e.PaintBackground(e.CellBounds, true);

                        // Gambar teks header dengan alignment tengah
                        TextFormatFlags flagss = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                        TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor, flagss);

                        e.Handled = true; // Tandai event sebagai sudah dihandle
                    }
                }

                e.Handled = true; // Tandai event sebagai sudah dihandle
            }
        }

        private Bitmap CreateSortGlyph(SortOrder sortOrder)
        {
            string assetsPath = Path.Combine(Application.StartupPath, "Asset"); // Path ke folder Asset
            string imagePath = Path.Combine(assetsPath, sortOrder == SortOrder.Ascending ? "ArrowUp.png" : "ArrowDown.png");

            if (File.Exists(imagePath))
            {
                return (Bitmap)Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Gambar tidak ditemukan: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

    }
}

