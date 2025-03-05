using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Booking.Jadwal
{
    public class JadwalOperasionalModel
    {
        public int id_jadwal_operasional { get; set; }
        public string? hari { get; set; }
        public TimeSpan jam_buka { get; set; }
        public TimeSpan jam_tutup { get; set; }
    }
}
