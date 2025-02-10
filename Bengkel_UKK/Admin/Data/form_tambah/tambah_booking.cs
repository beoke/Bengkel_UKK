using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Admin.Data
{
    public partial class tambah_booking : Form
    {
        public tambah_booking()
        {
            InitializeComponent();
            klikbutton();
        }
        private void klikbutton()
        {
            batal_button.Click += Batal_button_Click;
            simpan_button.Click += Simpan_button_Click;
        }

        private void Simpan_button_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Batal_button_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
