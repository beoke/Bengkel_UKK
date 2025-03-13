using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Kendaraan
{
    public class KendaraanDal
    {
        public IEnumerable<KendaraanModel> ListData(FilterDto filter)
        {
            const string sql = @"SELECT k.*,p.nama_pelanggan
                                FROM Kendaraan k 
                                INNER JOIN Pelanggan p
                                    ON k.ktp_pelanggan = p.ktp_pelanggan";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<KendaraanModel>(sql);
        }

        public IEnumerable<KendaraanModel> ListDataPelanggan(string ktp_pelanggan)
        {
            const string sql = @"SELECT k.*,p.nama_pelanggan
                                FROM Kendaraan k 
                                INNER JOIN Pelanggan p
                                    ON k.ktp_pelanggan = p.ktp_pelanggan
                                WHERE k.ktp_pelanggan = @ktp_pelanggan";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<KendaraanModel>(sql, new { ktp_pelanggan = ktp_pelanggan });
        }
        public int GetTotalRows(FilterDto filter)
        {
            string sql = $@"SELECT COUNT(*)
                            FROM Kendaraan {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
