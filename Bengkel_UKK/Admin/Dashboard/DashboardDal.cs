using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Dashboard
{
    
    public class DashboardDal
    {

        public int GetTotalBooking()
        {
            const string sql = "SELECT COUNT(*) FROM Booking";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql);
        }
        public int GetYangDikerjakan(string status)
        {
            const string sql = "SELECT COUNT(*) FROM Booking WHERE status = @status";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql, new {Status = status});
        }

        public int GetPendapatan()
        {
            const string sql = "SELECT SUM(total_harga) FROM Riwayat WHERE status = 'selesai'";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql);
        }
    }
    public class DashboardModel
    {
        public int TotalBooking { get; set; }
        public int TotalDikerjakan { get; set; }

        public int pendapatan { get; set; }

    }
}
