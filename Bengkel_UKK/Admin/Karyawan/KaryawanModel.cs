using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Karyawan
{
    public class KaryawanModel
    {
        public int No { get; set; } // 🔥 
        public string ktp_admin { get; set; }
        public string nama_admin { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string no_telp { get; set; }
        public string alamat { get; set; }
        public int role { get; set; }
        public string image_name { get; set; }
        public byte[]? image_data { get; set; }
    }
    public class KaryawanModelUpdate
    {
        public string ktp_admin_old { get; set; }
        public string ktp_admin_new { get; set; }
        public string nama_admin { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string no_telp { get; set; }
        public string alamat { get; set; }
        public int role { get; set; }
        public byte[]? image_data { get; set; }
    }   
}
