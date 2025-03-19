using Bengkel_UKK.Manage_Petugas;
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
    public partial class Dashboard : Form
    {
        private readonly DashboardDal _dashboardDal = new DashboardDal();

        public Dashboard()
        {
            InitializeComponent();
            LoadDataBooking();
        }
        private async void LoadDataBooking()
        {
            var dashboard = await _dashboardDal.GetDashboardDataAsync();

            label_totalbooking.Text = dashboard.TotalBookingHariIni.ToString();
            label_totalygdikerjakan.Text = dashboard.TotalBookingDikerjakan.ToString();
            label10.Text = dashboard.TotalPelanggan.ToString();
            label_pendapatan.Text = dashboard.TotalPendapatan.ToString("C"); // Format sebagai mata uang
        }
    }
}

