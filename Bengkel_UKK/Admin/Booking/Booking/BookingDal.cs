using Bengkel_UKK.Admin.Produk;
using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Booking
{
    public class BookingDal
    {
        public IEnumerable<BookingModel2> ListData(FilterDto filter)
        {
            string sql = $@"SELECT 
                                b.id_booking,
                                b.ktp_pelanggan, 
                                COALESCE(b.nama_pelanggan, p.nama_pelanggan) AS nama_pelanggan, 
                                b.id_kendaraan, 
                                COALESCE(b.no_pol, k.no_pol) AS no_pol,
                                COALESCE(
                                    b.nama_kendaraan, 
                                    CONCAT(k.merk, ' ', k.tipe, ' ', k.kapasitas, 'cc (', k.tahun, ')')
                                ) AS nama_kendaraan,
                                b.tanggal,
                                b.keluhan,
                                b.catatan,
                                b.antrean,
                                b.tipe_antrean,
                                b.ktp_mekanik,
                                b.id_jasaServis,
                                b.status
                            FROM Booking b 
                            LEFT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
                            LEFT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan
                            LEFT JOIN JasaServis js ON js.id_jasaServis = b.id_jasaServis {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<BookingModel2>(sql, filter.param);
        } 
        public IEnumerable<BookingModel2> ListDataByKtp(string ktp_pelanggan)
        {
            string sql = $@"SELECT 
                                b.id_booking,
                                b.ktp_pelanggan, 
                                COALESCE(b.nama_pelanggan, p.nama_pelanggan) AS nama_pelanggan, 
                                b.id_kendaraan, 
                                COALESCE(b.no_pol, k.no_pol) AS no_pol,
                                COALESCE(
                                    b.nama_kendaraan, 
                                    CONCAT(k.merk, ' ', k.tipe, ' ', k.kapasitas, 'cc (', k.tahun, ')')
                                ) AS nama_kendaraan,
                                b.tanggal,
                                b.keluhan,
                                b.catatan,
                                b.antrean,
                                b.ktp_mekanik,
                                b.id_jasaServis,
                                b.status
                            FROM Booking b 
                            LEFT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
                            LEFT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan
                            LEFT JOIN JasaServis js ON js.id_jasaServis = b.id_jasaServis
                            WHERE b.ktp_pelanggan = @ktp_pelanggan";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<BookingModel2>(sql,new {ktp_pelanggan});
        }
       

        public BookingModel2? GetData(int id_booking)
        {
            const string sql = @"SELECT 
                                b.id_booking,
                                b.ktp_pelanggan, 
                                COALESCE(b.nama_pelanggan, p.nama_pelanggan) AS nama_pelanggan, 
                                b.id_kendaraan, 
                                COALESCE(b.no_pol, k.no_pol) AS no_pol,
                                COALESCE(
                                    b.nama_kendaraan, 
                                    CONCAT(k.merk, ' ', k.tipe, ' ', k.kapasitas, 'cc (', k.tahun, ')')
                                ) AS nama_kendaraan,
                                b.tanggal,
                                b.keluhan,
                                b.catatan,
                                b.antrean,
                                b.tipe_antrean,
                                b.ktp_mekanik,
                                b.id_jasaServis,
                                b.status
                            FROM Booking b 
                            LEFT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
                            LEFT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan
                            LEFT JOIN JasaServis js ON js.id_jasaServis = b.id_jasaServis
                                WHERE b.id_booking = @id_booking";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<BookingModel2>(sql, new { id_booking = id_booking });
        }

        public IEnumerable<BookingSparepartModel> ListDataProduk(int id_booking)
        {
            const string sql = @"SELECT kode_sparepart, nama_sparepart, harga, jumlah
                            FROM Bookingsparepart
                            WHERE id_booking = @id_booking";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<BookingSparepartModel>(sql, new { id_booking = id_booking });
        }
        public async Task<bool> CancelServiceAsync(string id_booking)
        {
            const string sql = @"UPDATE Booking 
                         SET status = 'Dibatalkan' 
                         WHERE id_booking = @id_booking";

            using var koneksi = new SqlConnection(conn.connStr);
            int rowAffected = await koneksi.ExecuteAsync(sql, new { id_booking });

            return rowAffected > 0;
        }

        public AntreanDto? GetAntrean(DateTime tanggal, int tipe_antrean)
        {
            const string sql = @"SELECT * FROM GetAntrean(@tanggal,@tipe_antrean)";

            using var koneksi = new SqlConnection(conn.connStr);
            var dp = new DynamicParameters();
            dp.Add("@tanggal", tanggal);
            dp.Add("@tipe_antrean", tipe_antrean);

            return koneksi.QueryFirstOrDefault<AntreanDto>(sql, dp) ?? new AntreanDto();
        }

        public bool CekNoPol(string no_pol)
        {
            const string sql = @"SELECT COUNT(*) FROM Kendaraan WHERE no_pol = @no_pol";
            using var koneksi = new SqlConnection(conn.connStr);
            int count = koneksi.QuerySingleOrDefault<int>(sql, new { no_pol = no_pol });
            return count > 0;
        }

        public void InsertDataBooking(BookingModel2 booking, bool pelanggan)
        {
            var dp = new DynamicParameters();
            if (pelanggan)
            {
                dp.Add("@ktp_pelanggan", booking.ktp_pelanggan);
                dp.Add("@id_kendaraan", booking.id_kendaraan);
                dp.Add("@tanggal", booking.tanggal);
                dp.Add("@keluhan", booking.keluhan);
                dp.Add("@antrean", booking.antrean);
            }
            else
            {
                dp.Add("@nama_pelanggan", booking.nama_pelanggan);
                dp.Add("@nama_kendaraan", booking.nama_kendaraan);
                dp.Add("@no_pol", booking.no_pol);
                dp.Add("@tanggal", booking.tanggal);
                dp.Add("@keluhan", booking.keluhan);
                dp.Add("@antrean", booking.antrean);
            }

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Query<BookingModel2>("InsertBooking", dp, commandType: CommandType.StoredProcedure);
        }

        public void InsertDataBookingSparepart(ProdukAddDto sparepart)
        {
            var dp = new DynamicParameters();
            dp.Add("@id_booking", sparepart.id_booking);
            dp.Add("@kode_sparepart", sparepart.Kode);
            dp.Add("@jumlah", sparepart.Jumlah);

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Query<ProdukAddDto>("InsertBookingSparepart", dp, commandType: CommandType.StoredProcedure);
        }

        public void DeleteBookingSparepart(int id_booking)
        {
            const string sql = @"DELETE FROM BookingSparepart WHERE id_booking = @id_booking";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id_booking = id_booking });
        }

        public int GetTotalRows(FilterDto filter)
        {
            string sql = $@"SELECT COUNT(*)
                            FROM Booking b 
                            LEFT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
                            LEFT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan
                            LEFT JOIN JasaServis js ON js.id_jasaServis = b.id_jasaServis {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public IEnumerable<ProdukAddDto> ListDataSparepart()
        {
            const string sql = @"SELECT p.kode_sparepart AS Kode,p.nama_sparepart AS Sparepart, ISNULL(bs.jumlah, 1) AS Jumlah, p.stok AS Stok
                                FROM BookingSparepart bs
                                RIGHT JOIN Sparepart p ON bs.kode_sparepart = p.kode_sparepart";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<ProdukAddDto>(sql);
        }

        public async Task<IEnumerable<BookingModel2>> ListDataAntrean(DateTime tanggal)
        {
            const string sql = @"
                SELECT id_booking, antrean, tipe_antrean, status
                FROM Booking 
                WHERE tanggal <= @tanggal
                ORDER BY tanggal ASC, antrean ASC";

            using var koneksi = new SqlConnection(conn.connStr);
            return await koneksi.QueryAsync<BookingModel2>(sql, new { tanggal });
        }

        public void UpdateAntrean(BookingModel2 booking)
        {
            const string sql = @"UPDATE Booking SET antrean = @antrean, tipe_antrean = @tipe_antrean WHERE id_booking = @id_booking";
            using var koneksi = new SqlConnection(conn.connStr);

            var dp = new DynamicParameters();
            dp.Add("@antrean", booking.antrean);
            dp.Add("@tipe_antrean", booking.tipe_antrean);
            dp.Add("@id_booking", booking.id_booking);

            koneksi.Execute(sql, dp);
        }
        public async Task UpdateKonfirmasiBookingAsync(FilterDto data)
        {
            using var koneksi = new SqlConnection(conn.connStr);

            await koneksi.ExecuteAsync(data.sql, data.param);
        }


        public async Task SelesaiServisUpdate(DynamicParameters dp)
        {
            string sqlInsertRiwayat = @"
        INSERT INTO Riwayat (
            ktp_pelanggan, nama_pelanggan, id_kendaraan, no_pol, nama_kendaraan, 
            tanggal, tanggal_servis, tanggal_selesai, 
            ktp_admin, ktp_mekanik, keluhan, catatan, total_harga, 
            id_jasaServis, status, pembatalan_oleh, created_at
        )
        SELECT 
            b.ktp_pelanggan, b.nama_pelanggan, b.id_kendaraan, b.no_pol, b.nama_kendaraan, 
            b.tanggal, b.tanggal_servis, GETDATE(),
            @ktp_admin, b.ktp_mekanik, b.keluhan, b.catatan, @total_harga, 
            b.id_jasaServis, @status, @pembatalan_oleh,
            GETDATE()
        FROM Booking b
        WHERE b.id_booking = @id_booking;

        SELECT CAST(SCOPE_IDENTITY() AS INT);";

            string sqlGetSpareparts = @"SELECT kode_sparepart, jumlah FROM BookingSparepart WHERE id_booking = @id_booking";

            string sqlInsertRiwayatSparepart = @"
        INSERT INTO RiwayatSparepart (id_riwayat, kode_sparepart, jumlah) 
        VALUES (@id_riwayat, @kode_sparepart, @jumlah);";

            string sqlDeleteBooking = @"DELETE FROM Booking WHERE id_booking = @id_booking";

            using var koneksi = new SqlConnection(conn.connStr);
            await koneksi.OpenAsync();

            using var transaksi = await koneksi.BeginTransactionAsync();

            try
            {
                // 1. Insert ke Riwayat dan ambil ID yang baru dibuat
                int idRiwayat = await koneksi.QuerySingleAsync<int>(sqlInsertRiwayat, dp, transaksi);

                // 2. Ambil semua sparepart dari BookingSparepart
                var spareparts = await koneksi.QueryAsync<(string kode_sparepart, int jumlah)>(sqlGetSpareparts, dp, transaksi);

                // 3. Looping setiap sparepart dan insert ke RiwayatSparepart
                foreach (var sparepart in spareparts)
                {
                    var paramSparepart = new DynamicParameters();
                    paramSparepart.Add("@id_riwayat", idRiwayat);
                    paramSparepart.Add("@kode_sparepart", sparepart.kode_sparepart);
                    paramSparepart.Add("@jumlah", sparepart.jumlah);

                    await koneksi.ExecuteAsync(sqlInsertRiwayatSparepart, paramSparepart, transaksi);
                }

                // 4. Hapus data Booking setelah semua selesai
                await koneksi.ExecuteAsync(sqlDeleteBooking, dp, transaksi);

                // Commit transaksi
                await transaksi.CommitAsync();
            }
            catch
            {
                // Rollback transaksi jika ada error
                await transaksi.RollbackAsync();
                throw;
            }
        }
    }
}
