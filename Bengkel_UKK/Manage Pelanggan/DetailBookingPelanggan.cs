using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Jasa_Service;
using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Admin.Produk;
using Bengkel_UKK.Admin.Riwayat;
using Bengkel_UKK.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Manage_Pelanggan
{
    public partial class DetailBookingPelanggan : Form
    {
        private readonly BookingDal _bookingDal = new BookingDal();
        private readonly JasaServiceDal _jasaServisDal = new JasaServiceDal();
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        private readonly ProdukDal _produkDal = new ProdukDal();
        private readonly RiwayatDal _riwayatDal = new RiwayatDal();
        public static int _id_booking;
        private string _servisKeterangan = "pending";
        private string _serviceKeterangan = "DIbatalkan";
        private bool _invoiceShow = false;
        private static int id_kendaraan;
        Color _hijau = Color.FromArgb(0, 192, 0);
        Color _oren = Color.FromArgb(240, 177, 0);
        Color _biru = Color.FromArgb(52, 152, 219);
        Color _merah = Color.FromArgb(239, 7, 7); //merah
        public DetailBookingPelanggan(int id)
        {
            InitializeComponent();
            _id_booking = id;
            GetData();
            btnBatalkanPesanan.Click += BtnBatalkanPesanan_Click;
        }

        private void BtnBatalkanPesanan_Click(object? sender, EventArgs e)
        {
            if (txt_pembatalan.TextLength == 0)
            {
                PesanBox.Warning("Mohon mengisi alasan pembatalan pada catatan!");
                return;
            }
            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin membatalkan pesanan ini?\nIsi alasan pembatalan pada catatan")) return;
            CancelServis();
        }
        private async void CancelServis()
        {
            if (string.IsNullOrEmpty(lblIdBooking.Text))
            {
                PesanBox.Warning("Tidak ada servis yang dipilih!");
                return;
            }

            string idServis = lblIdBooking.Text;

            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin membatalkan servis ini?",
                                             "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.No)
                return;

            // Panggil DAL untuk update status servis ke 'Dibatalkan'
            bool hasil = await _bookingDal.CancelServiceAsync(idServis);

            if (hasil)
            {
                PesanBox.Informasi("Servis berhasil dibatalkan.");
                this.Close();
            }
            else
            {
                PesanBox.Error("Gagal membatalkan servis. Silakan coba lagi.");
            }
            btnBatalkanPesanan.Visible = false;
        }
      

        private void GetData()
        {
            var data = _bookingDal.GetData(_id_booking);
            if (data is null) return;

            id_kendaraan = data.id_kendaraan;
            lblIdBooking.Text = data.id_booking.ToString();
            lblNama.Text = data.nama_pelanggan;
            lblNoKTP.Text = data.ktp_pelanggan;
            lblKendaraan.Text = data.nama_kendaraan;
            lblNoPol.Text = data.no_pol;
            lblTanggal.Text = data.tanggal.ToString("d MMMM yyyy", new CultureInfo("id-ID"));
            lblKeluhan.Text = data.keluhan;
            lblAntrean.Text =$"B00{data.antrean}";
        }
    }
}
