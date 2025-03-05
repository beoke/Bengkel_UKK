using Bengkel_UKK.Admin.Booking.Batas_Booking;
using Bengkel_UKK.Admin.Kendaraan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Booking
{
    public partial class InputBooking_form : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        private readonly BookingDal _bookingDal = new BookingDal();
        private readonly BatasBookingDal _batasBookingDal = new BatasBookingDal();
        private readonly JadwalDal _jadwalDal = new JadwalDal();
        private readonly JadwalOperasionalDal _jadwalOperasionalDal = new JadwalOperasionalDal();
        public InputBooking_form()
        {
            InitializeComponent();
        }
    }
}
