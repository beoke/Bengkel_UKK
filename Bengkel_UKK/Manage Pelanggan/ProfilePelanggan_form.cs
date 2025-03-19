using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Kendaraan;
using Bengkel_UKK.Helper;
using DocumentFormat.OpenXml.Wordprocessing;
using Sodium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Bengkel_UKK.Admin.Pelanggan
{
    public partial class ProfilePelanggan_form : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        public ProfilePelanggan_form(string noktp)
        {
            InitializeComponent();
            Getdata(noktp);
            RegisterEvent();
            CustomGrid();
            LoadData();
        }
        private void Getdata(string ktp_pelanggan)
        {
            var data = _pelangganDal.GetDataByKTP(ktp_pelanggan);
            if (data == null) return;

            txtNama.Text = data.nama_pelanggan;
            txtEmail.Text = data.email.ToString();
            txtPassword.Text = data.nama_pelanggan;
            txtNoKTP.Text = data.ktp_pelanggan;
            txtNoTelp.Text = data.no_telp;
            txtAlamat.Text = data.alamat;
        }
        private void RegisterEvent()
        {
            btn_edit.Click += Btn_edit_Click;
            buttonSave.Click += ButtonSave_Click; 
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtNoKTP.Text) ||
               string.IsNullOrWhiteSpace(txtNoTelp.Text) ||
               string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pelanggan = new PelangganModelUpdate
            {
                ktp_pelanggan_old = txtNoKTP.Tag?.ToString(),  // Simpan KTP lama di Tag saat form dibuka
                ktp_pelanggan_new = txtNoKTP.Text,
                nama_pelanggan = txtNama.Text,
                email = txtEmail.Text,
                password = txtPassword.Text,  // Jangan lupa menyimpan password jika perlu
                no_telp = txtNoTelp.Text,
                alamat = txtAlamat.Text
            };

            try
            {
                _pelangganDal.UpdateData(pelanggan);
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kunci kembali inputan
                txtNama.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtNoKTP.ReadOnly = true;
                txtNoTelp.ReadOnly = true;
                txtAlamat.ReadOnly = true;

                // Nonaktifkan tombol Save lagi
                buttonSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui data! \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_edit_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda ingin mengedit data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Aktifkan input untuk diedit
                txtNama.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtNoKTP.ReadOnly = false;
                txtNoTelp.ReadOnly = false;
                txtAlamat.ReadOnly = false;

                // Aktifkan tombol Save
                buttonSave.Enabled = true;
            }
        }

        private void ProfilePelanggan_form_Load(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
        }
        private void Btn_save_Click(object? sender, EventArgs e)
        {   
            SaveData();
        }
        private void SaveData()
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string noKTP = txtNoKTP.Text.Trim();
            string noTelp = txtNoTelp.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string oldKTP = txtNoKTP.Tag?.ToString() ?? string.Empty; // Ambil KTP lama untuk update

            // Validasi input
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(noKTP) ||
                string.IsNullOrWhiteSpace(noTelp) || string.IsNullOrWhiteSpace(alamat))
            {
                PesanBox.Warning("Semua kolom harus diisi!");
                return;
            }

            // Periksa apakah ada perubahan KTP
            if (noKTP != oldKTP)
            {
                var existingData = _pelangganDal.GetDataByKTP(noKTP);
                if (existingData != null)
                {
                    PesanBox.Error("KTP sudah terdaftar! Gunakan KTP lain.");
                    return;
                }
            }

            // Hash password hanya jika berubah
            var oldData = _pelangganDal.GetDataByKTP(oldKTP);
            string hashedPassword = (oldData != null && oldData.password == password)
                                    ? password
                                    : PasswordHash.ArgonHashString(password);

            var pelanggan = new PelangganModelUpdate
            {
                ktp_pelanggan_old = oldKTP, // Gunakan KTP lama untuk referensi update
                ktp_pelanggan_new = noKTP,
                nama_pelanggan = nama,
                email = email,
                password = hashedPassword,
                no_telp = noTelp,
                alamat = alamat
            };

            bool result = _pelangganDal.UpdateDatabyktp(pelanggan);

            if (result)
            {
                PesanBox.Informasi("Data berhasil diperbarui!");
                this.Close();
            }
            else
            {
                PesanBox.Error("Gagal memperbarui data!");
            }
        }

        private void Getdataa(string ktp_pelanggan)
        {
            var data = _pelangganDal.GetDataByKTP(ktp_pelanggan);
            if (data == null) return;

            txtNama.Text = data.nama_pelanggan;
            txtEmail.Text = data.email; // Tidak perlu `.ToString()` karena sudah string
            txtPassword.Text = data.password;
            txtNoKTP.Text = data.ktp_pelanggan;
            txtNoTelp.Text = data.no_telp;
            txtAlamat.Text = data.alamat;

            // Simpan KTP lama sebagai referensi saat update
            txtNoKTP.Tag = data.ktp_pelanggan;
        }

        private void CustomGrid()
        {
            DataGridView dgv = dataGridView1;
            CustomGrids.CustomDataGrid(dgv);

             List<string> list = new List<string>() {
                "nama_pelanggan", "no_pol",
                "merk", "tipe", "transmisi", "kapasitas",
                "tahun", "total_servis"  
            };

            foreach (string s in list)
            {
                if (dgv.Columns.Contains(s)) // Cek apakah kolom ada sebelum diakses
                {
                    dgv.Columns[s].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
                }
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string[] columnsToFormat = {  "nama_pelanggan", "no_pol", "merk",
                                 "tipe", "kapasitas", "tahun", "transmisi", "total_servis" };

             Dictionary<string, float> fillWeights = new Dictionary<string, float>
            {
                { "nama_pelanggan", 25 }, { "no_pol", 13 },
                { "merk", 15 }, { "tipe", 13 }, { "kapasitas", 10 },
                { "tahun", 10 }, { "transmisi", 10 }, { "total_servis", 13 }
            };

                    Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "nama_pelanggan", "Pemilik" }, { "no_pol", "No. Polisi" },
                { "merk", "Merk" }, { "tipe", "Tipe" }, { "kapasitas", "Kapasitas (cc)" },
                { "tahun", "Tahun" }, { "transmisi", "Transmisi" }, { "total_servis", "Total Servis" }
            };

            foreach (var column in columnsToFormat)
            {
                if (dgv.Columns.Contains(column))
                {
                    dgv.Columns[column].FillWeight = fillWeights[column];
                    if (headers.ContainsKey(column))
                        dgv.Columns[column].HeaderText = headers[column];
                }
            }

           /* if (dgv.Columns.Contains("id_kendaraan"))
                dgv.Columns["id_kendaraan"].Visible = false;*/

            if (dgv.Columns.Contains("total_servis"))
                dgv.Columns["total_servis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //untuk style
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadData()
        {
            string ktp_pelanggan = GlobalVariabel._ktp_pelanggan;
            // Ambil KTP pelanggan dari sesi global
            var data = _kendaraanDal.GetdataByKTP(ktp_pelanggan);

            if (data == null) // Jika tidak ada data, tampilkan kosong
            {
                dataGridView1.DataSource = new List<object>();
                return;
            }

            var list = _kendaraanDal.GetdataByKTP(ktp_pelanggan)
                .Select((x, index) => new
                {
                    No = index + 1,
                //    id_kendaraan = x.id_kendaraan,
                //  nama_pelanggan = x.nama_pelanggan,
                    no_pol = x.no_pol,
                    merk = x.merk,
                    tipe = x.tipe,
                    transmisi = x.transmisi,
                    kapasitas = x.kapasitas + "cc",
                    tahun = x.tahun,
                    total_servis = x.total_servis
                }).ToList();

            // Tampilkan di DataGridView
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

                if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hanya proses header kolom
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
                e.Handled = true; // Tandai event sebagai sudah dihandle
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
