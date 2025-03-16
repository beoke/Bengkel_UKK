using Bengkel_UKK.Admin.Booking;
using Bengkel_UKK.Admin.Jasa_Service;
using Bengkel_UKK.Admin.Kendaraan;
using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Admin.Produk;
using Bengkel_UKK.Admin.Riwayat;
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

namespace Bengkel_UKK.Admin.Dashboard
{
    public partial class Dashboard_User : SfForm
    {
        public static Dashboard_User _userForm { get; private set; }
        private static Dictionary<int, Button> _listButton = new Dictionary<int, Button>();
        private static Label _lblDisplay;
        private static int buttonActiveBefore = 0;
        public static int buttonActiveAfter = 1;
        private static Color active = System.Drawing.Color.FromArgb(210, 0, 0);
        private static Color over = System.Drawing.Color.FromArgb(170, 0, 0);
        private static Color hover = System.Drawing.Color.FromArgb(210, 0, 0);
        public Dashboard_User()
        {
            InitializeComponent();
            _userForm = this;
            InitComponen();
            RegisterEvent();
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
            if (Dashboard_User._userForm == null) return;

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
                    text = "BOOKING";
                    break;
                case 2:
                    text = "SPAREPART";
                    break;
                case 3:
                    text = "RIWAYAT";
                    break;
                case 4:
                    text = "JASA SERVIS";
                    break;
                case 5:
                    text = "KENDARAAN";
                    break;
                case 6:
                    text = "PROFILE";
                    break;
            }
            _userForm.lblDisplay.Text = text;
        }
        private void InitComponen()
        {
            AddButton(1, btnBooking);
            AddButton(2, btnProduk);
            AddButton(3, btnRiwayat);
            AddButton(4, btnService);
            AddButton(5, btn_kendaraan);
            AddButton(6, btnProfile);

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
            List<Button> btnStyle = new List<Button> { btnBooking, btnProduk, btnRiwayat, btnService, btnProfile };
            foreach (var item in btnStyle)
            {
                item.FlatAppearance.MouseDownBackColor = active;
                item.FlatAppearance.MouseOverBackColor = hover;
            }
            btnBooking.Click += (s, e) => buttonActiveAfter = 1;
            btnBooking.Click += BtnSideBar_Click;
            btnProduk.Click += (s, e) => buttonActiveAfter = 2;
            btnProduk.Click += BtnSideBar_Click;
            btnRiwayat.Click += (s, e) => buttonActiveAfter = 3;
            btnRiwayat.Click += BtnSideBar_Click;
            btnService.Click += (s, e) => buttonActiveAfter = 4;
            btnService.Click += BtnSideBar_Click;
            btn_kendaraan.Click += (s, e) => buttonActiveAfter = 5;
            btn_kendaraan.Click += BtnSideBar_Click;
            btnProfile.Click += (s, e) => buttonActiveAfter = 6;
            btnProfile.Click += BtnSideBar_Click;
            btnLogout.Click += BtnLogout_Click; 

            btnProduk.Click += (s, e) => ShowFormInPanel2(new SparepartFormPelanggan());
            btnBooking.Click += (s, e) => ShowFormInPanel2(new InputBooking_form());
            btnRiwayat.Click += (s, e) => ShowFormInPanel2(new Riwayat_form());
            btnService.Click += (s, e) => ShowFormInPanel2(new JasaServisPelanggan());
            btn_kendaraan.Click += (s, e) => ShowFormInPanel2(new Kendaraan_form());
            btnProfile.Click += (s, e) => ShowFormInPanel2(new ProfilePelanggan_form());
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

        public static void ShowFormInPanel2(Form form)
        {
            if (Dashboard_User._userForm == null || Dashboard_User._userForm.panelMain == null)
                return; // Pastikan instance dan panelMain ada

            Panel panelMain = Dashboard_User._userForm.panelMain; // Akses panel dari instance FormUtama

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
