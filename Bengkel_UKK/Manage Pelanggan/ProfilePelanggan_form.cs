using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Helper;
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

namespace Bengkel_UKK.Admin.Pelanggan
{
    public partial class ProfilePelanggan_form : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        public ProfilePelanggan_form(string noktp)
        {
            InitializeComponent();
            Getdata(noktp);
            RegisterEvent();

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
            buttonSave.Click += ButtonSave_Click; ;
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
           
        }

        private void Getdataa(string ktp_pelanggan)
        {
            var data = _pelangganDal.GetDataByKTP(ktp_pelanggan);
            if (data == null) return;

            txtNama.Text = data.nama_pelanggan;
            txtEmail.Text = data.email.ToString();
            txtPassword.Text = data.password;  // Tambahkan jika perlu
            txtNoKTP.Text = data.ktp_pelanggan;
            txtNoTelp.Text = data.no_telp;
            txtAlamat.Text = data.alamat;

            // Simpan KTP lama untuk referensi saat update
            txtNoKTP.Tag = data.ktp_pelanggan;
        }


    }
}
