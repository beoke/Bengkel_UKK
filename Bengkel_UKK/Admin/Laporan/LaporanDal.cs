using Bengkel_UKK.Admin.Laporan;
using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Riwayat
{
    public class LaporanDal
    {
        public IEnumerable<RiwayatModel?> ListLaporan(DateTime tanggal_1, DateTime tanggal_2)
        {
            const string sql = @"
               SELECT
                    CAST(r.tanggal AS DATE) AS tanggal,
                    p.ktp_pelanggan,
                    COALESCE(p.nama_pelanggan, r.nama_pelanggan) AS nama_pelanggan,
                    CASE 
                        WHEN (r.no_pol IS NULL OR r.no_pol = '') AND (r.nama_kendaraan IS NULL OR r.nama_kendaraan = '')
                            THEN CONCAT(k.no_pol, ', ', k.merk)
                        ELSE CONCAT(r.no_pol, ', ', r.nama_kendaraan)
                    END AS nama_kendaraan,
                    a.nama_admin AS nama_petugas,
                    m.nama_admin AS nama_mekanik,
                    r.ktp_mekanik,
                    js.nama_jasaServis AS jasa_servis,
                    COALESCE(STRING_AGG(s.nama_sparepart, ', '), ' ') AS nama_sparepart,
                    r.keluhan,
                    r.catatan,
                    r.total_harga,
                    r.status
                FROM Riwayat r
                LEFT JOIN Pelanggan p ON r.ktp_pelanggan = p.ktp_pelanggan
                LEFT JOIN Admin m ON r.ktp_admin = m.ktp_admin
                LEFT JOIN Kendaraan k ON r.id_kendaraan = k.id_kendaraan
                LEFT JOIN Admin a ON r.ktp_admin = a.ktp_admin
                LEFT JOIN JasaServis js ON r.id_jasaServis = js.id_jasaServis
                LEFT JOIN RiwayatSparepart rs ON r.id_riwayat = rs.id_riwayat
                LEFT JOIN Sparepart s ON rs.kode_sparepart = s.kode_sparepart
                
                GROUP BY
                    r.tanggal,
                    p.ktp_pelanggan,
                    COALESCE(p.nama_pelanggan, r.nama_pelanggan),
                    CASE  
                        WHEN (r.no_pol IS NULL OR r.no_pol = '') AND (r.nama_kendaraan IS NULL OR r.nama_kendaraan = '')
                            THEN CONCAT(k.no_pol, ', ', k.merk)
                        ELSE CONCAT(r.no_pol, ', ', r.nama_kendaraan)
                    END,
                    a.nama_admin,
                    r.ktp_mekanik,  
                    m.nama_admin,
                    js.nama_jasaServis,
                    r.keluhan,
                    r.catatan,
                    r.total_harga,
                    r.status
";


            using var connection = new SqlConnection(conn.connStr);
            return connection.Query<RiwayatModel>(sql, new { tanggal_1, tanggal_2 });
        }
    }
}
