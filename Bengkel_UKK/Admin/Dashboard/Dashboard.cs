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
        private void LoadDataBooking()
        {
            int totalbooking = _dashboardDal.GetTotalBooking();
            label_totalbooking.Text = totalbooking.ToString();

            int totaldikerjakan = _dashboardDal.GetYangDikerjakan("Dikerjakan");
            label_totalbooking.Text = totaldikerjakan.ToString();

            int pendapatan = _dashboardDal.GetPendapatan();
            label_pendapatan.Text = pendapatan.ToString();
        }
    }
}

