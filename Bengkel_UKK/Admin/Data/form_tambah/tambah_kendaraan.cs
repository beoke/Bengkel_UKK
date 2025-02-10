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
    public partial class tambah_kendaraan : Form
    {
        public tambah_kendaraan()
        {
            InitializeComponent();
            klikbutton();
        }
        private void klikbutton()
        {
            batal_button.Click += Batal_button_Click;
        }

        private void Batal_button_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
