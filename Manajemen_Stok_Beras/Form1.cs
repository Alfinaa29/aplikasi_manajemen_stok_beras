using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Manajemen_Stok_Beras
{
    public partial class Form1 : Form
    {
        // Koneksi ke database MySQL
        private string connectionString = "server=localhost;database=manajemen_stok_beras;uid=root;pwd=;";

        public Form1()
        {
            InitializeComponent();
            IsiComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Fungsi untuk memuat data dari database ke DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama_beras, harga_beli, harga_jual, jumlah_stok FROM stok_beras";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hapus semua kolom sebelum menampilkan yang diinginkan
                        dgvStokBeras.AutoGenerateColumns = false;
                        dgvStokBeras.Columns.Clear();
                        dgvStokBeras.DataSource = dt;

                        // Tambahkan kolom yang diizinkan saja
                        dgvStokBeras.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "nama_beras", HeaderText = "Nama Beras" });
                        dgvStokBeras.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "harga_beli", HeaderText = "Harga Beli" });
                        dgvStokBeras.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "harga_jual", HeaderText = "Harga Jual" });
                        dgvStokBeras.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "jumlah_stok", HeaderText = "Jumlah Stok" });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fungsi untuk mengisi ComboBox dengan daftar pilihan
        private void IsiComboBox()
        {
            // Isi ComboBox Nama Beras
            cmbNamaBeras.Items.Clear();
            cmbNamaBeras.Items.Add("Bramo");
            cmbNamaBeras.Items.Add("Serang");
            cmbNamaBeras.Items.Add("64");
            cmbNamaBeras.Items.Add("Wangi");

            // Isi ComboBox Satuan Beli
            cmbSatuanBeli.Items.Clear();
            cmbSatuanBeli.Items.Add("Kg");
            cmbSatuanBeli.Items.Add("Ton");
            cmbSatuanBeli.Items.Add("Karung");

            // Isi ComboBox Satuan Stok
            cmbSatuanStok.Items.Clear();
            cmbSatuanStok.Items.Add("Kg");
            cmbSatuanStok.Items.Add("Ton");
            cmbSatuanStok.Items.Add("Karung");
        }

        private void btnTambahBeras_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (cmbNamaBeras.SelectedIndex == -1 ||
                cmbSatuanBeli.SelectedIndex == -1 || // Pastikan satuan beli dipilih
                string.IsNullOrWhiteSpace(txtHargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtHargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Harap lengkapi semua data termasuk satuan beli!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parsing input
            string namaBeras = cmbNamaBeras.SelectedItem.ToString();
            string satuanBeli = cmbSatuanBeli.SelectedItem.ToString(); // Ambil nilai satuan beli

            if (!decimal.TryParse(txtHargaBeli.Text, out decimal hargaBeli) ||
                !decimal.TryParse(txtHargaJual.Text, out decimal hargaJual) ||
                !int.TryParse(txtJumlahStok.Text, out int jumlahStok))
            {
                MessageBox.Show("Input harga dan jumlah stok harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan data ke database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO stok_beras (nama_beras, harga_beli, harga_jual, jumlah_stok) VALUES (@nama, @beli, @jual, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBeras);
                        cmd.Parameters.AddWithValue("@beli", hargaBeli);
                        cmd.Parameters.AddWithValue("@jual", hargaJual);
                        cmd.Parameters.AddWithValue("@stok", jumlahStok);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil ditambahkan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh tampilan DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reset input setelah tambah data
            cmbNamaBeras.SelectedIndex = -1;
            cmbSatuanBeli.SelectedIndex = -1;
            txtHargaBeli.Clear();
            txtHargaJual.Clear();
            txtJumlahStok.Clear();
        }


        private void txtHargaBeli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


