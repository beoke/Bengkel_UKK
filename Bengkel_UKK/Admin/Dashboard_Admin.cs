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
            if (isDataSetButtonClicked)
            {
                // Sembunyikan tombol Riwayat saat DataSet_Button diklik
                Riwayat_button.Visible = false;
            }
            else
            {
                // Munculkan tombol Riwayat saat DataSet_Button tidak diklik
                Riwayat_button.Visible = true;

                // Tentukan posisi tombol Riwayat di bawah FlowLayoutPanel
                Riwayat_button.Location = new Point(flowLayoutPanel1.Left, flowLayoutPanel1.Bottom + 10);
            }
        }


        private void evenbutton()
        {
            DataSet_Button.Click += DataSet_Button_Click; ;
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
        // --- Button Dataset ----
        private void DataSet_Button_Click(object? sender, EventArgs e)
        {
            isDataSetButtonClicked = !isDataSetButtonClicked;
            // Mengecek apakah FlowLayoutPanel sedang diperluas atau tidak
            if (isFlowLayoutExpanded)
            {
                AnimateFlowLayoutPanelCollapse(); // Menutup panel
            }
            else
            {
                AnimateFlowLayoutPanelExpand(); // Membuka panel
            }
            PositionRiwayatButton();
        }
        private void ResizeTimer_Tick(object? sender, EventArgs e)
        {
            if (currentStep < steps)
            {
                int previousHeight = flowLayoutPanel1.Height; // Simpan tinggi sebelumnya
                flowLayoutPanel1.Height += stepHeight;       // Perbarui tinggi panel

                int heightDifference = flowLayoutPanel1.Height - previousHeight; // Hitung perubahan tinggi
                AdjustControlsBelow(heightDifference); // Geser kontrol di bawah panel

                currentStep++;
            }
            else
            {
                // Setelah selesai, hentikan timer dan pastikan ukuran akhir tercapai
                int finalHeightDifference = targetHeight - flowLayoutPanel1.Height;
                flowLayoutPanel1.Height = targetHeight;

                AdjustControlsBelow(finalHeightDifference); // Pastikan posisi akhir disesuaikan
                resizeTimer.Stop();
            }
        }

        // Fungsi untuk menggeser kontrol di bawah FlowLayoutPanel
        private void AdjustControlsBelow(int offset)
        {
            foreach (Control control in this.Controls)
            {
                // Abaikan FlowLayoutPanel itu sendiri dan kontrol yang tidak berada di bawahnya
                if (control == flowLayoutPanel1 || control.Location.Y <= flowLayoutPanel1.Bottom)
                    continue;

                // Geser kontrol berdasarkan offset
                control.Location = new Point(control.Location.X, control.Location.Y + offset);
            }
        }

        private void AnimateFlowLayoutPanelExpand()
        {
            // Tentukan durasi animasi dalam milidetik
            int animationDuration = 100; // Durasi animasi dalam ms
            targetHeight = 200; // Target tinggi saat panel diperluas
            steps = animationDuration / resizeTimer.Interval; // Menghitung jumlah langkah berdasarkan interval dan durasi
            stepHeight = (targetHeight - flowLayoutPanel1.Height) / steps; // Menghitung perubahan per langkah
            currentStep = 0;

            // Sembunyikan tombol sebelum animasi dimulai
            DataKaryawan_button.Visible = true;
            DataPelanggan_button.Visible = true;
            DataKendaraan_button.Visible = true;

            flowLayoutPanel1.Visible = true;
            resizeTimer.Start(); // Mulai animasi

            isFlowLayoutExpanded = true;
        }

        private void AnimateFlowLayoutPanelCollapse()
        {
            // Tentukan durasi animasi dalam milidetik
            int animationDuration = 100; // Durasi animasi dalam ms
            targetHeight = 50; // Target tinggi saat panel ditutup
            steps = animationDuration / resizeTimer.Interval; // Menghitung jumlah langkah berdasarkan interval dan durasi
            stepHeight = (flowLayoutPanel1.Height - targetHeight) / steps; // Menghitung perubahan per langkah
            currentStep = 100;

            // Mulai animasi untuk menutup panel
            resizeTimer.Start();

            isFlowLayoutExpanded = false;
        }
        #endregion
    }

}
