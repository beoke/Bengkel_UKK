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
        public IEnumerable<KaryawanModel> ListData()
        {
            const string sql = @"SELECT * FROM Admin";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<KaryawanModel>(sql);
        }

        public KaryawanModel? GetData(string ktp_admin)
        {
            const string sql = @"SELECT * FROM Admin WHERE ktp_admin = @ktp_admin";
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
                (ktp_admin, nama_admin, email, password, alamat, no_telp, role, image_name, image_data)
            VALUES 
                (@ktp_admin, @nama_admin, @email, @password, @alamat, @no_telp, @role, @image_name, @image_data)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, admin);
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
                image_name = @image_name,
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

    }

}
