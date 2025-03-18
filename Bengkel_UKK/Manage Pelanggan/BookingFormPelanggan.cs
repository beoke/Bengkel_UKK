using Bengkel_UKK.Admin.Booking.Batas_Booking;
using Bengkel_UKK.Admin.Booking.Jadwal;
using Bengkel_UKK.Admin.Booking;
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
using Bengkel_UKK.Admin.Dashboard;
using Dapper;
using Syncfusion.Windows.Forms.Tools;

namespace Bengkel_UKK.Manage_Pelanggan
{
    public partial class BookingFormPelanggan : Form
    {
        private readonly BookingDal _bookingDal = new BookingDal();
        private readonly BatasBookingDal _batasBookingDal = new BatasBookingDal();
        private readonly JadwalDal _jadwalDal = new JadwalDal();
        private readonly JadwalOperasionalDal _jadwalOperasionalDal = new JadwalOperasionalDal();

        private byte[] _pending = ImageConvert.ImageToByteArray(ImageConvert.ResizeImageMax(Properties.Resources.Pending, 110, 110));
        private byte[] _dikerjakan = ImageConvert.ImageToByteArray(ImageConvert.ResizeImageMax(Properties.Resources.Dikerjakan, 110, 110));
        private byte[] _belum_bayar = ImageConvert.ImageToByteArray(ImageConvert.ResizeImageMax(Properties.Resources.BelumBayar, 110, 110));
        private byte[] _selesai = ImageConvert.ImageToByteArray(ImageConvert.ResizeImageMax(Properties.Resources.Selesai1, 110, 110));
        private bool _rangeTanggal = false;
        private int _page = 1;
        private int _Totalpage = 1;
        private DateTime _tanggal;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public BookingFormPelanggan(DateTime tanggal = default)
        {
            InitializeComponent();
            InitBatasBooking();
            RegisterEvent();
            LoadData();
            CustomGrid();
            if (tanggal == default)
                tanggal = new DateTime(2025, 1, 1);
            _timer.Interval = 10000;
            _timer.Tick += (s, e) => UpdateAntrean();
            _timer.Start();
        }
        private async void UpdateAntrean()
        {
            if (!await CekAntreanUpdate()) return;
            DateTime now = DateTime.Today;
            var listAntrean = await _bookingDal.ListDataAntrean(now);
            if (!listAntrean.Any()) return;
            int antrean = 1;
            foreach (var item in listAntrean)
            {
                var booking = new BookingModel2
                {
                    id_booking = item.id_booking,
                    antrean = antrean++,
                    tipe_antrean = 2
                };
                _bookingDal.UpdateAntrean(booking);
            }
            LoadData();
            _timer.Stop();
        }
        #region EVENT
        private void RegisterEvent()
        {
            /*btnSearch.Click += (s, e) =>
            {
                if (txtSearch.Text.Length > 0) LoadData();
            };*/
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            detailBookingToolStripMenuItem1.Click += DetailBookingToolStripMenuItem1_Click1; ;
            btnAddData.Click += BtnAddData_Click;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            this.Load += Booking_form_Load;
        }

        private void DetailBookingToolStripMenuItem1_Click1(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return; // Hindari NullReferenceException

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_booking"].Value);

            var detailForm = new DetailBookingPelanggan(id);
            detailForm.ShowDialog();
        }

        private void ComboFilterStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ResetPage();
            LoadData();
        }

        private async void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            await Task.Delay(500);
            ResetPage();
            LoadData();
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new pelangganbooking().ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void ComboFilterWaktu_SelectedValueChanged(object? sender, EventArgs e)
        {
            _rangeTanggal = false;
            ResetPage();
            LoadData();
        }

        private void Tgl_ValueChanged(object? sender, EventArgs e)
        {
            _rangeTanggal = true;
            ResetPage();
            LoadData();
        }

