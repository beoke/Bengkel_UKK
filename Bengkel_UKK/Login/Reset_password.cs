using Bengkel_UKK.Admin.Pelanggan;
using Sodium;
using Syncfusion.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Login
{
    public partial class Reset_password : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        public Reset_password(string email)
        {
            InitializeComponent();
            GetData(email);
            btn_daftar.Click += Btn_daftar_Click;
            txtPassword.PasswordChar = '*';
            txtCPassword.PasswordChar = '*';
        }

        private void Btn_daftar_Click(object? sender, EventArgs e)
        {
            SaveData();

        }

        private void GetData(string email)
        {
            var data = _pelangganDal.GetDataByEMail(email);
            if (data != null)
            {
                txt_noKtp.Text = data.ktp_pelanggan;
                txtNama.Text = data.nama_pelanggan;
                txtEmail.Text = data.email;
            }
        }
        private void SaveData()
        {
            string passwordBaru = txtPassword.Text.Trim();
            string konfirmasiPassword = txtCPassword.Text.Trim();

            // Validasi password tidak boleh kosong
            if (string.IsNullOrEmpty(passwordBaru))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi konfirmasi password harus sama
            if (passwordBaru != konfirmasiPassword)
            {
                MessageBox.Show("Konfirmasi password tidak sesuai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash password baru sebelum disimpan
            string hashedPassword = PasswordHash.ArgonHashString(passwordBaru, PasswordHash.StrengthArgon.Interactive);

            var data = new PelangganModelUpdate
            {
                ktp_pelanggan_old = txt_noKtp.Text,
                ktp_pelanggan_new = txt_noKtp.Text,
                nama_pelanggan = txtNama.Text,
                email = txtEmail.Text,
                password = hashedPassword,
            };

            _pelangganDal.UpdateDataPelanggan(data);

            MessageBox.Show("Password berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
