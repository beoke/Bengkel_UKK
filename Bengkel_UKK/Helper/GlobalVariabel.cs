using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Helper
{
    internal class GlobalVariabel
    {
        public static string _ktp = string.Empty;
        public static string _ktp_pelanggan = string.Empty;
        public static string _nama_pelanggan = string.Empty;
        public static int _role = 0;
        public static void SetSession(string ktp, int role)
        {
            _ktp = ktp;
            _role = role;
        }
        public static void SetKTPPelanggan(string ktp, string namapelanggan)
        {
            _ktp_pelanggan = ktp;
            _nama_pelanggan = namapelanggan;
        }

        public static int CekRole()
        {
            if (_role == 1)
                return 1;
            else
                return 2;
        }
    }
}
