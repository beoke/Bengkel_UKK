using Bengkel_UKK.Admin.Kendaraan;
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

namespace Bengkel_UKK.Manage_Pelanggan
{
    public partial class KendaraanPelanggan : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        public KendaraanPelanggan(string noktp)
        {
            InitializeComponent();

            LoadData();
            CustomGrid();
            RegisterEvent();
        }
        private void RegisterEvent()
        {
            btnAddData.Click += (s, e) =>
            {
                InputKendaraan_form input = new InputKendaraan_form();
                input.ShowDialog();
                LoadData();
            };
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }
        private void CustomGrid()
        {
            DataGridView dgv = dataGridView1;
            CustomGrids.CustomDataGrid(dgv);

            List<string> list = new List<string>() { "No", "nama_pelanggan", "no_pol", "merk", "tipe", "kapasitas", "tahun", "transmisi" };
            foreach (string s in list)
            {
                dgv.Columns[s].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }


            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.Columns["No"].FillWeight = 6;
            dgv.Columns["nama_pelanggan"].FillWeight = 25;
            dgv.Columns["no_pol"].FillWeight = 13;
            dgv.Columns["merk"].FillWeight = 15;
            dgv.Columns["tipe"].FillWeight = 13;
            dgv.Columns["kapasitas"].FillWeight = 10;
            dgv.Columns["tahun"].FillWeight = 10;
            dgv.Columns["transmisi"].FillWeight = 10;
        //    dgv.Columns["total_servis"].FillWeight = 13;

            dgv.Columns["nama_pelanggan"].HeaderText = "Pemilik";
            dgv.Columns["no_pol"].HeaderText = "No. Polisi";
            dgv.Columns["merk"].HeaderText = "Merk";
            dgv.Columns["tipe"].HeaderText = "Tipe";
            dgv.Columns["kapasitas"].HeaderText = "Kapasitas (cc)";
            dgv.Columns["tahun"].HeaderText = "Tahun";
            dgv.Columns["transmisi"].HeaderText = "Transmisi";
       //     dgv.Columns["total_servis"].HeaderText = " Total Servis";

            dgv.Columns["id_kendaraan"].Visible = false;

            //      dgv.Columns["total_servis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //untuk style
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }
        private void LoadData()
        {
            var list = _kendaraanDal.ListDataByKtp(GlobalVariabel._ktp_pelanggan)
                .Select((x, index) => new
                {
                    id_kendaraan = x.id_kendaraan,
                    No = index + 1,
                    nama_pelanggan = x.nama_pelanggan,
                    no_pol = x.no_pol,
                    merk = x.merk,
                    tipe = x.tipe,
                    transmisi = x.transmisi,
                    kapasitas = x.kapasitas + "cc",
                    tahun = x.tahun,
                   // total_servis = x.total_servis
                }).ToList();

            dataGridView1.DataSource = list;
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

              /*  if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hanya proses header kolom
                {
                    // Daftar kolom yang ingin diterapkan CellPainting
                    string[] targetColumns = { "total_servis" };

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
                e.Handled = true; // Tandai event sebagai sudah dihandle*/
            }
        }

        private Bitmap CreateSortGlyph(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Ascending)
                return (Bitmap)Properties.Resources.ArrowUp;
            else
                return (Bitmap)Properties.Resources.ArrowDown;

        }
    }
}
