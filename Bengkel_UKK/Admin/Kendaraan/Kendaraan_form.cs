using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Helper;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Kendaraan
{
    public partial class Kendaraan_form : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();

        private int page = 1;
        private int _page = 1;
        private int _Totalpage = 1;
        public Kendaraan_form()
        {
            InitializeComponent();
            RegisterEvent();
        }
        private void RegisterEvent()
        {
            btnAddData.Click += BtnAddData_Click;
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new InputKendaraan_form("", true).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private FilterDto? Filter()
        {
            string search = txtSearch.Text.Trim();

            string sql = "";
            var dp = new DynamicParameters();
            List<string> fltr = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                fltr.Add("(no_pol LIKE '%' + @search + '%' OR merk LIKE '%' + @search + '%' OR tipe LIKE '%' + @search + '%' OR transmisi LIKE '%' + @search + '%' OR tahun LIKE '%' + @search + '%')");
                dp.Add("@search", search);
            }

            if (fltr.Count > 0)
                sql = " WHERE " + string.Join(" AND ", fltr);

            return new FilterDto
            {
                sql = sql,
                param = dp
            };
        }
        private void LoadData()
        {
            var sqlFilter = Filter() ?? new FilterDto();
            var totalRows = _kendaraanDal.GetTotalRows(sqlFilter);

            int showData = (int)numericEntries.Value;
            _Totalpage = Convert.ToInt32(Math.Ceiling((double)totalRows / showData));
            int offset = (_page - 1) * showData;

            // Periksa apakah sqlFilter.param null, jika ya, buat objek baru
            if (sqlFilter.param == null)
                sqlFilter.param = new DynamicParameters();

            // Gunakan .Add() untuk menambahkan parameter ke DynamicParameters
            sqlFilter.param.Add("@offset", offset);
            sqlFilter.param.Add("@fetch", showData);

            lblHalaman.Text = _page.ToString();
            int toValue = Math.Min(offset + showData, totalRows);
            lblShowingEntries.Text = $"Showing {offset + 1} to {toValue} of {totalRows} entries";

            var list = _kendaraanDal.ListData(sqlFilter)
                .Select((x, index) => new KendaraanDto()
                {
                    id_kendaraan = x.id_kendaraan,
                    nama_kendaraan = x.merk,
                    no_pol = x.no_pol,
                    tipe = x.tipe,
                    transmisi = x.transmisi,
                    kapasitas = x.kapasitas,
                    tahun = x.tahun,
                    ktp_pelanggan = x.ktp_pelanggan,
                    total_servis = x.total_servis
                }).ToList();

            dataGridView1.DataSource = new SortableBindingList<KendaraanDto>(list);
        }


    }
}

