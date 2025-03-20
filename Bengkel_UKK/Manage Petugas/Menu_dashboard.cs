using Bengkel_UKK.Admin.Dashboard;
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
    public partial class Menu_dashboard : Form
    {
        private readonly DashboardDal _dashboardDal = new DashboardDal();   
        public Menu_dashboard()
        {
            InitializeComponent();
            LoadDataBooking();
        }
        private async void LoadDataBooking()
        {
            var dashboard = await _dashboardDal.GetDashboardDataAsync();

            label4.Text = dashboard.TotalBookingHariIni.ToString();
            label7.Text = dashboard.TotalBookingDikerjakan.ToString();
            label10.Text = dashboard.TotalPelanggan.ToString();
            label13.Text = dashboard.TotalPendapatan.ToString("C"); // Format sebagai mata uang
            chartControl1.Text = "PENDAPATAN";
        }
    }
}
