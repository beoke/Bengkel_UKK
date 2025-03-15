﻿using Bengkel_UKK.Helper;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bengkel_UKK.Admin.Pelanggan.InputPelanggan_form;

namespace Bengkel_UKK.Admin.Karyawan
{
    public partial class InputKaryawan_form : Form
    {
        private Image _fotoAdmin = Properties.Resources.defaultProfile;
        private Image _defaultProfile = Properties.Resources.defaultProfile;
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        private bool _anyProfile = false;
        private bool _IsInsert = true;
        private string _ktp_admin = string.Empty;
        public event Action? DataUpdated; // Event untuk memberi tahu Form Karyawan
        public InputKaryawan_form(string ktp_admin, bool IsInsert = true)
        {
            InitializeComponent();
            InitComponen();
            RegisterEvent();
            if (!IsInsert)
            {
                GetData(ktp_admin);
                lblHeader.Text = "Edit Pegawai";
                _IsInsert = false;
                _ktp_admin = ktp_admin;
            }
        }
        private void RegisterEvent()
        {
            btnChooseFile.Click += BtnChooseFile_Click;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click; 
            btnCancel.Click += (s, e) =>
            {
                this.Close();
            };
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (!PesanBox.Konfirmasi("Apakah Anda yakin ingin menghapus foto ini!")) return;
            _fotoAdmin = _defaultProfile;
            _anyProfile = false;
            pictureBoxProfile.BackgroundImage = Properties.Resources.defaultProfile;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveData();
        }

        private void BtnChooseFile_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image originalImage = Image.FromFile(openFileDialog.FileName);

                    if (new ImageCropTest(originalImage).ShowDialog(this) != DialogResult.OK)
                    {
                        _anyProfile = !IsSameImage(_fotoAdmin, _defaultProfile);

                        return;
                    }
                    _anyProfile = true;
                    pictureBoxProfile.BackgroundImage = ImageConvert.SmoothImagePictureBox(ImageDirectory._imageResult, pictureBoxProfile.Width, pictureBoxProfile.Height);
                    pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
                    _fotoAdmin = ImageDirectory._imageResult;
                }
            }
        }
        private bool IsSameImage(Image img1, Image img2)
        {
            if (img1 == null || img2 == null) return false;

            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                byte[] imgBytes1 = ms1.ToArray();
                byte[] imgBytes2 = ms2.ToArray();

                return StructuralComparisons.StructuralEqualityComparer.Equals(imgBytes1, imgBytes2);
            }
        }

        #region INIT COMPONEN

        private void InitComponen()
        {
           // txtPassword.ReadOnly = true;
           // txtKonfirPassword.ReadOnly = true;
            StyleComponent.TextChangeNull(txtNama, lblErrorNama, "⚠️ Harap mengisi nama!");
            StyleComponent.TextChangeNull(txtNoKTP, lblErrorKTP, "⚠️ Harap mengisi nomor KTP!");
            StyleComponent.TextChangeNull(txtEmail, lblErrorEmail, "⚠️ Harap mengisi email!");
            StyleComponent.TextChangeNull(txtNoTelepon, lblErrorTelepon, "⚠️ Harap mengisi nomor telepon!");
            StyleComponent.TextChangeNull(txtPassword, lblErrorPassword, "⚠️ Harap mengisi password!");
            StyleComponent.TextChangeNull(txtKonfirPassword, lblErrorCPassword, "⚠️ Harap mengisi konfirmasi password!");
            StyleComponent.TextChangeNull(txtAlamat, lblErrorAlamat, "⚠️ Harap mengisi alamat!");

            txtNoKTP.InputNumber();
            txtNoTelepon.InputNumber();

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
                else if (_IsInsert ? _karyawanDal.CekEmail(email) : _karyawanDal.CekEmailUpdate(email, _ktp_admin))
                {
                    lblErrorEmail.Text = "⚠️ Email sudah terdaftar!";
                    lblErrorEmail.Visible = true;
                    return;
                }
                lblErrorEmail.Visible = false;
            };

            txtNoTelepon.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string telepon = txtNoTelepon.Text;
                if (_IsInsert ? _karyawanDal.CekTelepon(telepon) : _karyawanDal.CekTeleponUpdate(telepon, _ktp_admin))
                {
                    lblErrorTelepon.Text = "⚠️ Nomor telepon sudah terdaftar!";
                    lblErrorTelepon.Visible = true;
                    return;
                }
                lblErrorTelepon.Visible = false;
            };

            txtNoKTP.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string noKtp = txtNoKTP.Text;
                if (noKtp == _ktp_admin) return;

                if (_IsInsert ? _karyawanDal.CekKTP(noKtp) : !_karyawanDal.CekKTPUpdate(noKtp))
                {
                    lblErrorKTP.Text = "⚠️ Nomor KTP sudah terdaftar!";
                    lblErrorKTP.Visible = true;
                    return;
                }
                lblErrorKTP.Visible = false;
            };

            txtKonfirPassword.TextChanged += async (s, e) =>
            {
                await Task.Delay(1000);
                string password = txtPassword.Text;
                string CPassword = txtKonfirPassword.Text;
                if (password != CPassword)
                {
                    lblErrorCPassword.Text = "⚠️ Konfirmasi password salah/tidak sama!";
                    lblErrorCPassword.Visible = true;
                    return;
                }
                lblErrorCPassword.Visible = false;
            };


            comboPegawai.DataSource = new List<string>() { "Mekanik", "Petugas", "Super Admin" };
        }

        #endregion

        #region SAVE DATA

        private void SaveData()
        {
            string nama = txtNama.Text.Trim();
            string noKtpNew = txtNoKTP.Text.Trim();
            string telepon = txtNoTelepon.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string konfirmPass = txtKonfirPassword.Text;
            string alamat = txtAlamat.Text;
            int jabatan = comboPegawai.SelectedIndex == 0 ? 0
                : comboPegawai.SelectedIndex == 1 ? 1
                : 2;
            byte[]? profile = pictureBoxProfile.BackgroundImage != _defaultProfile ? ImageConvert.ImageToByteArray(ImageConvert.CropToCircle(pictureBoxProfile.BackgroundImage)) : null;

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

            var dataPegawai = new KaryawanModel()
            {
                ktp_admin = string.IsNullOrEmpty(_ktp_admin) ? noKtpNew : _ktp_admin,
                nama_admin = nama,
                no_telp = telepon,
                email = email,
                password = PasswordHash.ArgonHashString(password, PasswordHash.StrengthArgon.Interactive),
                alamat = alamat,
                role = jabatan,
                image_data = profile
            }; 

            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin menyimpan data?")) return;
            if (_ktp_admin == string.Empty)
            {
                _karyawanDal.InsertData(dataPegawai);
            }
            else
            {
                _karyawanDal.UpdateData(dataPegawai);
                _karyawanDal.UpdateKTP(noKtpNew, dataPegawai.ktp_admin);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GetData(string ktp_admin)
        {
            var data = _karyawanDal.GetData(ktp_admin);
            if (data is null) return;

            txtNama.Text = data.nama_admin;
            txtNoKTP.Text = data.ktp_admin;
            txtNoTelepon.Text = data.no_telp;
            txtEmail.Text = data.email;
            txtPassword.Text = data.password;
            txtKonfirPassword.Text = data.password;
            txtAlamat.Text = data.alamat;
            pictureBoxProfile.BackgroundImage = data.image_data != null ? ImageConvert.Image_ByteToImage(data.image_data) : _defaultProfile;
        }

        #endregion

    }
}
