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
            resizeTimer = new System.Windows.Forms.Timer { Interval = 8 }; // Interval animasi
            InitializeEventHandlers();
            Menu_label.Text = "Dashboard";
            PositionRiwayatButton(); // Inisialisasi posisi tombol Riwayat
        }

        private void InitializeEventHandlers()
        {
            DataSet_Button.Click += DataSet_Button_Click;
            resizeTimer.Tick += ResizeTimer_Tick;
            Dashboard_Button.Click += Dashboard_Button_Click;
            DataKaryawan_button.Click += DataKaryawan_button_Click;
            DataPelanggan_button.Click += DataPelanggan_button_Click;
            DataKendaraan_button.Click += DataKendaraan_button_Click;
        }

        private void PositionRiwayatButton()
        {
            // Menyesuaikan posisi tombol Riwayat agar selalu di bawah FlowLayoutPanel
            Riwayat_button.Location = new Point(0, flowLayoutPanel1.Bottom + 0);
        }

        #region ---- EVENT HANDLER ----
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

        private void Dashboard_Button_Click(object? sender, EventArgs e)
        {
            Menu_label.Text = "Dashboard";
        }
        #endregion

        #region ---- ANIMASI FLOWLAYOUTPANEL ----
        private void DataSet_Button_Click(object? sender, EventArgs e)
        {
            if (isFlowLayoutExpanded)
                AnimateFlowLayoutPanelCollapse();
            else
                AnimateFlowLayoutPanelExpand();
        }

        private void ResizeTimer_Tick(object? sender, EventArgs e)
        {
            if (currentStep < steps)
            {
                flowLayoutPanel1.Height += stepHeight; // Perbarui tinggi panel
                currentStep++;

                // Selalu sesuaikan posisi Riwayat_button
                PositionRiwayatButton();
            }
            else
            {
                flowLayoutPanel1.Height = targetHeight; // Tetapkan tinggi akhir panel
                resizeTimer.Stop();

                // Pastikan posisi Riwayat_button sesuai
                PositionRiwayatButton();
            }
        }

        private void AnimateFlowLayoutPanelExpand()
        {
            StartAnimation(200); // Target tinggi saat panel diperluas
            isFlowLayoutExpanded = true;
        }

        private void AnimateFlowLayoutPanelCollapse()
        {
            StartAnimation(50); // Target tinggi saat panel ditutup
            isFlowLayoutExpanded = false;
        }

        private void StartAnimation(int newTargetHeight)
        {
            int animationDuration = 100; // Durasi animasi dalam ms
            targetHeight = newTargetHeight;
            steps = animationDuration / resizeTimer.Interval; // Jumlah langkah animasi
            stepHeight = (targetHeight - flowLayoutPanel1.Height) / steps; // Perubahan tinggi per langkah
            currentStep = 0;

            resizeTimer.Start(); // Mulai animasi
        }
        #endregion
    }



}
