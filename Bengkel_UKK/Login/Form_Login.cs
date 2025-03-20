using Bengkel_UKK.Admin.Dashboard;
using Bengkel_UKK.Admin.Karyawan;
using Bengkel_UKK.Admin.Pelanggan;
using Bengkel_UKK.Helper;
using Bengkel_UKK.Manage_Petugas;
using Microsoft.Win32;
using Sodium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bengkel_UKK.Admin.Pelanggan.InputPelanggan_form;

namespace Bengkel_UKK.Login
{
    
    public partial class Form_Login : Form
    {
        public static Form _loginForm = new Form_Login();
        private readonly PelangganDal _pelangganDal = new PelangganDal();
        private readonly KaryawanDal _karyawanDal = new KaryawanDal();
        private bool _showPassword = false;

        public Form_Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _loginForm = this;
            InitComponent();
            RegisterEvent();
        }
        private void RegisterEvent()
        {
            btnShowPassword.Click += (s, e) =>
            {
                if (_showPassword)
                {
                    txtPassword.PasswordChar = '*';
                    btnShowPassword.Image = Properties.Resources.eye;
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    btnShowPassword.Image = Properties.Resources.view;
                }
                _showPassword = !_showPassword;
                txtPassword.Focus();
            };
            txtEmail.TextChanged += async (s, e) =>
            {
                await Task.Delay(2000);
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txtEmail.Text, pattern))
                    lblErrorEmail.Visible = true;
                else
                    lblErrorEmail.Visible = false;
            };
            btn_masuk.Click += (s, e) => CekLogin();
            linkRegister.Click += (s, e) =>
            {
                new Registrasi_form().Show();
                this.Hide();
            };
            linkLabel1.Click += (s, e) =>
            {
                string email = txtEmail.Text.Trim();
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Silakan masukkan email terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool emailTerdaftar = _pelangganDal.CekEmailTerdaftar(email);

                if (!emailTerdaftar)
                {
                    MessageBox.Show("Email tidak ditemukan! Silakan daftar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                new Reset_password(email).Show();
            };

        }
        private void InitComponent()
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 100;
            txtEmail.MaxLength = 100;
        }
        private void CekLogin()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text.Trim();
            if (email == string.Empty || password == string.Empty || lblErrorEmail.Visible)
            {
                PesanBox.Warning("Data tidak valid, mohon cek kembali!");
                return;
            }

            var dataPelanggan = _pelangganDal.GetLogin(email);
            var dataAdmin = _karyawanDal.GetLogin(email);

            bool loginPelanggan = dataPelanggan?.password != null &&
                          PasswordHash.ArgonHashStringVerify(dataPelanggan.password, password);

            bool loginAdmin = dataAdmin?.password != null &&
                              PasswordHash.ArgonHashStringVerify(dataAdmin.password, password);

            if (loginPelanggan)
            {
                GlobalVariabel.SetKTPPelanggan(dataPelanggan?.ktp_pelanggan ?? string.Empty, dataPelanggan.nama_pelanggan);
                new Dashboard_User().Show();
                this.Hide();
            }

            else if (loginAdmin)
            {
                GlobalVariabel.SetSession(dataAdmin?.ktp_admin ?? string.Empty, dataAdmin.role);
                if (GlobalVariabel.CekRole() == 1)
                {
                    new Dashboard_petugas().Show();
                }
                else 
                {
                    new MainFormAdmin().Show();
                }
                this.Hide();
            }
            else
            {
                PesanBox.Error("Email atau password salah!");
                return;
            }
        }

    }
}
