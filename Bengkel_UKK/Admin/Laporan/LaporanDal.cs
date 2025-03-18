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
               SELECT rw.tanggal, rw.ktp_pelanggan, 
       COALESCE(pl.nama_pelanggan, rw.nama_pelanggan) AS nama_pelanggan,
       COALESCE(CONCAT(kd.merk, ' ', kd.tipe, ' ', kd.kapasitas, 'cc (', kd.tahun, ')'), rw.nama_kendaraan) AS nama_kendaraan,
       ad_admin.nama_admin AS nama_petugas, 
       ad_mekanik.nama_admin AS nama_mekanik,
       js.nama_jasaServis AS jasa_servis, 
       COALESCE(STRING_AGG(sp.nama_sparepart, ', '), ' ') AS nama_sparepart,
       rw.keluhan, rw.catatan, rw.total_harga, rw.status
        FROM Riwayat rw
        LEFT JOIN Pelanggan pl ON rw.ktp_pelanggan = pl.ktp_pelanggan
        LEFT JOIN Kendaraan kd ON rw.id_kendaraan = kd.id_kendaraan
        LEFT JOIN Admin ad_admin ON rw.ktp_admin = ad_admin.ktp_admin AND ad_admin.role = 1
        LEFT JOIN Admin ad_mekanik ON rw.ktp_mekanik = ad_mekanik.ktp_admin AND ad_mekanik.role = 0
        LEFT JOIN JasaServis js ON rw.id_jasaServis = js.id_jasaServis
        LEFT JOIN RiwayatSparepart ps ON rw.id_riwayat = ps.id_riwayat
        LEFT JOIN Sparepart sp ON ps.kode_sparepart = sp.kode_sparepart
        WHERE rw.tanggal BETWEEN @tanggal_1 AND @tanggal_2
        GROUP BY rw.tanggal, rw.ktp_pelanggan, 
         COALESCE(pl.nama_pelanggan, rw.nama_pelanggan),
         COALESCE(CONCAT(kd.merk, ' ', kd.tipe, ' ', kd.kapasitas, 'cc (', kd.tahun, ')'), rw.nama_kendaraan),
         ad_admin.nama_admin, 
         ad_mekanik.nama_admin, 
         js.nama_jasaServis,
         rw.keluhan, rw.catatan, rw.total_harga, rw.status;
";


            using var connection = new SqlConnection(conn.connStr);
            return connection.Query<RiwayatModel>(sql, new { tanggal_1, tanggal_2 });
        }
        public List<RiwayatModel> ListData(DateTime tanggal_1, DateTime tanggal_2 = default)
        {
            string sql = $@"SELECT 
                r.id_riwayat,
                r.ktp_pelanggan, 
                COALESCE(r.nama_pelanggan, p.nama_pelanggan) AS nama_pelanggan, 
                r.id_kendaraan, 
                COALESCE(r.no_pol, k.no_pol) AS no_pol,
                COALESCE(
                    r.nama_kendaraan, 
                    CONCAT(k.merk, ' ', k.tipe, ' ', k.kapasitas, 'cc (', k.tahun, ')')
                ) AS nama_kendaraan,
                r.tanggal,
                r.tanggal_servis,
                r.tanggal_selesai,
                r.keluhan,
                r.catatan,
                a.nama_admin AS nama_admin,
                m.nama_admin AS nama_mekanik,
                r.id_jasaServis,
                r.status,
                r.total_harga,
                r.pembatalan_oleh
            FROM Riwayat r
            LEFT JOIN Pelanggan p ON r.ktp_pelanggan = p.ktp_pelanggan
            LEFT JOIN Kendaraan k ON r.id_kendaraan = k.id_kendaraan
            LEFT JOIN JasaServis js ON r.id_jasaServis = js.id_jasaServis
            LEFT JOIN Admin a ON r.ktp_admin = a.ktp_admin  -- Join untuk admin
            LEFT JOIN Admin m ON r.ktp_mekanik = m.ktp_admin  -- Join lagi untuk mekanik";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<RiwayatModel>(sql, new { tanggal_1, tanggal_2 }).ToList();
        }
    }
}
