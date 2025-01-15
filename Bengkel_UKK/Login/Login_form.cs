using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bengkel_UKK.Login
{
    public partial class Login_form : Form  
    {
        private bool isPasswordVisible = false; // Status visibility password
        private Image eyeIcon = Properties.Resources.eye;  // Gambar eye
        private Image viewIcon = Properties.Resources.view;  // Gambar view

        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            SmoothRoundedPanel(panel1, 25, Color.FromArgb(254, 228, 216)); 
            SmoothRoundedPanel(panel2, 25, Color.FromArgb(254, 228, 216));
            SmoothRoundedPanel(panel3, 25, Color.FromArgb(248, 81, 0));

            // Atur placeholder untuk TextBox
            SetPlaceholder(Username_text, "Username");
            SetPlaceholder(Password_text, "Password");

            // Event untuk view_button
            lihat_button.Click += Lihat_button_Click; 
        }

        private void Lihat_button_Click(object? sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                Password_text.UseSystemPasswordChar = false; // Tampilkan password
                lihat_button.Image = viewIcon; // Tampilkan ikon "view"
            }
            else
            {
                Password_text.UseSystemPasswordChar = true; // Sembunyikan password
                lihat_button.Image = eyeIcon; // Tampilkan ikon "eye"
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // Event untuk menghapus placeholder saat fokus
            textBox.Enter += (s, e) =>
            {   
                if (textBox.Text == placeholder)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = Color.Black;
                    if (textBox == Password_text)
                        Password_text.UseSystemPasswordChar = false; // Aktifkan mode password
                }
            };

            // Event untuk menambahkan placeholder kembali jika kosong saat kehilangan fokus
            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    if (textBox == Password_text)
                        Password_text.UseSystemPasswordChar = true; // Nonaktifkan mode password
                }
            };
        }

        private void SmoothRoundedPanel(Panel panel, int cornerRadius, Color baseColor)
        {
            panel.BackColor = Color.Transparent;

            // Menambahkan event handler untuk Paint
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                using (GraphicsPath path = new GraphicsPath())
                {
                    // Tambahkan sudut dengan radius yang lebih lembut
                    int diameter = cornerRadius * 2;
                    path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Kiri atas
                    path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Kanan atas
                    path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Kanan bawah
                    path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Kiri bawah
                    path.CloseFigure();

                    using (Brush brush = new SolidBrush(baseColor))
                    {
                        e.Graphics.FillPath(brush, path); // Isi panel dengan warna dasar
                    }
                }
            };

            // Menyesuaikan ulang ketika ukuran panel berubah
            panel.Resize += (s, e) => panel.Invalidate();
        }
        
    }
}
