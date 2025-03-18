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
        public static string _ktp_pelanggan = string.Empty;
        public int _id_kendaraan = 0;
        public InputKendaraan_form(int id_kendaraan = 0)
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
            if (id_kendaraan != 0)
            {
                _id_kendaraan = id_kendaraan;
                GetData(id_kendaraan);
            }
        }
        private void RegisterEvent()
        {
            noKtp_text.TextChanged += NoKtp_text_TextChanged; ;
            button_cari.Click += Button_cari_Click; ;
            button_simpan.Click += (s, e) => SaveData();
            button_batal.Click += (s, e) => this.Close();

        }

        private void Button_cari_Click(object? sender, EventArgs e)
        {
            PilihPelangganForm pilih = new PilihPelangganForm();
            if (pilih.ShowDialog() != DialogResult.OK) return;
            noKtp_text.Text = pilih.ktp_pelanggan;
            GetPelanggan();
        }

        private async void NoKtp_text_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(1500);
            GetPelanggan();
        }


        private void InitComponent()
        {
            List<string> list = new List<string>() { "Manual", "Matic", "Kopling" };
            comboTransmisi.DataSource = list;

            noKtp_text.MaxLength = 16;
            merk_text.MaxLength = 50;
            tipeText.MaxLength = 50;
            kapasitas_text.MaxLength = 50;
            tahun_text.MaxLength = 10;
            noPolisi_text.MaxLength = 20;

            tahun_text.InputNumber();
            kapasitas_text.InputNumber();

            StyleComponent.TextChangeNull(noKtp_text, lblerorKtp, "⚠️ Harap mengisi KTP Pemilik!", true);
            StyleComponent.TextChangeNull(merk_text, lblErrorMerk, "⚠️ Harap mengisi merk kendaraan!");
            StyleComponent.TextChangeNull(tipeText, lblErrorTipe, "⚠️ Harap mengisi tipe kendaraan!");
            StyleComponent.TextChangeNull(kapasitas_text, lblErrorKapasitas, "⚠️ Harap mengisi kapasitas mesin!");
            StyleComponent.TextChangeNull(tahun_text, lblErrorTahunMotor, "⚠️ Harap mengisi tahun produksi!");
            StyleComponent.TextChangeNull(noPolisi_text, lblErrorNopol, "⚠️ Harap mengisi nomor polisi!", true);

            noPolisi_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string no_pol = noPolisi_text.Text;
                string pola = @"^[A-Z]{1,2} \d{1,4} [A-Z]{1,3}$";
                if (!Regex.IsMatch(no_pol, pola) || no_pol.Length == 0)
                {
                    lblErrorNopol.Text = "⚠️ Format No Pol tidak valid!";
                    lblErrorNopol.Visible = true;
                    return;
                }
                bool tersedia = _id_kendaraan == 0 ? _kendaraanDal.CekNoPol(no_pol.Trim())
                    : _kendaraanDal.CekNoPolUpdate(no_pol.Trim(), _id_kendaraan);
                if (tersedia)
                {
                    lblErrorNopol.Text = "⚠️ Nomor polisi sudah tersedia!";
                    lblErrorNopol.Visible = true;
                    return;
                }
                lblErrorNopol.Visible = false;
            };

        }
        private void GetPelanggan()
        {
            string ktp = noKtp_text.Text;
            var data = _pelangganDal.GetData(ktp);
            if (data is null)
            {
                lblerorKtp.Visible = true;
                lblerorKtp.Text = "⚠️ Pelanggan tidak ditemukan!";
                pemilik_text.Clear();
                return;
            }
            lblerorKtp.Visible = false;
            pemilik_text.Text = data.nama_pelanggan;
        }
        private void GetData(int id)
        {
            var data = _kendaraanDal.GetData(id);
            if (data is null) return;

            noKtp_text.Text = data.ktp_pelanggan;
            pemilik_text.Text = data.nama_pelanggan;
            merk_text.Text = data.merk;
            tipeText.Text = data.tipe;
            kapasitas_text.Text = data.kapasitas.ToString();
            tahun_text.Text = data.tahun;
            noPolisi_text.Text = data.no_pol;
            foreach (var item in comboTransmisi.Items)
                if ((string)item == (string)data.transmisi)
                    comboTransmisi.SelectedItem = item;
        }
        private void SaveData()
        {
            string ktp = noKtp_text.Text;
            string pemilik = pemilik_text.Text;
            string merk = merk_text.Text;
            string tipe = tipeText.Text;
            string transmisi = comboTransmisi.SelectedValue?.ToString() ?? string.Empty;
            int kapasitas = Convert.ToInt32(kapasitas_text.Text);
            string tahun = tahun_text.Text;
            string noPol = noPolisi_text.Text;

            bool valid = !lblerorKtp.Visible &&
                !lblErrorMerk.Visible &&
                !lblErrorTipe.Visible &&
                !lblErrorKapasitas.Visible &&
                !lblErrorTahunMotor.Visible &&
                !lblErrorNopol.Visible;

            if (!valid)
            {
                PesanBox.Warning("Data tidak valid, mohon cek kembali!");
                return;
            }
            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin menyimpan data?")) return;

            var kendaraan = new KendaraanModel
            {
                id_kendaraan = _id_kendaraan,
                ktp_pelanggan = ktp,
                merk = merk,
                tipe = tipe,
                transmisi = transmisi,
                kapasitas = kapasitas,
                tahun = tahun,
                no_pol = noPol
            };

            if (_id_kendaraan == 0)
                _kendaraanDal.InsertData(kendaraan);
            else
                _kendaraanDal.UpdateData(kendaraan);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
