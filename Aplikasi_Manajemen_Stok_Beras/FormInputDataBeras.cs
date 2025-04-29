using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Stok_Beras
{
    public partial class FormInputDataBeras : Form
    {
        private string connectionString = "server=localhost;database=aplikasi_manajemen_stok_beras;uid=root;pwd=;";
        private FormDaftarStokBeras2 formUtama; // Referensi ke form utama
        private string namaBerasUntukEdit; // Deklarasi variabel untuk menyimpan nama beras saat edit

        public FormInputDataBeras(FormDaftarStokBeras2 formUtamaRef)
        {
            InitializeComponent();
            IsiComboBox();
            this.formUtama = formUtamaRef;
        }

        // Constructor untuk EDIT DATA
        public FormInputDataBeras(FormDaftarStokBeras2 formUtamaRef, string namaBeras)
        {
            InitializeComponent();
            IsiComboBox();
            this.formUtama = formUtamaRef;
            this.namaBerasUntukEdit = namaBeras; // Menyimpan nama beras yang akan diedit

            // Load data untuk edit, pastikan data sudah siap sebelum tampilan form dimuat
            LoadDataUntukEdit();
        }

        private void LoadDataUntukEdit()
        {
            // Query untuk mendapatkan data berdasarkan nama beras
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT harga_beli, harga_jual, jumlah_stok FROM stok_beras WHERE nama_beras = @namaBeras";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@namaBeras", namaBerasUntukEdit);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Mengisi nilai data yang diambil dari database ke kontrol form
                                txtHargaBeli.Text = reader["harga_beli"].ToString();
                                txtHargaJual.Text = reader["harga_jual"].ToString();
                                txtJumlahStok.Text = reader["jumlah_stok"].ToString();

                                // Menetapkan nama beras di ComboBox
                                cmbNamaBeras.SelectedItem = namaBerasUntukEdit; // Pastikan item ada di ComboBox
                            }
                            else
                            {
                                MessageBox.Show("Data beras tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input untuk memastikan semua field sudah terisi
            if (cmbNamaBeras.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtHargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtHargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari form input
            string namaBeras = cmbNamaBeras.SelectedItem.ToString();

            // Validasi untuk memastikan harga dan jumlah stok adalah angka yang benar
            if (!decimal.TryParse(txtHargaBeli.Text, out decimal hargaBeli) ||
                !decimal.TryParse(txtHargaJual.Text, out decimal hargaJual) ||
                !int.TryParse(txtJumlahStok.Text, out int jumlahStok))
            {
                MessageBox.Show("Harga dan jumlah stok harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi tambahan untuk memastikan harga dan jumlah stok tidak negatif
            if (hargaBeli < 0 || hargaJual < 0 || jumlahStok < 0)
            {
                MessageBox.Show("Harga dan jumlah stok tidak boleh kurang dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Membuka koneksi ke database dan menjalankan query untuk update data
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Membuka koneksi

                    string query = "UPDATE stok_beras SET harga_beli = @beli, harga_jual = @jual, jumlah_stok = @stok WHERE nama_beras = @namaBeras";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Menambahkan parameter dengan tipe data eksplisit
                        cmd.Parameters.Add("@namaBeras", MySqlDbType.VarChar).Value = namaBeras;
                        cmd.Parameters.Add("@beli", MySqlDbType.Decimal).Value = hargaBeli;
                        cmd.Parameters.Add("@jual", MySqlDbType.Decimal).Value = hargaJual;
                        cmd.Parameters.Add("@stok", MySqlDbType.Int32).Value = jumlahStok;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ Refresh data langsung setelah update
                            formUtama.LoadData();

                            this.Close(); // Tutup form
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal diperbarui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (cmbNamaBeras.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih nama beras yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBeras = cmbNamaBeras.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM stok_beras WHERE nama_beras = @nama";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", namaBeras);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                formUtama.LoadData(); // Refresh data
                                this.Close(); // Tutup form setelah penghapusan
                            }
                            else
                            {
                                MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormInputDataBeras_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Batalkan penutupan form jika pengguna memilih "No"
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
