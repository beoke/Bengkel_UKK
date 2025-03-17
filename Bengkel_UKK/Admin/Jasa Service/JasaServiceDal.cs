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
        private readonly string _connStr = conn.connStr;

        public IEnumerable<JasaServiceModel> ListData(FilterDto filter)
        {
            string sql = $@"SELECT * FROM JasaServis {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<JasaServiceModel>(sql, filter.param);
        }

        public IEnumerable<JasaServiceModel> ListDataa()
        {
            const string sql = "SELECT * FROM JasaServis";
            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            return koneksi.Query<JasaServiceModel>(sql);
        }
        public int? GetIdJasaByName(string namaJasa)
        {
            const string sql = "SELECT id_jasaServis FROM JasaServis WHERE nama_jasaServis = @namaJasa";
            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            return koneksi.QueryFirstOrDefault<int?>(sql, new { namaJasa });
        }

        public bool CekJasaExist(int idJasaServis)
        {
            const string sql = "SELECT COUNT(1) FROM JasaServis WHERE id_jasaServis = @id_jasaServis";
            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            return koneksi.ExecuteScalar<int>(sql, new { id_jasaServis = idJasaServis }) > 0;
        }

        public void InsertData(JasaServiceModel jasaServis)
        {
            const string sql = @"
            INSERT INTO JasaServis 
                (nama_jasaServis, harga, keterangan)
            VALUES 
                (@nama_jasaServis, @harga, @keterangan)";

            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            koneksi.Execute(sql, jasaServis);
        }

        public void UpdateData(JasaServiceModel jasaServis)
        {
            const string sql = @"
            UPDATE JasaServis
            SET 
                nama_jasaServis = @nama_jasaServis,
                harga = @harga,
                keterangan = @keterangan
            WHERE id_jasaServis = @id_jasaServis";

            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            koneksi.Execute(sql, jasaServis);
        }

        public JasaServiceModel GetData(string namaJasa)
        {
            const string sql = "SELECT * FROM JasaServis WHERE nama_jasaServis = @nama_jasaServis";
            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            return koneksi.QueryFirstOrDefault<JasaServiceModel>(sql, new { nama_jasaServis = namaJasa });
        }

        public void DeleteData(int idJasaServis)
        {
            const string sql = "DELETE FROM JasaServis WHERE id_jasaServis = @id_jasaServis";

            using var koneksi = new SqlConnection(_connStr);
            koneksi.Open();
            koneksi.Execute(sql, new { id_jasaServis = idJasaServis });
        }
    }
}
