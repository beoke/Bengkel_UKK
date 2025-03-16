using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Helper;
using Sodium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Kendaraan
{
    public partial class InputKendaraan_form : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private bool _IsInsert = true;
        private string _ktp_admin = string.Empty;
        private int _idkendaraan = 0;
        private string _ktp_pelanggan = string.Empty;
        public InputKendaraan_form(string ktp_pelanggan, bool IsInsert = true)
        {
            InitializeComponent();
            RegisterEvent();
            InitCombo();
            InitComponent();
            if (!IsInsert)
            {
                GetData(ktp_pelanggan);
                lblHeader.Text = "Edit Pelanggan";
                _IsInsert = false;
                _ktp_pelanggan = ktp_pelanggan;
            }
        }
        private void RegisterEvent()
        {
            button_simpan.Click += Button_simpan_Click;
        }

        private void Button_simpan_Click(object? sender, EventArgs e)
        {
           SaveData();
        }

        private void InitCombo()
        {
            List<string> list = new List<string>()
            {
                "Semua (All)","Advanture","Listrik","Bebek", "Skuter","Spot"
            };
            tipe_combo.DataSource = list;
        }
        private void InitComponent()
        {
            noKtp_text.ReadOnly = true;
            pemilik_text.ReadOnly = false;
            lblErrorNopol.Visible = false;
            lblErrorMerk.Visible = false;
            lblErrorTipe.Visible = false;
            lblErrorTransmisi.Visible = false;
            lblErrorKapasitas.Visible = false;
            lblErrorTahunMotor.Visible = false;

            StyleComponent.TextChangeNull(pemilik_text, lblPemilik, "⚠️ Harap mengisi nama Pemilik !");
            StyleComponent.TextChangeNull(noPolisi_text, lblErrorNopol, "⚠️ Harap mengisi no polisi !");
            StyleComponent.TextChangeNull(merk_text, lblErrorMerk, "⚠️ Harap mengisi merk motor !");
            StyleComponent.TextChangeNull(Transmisi_text, lblErrorTipe, "⚠️ Masukkan Transmisi yang valid !");
            StyleComponent.TextChangeNull(kapasitas_text, lblErrorKapasitas, "⚠️ Harap mengisi kapasitas motor !");
            StyleComponent.TextChangeNull(tahun_text, lblErrorTahunMotor, "⚠️ Harap mengisi tahun motor !");

            noKtp_text.InputNumber();
            tahun_text.InputNumber();

            pemilik_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string nama = pemilik_text.Text.Trim();

                if (string.IsNullOrEmpty(nama))
                {
                    lblPemilik.Text = "⚠️ Nama tidak boleh kosong!";
                    lblPemilik.Visible = true;
                    noKtp_text.Text = string.Empty;
                    return;
                }

                // Ambil data pelanggan berdasarkan nama
                string ktp_pelanggan = _pelangganDal.GetKtpByNama(nama);

                if (string.IsNullOrEmpty(ktp_pelanggan))
                {
                    lblPemilik.Text = "⚠️ Nama tidak ditemukan!";
                    lblPemilik.Visible = true;
                    noKtp_text.Text = string.Empty;
                    return;
                }

                // Jika ditemukan, tampilkan KTP pelanggan
                lblPemilik.Visible = false;
                noKtp_text.Text = ktp_pelanggan;
            };

            noPolisi_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string noPolisi = noPolisi_text.Text.Trim();

                if (string.IsNullOrEmpty(noPolisi))
                {
                    lblErrorNopol.Text = "⚠️ Nomor Polisi tidak boleh kosong!";
                    lblErrorNopol.Visible = true;
                    return;
                }

                bool nopolTerdaftar = _IsInsert
                    ? _kendaraanDal.CekNomorPolisi(noPolisi)
                    : _kendaraanDal.CekNomorPolisiUpdate(noPolisi, _idkendaraan);

                if (nopolTerdaftar)
                {
                    lblErrorNopol.Text = "⚠️ Nomor Polisi sudah terdaftar!";
                    lblErrorNopol.Visible = true;
                    return;
                }

                lblErrorNopol.Visible = false;
            };
        }
        private void SaveData()
        {
            string namaPemilik = pemilik_text.Text.Trim();
            string nopol = noPolisi_text.Text.Trim();
            string merk = merk_text.Text.Trim();
            string tipe = tipe_combo.Text.Trim();
            string transmisi = Transmisi_text.Text.Trim();
            string kapasitas = kapasitas_text.Text.Trim();
            string tahun = tahun_text.Text.Trim();

            // Validasi input
            if (string.IsNullOrEmpty(namaPemilik) || string.IsNullOrEmpty(nopol) ||
                string.IsNullOrEmpty(merk) || string.IsNullOrEmpty(tipe) ||
                string.IsNullOrEmpty(transmisi) || string.IsNullOrEmpty(kapasitas) ||
                string.IsNullOrEmpty(tahun))
            {
                PesanBox.Warning("Harap lengkapi semua data kendaraan!");
                return;
            }

            int kapasitasMotor;
            if (!int.TryParse(kapasitas_text.Text, out kapasitasMotor))
            {
                PesanBox.Warning("Kapasitas motor harus berupa angka!");
                return;
            }

            var kendaraan = new KendaraanModel
            {
                ktp_pelanggan = _ktp_pelanggan,
                no_pol = nopol,
                merk = merk,
                tipe = tipe,
                transmisi = transmisi,
                kapasitas = kapasitasMotor, 
                tahun = tahun
            };



            if (!PesanBox.Konfirmasi("Apakah Anda yakin ingin menyimpan data kendaraan?")) return;

            bool sukses = _kendaraanDal.TambahKendaraanByNamaPelanggan(namaPemilik, kendaraan);

            if (sukses)
            {
                PesanBox.Informasi("Data kendaraan berhasil disimpan!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                PesanBox.Error("Gagal menyimpan data kendaraan!");
            }
        }


        private void GetData(string ktp_pelanggan)
        {
            var data = _kendaraanDal.GetDataByKtp(ktp_pelanggan);

            if (data != null)
            {
                pemilik_text.Text = data.nama_pelanggan;
                noKtp_text.Text = Regex.IsMatch(data.ktp_pelanggan, @"[A-Za-z]") ? string.Empty : data.ktp_pelanggan;
                noPolisi_text.Text = data.no_pol;
                merk_text.Text = data.merk;
                tipe_combo.Text = data.tipe;
                Transmisi_text.Text = data.transmisi;
                kapasitas_text.Text = data.kapasitas.ToString();
                tahun_text.Text = data.tahun;
            }
            else
            {
                MessageBox.Show("Data kendaraan tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
