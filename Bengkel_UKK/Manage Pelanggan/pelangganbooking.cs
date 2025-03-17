using Bengkel_UKK.Admin.Booking.Batas_Booking;
using Bengkel_UKK.Admin.Booking.Jadwal;
using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Kendaraan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bengkel_UKK.Helper;
using Syncfusion.Windows.Forms.Tools;
using Bengkel_UKK.Admin.Booking.Booking;

namespace Bengkel_UKK.Manage_Pelanggan
{
    public partial class pelangganbooking : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        private readonly BookingDal _bookingDal = new BookingDal();
        private readonly BatasBookingDal _batasBookingDal = new BatasBookingDal();
        private readonly JadwalDal _jadwalDal = new JadwalDal();
        private readonly JadwalOperasionalDal _jadwalOperasionalDal = new JadwalOperasionalDal();
        public static int _antrean;
        public pelangganbooking()
        {
            InitializeComponent();
            InitComponent_Pelanggan();
            RegisterEvent_Pelanggan();
            CekKetersediaanBoking();
        }
        private void RegisterEvent_Pelanggan()
        {
            StyleComponent.TextChangeNull(txtKeluhan, lblErrorKeluhan, "⚠️ Harap isi keluhan!");

            txtNoKTP.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    LoadData_Pelanggan();
                }
            };
            comboKendaraan.SelectedIndexChanged += (s, e) =>
            {
                txtNoPol.Text = ((KendaraanDto)comboKendaraan.SelectedItem)?.no_pol ?? string.Empty;
            };
            btnSearch.Click += (s, e) => LoadData_Pelanggan();
            btnSave.Click += (s, e) => SaveData_Pelanggan();
            btnCancel.Click += (s, e) => this.Close();
            TglEditSync.ValueChanged += async (s, e) =>
            {
                await Task.Delay(500);
                CekKetersediaanBoking();
            };
        }
        private async void CekKetersediaanBoking()
        {
            DateTime tanggal = TglEditSync.Value ?? DateTime.Today;

            var libur = await _jadwalDal.CekLibur(tanggal);
            if (libur)
            {
                lblErrorTanggal.Text = "Bengkel sedang libur, Mohon pilih tanggal lain!";
                lblErrorTanggal.Visible = true;
                return;
            }

            var tutup = await _jadwalOperasionalDal.CekTutup(tanggal);
            if (tutup)
            {
                lblErrorTanggal.Text = "Bengkel sudah tutup, Mohon pilih tanggal lain!";
                lblErrorTanggal.Visible = true;
                return;
            }

            var totalBooking = _bookingDal.GetAntrean(tanggal, 1)?.Antrean - 1;
            var maxBooking = _batasBookingDal.GetBatasBooking(tanggal);

            if (totalBooking >= maxBooking)
            {
                lblErrorTanggal.Text = "Antrean sudah penuh, Mohon pilih tanggal lain!";
                lblErrorTanggal.Visible = true;
                return;
            }
            lblErrorTanggal.Visible = false;
        }
        private void InitComponent_Pelanggan()
        {
            txtNama.MaxLength = 100;
            txtNoKTP.MaxLength = 90;
            txtKeluhan.MaxLength = 100;
            TglEditSync.MinDateTime = DateTime.Today;
            TglEditSync.StyleDateTimeEdit();
        }
        private void LoadData_Pelanggan()
        {
            ClearInput();
            var kendaraanPelanggan = _kendaraanDal.ListDataPelanggan(txtNoKTP.Text.Trim());

            if (kendaraanPelanggan == null) return;
            if (!kendaraanPelanggan.Any())
            {
                lblErrorKTP.Visible = true;
                comboKendaraan.DataSource = null;
                return;
            }
            lblErrorKTP.Visible = false;
            var data = kendaraanPelanggan.FirstOrDefault();

            txtNama.Text = data?.nama_pelanggan;
            var listkendaraan = kendaraanPelanggan
                .Select(x => new KendaraanDto
                {
                    id_kendaraan = x.id_kendaraan,
                    nama_kendaraan = $"{x.merk} {x.tipe} {x.kapasitas}cc ({x.tahun})",
                    no_pol = x.no_pol
                }).ToList();
            comboKendaraan.DataSource = listkendaraan;
            comboKendaraan.DisplayMember = "nama_kendaraan";
            comboKendaraan.ValueMember = "id_kendaraan";

            txtNoPol.Text = ((KendaraanDto)comboKendaraan.SelectedItem)?.no_pol ?? string.Empty;
        }
        private void ClearInput()
        {
            txtNama.Clear();
            txtNoPol.Clear();
        }
        private void SaveData_Pelanggan()
        {
            string noKTP = txtNoKTP.Text;
            int id_kendaraan = Convert.ToInt32(comboKendaraan?.SelectedValue);
            DateTime tanggal = TglEditSync.Value ?? DateTime.Today;
            string keluhan = txtKeluhan.Text;

            if (noKTP == string.Empty || id_kendaraan == 0 || keluhan == string.Empty)
            {
                PesanBox.Warning("Harap melengkapi data!");
                return;
            }

            bool valid = !lblErrorKTP.Visible &&
                         !lblErrorKeluhan.Visible &&
                         !lblErrorTanggal.Visible;
            if (!valid)
            {
                PesanBox.Warning("Data tidak valid, mohon cek kembali!");
                return;
            }
            if (new Antrean_form(tanggal).ShowDialog() == DialogResult.OK)
            {
                var data = new BookingModel2
                {
                    ktp_pelanggan = noKTP,
                    id_kendaraan = id_kendaraan,
                    tanggal = tanggal,
                    keluhan = keluhan,
                    antrean = _antrean,
                    status = "Menunggu"
                };
                _bookingDal.InsertDataBooking(data, true);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
