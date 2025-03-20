using Bengkel_UKK.Admin.Karyawan;
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

namespace Bengkel_UKK.Login
{
    public partial class Registrasi_form : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        public Registrasi_form()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitComponent();
            RegisterEvent();
        }
        private void InitComponent()
        {
            txtPassword.PasswordChar = '*';
            txtCPassword.PasswordChar = '*';
        }
        private void RegisterEvent()
        {
            StyleComponent.TextChangeNull(txtNama, lblErrorNama, "⚠️ Harap masukkan nama!");
            StyleComponent.TextChangeNull(txtPassword, lblErrorPassword, "⚠️ Harap masukkan password!");

            linkLogin.Click += (s, e) =>
            {
                new Form_Login().Show();
                this.Close();
            };
            txtEmail.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string email = txtEmail.Text;
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(email, pattern))
                {
                    lblErrorEmail.Text = "⚠️ Format email tidak valid!";
                    lblErrorEmail.Visible = true;
                    return;
                }
                else if (_pelangganDal.CekEmail(email) || _karyawanDal.CekEmail(email))
                {
                    lblErrorEmail.Text = "⚠️ Email sudah terdaftar!";
                    lblErrorEmail.Visible = true;
                    return;
                }
                lblErrorEmail.Visible = false;
            };
            txtPassword.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string password = txtPassword.Text;
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";
                if (!Regex.IsMatch(password, pattern))
                {
                    lblErrorPassword.Text = "⚠️ Password minimal 8 karakter, huruf besar, kecil, dan angka.";
                    lblErrorPassword.Visible = true;
                    return;
                }
                lblErrorPassword.Visible = false;
            };
            txtCPassword.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string Cpassword = txtCPassword.Text;
                if (Cpassword != txtPassword.Text)
                {
                    lblErrorCPassword.Text = "⚠️ Konfirmasi password tidak valid!";
                    lblErrorCPassword.Visible = true;
                    return;
                }
                lblErrorCPassword.Visible = false;
            };
            txt_noKtp.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                txt_noKtp.Text = new string(txt_noKtp.Text.Where(char.IsDigit).ToArray());
                txt_noKtp.SelectionStart = txt_noKtp.Text.Length;
                string noKtp = txt_noKtp.Text.Trim();
                if (noKtp.Length != 16)
                {
                    lblEror_ktp.Text = "⚠️ Nomor KTP harus 16 digit angka!";
                    lblEror_ktp.Visible = true;
                    return;
                }

                lblEror_ktp.Visible = false;
            };

            txt_noTelp.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                txt_noTelp.Text = new string(txt_noTelp.Text.Where(char.IsDigit).ToArray());
                txt_noTelp.SelectionStart = txt_noTelp.Text.Length;

                string noTelp = txt_noTelp.Text;
                string pattern = @"\d{8,10}$"; // berjumlah 8 - 10 digit angka

                if (!Regex.IsMatch(noTelp, pattern))
                {
                    lbl_erorNoTelp.Text = "⚠️ Format nomor telepon tidak valid!";
                    lbl_erorNoTelp.Visible = true;
                    return;
                }

                lbl_erorNoTelp.Visible = false;
            };

            btn_daftar.Click += (s, e) => SaveData();

        }
        private void SaveData()
        {
            string nama = txtNama.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text.Trim();
            string ktp = txt_noKtp.Text.Trim();
            string Cpassword = txtCPassword.Text.Trim();
            string Notelp = txt_noTelp.Text;
            string alamat = txt_alamat.Text;

            bool valid = !lblErrorNama.Visible
                && !lblErrorEmail.Visible
                && !lblErrorPassword.Visible
                && !lblErrorCPassword.Visible
                && !lblEror_ktp.Visible;
            if (!valid)
            {
                PesanBox.Warning("Data tidak valid, harap melengkapi data!");
                return;
            }
            
            string hash = PasswordHash.ArgonHashString(password, PasswordHash.StrengthArgon.Interactive);
            var pelanggan = new PelangganModelUpdate
            {
                ktp_pelanggan_new = ktp,
                nama_pelanggan = nama,
                email = email,
                password = hash,
                no_telp = Notelp,
                alamat = alamat
            };
            _pelangganDal.InsertData(pelanggan);
            PesanBox.Informasi("Registrasi berhasil!, Klik OK untuk melanjutkan ke menu login");
            Form_Login._loginForm.Show();
            this.Close();
        }
    }
}
