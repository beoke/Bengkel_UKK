﻿using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Dashboard;
using Bengkel_UKK.Admin.Jasa_Service;
using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Admin.Kendaraan;
using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Admin.Produk;
using Bengkel_UKK.Admin.Riwayat;
using Bengkel_UKK.Helper;
using Bengkel_UKK.Login;
using Bengkel_UKK.Manage_Pelanggan;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Manage_Petugas
{
    public partial class Dashboard_petugas : SfForm
    {
        public static Dashboard_petugas _dashboardpetugas { get; private set; }
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        private static Dictionary<int, Button> _listButton = new Dictionary<int, Button>();
        private static Label _lblDisplay;
        private static int buttonActiveBefore = 0;
        public static int buttonActiveAfter = 1;
        private static Color active = System.Drawing.Color.FromArgb(210, 0, 0);
        private static Color over = System.Drawing.Color.FromArgb(170, 0, 0);
        private static Color hover = System.Drawing.Color.FromArgb(210, 0, 0);
        public Dashboard_petugas()
        {
            InitializeComponent();
            _dashboardpetugas = this;
            InitComponen();
            RegisterEvent();    
            InitialProfile();
        }
        private void InitialProfile()
        {
            var data = _karyawanDal.GetDataSession(GlobalVariabel._ktp);
            if (data == null) return;
            rjCircularPictureBox1.Image = ImageConvert.Image_ByteToImage(data.image_data);
            label1.Text = data.nama_admin;
            label2  .Text = data.role == 1 ? "Petugas" : "Super Admin";
        }
        private void InitComponen()
        {
            AddButton(1, btnDashboard);
            AddButton(2, btnBooking);
            AddButton(3, btnProduk);
            AddButton(4, btnRiwayat);
            AddButton(5, btnService);
            AddButton(6, btnPelanggan);
            AddButton(7, btnKaryawan);
            AddButton(8, btn_kendaraan);

            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.HorizontalScroll.Enabled = false; // Matikan horizontal scroll bar
            flowLayoutPanel2.HorizontalScroll.Visible = false; // Sembunyikan horizontal scroll bar
            flowLayoutPanel2.VerticalScroll.Enabled = true;    // Aktifkan vertical scroll bar (opsional)
            flowLayoutPanel2.VerticalScroll.Visible = true;    // Tampilkan vertical scroll bar (opsional)

            this.Style.ShadowOpacity = 0;
            this.Style.TitleBar.BackColor = Color.FromArgb(52, 152, 219);
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.BottomBorderColor = Color.White;
            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
        }
        private void RegisterEvent()
        {
            List<Button> btnStyle = new List<Button> { btnDashboard, btnBooking, btnProduk, btnRiwayat, btnService, btnPelanggan, btnKaryawan };
            foreach (var item in btnStyle)
            {
                item.FlatAppearance.MouseDownBackColor = active;
                item.FlatAppearance.MouseOverBackColor = hover;
            }

            btnDashboard.Click += (s, e) => buttonActiveAfter = 1;
            btnDashboard.Click += BtnSideBar_Click;
            btnBooking.Click += (s, e) => buttonActiveAfter = 2;
            btnBooking.Click += BtnSideBar_Click;
            btnProduk.Click += (s, e) => buttonActiveAfter = 3;
            btnProduk.Click += BtnSideBar_Click;
            btnRiwayat.Click += (s, e) => buttonActiveAfter = 4;
            btnRiwayat.Click += BtnSideBar_Click;
            btnService.Click += (s, e) => buttonActiveAfter = 5;
            btnService.Click += BtnSideBar_Click;
            btnPelanggan.Click += (s, e) => buttonActiveAfter = 6;
            btnPelanggan.Click += BtnSideBar_Click;
            btnKaryawan.Click += (s, e) => buttonActiveAfter = 7;
            btnKaryawan.Click += BtnSideBar_Click;
            btn_kendaraan.Click += (s, e) => buttonActiveAfter = 8;
            btn_kendaraan.Click += BtnSideBar_Click;
            btnLogout.Click += BtnLogout_Click;

            btnDashboard.Click += (s, e) => ShowFormInPanel2(new Menu_dashboard());
            btnProduk.Click += (s, e) => ShowFormInPanel2(new SparepartFormPelanggan());
            btnKaryawan.Click += (s, e) => ShowFormInPanel2(new karyawan_petugas());
            btnBooking.Click += (s, e) => ShowFormInPanel2(new Booking_petugas());
            btnPelanggan.Click += (s, e) => ShowFormInPanel2(new Pelanggan_form());
            btnRiwayat.Click += (s, e) => ShowFormInPanel2(new RIwayat_petugas());
            btnService.Click += (s, e) => ShowFormInPanel2(new JasaService_form());
            btn_kendaraan.Click += (s, e) => ShowFormInPanel2(new Kendaraan_form());
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form loginForm = new Form_Login();
                loginForm.ShowDialog();
                this.Close();
            }
        }
       
        private void AddButton(int key, Button value)
        {
            _listButton.Clear();
            _listButton.Add(key, value);
        }

        private void BtnSideBar_Click(object? sender, EventArgs e)
        {
            ControlSideBar();
        }

        public static void ControlSideBar()
        {
            if (Dashboard_petugas._dashboardpetugas == null) return;

            if (_listButton.ContainsKey(buttonActiveAfter) && buttonActiveBefore != buttonActiveAfter)
            {
                var button = _listButton[buttonActiveAfter];
                button.BackColor = active;
                button.FlatAppearance.MouseDownBackColor = active;
                button.FlatAppearance.MouseOverBackColor = active;
                if (buttonActiveBefore != 0)
                {
                    _listButton[buttonActiveBefore].BackColor = over;
                    _listButton[buttonActiveBefore].FlatAppearance.MouseOverBackColor = hover;
                }
                buttonActiveBefore = buttonActiveAfter;
            }
            string text = "";
            switch (buttonActiveAfter)
            {
                case 1:
                    text = "DASHBOARD";
                    break;
                case 2:
                    text = "BOOKING";
                    break;
                case 3:
                    text = "SPAREPART";
                    break;
                case 4:
                    text = "RIWAYAT";
                    break;
                case 5:
                    text = "SERVIS";
                    break;
                case 6:
                    text = "PELANGGAN";
                    break;
                case 7:
                    text = "PEGAWAI";
                    break;
                case 8:
                    text = "KENDARAAN";
                    break;
            }
            _dashboardpetugas.lblDisplay.Text = text;
        }


        public static void ShowFormInPanel2(Form form)
        {
            if (Dashboard_petugas._dashboardpetugas == null || Dashboard_petugas._dashboardpetugas.panelMain == null)
                return; // Pastikan instance dan panelMain ada

            Panel panelMain = Dashboard_petugas._dashboardpetugas.panelMain; // Akses panel dari instance FormUtama

            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls[0].Dispose();
                panelMain.Controls.Clear();
            }

            if (form == null) return;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.Show();
        }
    }
}
