using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Data
{
    public partial class form_Booking : Form
    {
        public form_Booking()
        {
            InitializeComponent();
            klikButton();
        }
        private void klikButton()
        {
            booking_button.Click += Booking_button_Click;
        }

        private void Booking_button_Click(object? sender, EventArgs e)
        {
            tambah_booking tambah = new tambah_booking();
            tambah.StartPosition = FormStartPosition.CenterScreen;
            tambah.ShowDialog();
            
        }
    }
}
