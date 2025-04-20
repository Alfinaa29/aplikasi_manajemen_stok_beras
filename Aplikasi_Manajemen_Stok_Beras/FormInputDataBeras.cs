using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Stok_Beras
{
    public partial class FormInputDataBeras : Form
    {
        private string connectionString = "server=localhost;database=aplikasi_manajemen_stok_beras;uid=root;pwd=;";
        private FormDaftarStokBeras2 formUtama; // Referensi ke form utama

        public FormInputDataBeras(FormDaftarStokBeras2 formUtamaRef)
        {
            InitializeComponent();
            IsiComboBox();
            this.formUtama = formUtamaRef;
        }

        private void IsiComboBox()
        {
            cmbNamaBeras.Items.Clear();
            cmbNamaBeras.Items.Add("Bramo");
            cmbNamaBeras.Items.Add("Serang");
            cmbNamaBeras.Items.Add("64");
            cmbNamaBeras.Items.Add("Wangi");

            // ComboBox satuan beli tetap ada meskipun tidak digunakan
            cmbSatuanBeli.Items.Clear();
            cmbSatuanBeli.Items.Add("Kg");
            cmbSatuanBeli.Items.Add("Ton");
            cmbSatuanBeli.Items.Add("Karung");

            cmbSatuanStok.Items.Clear();
            cmbSatuanStok.Items.Add("Kg");
            cmbSatuanStok.Items.Add("Ton");
            cmbSatuanStok.Items.Add("Karung");
        }

        private void btnTambahBeras_Click(object sender, EventArgs e)
        {
            if (cmbNamaBeras.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtHargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtHargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBeras = cmbNamaBeras.SelectedItem.ToString();

            if (!decimal.TryParse(txtHargaBeli.Text, out decimal hargaBeli) ||
                !decimal.TryParse(txtHargaJual.Text, out decimal hargaJual) ||
                !int.TryParse(txtJumlahStok.Text, out int jumlahStok))
            {
                MessageBox.Show("Harga dan jumlah stok harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTambahBeras.Enabled = false; // Disable button untuk mencegah klik ganda

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO stok_beras (nama_beras, harga_beli, harga_jual, jumlah_stok) " +
                                   "VALUES (@nama, @beli, @jual, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBeras);
                        cmd.Parameters.AddWithValue("@beli", hargaBeli);
                        cmd.Parameters.AddWithValue("@jual", hargaJual);
                        cmd.Parameters.AddWithValue("@stok", jumlahStok);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ Refresh data langsung setelah insert
                            formUtama.LoadData();

                            this.Close(); // Tutup form
                        }
                        else
                        {
                            MessageBox.Show("Data gagal ditambahkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnTambahBeras.Enabled = true; // Aktifkan kembali tombol
                }
            }
        }

        private void gbInputDataBeras_Enter(object sender, EventArgs e)
        {
            // Placeholder, bisa ditambahkan fungsi jika dibutuhkan
        }

        private void FormInputDataBeras_Load(object sender, EventArgs e)
        {
            // Tidak ada kode saat form load
        }
    }
}
