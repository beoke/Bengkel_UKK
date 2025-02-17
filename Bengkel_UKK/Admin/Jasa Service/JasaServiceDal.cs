using Bengkel_UKK.Helper;
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
    }
}
