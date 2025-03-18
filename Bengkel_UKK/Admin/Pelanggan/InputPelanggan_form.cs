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
using System.Text.RegularExpressions;
using Konscious.Security.Cryptography;
using Sodium;


namespace Bengkel_UKK.Admin.Pelanggan
{
    public partial class InputPelanggan_form : Form
    {
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private bool _anyProfile = false;
        private bool _IsInsert = true;
        private string _ktp_pelanggan = string.Empty;
        public InputPelanggan_form(string ktp_pelanggan, bool IsInsert = true)
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();

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
            button_save.Click += (s, e) => SaveData();
            button_cancel.Click += (s, e) =>
            {
                this.Close();
            };
        }

        #region INIT COMPONENT

        private void InitComponent()
        {
            password_text.PasswordChar = '*';
            konfirm_text.PasswordChar = '*';
            password_text.ReadOnly = false;
            konfirm_text.ReadOnly = false;
            lblErrorNama.Visible = false;
            lblErrorKTP.Visible = false;
            lblErrorTelepon.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorPassword.Visible = false;
            lblErrorCPassword.Visible = false;
            lblErrorAlamat.Visible = false;

            StyleComponent.TextChangeNull(nama_text, lblErrorNama, "⚠️ Harap mengisi nama!");
            StyleComponent.TextChangeNull(ktp_text, lblErrorKTP, "⚠️ Harap mengisi nomor KTP!");
            StyleComponent.TextChangeNull(email_text, lblErrorEmail, "⚠️ Harap mengisi email!");
            StyleComponent.TextChangeNull(telepon_text, lblErrorTelepon, "⚠️ Harap mengisi nomor telepon!");
            StyleComponent.TextChangeNull(password_text, lblErrorPassword, "⚠️ Harap mengisi password!");
            StyleComponent.TextChangeNull(konfirm_text, lblErrorCPassword, "⚠️ Harap mengisi konfirmasi password!");
            StyleComponent.TextChangeNull(alamat_text, lblErrorAlamat, "⚠️ Harap mengisi alamat!");

            ktp_text.InputNumber();
            telepon_text.InputNumber();

            email_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string email = email_text.Text;
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(email, pattern))
                {
                    lblErrorEmail.Text = "⚠️ Format email tidak valid!";
                    lblErrorEmail.Visible = true;
                    return;
                }
                else if (_IsInsert ? _pelangganDal.CekEmail(email) : _pelangganDal.CekEmailUpdate(email, _ktp_pelanggan))
                {
                    lblErrorEmail.Text = "⚠️ Email sudah terdaftar!";
                    lblErrorEmail.Visible = true;
                    return;
                }
                lblErrorEmail.Visible = false;
            };

            telepon_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string telepon = telepon_text.Text;
                if (_IsInsert ? _pelangganDal.CekTelepon(telepon) : _pelangganDal.CekTeleponUpdate(telepon, _ktp_pelanggan))
                {
                    lblErrorTelepon.Text = "⚠️ Nomor telepon sudah terdaftar!";
                    lblErrorTelepon.Visible = true;
                    return;
                }
                lblErrorTelepon.Visible = false;
            };

            ktp_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string noKtp = konfirm_text.Text;
                if (_IsInsert ? _pelangganDal.CekKTP(noKtp) : !_pelangganDal.CekKTPUpdate(noKtp))
                {
                    lblErrorKTP.Text = "⚠️ Nomor KTP sudah terdaftar!";
                    lblErrorKTP.Visible = true;
                    return;
                }
                lblErrorKTP.Visible = false;
            };

            konfirm_text.TextChanged += async (s, e) =>
            {
                await Task.Delay(1000);
                string password = password_text.Text;
                string CPassword = password_text.Text;
                if (password != CPassword)
                {
                    lblErrorCPassword.Text = "⚠️ Konfirmasi password salah/tidak sama!";
                    lblErrorCPassword.Visible = true;
                    return;
                }
                lblErrorCPassword.Visible = false;
            };
        }
        #endregion
        #region SAVE & GET

        private void SaveData()
        {
            string nama = nama_text.Text.Trim();
            string noKtp = ktp_text.Text.Trim();
            string telepon = telepon_text.Text;
            string email = email_text.Text;
            string password = password_text.Text;
            string konfirmPass = konfirm_text.Text;
            string alamat = alamat_text.Text;

            bool validationEvent = !lblErrorKTP.Visible
                 && !lblErrorTelepon.Visible
                 && !lblErrorEmail.Visible
                 && !lblErrorCPassword.Visible;
            bool validationEmpty = nama != ""
                && password != ""
                && alamat != "";
            if (!validationEvent || !validationEmpty)
            {
                PesanBox.Warning("Data tidak valid, harap cek kembali!");
                return;
            }

            var dataPelanggan = new PelangganModelUpdate()
            {
                ktp_pelanggan_old = _ktp_pelanggan,
                ktp_pelanggan_new = noKtp,
                nama_pelanggan = nama,
                no_telp = telepon,
                email = email,
                password = PasswordHash.ArgonHashString(password, PasswordHash.StrengthArgon.Interactive),
                alamat = alamat
            };

            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin menyimpan data?")) return;

            if (_ktp_pelanggan == string.Empty)
            {
                _pelangganDal.InsertData(dataPelanggan);
            }
            else
            {
                _pelangganDal.UpdateData(dataPelanggan);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void GetData(string ktp_pelanggan)
        {
            var data = _pelangganDal.GetData(ktp_pelanggan);


            nama_text.Text = data.nama_pelanggan;
            ktp_text.Text = Regex.IsMatch(data.ktp_pelanggan, @"[A-Za-z]") ?
                string.Empty : data.ktp_pelanggan;
            telepon_text.Text = data.no_telp;
            email_text.Text = data.email;
            password_text.Text = data.password;
            konfirm_text.Text = data.password;
            alamat_text.Text = data.alamat;

            password_text.ReadOnly = true;
            konfirm_text.ReadOnly = true;
        }

        #endregion

    }
}
