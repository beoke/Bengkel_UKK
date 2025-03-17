using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Laporan
{
    public class LaporanModel
    {
        
            public DateTime Tanggal { get; set; }
            public string KtpPelanggan { get; set; }
            public string NamaPelanggan { get; set; }
            public string NamaKendaraan { get; set; }
            public string NamaPetugas { get; set; }
            public string NamaMekanik { get; set; }
            public string JasaServis { get; set; }
            public string NamaSparepart { get; set; }
            public string Keluhan { get; set; }
            public string Catatan { get; set; }
            public decimal TotalBiaya { get; set; }
            public string Status { get; set; }
        

    }
}
