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
        public async Task<DashboardModel> GetDashboardDataAsync()
        {
            const string sql = @"
            SELECT
                (SELECT COUNT(*) FROM Booking WHERE CAST(tanggal AS DATE) = CAST(GETDATE() AS DATE)) AS TotalBookingHariIni,
                (SELECT COUNT(*) FROM Booking WHERE status = 'Dikerjakan') AS TotalBookingDikerjakan,
                (SELECT COUNT(*) FROM Pelanggan) AS TotalPelanggan,
                (SELECT SUM(total_harga) FROM Riwayat) AS TotalPendapatan"
;

            using var koneksi = new SqlConnection(conn.connStr);
            return await koneksi.QueryFirstOrDefaultAsync<DashboardModel>(sql);
        }
    }
    public class DashboardModel
    {
        public int TotalBookingHariIni { get; set; }
        public int TotalBookingDikerjakan { get; set; }
        public int TotalPelanggan { get; set; }
        public decimal TotalPendapatan { get; set; }
    }
}
