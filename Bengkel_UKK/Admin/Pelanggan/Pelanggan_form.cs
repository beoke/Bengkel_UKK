﻿using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        private bool _btnMain = true;
        public Pelanggan_form()
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
            btnSearch.Visible = false;
        }
        #region INIT COMPONENT

        private void InitComponent()
        {
            List<string> listFilter = new List<string>() { "Semua(All)", "Sudah Melengkapi Data", "Belum Melengkapi Data" };
            comboFilter.DataSource = listFilter;

            numericEntries.Minimum = 4;
        }

        #endregion

        #region EVENT
        private void RegisterEvent()
        {
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            btnAddData.Click += (s, e) =>
            {
                if (!_btnMain)
                {
                    Image img = Properties.Resources.plusDark;
                    StyleComponent.ControlButtonMainDelete(btnAddData, DataHapus_Button, img, true, "Pelanggan");
                    _btnMain = true;
                    LoadData();
                    return;
                }
                if (new InputPelanggan_form("").ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            };
            DataHapus_Button.Click += (s, e) =>
            {
                if (_btnMain)
                {
                    Image img = Properties.Resources.plusPutih;
                    StyleComponent.ControlButtonMainDelete(btnAddData, DataHapus_Button, img, false, "Pelanggan");
                    _btnMain = false;
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
            comboFilter.SelectedIndexChanged += (s, e) => LoadData();
            btnNext.Click += (s, e) =>
            {
                if (_page < _Totalpage)
                {
                    _page++;
                    LoadData();
                }
            };
            btnPrevious.Click += (s, e) =>
            {
                if (_page > 1)
                {
                    _page--;
                    LoadData();
                }
            };
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick; ;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click; ;
            hapusToolStripMenuItem.Click += HapusToolStripMenuItem_Click; ;
            kembalikanToolStripMenuItem.Click += KembalikanToolStripMenuItem_Click; ;

        }

        private void KembalikanToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin memulihkan data?")) return;
            string ktp = dataGridView1.CurrentRow.Cells["ktp_pelanggan"].Value?.ToString() ?? string.Empty;
            _pelangganDal.RestoreData(ktp);
            LoadData();
        }

        private void HapusToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                PesanBox.Warning("Pilih data yang ingin dihapus!");
                return;
            }

            if (!PesanBox.Konfirmasi("Apakah Anda yakin ingin menghapus data?")) return;

            string ktp = dataGridView1.CurrentRow.Cells["ktp_pelanggan"].Value?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(ktp))
            {
                PesanBox.Error("Data KTP tidak valid!");
                return;
            }

            bool success = _pelangganDal.SoftDeleteData(ktp);

            if (success)
            {
                PesanBox.Informasi("Data berhasil dihapus.");
                LoadData(); 
            }
            else
            {
                PesanBox.Error("Gagal menghapus data. Mungkin data tidak ditemukan.");
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string ktp = dataGridView1.CurrentRow.Cells["ktp_pelanggan"].Value?.ToString() ?? string.Empty;
            if (new InputPelanggan_form(ktp, false).ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (_btnMain)
                    contextMenuStrip1.Show(Cursor.Position);
                else
                    contextMenuStrip2.Show(Cursor.Position);
            }
        }

        private void ResetPage()
        {
            _page = 1;
        }
        #endregion

        #region LOAD DATAGRID
        private FilterDto? Filter()
        {
            string search = txtSearch.Text;
            bool dataActive = _btnMain;
            int indexFilter = comboFilter.SelectedIndex;

            string sql = @"";
            var dp = new DynamicParameters();
            List<string> fltr = new List<string>();

            if (search != string.Empty)
            {
                fltr.Add("(ktp_pelanggan LIKE @search + '%' OR nama_pelanggan LIKE '%' + @search + '%' OR email LIKE '%' + @search + '%' OR alamat LIKE '%' + @search + '%' OR no_telp LIKE '%' + @search + '%')");
                dp.Add(@"search", search);
            }

            if (indexFilter == 1) fltr.Add("(no_telp IS NOT NULL)");
            if (indexFilter == 2) fltr.Add("(no_telp IS NULL)");

            if (dataActive)
                fltr.Add("(deleted_at IS NULL)");
            else
                fltr.Add("(deleted_at IS NOT NULL)");

            if (fltr.Count > 0)
                sql += " WHERE " + string.Join(" AND ", fltr);


            var filterResult = new FilterDto
            {
                sql = sql,
                param = dp
            };
            return filterResult;
        }

        private void LoadData()
        {
            var sqlFilter = Filter() ?? new FilterDto();
            var totalRows = _pelangganDal.GetTotalRows(sqlFilter);

            int showData = (int)numericEntries.Value;
            _Totalpage = Convert.ToInt32(Math.Ceiling((double)totalRows / showData));
            int offset = (_page - 1) * showData;
            sqlFilter.param.Add("@offset", offset);
            sqlFilter.param.Add("@fetch", showData);

            lblHalaman.Text = _page.ToString();
            int toValue = Math.Min(offset + showData, totalRows);
            lblShowingEntries.Text = $"Showing {offset + 1} to {toValue} of {totalRows} entries";

            var list = _pelangganDal.ListData(sqlFilter)
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

            //untuk style
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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


