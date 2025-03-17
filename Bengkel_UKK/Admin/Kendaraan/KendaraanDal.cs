using Bengkel_UKK.Admin.Pelanggan;
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
        public bool TambahKendaraanByNamaPelanggan(string namaPelanggan, KendaraanModel kendaraan)
        {
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Open();

            using var transaksi = koneksi.BeginTransaction();
            try
            {
                const string sqlPelanggan = @"
              SELECT ktp_pelanggan FROM Pelanggan WHERE nama_pelanggan = @nama_pelanggan";

                string ktp_pelanggan = koneksi.QueryFirstOrDefault<string>(
                    sqlPelanggan, new { nama_pelanggan = namaPelanggan }, transaction: transaksi);

                if (string.IsNullOrEmpty(ktp_pelanggan))
                {
                    transaksi.Rollback();
                    return false; // Pelanggan tidak ditemukan
                }

                const string sqlKendaraan = @"
                INSERT INTO Kendaraan (ktp_pelanggan, no_pol, merk, tipe, transmisi, kapasitas, tahun)
                VALUES (@ktp_pelanggan, @no_pol, @merk, @tipe, @transmisi, @kapasitas, @tahun)";

                int rowsAffected = koneksi.Execute(sqlKendaraan, new
                {
                    ktp_pelanggan,
                    kendaraan.no_pol,
                    kendaraan.merk,
                    kendaraan.tipe,
                    kendaraan.transmisi,
                    kendaraan.kapasitas,
                    kendaraan.tahun
                }, transaction: transaksi);

                if (rowsAffected > 0)
                {
                    transaksi.Commit();
                    return true;
                }

                transaksi.Rollback();
                return false;
            }
            catch
            {
                transaksi.Rollback();
                throw;
            }
        }

        public void UpdateData(KendaraanModel kendaraan)
        {
            var dp = new DynamicParameters();
            dp.Add(@"id_kendaraan", kendaraan.id_kendaraan);
            dp.Add(@"ktp_pelanggan", kendaraan.ktp_pelanggan);
            dp.Add(@"nama_pelanggan", kendaraan.nama_pelanggan);
            dp.Add(@"no_pol", kendaraan.no_pol);
            dp.Add(@"merk", kendaraan.merk);
            dp.Add(@"tipe", kendaraan.tipe);
            dp.Add(@"transmisi", kendaraan.transmisi);
            dp.Add(@"kapasitas", kendaraan.kapasitas);
            dp.Add(@"tahun", kendaraan.tahun);

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute("UpdateKendaraan", dp, commandType: System.Data.CommandType.StoredProcedure);
        }
        public bool CekNomorPolisi(string noPolisi)
        {
            const string sql = "SELECT COUNT(1) FROM Kendaraan WHERE no_pol = @noPolisi";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql, new { noPolisi }) > 0;
        }

        public bool CekNomorPolisiUpdate(string noPolisi, int idKendaraan)
        {
            const string sql = "SELECT COUNT(1) FROM Kendaraan WHERE no_pol = @noPolisi AND id_kendaraan <> @idKendaraan";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql, new { noPolisi, idKendaraan }) > 0;
        }
        public KendaraanModel GetDataByKtp(string ktp_pelanggan)
        {
            const string sql = @"
        SELECT k.ktp_pelanggan, p.nama_pelanggan, p.no_telp, 
               k.no_pol, k.merk, k.tipe, k.transmisi, k.kapasitas, k.tahun 
        FROM Kendaraan k
        JOIN Pelanggan p ON k.ktp_pelanggan = p.ktp_pelanggan
        WHERE k.ktp_pelanggan = @ktp_pelanggan";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<KendaraanModel>(sql, new { ktp_pelanggan });
        }


        public bool SoftDeleteData(int id_kendaraan)
        {
            const string sql = @"UPDATE Kendaraan SET deleted_at = GETDATE() WHERE id_kendaraan = @id_kendaraan";

            using var koneksi = new SqlConnection(conn.connStr);
            int rowsAffected = koneksi.Execute(sql, new { id_kendaraan });

            return rowsAffected > 0;
        }
        public bool HardDeleteData(int id_kendaraan)
        {
            const string sql = @"DELETE FROM Kendaraan WHERE id_kendaraan = @id_kendaraan";

            using var koneksi = new SqlConnection(conn.connStr);
            int rowsAffected = koneksi.Execute(sql, new { id_kendaraan });

            return rowsAffected > 0;
        }
        public bool RestoreData(int id_kendaraan)
        {
            const string sql = @"UPDATE Kendaraan SET deleted_at = NULL WHERE id_kendaraan = @id_kendaraan";

            using var koneksi = new SqlConnection(conn.connStr);
            int rowsAffected = koneksi.Execute(sql, new { id_kendaraan });

            return rowsAffected > 0;
        }

    }
}
