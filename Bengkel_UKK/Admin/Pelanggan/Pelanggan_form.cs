using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Pelanggan
{
    public partial class Pelanggan_form : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private int _page = 1;
        private int _Totalpage = 1;
        public Pelanggan_form()
        {
            InitializeComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
        }
        #region INIT COMPONENT

        private void InitComponent()
        {

        }

        #endregion

        #region EVENT
        private void RegisterEvent()
        {
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            btnAddData.Click += (s, e) =>
            {
                if (new InputPelanggan_form("").ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            };
            txtSearch.TextChanged += async (s, e) =>
            {
                await Task.Delay(500);
                ResetPage();
                LoadData();
            };
            numericEntries.ValueChanged += async (s, e) =>
            {
                await Task.Delay(1000);
                ResetPage();
                LoadData();
            };


        }
        private void ResetPage()
        {
            _page = 1;
        }
        #endregion

        #region LOAD DATAGRID
        private FilterDto Filter()
        {
            string search = txtSearch.Text.Trim();
            string sql = "";

            if (!string.IsNullOrEmpty(search))
            {
                sql = $" WHERE (ktp_pelanggan LIKE '%{search}%' OR nama_pelanggan LIKE '%{search}%' OR email LIKE '%{search}%' OR alamat LIKE '%{search}%' OR no_telp LIKE '%{search}%')";
            }

            return new FilterDto
            {
                sql = sql,
                param = null // Tidak menggunakan parameter tambahan
            };
        }

        private void LoadData()
        {
            var sqlFilter = Filter() ?? new FilterDto();
            var totalRows = _pelangganDal.GetTotalRows(sqlFilter);

            int showData = (int)numericEntries.Value;
            if (showData <= 0) showData = 1; // Pastikan tidak nol atau negatif

            long totalPages = totalRows > 0 ? (long)Math.Ceiling((double)totalRows / showData) : 1;
            _Totalpage = totalPages > int.MaxValue ? int.MaxValue : (int)totalPages; // Hindari Overflow

            int offset = (_page - 1) * showData;

            lblHalaman.Text = _page.ToString();
            int toValue = Math.Min(offset + showData, totalRows);
            lblShowingEntries.Text = totalRows > 0
                ? $"Showing {offset + 1} to {toValue} of {totalRows} entries"
                : "No entries found";

            // ✅ Tambahkan offset dan showData saat memanggil ListData
            var list = _pelangganDal.ListData(sqlFilter, offset, showData)
                .Select((x, index) => new PelangganModel()
                {
                    No = offset + index + 1,
                    ktp_pelanggan = x.ktp_pelanggan,
                    nama_pelanggan = x.nama_pelanggan,
                    email = x.email,
                    alamat = x.alamat,
                    no_telp = x.no_telp
                }).ToList();

            dataGridView1.DataSource = new SortableBindingList<PelangganModel>(list);
        }




        #endregion

        #region CUSTOM DATAGRID
        private void CustomGrid()
        {
            DataGridView dgv = dataGridView1;
            CustomGrids.CustomDataGrid(dgv);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgv.Columns["ktp_pelanggan"].HeaderText = "No KTP";
            dgv.Columns["nama_pelanggan"].HeaderText = "Nama";
            dgv.Columns["email"].HeaderText = "Email";
            dgv.Columns["alamat"].HeaderText = "Alamat";
            dgv.Columns["no_telp"].HeaderText = "Telepon";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 6;
            dgv.Columns["ktp_pelanggan"].FillWeight = 17;
            dgv.Columns["nama_pelanggan"].FillWeight = 23;
            dgv.Columns["email"].FillWeight = 17;
            dgv.Columns["alamat"].FillWeight = 23;
            dgv.Columns["no_telp"].FillWeight = 14;


            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["ktp_pelanggan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["nama_pelanggan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["email"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["alamat"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dgv.Columns["no_telp"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);


            dgv.Columns["No"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns["ktp_pelanggan"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns["no_telp"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv.Columns["password"].Visible = false;
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


