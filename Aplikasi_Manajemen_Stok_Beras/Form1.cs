using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Manajemen_Stok_Beras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblErrorMessage.Text = "Username atau Password tidak boleh kosong!";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }

            string connectionString = "server=localhost;user=root;database=aplikasi_manajemen_stok_beras;port=3306;password=";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah username sudah ada
                    string checkQuery = "SELECT * FROM login WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    MySqlDataReader reader = checkCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Username ada, cek password
                        reader.Close();
                        string loginQuery = "SELECT * FROM login WHERE username = @username AND password = @password";
                        MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn);
                        loginCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        loginCmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        MySqlDataReader loginReader = loginCmd.ExecuteReader();

                        if (loginReader.HasRows)
                        {
                            loginReader.Close();
                            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FormDaftarStokBeras2 formStok = new FormDaftarStokBeras2();
                            formStok.Show();
                        }
                        else
                        {
                            lblErrorMessage.Text = "Password salah!";
                            lblErrorMessage.ForeColor = Color.Red;
                        }

                        loginReader.Close();
                    }
                    else
                    {
                        // Username belum ada, daftarkan
                        reader.Close();
                        string insertQuery = "INSERT INTO login (username, password) VALUES (@username, @password)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registrasi dan Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FormDaftarStokBeras2 formStok = new FormDaftarStokBeras2();
                            formStok.Show();
                        }
                        else
                        {
                            lblErrorMessage.Text = "Gagal menyimpan data!";
                            lblErrorMessage.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan koneksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
