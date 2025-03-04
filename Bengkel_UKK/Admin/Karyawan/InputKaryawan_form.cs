using Bengkel_UKK.Helper;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Karyawan
{
    public partial class InputKaryawan_form : Form
    {
        private Image _fotoKaryawan = Image.FromFile(@"D:\UKK\Bengkel_UKK\Bengkel_UKK\Asset\defaultProfile.png");
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
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
            }
        }
        private void RegisterEvent()
        {
            btnChooseFile.Click += BtnChooseFile_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
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

                    if (new ImageCropTest(originalImage).ShowDialog(this) != DialogResult.OK) return;

                    pictureBoxProfile.BackgroundImage = ImageDirectory._imageResult;
                    pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        #region INIT COMPONEN

        private void InitComponen()
        {
            comboPegawai.DataSource = new List<string>() { "Mekanik", "Petugas", "Super Admin" };
        }

        #endregion

        #region SAVE DATA

        private void SaveData()
        {
            #region Cek apakah ada yang kosong
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                nama_label.Visible = true;
                isValid = false;
            }
            else nama_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtNoKTP.Text))
            {
                noKtp_label.Visible = true;
                isValid = false;
            }
            else noKtp_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtTelepon.Text))
            {
                telp_label.Visible = true;
                isValid = false;
            }
            else telp_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                email_label.Visible = true;
                isValid = false;
            }
            else email_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                pass_label.Visible = true;
                isValid = false;
            }
            else pass_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtKonfirPassword.Text))
            {
                confirm_label.Visible = true;
                isValid = false;
            }
            else confirm_label.Visible = false;

            if (string.IsNullOrWhiteSpace(txtKonfirPassword.Text))
            {
                confirm_label.Visible = true;
                isValid = false;
            }
            else confirm_label.Visible = false;
            // Cek apakah gambar sudah diubah atau masih default
            if (pictureBoxProfile.BackgroundImage == null || pictureBoxProfile.BackgroundImage == _fotoKaryawan)
            {
                foto_label.Visible = true; // Tampilkan label peringatan
                isValid = false;
            }
            else foto_label.Visible = false; // Sembunyikan jika gambar sudah dipilih

            // Jika ada yang kosong, hentikan proses penyimpanan
            if (!isValid)
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            string nama = txtNama.Text.Trim();
            string noKtp = txtNoKTP.Text.Trim();
            string telepon = txtTelepon.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string konfirmPass = txtKonfirPassword.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            int jabatan = comboPegawai.SelectedIndex == 0 ? 0
                        : comboPegawai.SelectedIndex == 1 ? 1
                        : 2;
            byte[] profile = ImageConvert.ImageToByteArray(pictureBoxProfile.BackgroundImage);

            var karyawan = new KaryawanModel
            {
                ktp_admin = noKtp,
                nama_admin = nama,
                email = email,
                password = password,
                no_telp = telepon,
                alamat = alamat,
                role = jabatan,
                image_name = "profile.png",
                image_data = profile
            };

            if (!_karyawanDal.CekDataExist(noKtp))
            {
                // Jika data belum ada, lakukan INSERT
                _karyawanDal.InsertData(karyawan);
                MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Jika data sudah ada, lakukan UPDATE
                _karyawanDal.UpdateData(karyawan);
                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataUpdated?.Invoke(); // 🔥 Panggil event agar Form Karyawan tahu ada perubahan

            this.Close(); // Tutup form setelah selesai
        }


        private void GetData(string ktp_admin)
        {
            var data = _karyawanDal.GetData(ktp_admin);
            if (data is null) return;

            txtPassword.ReadOnly = true;
            txtKonfirPassword.ReadOnly = true;
            //MessageBox.Show(data.image_data != null ? "NPT null" : "NULLLL");
            txtNama.Text = data.nama_admin;
            txtNoKTP.Text = data.ktp_admin;
            txtTelepon.Text = data.no_telp;
            txtEmail.Text = data.email;
            txtPassword.Text = data.password;
            txtKonfirPassword.Text = data.password;
            txtAlamat.Text = data.alamat;
            pictureBoxProfile.BackgroundImage = data.image_data != null ? ImageConvert.Image_ByteToImage(data.image_data) : _fotoKaryawan;
        }

        #endregion

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