        private void DetailBookingToolStripMenuItem1_Click(object? sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            using (var detailForm = new DetailBookingPelanggan(id))
            {
                detailForm.StartPosition = FormStartPosition.CenterParent;
                detailForm.ShowDialog(); 
            }
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ResetPage()
        {
            _page = 1;
        }
        #endregion

        #region DATAGRID LOAD
        private void LoadData()
        {
            var list = _bookingDal.ListDataByKtp(GlobalVariabel._ktp_pelanggan)
                .Select((x, index) => new BookingDto
                {
                    id_booking = x.id_booking,
                    No = index + 1,
                    antrean = (x.tipe_antrean == 1 ? "A" : "B") + x.antrean.ToString("D3"),
                    ktp_pelanggan = x.ktp_pelanggan == null ? "(Tamu)" : x.ktp_pelanggan,
                    nama_pelanggan = x.nama_pelanggan,
                    no_pol = x.no_pol,
                    nama_kendaraan = x.nama_kendaraan,
                    tanggal = x.tanggal,
                    keluhan = x.keluhan,
                    catatan = x.catatan == null ? "(Belum ada catatan)" : x.catatan,
                    statusImg = x.status == "Menunggu" ? _pending : x.status == "dikerjakan" ? _dikerjakan : _selesai
                }).ToList();

            dataGridView1.DataSource = new SortableBindingList<BookingDto>(list);
        }
        #endregion

        #region INIT COMPONENT

        private void InitBatasBooking()
        {
            int batas = _batasBookingDal.GetBatasBooking(DateTime.Today);
            txtBatas.Text = batas.ToString();
        }
        #endregion


        #region DATAGRID CUSTOM
        private void CustomGrid()
        {
            DataGridView dgv = dataGridView1;
            CustomGrids.CustomDataGrid(dgv);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0);

            dgv.Columns["id_kendaraan"].Visible = false;

            dgv.Columns["id_booking"].Width = 10;
            dgv.Columns["No"].Width = 70;
            dgv.Columns["antrean"].Width = 100;
            dgv.Columns["ktp_pelanggan"].Width = 200;
            dgv.Columns["nama_pelanggan"].Width = 250;
            dgv.Columns["no_pol"].Width = 150;
            dgv.Columns["nama_kendaraan"].Width = 250;
            dgv.Columns["tanggal"].Width = 200;
            dgv.Columns["keluhan"].Width = 250;
            dgv.Columns["catatan"].Width = 250;
            dgv.Columns["statusImg"].Width = 180;

            dgv.Columns["antrean"].HeaderText = "Antrean";
            dgv.Columns["ktp_pelanggan"].HeaderText = "KTP Pelanggan";
            dgv.Columns["nama_pelanggan"].HeaderText = "Pelanggan";
            dgv.Columns["no_pol"].HeaderText = "Nomor Polisi";
            dgv.Columns["nama_kendaraan"].HeaderText = "Kendaraan";
            dgv.Columns["tanggal"].HeaderText = "Tanggal";
            dgv.Columns["keluhan"].HeaderText = "Keluhan";
            dgv.Columns["catatan"].HeaderText = "Catatan";
            dgv.Columns["statusImg"].HeaderText = "Status";

            string[] columnPadding = { "No", "antrean", "ktp_pelanggan", "nama_pelanggan", "no_pol", "nama_kendaraan", "tanggal", "keluhan", "catatan" };
            foreach (var col in columnPadding)
                dgv.Columns[col].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);


            dgv.Columns["id_booking"].Visible = false;
            dgv.Columns["statusImg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["id_booking"].Frozen = true;
            dgv.Columns["No"].Frozen = true;
            dgv.Columns["ktp_pelanggan"].Frozen = true;
            dgv.Columns["nama_pelanggan"].Frozen = true;

            string[] columnSort = { "No", "ktp_pelanggan", "nama_pelanggan", "no_pol", "keluhan", "catatan", "statusImg" };
            foreach (var col in columnSort)
                dgv.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
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
                TextRenderer.DrawText(e.Graphics, e.FormattedValue?.ToString() ?? "", e.CellStyle.Font, paddedBounds, e.CellStyle.ForeColor, flags);

                // Jika kolom sedang diurutkan, gambar panah
                if (dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    int arrowWidth = 10; // Lebar panah
                    int arrowHeight = 10; // Tinggi panah
                    int textWidth = TextRenderer.MeasureText(e.FormattedValue?.ToString() ?? "", e.CellStyle.Font).Width;
                    int arrowX = paddedBounds.Left + textWidth + 2; // Posisi X panah
                    int arrowY = e.CellBounds.Top + (e.CellBounds.Height - arrowHeight) / 2; // Posisi vertikal tengah

                    using (var sortGlyph = CreateSortGlyph(dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection))
                    {
                        if (sortGlyph != null) // Pastikan gambar tidak null sebelum menggambar
                        {
                            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            e.Graphics.DrawImage(sortGlyph, arrowX, arrowY, arrowWidth, arrowHeight);
                        }
                    }
                }

                // Mencegah rendering default header
                e.Handled = true;

                if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hanya proses header kolom
                {
                    // Daftar kolom yang ingin diterapkan CellPainting
                    string[] targetColumns = { "statusImg" };

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
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["NO"].Value = i + 1;
                }
                e.Handled = true; // Tandai event sebagai sudah dihandle
            }
        }

        private Bitmap CreateSortGlyph(SortOrder sortOrder)
        {
            string assetPath = Path.Combine(Application.StartupPath, "Assets");

            string imagePath = sortOrder == SortOrder.Ascending
                ? Path.Combine(assetPath, "ArrowUp.png")
                : Path.Combine(assetPath, "ArrowDown.png");

            if (File.Exists(imagePath))
            {
                return (Bitmap)Image.FromFile(imagePath);
            }

            return null; // Bisa diganti dengan gambar default jika file tidak ditemukan
        }
        private void Booking_form_Load(object? sender, EventArgs e)
        {
            DataGridViewColumn targetColumn = dataGridView1.Columns["Antrean"];

            if (targetColumn != null)
            {
                // Atur pengurutan ascending pada kolom tersebut
                dataGridView1.Sort(targetColumn, ListSortDirection.Ascending);

                // Atur tanda panah (sort glyph) pada header kolom
                targetColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
        }
        #endregion

        #region HELPER

        private async Task<bool> CekAntreanUpdate()
        {
            DateTime tanggal = DateTime.Today;

            var libur = await _jadwalDal.CekLibur(tanggal);
            if (libur) return true;

            var tutup = await _jadwalOperasionalDal.CekTutup(tanggal);
            if (tutup) return true;
            return false;
        }

        #endregion
    }
} 
