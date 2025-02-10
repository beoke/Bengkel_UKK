using Bengkel_UKK.Admin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin
{
    public partial class form_DataKendaraan : Form
    {
        public form_DataKendaraan()
        {
            InitializeComponent();
            klikbutton();
        }
        private void klikbutton()
        {
            tambah_button.Click += Tambah_button_Click;
        }

        private void Tambah_button_Click(object? sender, EventArgs e)
        {
            tambah_kendaraan tambah = new tambah_kendaraan();
            tambah.StartPosition = FormStartPosition.CenterScreen;
            tambah.ShowDialog();
        }
    }
}
