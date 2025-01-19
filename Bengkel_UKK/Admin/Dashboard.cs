using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin
{

    public partial class Dashboard : Form
    {
        private Form activeForm = null;

        form_Dashboard dashboard;
        form_DataKaryawan dataKaryawan;
        form_DataPelanggan dataPelanggan;
        form_DataKendaraan dataKendaran;
        form_Riwayat riwayat;


        bool menuExpand = false;
        bool sidebarExpand = true;
        public Dashboard()
        {
            InitializeComponent();
            evenbutton();
            mdiProp();
           // this.FormBorderStyle = FormBorderStyle.None; 
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false; // Pastikan form bukan form utama
            childForm.FormBorderStyle = FormBorderStyle.None; // Hilangkan border form
            childForm.Dock = DockStyle.Fill; // Isi seluruh panelMdi
            panelmdi.Controls.Add(childForm); // Tambahkan form ke panelMdi
            panelmdi.Tag = childForm; // Simpan referensi ke form dalam Tag
            childForm.BringToFront(); // Bawa form ke depan
            childForm.Show(); // Tampilkan form
        }
        private void evenbutton()
        {
            data_button.Click += Data_button_Click;
            MenuTransition.Tick += MenuTransition_Tick;
            sidebarTransition.Tick += SidebarTransition_Tick;
            Hamburger_button.Click += Hamburger_button_Click;
            Dashboard_button.Click += Dashboard_button_Click;
            karyawan_button.Click += Karyawan_button_Click;
            pelanggan_button.Click += Pelanggan_button_Click;
            kendaraan_button.Click += Kendaraan_button_Click;
            riwayat_button.Click += Riwayat_button_Click;
        }

        #region Riwayat
        private void Riwayat_button_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new form_Riwayat());
        }
        #endregion

        #region Data Kendaraan
        private void Kendaraan_button_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new form_DataKendaraan());
        }
        #endregion

        #region Data Pelanggan
        private void Pelanggan_button_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new form_DataPelanggan());
        }
        #endregion

        #region Data Karyawan
        private void Karyawan_button_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new form_DataKaryawan());
        }
        #endregion

        #region dashboard
        private void Dashboard_button_Click(object? sender, EventArgs e)
        {
            /*if (dashboard == null) 
            {
                dashboard = new form_Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }*/
            OpenChildForm(new form_Dashboard());
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
        #endregion

        #region TRANSISI SIDE BAR dan MENU
        private void Hamburger_button_Click(object? sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Data_button_Click(object? sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        private void SidebarTransition_Tick(object? sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                SideBar_Layout.Width -= 10;
                if (SideBar_Layout.Width <= 72)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                SideBar_Layout.Width += 10;
                if (SideBar_Layout.Width >= 234)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void MenuTransition_Tick (object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                Data_flowLayOut.Height += 10;
                if (Data_flowLayOut.Height >= 204)
                {
                    MenuTransition.Stop();
                    menuExpand = true ;

                }
            }else
            {
                Data_flowLayOut.Height -= 10;
                if(Data_flowLayOut.Height <= 51)
                {
                    MenuTransition.Stop();
                    menuExpand = false ;
                }
            }
        }
        #endregion
    }
}
