namespace Bengkel_UKK
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            EvenButton();
        }
        private void EvenButton()
        {
            Button_Login.Click += Button_Login_Click;
            Link_Registrasi.Click += Link_Registrasi_Click;
        }

        private void Button_Login_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text_Username.Text) || string.IsNullOrEmpty(Text_Password.Text))
            {
                MessageBox.Show("data Kosong Belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Link_Registrasi_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda belum mempunyai akun?" + Environment.NewLine + "Dan ingin membuat akun baru?",
                                      "Pemberitahuan",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Registrasi_Form regis = new Registrasi_Form();
                regis.ShowDialog();
            }
        }
    }
}
