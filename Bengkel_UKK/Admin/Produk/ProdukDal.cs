using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK.Admin.Produk
{
    public class ProdukDal
    {
        public IEnumerable<ProdukModel> ListData()
        {
            string sql = @"SELECT * FROM Sparepart";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<ProdukModel>(sql);
        }
    }
}
