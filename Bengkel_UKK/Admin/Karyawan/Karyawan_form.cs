using Bengkel_UKK.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools; // Pastikan namespace ini ditambahkan

namespace Bengkel_UKK.Admin.Karyawan
{
    public partial class Karyawan_form : Form
    {
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        private int page = 1;
        private byte[] _defaultProfile = ImageDirectory._defaultProfile;
        // Tambahkan variabel ini di dalam class untuk menyimpan data asli
        private List<KaryawanDto> _originalData = new List<KaryawanDto>();
        public Karyawan_form()
        {
            InitializeComponent();
            RegisterEvent();
            InitCombo();

            LoadData();
            CustomGrid();
        }
        private void RegisterEvent()
        {
            yogaPanel1.Resize += (s, e) => yogaPanel1.Invalidate();
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            btnAddData.Click += BtnAddData_Click;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            hapusToolStripMenuItem.Click += HapusToolStripMenuItem_Click;
          //  dataGridView1.Paint += DataGridView1_Paint; ;
        }

        private void HapusToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ktp_admin = dataGridView1.SelectedRows[0].Cells["ktp_admin"].Value.ToString();

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _karyawanDal.DeleteData(ktp_admin);
                LoadData(); // 🔄 Update DataGridView setelah penghapusan
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string ktp_admin = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            if (new InputKaryawan_form(ktp_admin, false).ShowDialog() != DialogResult.OK) return;
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            InputKaryawan_form form = new InputKaryawan_form("", true);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.DataUpdated += LoadData; // 🚀 Hubungkan event ke LoadData
            form.ShowDialog();
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
            }
            lblHalaman.Text = page.ToString();
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (page <= 10)
            {
                page++;
            }
            lblHalaman.Text = page.ToString();
        }

        #region COMBO BOX
        private void InitCombo()
        {
            List<string> job = new List<string>()
            {
                "Semua (All)", "Petugas", "Mekanik", "Super Admin"
            };
            comboFilter.DataSource = job;
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged; // Tambahkan event handler

            List<int> listPerPage = new List<int>()
            {
                0, 10, 25, 50,
            };
            line_combo.DataSource = listPerPage;
            line_combo.SelectedIndexChanged += Line_combo_SelectedIndexChanged;
        }
        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text, comboFilter.SelectedItem?.ToString());
        }

        private void Line_combo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_karyawanDal == null || _originalData == null) return;
            int limit = Convert.ToInt32(line_combo.SelectedItem);

            var filteredList = _originalData
                .Where(x => (string.IsNullOrEmpty(txtSearch.Text) ||
                            x.Nama.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                            x.ktp_admin.Contains(txtSearch.Text)) &&
                            (comboFilter.SelectedItem?.ToString() == "Semua (All)" ||
                            x.Role == comboFilter.SelectedItem?.ToString()))
                .Take(limit == 0 ? _originalData.Count : limit) // Jika 0, tampilkan semua
                .ToList();

            // Update DataGridView
            dataGridView1.DataSource = new SortableBindingList<KaryawanDto>(filteredList);
        }
        #endregion

        #region DATAGRID
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
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
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
            dataGridView1.Columns["No"].FillWeight = 6;
            dataGridView1.Columns["ktp_admin"].FillWeight = 9;
            dataGridView1.Columns["Foto"].FillWeight = 10;
            dataGridView1.Columns["Nama"].FillWeight = 16;
            dataGridView1.Columns["Email"].FillWeight = 15;
            dataGridView1.Columns["Password"].FillWeight = 10;
            dataGridView1.Columns["Telepon"].FillWeight = 12;
            dataGridView1.Columns["Alamat"].FillWeight = 12;
            dataGridView1.Columns["Role"].FillWeight = 10;

            dataGridView1.Columns["No"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["ktp_admin"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Foto"].DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGridView1.Columns["Nama"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Email"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Password"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Telepon"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Alamat"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            dataGridView1.Columns["Role"].DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);

            dataGridView1.Columns["Foto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["No"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["ktp_admin"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Password"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Telepon"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Role"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.Columns["ktp_admin"].HeaderText = "No KTP";


            // supaya password tidak terlihat
            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
                {
                    e.Value = "********"; // Menampilkan selalu 8 bintang
                    e.FormattingApplied = true;
                }
            };

        }


        private void LoadData()
        {
            int number = 1;
            _originalData = _karyawanDal.ListData() // Simpan data asli saat pertama kali di-load
                .Select(x => new KaryawanDto()
                {
                    No = number++,
                    ktp_admin = x.ktp_admin,
                    Foto = x.image_data != null ? ImageConvert.ImageToByteArray(
                        ImageConvert.ResizeImageMax(ImageConvert.CropToCircle(
                        ImageConvert.ResizeImageMax(ImageConvert.Image_ByteToImage(x.image_data), 400, 400)), 45, 45))
                        : _defaultProfile,
                    Nama = x.nama_admin,
                    Email = x.email,
                    Password = x.password,
                    Telepon = x.no_telp,
                    Alamat = x.alamat,
                    Role = x.role == 1 ? "Petugas" : "Super Admin",
                })
                .ToList();

            dataGridView1.DataSource = new SortableBindingList<KaryawanDto>(_originalData);
        }


        private void DataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Proses hanya header kolom
            {
               
                // Gambar latar belakang header default
                e.PaintBackground(e.CellBounds, true);

                // Tentukan padding
                Rectangle paddedBounds = e.CellBounds;
                paddedBounds.X += 20; // Padding kiri
                paddedBounds.Width -= 20; // Sesuaikan lebar setelah padding

                // Tentukan alignment teks
                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

                // Jika kolom yang diproses adalah "Foto" atau "Role", ubah alignment ke tengah
                string[] targetColumns = { "Foto", "Role" };
                if (targetColumns.Contains(dataGridView1.Columns[e.ColumnIndex].Name))
                {
                    flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                    paddedBounds = e.CellBounds; // Reset padding untuk kolom ini
                }

                // Gambar teks header
                TextRenderer.DrawText(e.Graphics, e.FormattedValue?.ToString() ?? "", e.CellStyle.Font, paddedBounds, e.CellStyle.ForeColor, flags);

                // Jika kolom sedang diurutkan, tambahkan ikon panah sorting
                if (dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    int arrowSize = 10; // Ukuran panah kecil
                    int textWidth = TextRenderer.MeasureText(e.FormattedValue?.ToString() ?? "", e.CellStyle.Font).Width;
                    int arrowX = paddedBounds.Left + textWidth + 5; // Beri jarak 5px dari teks
                    int arrowY = e.CellBounds.Top + (e.CellBounds.Height - arrowSize) / 2; // Posisi tengah

                    using (var sortGlyph = CreateSortGlyph(dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection))
                    {
                        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.DrawImage(sortGlyph, arrowX, arrowY, arrowSize, arrowSize);
                    }
                }

                e.Handled = true; // Tandai bahwa event sudah ditangani
            }
        }

        #region shorting
      /*  private void DataGridView1_Paint(object? sender, PaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null || dgv.SortedColumn == null) return;

            // Ambil informasi kolom yang sedang diurutkan
            DataGridViewColumn sortedColumn = dgv.SortedColumn;
            Rectangle headerRect = dgv.GetColumnDisplayRectangle(sortedColumn.Index, true);

            if (headerRect.Width == 0 || headerRect.Height == 0) return;

            // Buat ikon panah di ujung kanan header
            int iconSize = 12;
            int paddingRight = 10;
            int iconX = headerRect.Right - iconSize - paddingRight;
            int iconY = headerRect.Top + (headerRect.Height - iconSize) / 2;

            using (Bitmap sortIcon = CreateSortGlyph(dgv.SortOrder))
            {
                e.Graphics.DrawImage(sortIcon, new Rectangle(iconX, iconY, iconSize, iconSize));
            }
        }*/

        private Bitmap CreateSortGlyph(SortOrder sortOrder)
        {

            int width = 12, height = 12;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Font font = new Font("Arial", 10, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.White))
                {
                    string arrow = sortOrder == SortOrder.Ascending ? "▲" : "▼";
                    g.DrawString(arrow, font, brush, new PointF(0, 0));
                }
            }
            return bmp;
        }
        #endregion

        #endregion

        #region SEARCH
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text, comboFilter.SelectedItem?.ToString());
            CustomGrid(); // Pastikan tampilan tetap konsisten
        }
        private void SearchData(string keyword, string roleFilter)
        {
            var filteredList = _originalData
                 .Where(x => (string.IsNullOrEmpty(keyword) ||
                     x.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                     x.ktp_admin.Contains(keyword)) &&
                     (roleFilter == "Semua (All)" || x.Role == roleFilter))
                 .ToList();

            dataGridView1.DataSource = new SortableBindingList<KaryawanDto>(filteredList);

        }
        #endregion
    }
}

    public class KaryawanDto
{
    public int No { get; set; }
    public string ktp_admin { get; set; }
    public byte[] Foto { get; set; }
    public string Nama { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Telepon { get; set; }
    public string Alamat { get; set; }
    public string Role { get; set; }
}
