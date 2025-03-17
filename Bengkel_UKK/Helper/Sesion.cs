using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Helper
{
    public class Sesion
    {
        public static string ktp_admin { get; set; }
        public static string nama_admin { get; set; }
        public static int role { get; set; }
    }
    public static class SesionPelanggan
    {
        public static string ktp_pelanggan { get; set; }
        public static string nama_pelanggan { get; set; }
        public static string role { get; set; }
    }
}
