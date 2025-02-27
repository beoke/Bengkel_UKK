using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Jasa_Service
{
    public partial class InputJasaService_form : Form
    {
        private readonly JasaServiceDal _jasaServisDal = new JasaServiceDal();
        int harga = 0;
        public event Action? DataUpdated; // Event untuk memberi tahu Form Jasaservice
        private bool IsInsert;
        private int? idJasa;
        public InputJasaService_form(string nama_jasa, bool isInsert, int? jasaId = null)
        {
            InitializeComponent();
            RegisterEvent();
            if (!IsInsert)
            {
                GetData(nama_jasa);
                header_label.Text = "Edit Jasa Servis";
            }
            IsInsert = isInsert;
            idJasa = jasaId;
        }

        private void RegisterEvent()
        {
            save_button.Click += Save_button_Click; ;
            cancel_button.Click += Cancel_button_Click; 
        }

        private void Cancel_button_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_button_Click(object? sender, EventArgs e)
        {
            SaveData();
        }


        private void SaveData()
        {
            #region Cek apakah ada yang kosong
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(promo_text.Text))
            {
                promo_label.Visible = true;
                isValid = false;
            }
            else promo_label.Visible = false;

            if (string.IsNullOrWhiteSpace(harga_text.Text) || !int.TryParse(harga_text.Text, out harga))
            {
                harga_label.Visible = true;
                isValid = false;
            }
            else harga_label.Visible = false;

            if (string.IsNullOrWhiteSpace(keterangan_text.Text))
            {
                keterangan_label.Visible = true;
                isValid = false;
            }
            else keterangan_label.Visible = false;

            if (!isValid)
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            // Ambil data dari input form
            string namaJasa = promo_text.Text.Trim();
            string keterangan = keterangan_text.Text.Trim();

            // Buat objek model untuk disimpan
            var jasaServis = new JasaServiceModel
            {
                nama_jasaServis = namaJasa,
                harga = harga,
                keterangan = keterangan
            };

            if (IsInsert)
            {
                // 🔹 Pastikan nama belum ada di database sebelum insert
                int? existingId = _jasaServisDal.GetIdJasaByName(namaJasa);
                if (existingId.HasValue)
                {
                    MessageBox.Show("Jasa servis sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Jika Insert, tambahkan data baru
                _jasaServisDal.InsertData(jasaServis);
                MessageBox.Show("Jasa servis berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Jika Edit, pastikan ID valid
                if (idJasa == null)
                {
                    MessageBox.Show("Jasa servis tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                jasaServis.id_jasaServis = idJasa.Value;
                _jasaServisDal.UpdateData(jasaServis);
                MessageBox.Show("Jasa servis berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 🔥 Panggil event agar Form lain tahu ada perubahan
            DataUpdated?.Invoke();
            this.Close();

        }
        private void GetData(string namaJasa)
        {
            var data = _jasaServisDal.GetData(namaJasa);
            if (data is null) return;

            promo_text.Text = data.nama_jasaServis;
            harga_text.Text = data.harga.ToString(); // Konversi integer ke string
            keterangan_text.Text = data.keterangan;
        }

    }
}
