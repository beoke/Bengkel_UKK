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

namespace Bengkel_UKK.Admin.Produk
{
    public partial class InputProduk_form : Form
    {
        private readonly ProdukDal _produkDal = new ProdukDal();
        private Image _imageProduk = Properties.Resources.defaultImage;
        private Image _defaultImage = Properties.Resources.defaultImage;
        private string _kode_produk = "";
        private bool _deleteProfile = false;
        public InputProduk_form(string kode_produk = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            _kode_produk = kode_produk;
            RegisterEvent();
            GetData();
        }
        private void RegisterEvent()
        {
            StyleComponent.TextChangeNull(txtNamaProduk, lblErrorProduk, "⚠️ Harap isi nama sparepart!");

            txtHarga.DecimalValueChanged += (s, e) =>
            {
                if (txtHarga.DecimalValue == 0)
                    lblErrorHarga.Visible = true;
                else
                    lblErrorHarga.Visible = false;
            };

            txtStokMinimum.DoubleValueChanged += (s, e) =>
            {
                if (txtStokMinimum.DoubleValue == 0)
                    lblErrorStokMin.Visible = true;
                else
                    lblErrorStokMin.Visible = false;
            };

            txtStok.NumberDecimalDigits = 0;
            txtStokMinimum.NumberDecimalDigits = 0;
            btnPlusStok.Click += (s, e) => txtStok.DoubleValue += 1;
            btnMinStok.Click += (s, e) => txtStok.DoubleValue -= 1;
            btnPlusStokMinimum.Click += (s, e) => txtStokMinimum.DoubleValue += 1;
            btnMinStokMinimum.Click += (s, e) => txtStokMinimum.DoubleValue -= 1;

            btnSave.Click += BtnSave_Click;
            btnChooseFile.Click += BtnChooseFile_Click;
            btnHapus.Click += BtnHapus_Click; ;
        }

        private void BtnHapus_Click(object? sender, EventArgs e)
        {
            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin menghapus gambar?")) return;
            pictureBox1.BackgroundImage = _defaultImage;
            _deleteProfile = true;
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

                    pictureBox1.BackgroundImage = ImageDirectory._imageResult;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                    _imageProduk = ImageDirectory._imageResult;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string namaProduk = txtNamaProduk.Text;
            int harga = Convert.ToInt32(txtHarga.DecimalValue);
            int stok = Convert.ToInt32(txtStok.DoubleValue);
            int stokMinimum = Convert.ToInt32(txtStokMinimum.DoubleValue);
            Image foto = _imageProduk;

            bool valid = !lblErrorProduk.Visible
                && !lblErrorHarga.Visible
                && !lblErrorStokMin.Visible;
            if (!valid || harga == 0)
            {
                PesanBox.Warning("Data tidak valid, mohon cek kembali!");
                return;
            }

            if (!PesanBox.Konfirmasi("Apakah anda yakin ingin menyimpan data?")) return;

            var produk = new ProdukModel
            {
                kode_sparepart = _kode_produk,
                nama_sparepart = namaProduk,
                harga = harga,
                stok = stok,
                stok_minimum = stokMinimum,
                image_data = _deleteProfile ? null : ImageConvert.ImageToByteArray(_imageProduk)
            };

            if (_kode_produk == "")
                _produkDal.InsertData(produk);
            else
                _produkDal.UpdateData(produk);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void GetData()
        {
            if (_kode_produk == "") return;

            var data = _produkDal.GetData(_kode_produk);
            if (data is null) return;

            pictureBox1.BackgroundImage = data.image_data != null
                ? ImageConvert.Image_ByteToImage(data.image_data)
                : null;
            txtNamaProduk.Text = data.nama_sparepart;
            txtHarga.DecimalValue = data.harga;
            txtStok.DoubleValue = data.stok;
            txtStokMinimum.DoubleValue = data.stok_minimum;
        }
    }
}
