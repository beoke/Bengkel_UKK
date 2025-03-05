using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Booking.Booking
{
    public partial class AddSparepart_form : Form
    {
        public AddSparepart_form()
        {
            InitializeComponent();
        }
    }
}
public class ProdukAddDto
{
    public string Kode { get; set; }
    public string Sparepart { get; set; }
    public int Stok { get; set; }
    public int Jumlah { get; set; }
    public int id_booking { get; set; }
}
