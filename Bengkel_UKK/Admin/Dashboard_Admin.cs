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
    public partial class Dashboard_Admin : Form
    {
        private bool isDataSetButtonClicked = false; // Status apakah tombol DataSet sedang diklik
        private bool isFlowLayoutExpanded = false;
        private System.Windows.Forms.Timer resizeTimer;
        private int targetHeight;
        private int stepHeight;
        private int steps;
        private int currentStep;

        public Dashboard_Admin()
        {
            InitializeComponent();

            // Timer untuk animasi
            resizeTimer = new System.Windows.Forms.Timer();
            resizeTimer.Interval = 8; // Interval waktu antara setiap langkah animasi (dalam milidetik)
            evenbutton();
            PositionRiwayatButton();
            Menu_label.Text = "Dashboard";
        }

        private void PositionRiwayatButton()
        {
            if (isFlowLayoutExpanded)
            {
                // Ketika FlowLayoutPanel diperluas, atur lokasi Riwayat_button di (0, 250)
                Riwayat_button.Location = new Point(0, 250);
            }
            else
            {
                // Ketika FlowLayoutPanel ditutup, kembalikan lokasi Riwayat_button ke (0, 100)
                Riwayat_button.Location = new Point(0, 100);
            }
        }

        private void evenbutton()
        {
            DataSet_Button.Click += DataSet_Button_Click;
            resizeTimer.Tick += ResizeTimer_Tick;
            Dashboard_Button.Click += Dashboard_Button_Click;
            DataKaryawan_button.Click += DataKaryawan_button_Click;
            DataPelanggan_button.Click += DataPelanggan_button_Click;
            DataKendaraan_button.Click += DataKendaraan_button_Click;
        }

        #region ---- DATA KENDARAAN,PELANGGAN,KARYAWAN ---- 
        private void DataKendaraan_button_Click(object? sender, EventArgs e)
        {
            Menu_label.Text = "Data Kendaraan";
        }

        private void DataPelanggan_button_Click(object? sender, EventArgs e)
        {
            Menu_label.Text = "Data Pelanggan";
        }

        private void DataKaryawan_button_Click(object? sender, EventArgs e)
        {
            Menu_label.Text = "Data Karyawan";
        }
        #endregion

        // ---- Button Dashboard ----
        private void Dashboard_Button_Click(object? sender, EventArgs e)
        {
            Menu_label.Text = "Dashboard";
        }

        #region ---- ANIMASI BERJALAN BUTTON ----
        private void DataSet_Button_Click(object? sender, EventArgs e)
        {
            isDataSetButtonClicked = !isDataSetButtonClicked;

            if (isFlowLayoutExpanded)
            {
                AnimateFlowLayoutPanelCollapse(); // Menutup panel
            }
            else
            {
                AnimateFlowLayoutPanelExpand(); // Membuka panel
            }
        }

        private void ResizeTimer_Tick(object? sender, EventArgs e)
        {
            if (currentStep < steps)
            {
                int previousHeight = flowLayoutPanel1.Height; // Simpan tinggi sebelumnya
                flowLayoutPanel1.Height += stepHeight;       // Perbarui tinggi panel

                currentStep++;
            }
            else
            {
                flowLayoutPanel1.Height = targetHeight;
                resizeTimer.Stop();

                // Atur posisi Riwayat_button setelah animasi selesai
                PositionRiwayatButton();
            }
        }

        private void AnimateFlowLayoutPanelExpand()
        {
            int animationDuration = 100; // Durasi animasi dalam ms
            targetHeight = 200; // Target tinggi saat panel diperluas
            steps = animationDuration / resizeTimer.Interval; // Menghitung jumlah langkah berdasarkan interval dan durasi
            stepHeight = (targetHeight - flowLayoutPanel1.Height) / steps; // Menghitung perubahan per langkah
            currentStep = 0;

            resizeTimer.Start(); // Mulai animasi
            isFlowLayoutExpanded = true;
        }

        private void AnimateFlowLayoutPanelCollapse()
        {
            int animationDuration = 100; // Durasi animasi dalam ms
            targetHeight = 50; // Target tinggi saat panel ditutup
            steps = animationDuration / resizeTimer.Interval; // Menghitung jumlah langkah berdasarkan interval dan durasi
            stepHeight = (flowLayoutPanel1.Height - targetHeight) / steps; // Menghitung perubahan per langkah
            currentStep = 100;

            resizeTimer.Start(); // Mulai animasi
            isFlowLayoutExpanded = false;
        }
        #endregion
    }


}
