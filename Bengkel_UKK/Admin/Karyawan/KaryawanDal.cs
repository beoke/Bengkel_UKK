using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Karyawan
{
    public class KaryawanDal
    {
        public IEnumerable<KaryawanModel> ListData(FilterDto filter)
        {
            const string sql = @"SELECT * FROM Admin";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<KaryawanModel>(sql);
        }

        #region SET HALMAN SESUAI TOTAL LINE
        public IEnumerable<KaryawanModel> GetAllKaryawan(int pageNumber, int pageSize)
        {
            const string sql = @"
            SELECT * FROM Admin
            ORDER BY ktp_admin
            OFFSET @Offset ROWS 
            FETCH NEXT @PageSize ROWS ONLY;";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<KaryawanModel>(sql, new { Offset = (pageNumber - 1) * pageSize, PageSize = pageSize });
        }

        public int GetTotalKaryawan()
        {
            const string sql = @"SELECT COUNT(*) FROM Admin";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql);
        }
        #endregion

        public KaryawanModel? GetData(string ktp_admin)
        {
            const string sql = @"SELECT * FROM Admin WHERE ktp_admin = @ktp_admin";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { ktp_admin });
        }
        public KaryawanModel? GetDataSession(string ktp_admin)
        {
            const string sql = @"SELECT image_data, nama_admin, role FROM Admin WHERE ktp_admin = @ktp_admin";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { ktp_admin });
        }

        public bool CekDataExist(string ktp_admin)
        {
            const string sql = "SELECT COUNT(*) FROM Admin WHERE ktp_admin = @ktp_admin";
            using var koneksi = new SqlConnection(conn.connStr);
            int count = koneksi.ExecuteScalar<int>(sql, new { ktp_admin });
            return count > 0;
        }

        public void InsertData(KaryawanModel admin)
        {
            const string sql = @"
            INSERT INTO Admin 
                (ktp_admin, nama_admin, email, password, alamat, no_telp, role, image_data)
            VALUES 
                (@ktp_admin, @nama_admin, @email, @password, @alamat, @no_telp, @role, @image_data)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, admin);
        }
        public bool CekEmail(string email)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE email = @email";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { email = email });
            return data != null ? true : false;
        }
        public bool CekTelepon(string telepon)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE no_telp = @no_telp";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { no_telp = telepon });
            return data != null ? true : false;
        }
        public bool CekKTP(string ktp)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE ktp_admin = @ktp_admin";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { ktp_admin = ktp });
            return data != null ? true : false;
        }

        public bool CekEmailUpdate(string email, string ktp_admin)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE ktp_admin <> @ktp_admin AND email = @email";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { email = email, ktp_admin = ktp_admin });
            return data != null ? true : false;
        }
        public bool CekTeleponUpdate(string telepon, string ktp_admin)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE ktp_admin <> @ktp_admin AND no_telp = @no_telp";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { no_telp = telepon, ktp_admin = ktp_admin });
            return data != null ? true : false;
        }
        public bool CekKTPUpdate(string ktp)
        {
            const string sql = @"SELECT 1 FROM Admin WHERE ktp_admin <> @ktp_admin";
            using var koneksi = new SqlConnection(conn.connStr);
            var data = koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { ktp_admin = ktp });
            return data != null ? true : false;
        }

        public void UpdateKTP(string ktp_new, string ktp_old)
        {
            const string sql = @"UPDATE Admin SET ktp_admin = @ktp_new WHERE ktp_admin = @ktp_old";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { ktp_new = ktp_new, ktp_old = ktp_old });
        }

        public void UpdateData(KaryawanModel admin)
        {
            const string sql = @"
            UPDATE Admin
            SET 
                nama_admin = @nama_admin,
                email = @email,
                password = @password,
                no_telp = @no_telp,
                alamat = @alamat,
                role = @role,
                image_data = @image_data
            WHERE ktp_admin = @ktp_admin";  

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, admin);
        }
        public void DeleteData(string ktp_admin)
        {
            const string sql = @"DELETE FROM Admin WHERE ktp_admin = @ktp_admin";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { ktp_admin });
        }
        public int GetTotalRows(FilterDto filter)
        {
            string sql = $@"SELECT COUNT(*)
                            FROM Admin {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
        public KaryawanModel? GetLogin(string email)
        {
            const string sql = @"SELECT ktp_admin, password, role FROM Admin
                        WHERE email = @email";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<KaryawanModel>(sql, new { email = email });
        }
        public void SoftDeleteData(string ktp)
        {
            const string sql = @"UPDATE Admins SET deleted_at = GETDATE() WHERE ktp_admin = @ktp";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { ktp });
        }

        public void RestoreData(string ktp)
        {
            const string sql = @"UPDATE Admins SET deleted_at = NULL WHERE ktp_admin = @ktp";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { ktp });
        }

    }

}
