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
    public partial class InputKendaraan_form : Form
    {
        private readonly KendaraanDal _kendaraanDal = new KendaraanDal();
        private bool _IsInsert = true;
        private string _ktp_admin = string.Empty;
        public InputKendaraan_form(string ktp_admin, bool IsInsert = true)
        {
            InitializeComponent();
            RegisterEvent();
            InitCombo();
        }
        private void RegisterEvent()
        {

        }
        private void InitCombo()
        {
            List<string> list = new List<string>()
            {
                "Semua (All)","Advanture","Listrik","Bebek", "Skuter","Spot"
            };
            tipe_combo.DataSource = list;
        }
    }
}
