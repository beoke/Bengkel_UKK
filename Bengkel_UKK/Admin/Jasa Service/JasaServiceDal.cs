using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Jasa_Service
{
    public class JasaServiceDal
    {
        public IEnumerable<JasaServiceModel> ListData()
        {
            const string sql = @"SELECT * FROM JasaServis";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<JasaServiceModel>(sql);
        }
        public void InsertData(KaryawanModel admin)
        {
            const string sql = @"
            INSERT INTO JasaServis 
                (nama_jasaServis, harga, keterangan)
            VALUES 
                (@nama_jasaServis, @harga, @keterangan)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, admin);
        }
        public bool CekDataExist(string jasaservis)
        {
            const string sql = "SELECT COUNT(*) FROM JasaServis WHERE id_jasaServis = @id_jasaServis";
            using var koneksi = new SqlConnection(conn.connStr);
            int count = koneksi.ExecuteScalar<int>(sql, new { jasaservis });
            return count > 0;
        }
        public void DeleteData(string jasaservis)
        {
            const string sql = @"DELETE FROM Jasa_Servis WHERE id_jasaServis = @id_jasaServis";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { jasaservis });
        }
    }
}
