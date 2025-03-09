﻿using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Jasa_Service;
using Bengkel_UKK.Admin.Kalender;
using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Admin.Produk;
using Bengkel_UKK.Admin.Riwayat;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Dashboard
{
    public partial class MainFormAdmin : SfForm
    {
        public static MainFormAdmin _mainForm { get; private set; }
        private static Dictionary<int, Button> _listButton = new Dictionary<int, Button>();
        private static Label _lblDisplay;
        private static int buttonActiveBefore = 0;
        public static int buttonActiveAfter = 1;
        private static Color active = System.Drawing.Color.FromArgb(210, 0, 0);
        private static Color over = System.Drawing.Color.FromArgb(170, 0, 0);
        private static Color hover = System.Drawing.Color.FromArgb(210, 0, 0);
        public MainFormAdmin()
        {
            InitializeComponent();
            _mainForm = this;
            InitComponen();
            RegisterEvent();
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
            AddButton(8, btnKalender);

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
            List<Button> btnStyle = new List<Button> { btnDashboard, btnBooking, btnProduk, btnRiwayat, btnService, btnPelanggan, btnKaryawan, btnKalender };
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
            btnKalender.Click += (s, e) => buttonActiveAfter = 8;
            btnKalender.Click += BtnSideBar_Click;

            // btnDashboard.Click += (s, e) => ShowFormInPanel2(new Dashboard2());
            btnDashboard.Click += (s, e) => ShowFormInPanel2(new Dashboard());
            btnProduk.Click += (s, e) => ShowFormInPanel2(new Produk_form());
            btnKaryawan.Click += (s, e) => ShowFormInPanel2(new Karyawan_form());
            btnKalender.Click += (s, e) => ShowFormInPanel2(new Kalender_form());
            btnBooking.Click += (s, e) => ShowFormInPanel2(new Booking_form());
            btnPelanggan.Click += (s, e) => ShowFormInPanel2(new Pelanggan_form());
            btnRiwayat.Click += (s, e) => ShowFormInPanel2(new Riwayat_form());
            btnService.Click += (s, e) => ShowFormInPanel2(new JasaService_form());
        }


        private void AddButton(int key, Button value)
        {
            _listButton.Add(key, value);
        }

        private void BtnSideBar_Click(object? sender, EventArgs e)
        {
            ControlSideBar();
        }

        public static void ControlSideBar()
        {
            if (MainFormAdmin._mainForm == null) return;

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
                    text = "PRODUK";
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
                    text = "KALENDER";
                    break;
            }
            _mainForm.lblDisplay.Text = text;
        }


        public static void ShowFormInPanel2(Form form)
        {
            if (MainFormAdmin._mainForm == null || MainFormAdmin._mainForm.panelMain == null)
                return; // Pastikan instance dan panelMain ada

            Panel panelMain = MainFormAdmin._mainForm.panelMain; // Akses panel dari instance FormUtama

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


        private void SetProfilePicture(Image image, PictureBox pictureBox)
        {
            // Buat bitmap baru dengan ukuran PictureBox
            Bitmap resizedImage = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Gunakan Graphics untuk menggambar gambar asli ke bitmap baru
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                // Atur InterpolationMode ke HighQualityBicubic
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, pictureBox.Width, pictureBox.Height);
            }

            // Set gambar yang sudah di-resize ke PictureBox
            pictureBox.Image = resizedImage;
        }
    }
}
